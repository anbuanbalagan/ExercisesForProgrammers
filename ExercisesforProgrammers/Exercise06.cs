using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise06
	{
		public void Solution06()
		{
			int Age, RetireAge;
			Console.Write("What is your Current Age? ");			
			Age = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");

			Console.Write("At What Age would you like to Retire? ");			
			RetireAge = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");
			int Work, CurrentYear = 2021;
			Work = RetireAge - Age;

			Console.WriteLine("You have " + Work + " years left until you can Retire.");
			Console.WriteLine(" ");
			Console.WriteLine("It's " + CurrentYear + " ,so you can retire in " +(CurrentYear + Work)+ ".");

		}
	}
}
