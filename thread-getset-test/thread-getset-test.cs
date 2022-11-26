using System;
using System.Threading;

class Program {
	public static void Main(string[] args) {
		// Inicializa Car
		Car car1 = new Car("Corsa", 0, 3);
		Car car2 = new Car("Uno", 10, 5);
		
		// Cria dois threads, um setta outro getta um valor
		Thread thread1 = new Thread(() => Race(car1, 10));
		Thread thread2 = new Thread(() => Race(car2, 10));
		
		thread1.Start();
		thread2.Start();
	}

	public class Car {
		public string Name { get; set; }
		public int Speed { get; set; }
		public int Nitro { get; set; }
		
		public Car(string name, int speed, int nitro) {
			this.Name = name;
			this.Speed = speed;
			this.Nitro = nitro;
		}
		
		public void Go() {
			if (this.Nitro > 0) {
				this.Speed += 10;
				this.Nitro--;
			}
			
			Console.WriteLine(this.Name + " " + this.Speed);
		}
	}
	
	public static void Race(Car car, int duration) {
		for (int i = 0; i < duration; i++) {
			car.Go();
			Thread.Sleep(1000);
		}
		Console.WriteLine("Finish!!!");
	}
}