using System;

namespace ExercisesforProgrammers
{
	class Exercise16
	{
		public void Solution16()
		{
			int nAge;
			Console.Write("What is your Age? ");
			nAge = int.Parse(Console.ReadLine());
						
			Console.WriteLine((nAge >= 16) ?"\nYou are old enough to legally drive." : "\nYou are not old enough to legally drive.");			
		}
	}
}
