using System;

namespace StringTest {
	class Program {
		public static void Main(string[] args) {
			string name = "Bruno Peres";
			
			Console.WriteLine(name.ToLower());
			Console.WriteLine(name.ToUpper());
			
			Console.WriteLine(name.IsNullOrEmpty());
			
			String nameClass = new String();
			nameClass = "Bruno Peres";
			
			Console.WriteLine(nameClass.ToLower());
			Console.WriteLine(nameClass.ToUpper());
			
			Console.WriteLine(nameClass.IsNullOrEmpty());
		}
	}
}