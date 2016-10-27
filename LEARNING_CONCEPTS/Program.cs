using System;

namespace LEARNING_CSHARP
{
	public class Person
	{
		public int Age;
		public string FullName;

		public void ShowInfo()
		{
			System.Console.WriteLine("Full Name: {0} - Age: {1}", FullName, Age);
			//System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person P1 = new Person();

			P1.Age = 20;
			P1.FullName = "Ali Reza Alavi";

			P1.ShowInfo();
			//System.Console.WriteLine("Full Name: {0} - Age: {1}", P1.FullName, P1.Age);
			//System.Console.WriteLine("I'm {0} and {1} years old.", P1.FullName, P1.Age);

			Person P2 = new Person();

			P2.Age = 30;
			P2.FullName = "Sara Ahmadi";

			P2.ShowInfo();
			//System.Console.WriteLine("Full Name: {0} - Age: {1}", P2.FullName, P2.Age);
			//System.Console.WriteLine("I'm {0} and {1} years old.", P2.FullName, P2.Age);

			Person P3 = new Person();

			P3.Age = 40;
			P3.FullName = "Mohammad Ghaderi";

			P3.ShowInfo();
			//System.Console.WriteLine("Full Name: {0} - Age: {1}", P3.FullName, P3.Age);
			//System.Console.WriteLine("I'm {0} and {1} years old.", P3.FullName, P3.Age);

			Person P4 = new Person();

			P4.Age = 50;
			P4.FullName = "Reza Ghorji";

			P4.ShowInfo();
			//System.Console.WriteLine("Full Name: {0} - Age: {1}", P4.FullName, P4.Age);
			//System.Console.WriteLine("I'm {0} and {1} years old.", P4.FullName, P4.Age); 

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
