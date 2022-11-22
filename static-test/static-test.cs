using System;

class Program {
	public static void Main(string[] args) {
		Car honda = new Car("honda", 200, 1500);
		Car fiat = new Car("fiat uno", 120, 1400);
		Car jeep = new Car("jeepão", 180, 3000);
		
		Console.WriteLine(honda);
		Console.WriteLine(fiat);
		Console.WriteLine(jeep);
		
		honda.speed += 100;
		fiat.weight -= 300;
		jeep.name = "jeepzao";
		
		Console.WriteLine(honda);
		Console.WriteLine(fiat);
		Console.WriteLine(jeep);
		
		Console.WriteLine(Car.amount);
	}
}

public class Car {
	public string name;
	public int speed, weight;
	
	public static int amount = 0;
	
	public Car(string carName, int carSpeed, int carWeight) {
		name = carName;
		speed = carSpeed;
		weight = carWeight;
		
		amount++;
	}
	
	public override string ToString() {
		return name + ": " + speed + "kmph, " + weight + "kg";
	}
}