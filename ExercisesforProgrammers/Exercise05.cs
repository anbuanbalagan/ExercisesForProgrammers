using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise05
	{
		public void Solution05()
		{
			int FirstNumber, SecondNumber;
			Console.Write("What is the First Number? ");
			FirstNumber = int.Parse(Console.ReadLine());
			Console.Write("\n");

			Console.Write("What is the Second Number? ");
			SecondNumber = int.Parse(Console.ReadLine());
			Console.Write("\n");

			Console.WriteLine(FirstNumber + " + " + SecondNumber + " = " +(FirstNumber + SecondNumber));
			Console.WriteLine(FirstNumber + " - " + SecondNumber + " = " +(FirstNumber - SecondNumber));
			Console.WriteLine(FirstNumber + " * " + SecondNumber + " = " +(FirstNumber * SecondNumber));
			Console.WriteLine(FirstNumber + " / " + SecondNumber + " = " +(FirstNumber / SecondNumber));
		}
	}
}
