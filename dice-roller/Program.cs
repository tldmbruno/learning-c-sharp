using System;

namespace DiceRoller {
	class Program {
		public static void Main(string[] args) {
			Console.WriteLine("How many sides? ");
			int sides = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("How many dice? ");
			int amount = Convert.ToInt32(Console.ReadLine());
			
			Dice dice1 = new Dice(amount, sides);
			
			dice1.Roll();
			dice1.Roll();
			dice1.Roll();
			dice1.Roll();
			dice1.Roll();
			
			Dice dice2 = new Dice(2, 10);
			
			dice2.Roll();
			dice2.Roll();
			dice2.Roll();
			dice2.Roll();
			dice2.Roll();
			
			dice1.Roll();
			dice1.Roll();
			dice1.Roll();
			dice1.Roll();
			dice1.Roll();
			
		}
	}
	
	public class Dice {
		int amount;
		int sides;
		
		Random random;
		
		public Dice(int amount, int sides) {
			this.amount = amount;
			this.sides = sides;
			
			random = new Random();
		}
		
		public int Roll() {
			Console.Write($"{amount}d{sides}: ");
			
			int total = 0;
			for (int i = 0; i < amount; i++) {
				total += random.Next(1, sides+1);
			}
			
			Console.WriteLine(total);
			return total;
		}
	}
}