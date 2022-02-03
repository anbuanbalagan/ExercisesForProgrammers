using System;

namespace ExercisesforProgrammers
{
	class Exercise28
	{
		public void Solution28()
		{
			int nNumber, i, num, nSum = 0;
			Console.Write("Enter the number of Inputs given ");
			num = int.Parse(Console.ReadLine());

			for(i = 0; i < num; i++)
			{
				Console.Write("Enter a Number: ");
				nNumber = int.Parse(Console.ReadLine());
				nSum = nSum + nNumber;
			}

			Console.WriteLine("\nThe Total is " +nSum);
		}			
	}
}
