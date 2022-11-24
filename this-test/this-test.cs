using System;

class Program {
	public static void Main(string[] args) {
		Rice bowl1 = new Rice(300);
		Rice bowl2 = new Rice(600);
		Rice bowl3 = new Rice(250);
		
		Console.WriteLine(bowl1);
		Console.WriteLine(bowl2);
		Console.WriteLine(bowl3);
	}
	
	public class Rice {
		int amount;
		
		public Rice (int amount) {
			this.amount = amount;
		}
		
		public override string ToString() {
			return $"{amount} grams";
		}
	}
}