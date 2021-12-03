using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise06
	{
		public void Solution06()
		{
			int nAge, nRetireAge;
			Console.Write("What is your Current Age? ");			
			nAge = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");

			Console.Write("At What Age would you like to Retire? ");			
			nRetireAge = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");
			int nWork, nCurrentYear = 2021;
			nWork = nRetireAge - nAge;

			Console.WriteLine("You have " + nWork + " years left until you can Retire.");
			Console.WriteLine(" ");
			Console.WriteLine("It's " + nCurrentYear + " ,so you can retire in " +(nCurrentYear + nWork)+ ".");

		}
	}
}
