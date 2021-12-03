using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise05
	{
		public void Solution05()
		{
			int nFirstNumber, nSecondNumber;
			Console.Write("What is the First Number? ");
			nFirstNumber = int.Parse(Console.ReadLine());
			Console.Write("\n");

			Console.Write("What is the Second Number? ");
			nSecondNumber = int.Parse(Console.ReadLine());
			Console.Write("\n");

			Console.WriteLine(nFirstNumber + " + " + nSecondNumber + " = " +(nFirstNumber + nSecondNumber));
			Console.WriteLine(nFirstNumber + " - " + nSecondNumber + " = " +(nFirstNumber - nSecondNumber));
			Console.WriteLine(nFirstNumber + " * " + nSecondNumber + " = " +(nFirstNumber * nSecondNumber));
			Console.WriteLine(nFirstNumber + " / " + nSecondNumber + " = " +(nFirstNumber / nSecondNumber));
		}
	}
}
