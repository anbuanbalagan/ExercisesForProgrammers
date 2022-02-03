using System;

namespace ExercisesforProgrammers
{
	class Exercise21
	{
		public void Solution21()
		{
			int nNumber;
			Console.Write("Please enter the number of the month: ");
			int.TryParse(Console.ReadLine(), out nNumber);

			switch(nNumber)
			{
				case 1:
					Console.WriteLine("\nThe name of the Month is January");
					break;

				case 2:
					Console.WriteLine("\nThe name of the Month is February");
					break;

				case 3:
					Console.WriteLine("\nThe name of the Month is March");
					break;

				case 4:
					Console.WriteLine("\nThe name of the Month is April");
					break;

				case 5:
					Console.WriteLine("\nThe name of the Month is May");
					break;

				case 6:
					Console.WriteLine("\nThe name of the Month is June");
					break;

				case 7:
					Console.WriteLine("\nThe name of the Month is July");
					break;

				case 8:
					Console.WriteLine("\nThe name of the Month is August");
					break;

				case 9:
					Console.WriteLine("\nThe name of the Month is September");
					break;

				case 10:
					Console.WriteLine("\nThe name of the Month is October");
					break;

				case 11:
					Console.WriteLine("\nThe name of the Month is November");
					break;

				case 12:
					Console.WriteLine("\nThe name of the Month is December");
					break;

				default: Console.WriteLine("Invalid Number");
					break;
			}
		}
	}
}
