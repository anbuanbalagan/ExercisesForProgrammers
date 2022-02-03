using System;

namespace ExercisesforProgrammers
{
	class Exercise06
	{
		public void Solution06()
		{
			int nAge, nRetireAge;
			Console.Write("What is your Current Age? ");			
			nAge = int.Parse(Console.ReadLine());

			Console.Write("At What Age would you like to Retire? ");			
			nRetireAge = int.Parse(Console.ReadLine());
			int nWork, nCurrentYear = 2021;
			nWork = nRetireAge - nAge;

			Console.WriteLine("\nYou have " + nWork + " years left until you can Retire.");
			Console.WriteLine("\nIt's " + nCurrentYear + " ,so you can retire in " +(nCurrentYear + nWork)+ ".");

		}
	}
}
