using System;
using System.ComponentModel.Design;

namespace Leart
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Number 1: ");
				int userImput1;
				string number1 = Console.ReadLine();
				if (int.TryParse(number1, out userImput1))
					{
						
					}
				else
				{
                    Console.WriteLine("Incorrect number!");
					continue;
                }
				Console.WriteLine("Number 2: ");
				int userImput2;
				string number2 = Console.ReadLine();
				if (int.TryParse(number2, out userImput2))
					{
					
					}
				else
				{
					Console.WriteLine("Incorrect number!");
					continue;
				}
				Console.WriteLine("+ - * /: ");
				char oper = Convert.ToChar(Console.ReadLine());
				int plus = userImput1 + userImput2;
				int minus = userImput1 - userImput2;
				int multiply = userImput1 * userImput2;
				if (oper == '+' || oper == '-' || oper == '*' || oper == '/')
				{
					if (oper == '+')
					{
						Console.WriteLine($"Result: {userImput1} + {userImput2} = {plus}");
					}
					if (oper == '-')
					{
						Console.WriteLine($"Result: {userImput1} - {userImput2} = {minus}");
					}
					if (oper == '*')
					{
						Console.WriteLine($"Result: {userImput1} * {userImput2} = {multiply}");
					}
					if (oper == '/')
					{
						if (userImput1 == 0 || userImput2 == 0)
						{
							Console.WriteLine("You can't divide by zero");
						}
						else
						{ 
							double divide = (double)userImput1 / (double)userImput2;
							Console.WriteLine($"Result: {userImput1} / {userImput2} = {divide}");
						}
					}
				}
				else
				{
					Console.WriteLine("Incorrect symbol!");
					continue;
				}

			}
		}
	}
}