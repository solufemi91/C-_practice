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
		else if (operation == "basic")
		{
			basic();
		}

	}


	public static void basic()
	{
	  Console.WriteLine("You have chose the basic calculator");
	  Console.WriteLine("Please enter the first number");
	  float first_number = Convert.ToInt32(Console.ReadLine());
	  Console.WriteLine("Please enter the second number");
	  float second_number = Convert.ToInt32(Console.ReadLine());
	  Console.WriteLine("Please choose one of the following operations: *, /, +, -");
	  String operation = Console.ReadLine();
	  //operationFunction(first_number,second_number, operation)
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
			Convert.ToString(answer);
			String FinalAnswer = "The answer is " + answer;
			Console.WriteLine(FinalAnswer);
		}

	}

}
