using System;

public class Program
{
	public static void Main()
	{

		Console.WriteLine("Which calculator would you like to use? Basic, advanced, bmi?");
		String operation = Console.ReadLine();

		if (operation == "advanced")
		{
			advanced();
		}

	}
	

	public static void advanced()
	{

		Console.WriteLine("Choose an operation. SquareRoot or Power");
		String operation = Console.ReadLine();
		Console.WriteLine(operation);
		if (operation == "SquareRoot")
		{
			Console.WriteLine("Enter the number that you want to find the square root of");
			float number = Convert.ToInt32(Console.ReadLine());
			float answer = (float)Math.Sqrt(number);
			Console.WriteLine(answer);
		}
		else if (operation == "Power")
		{
			Console.WriteLine("Enter the base number");
			float Base = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the exponent");
			float exponent = Convert.ToInt32(Console.ReadLine());
			double answer = Math.Pow(Base,exponent);
			Console.WriteLine(answer);
		}

	}

}
