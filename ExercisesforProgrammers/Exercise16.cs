using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise16
	{
		public void Solution16()
		{
			int nAge;
			Console.Write("What is your Age? ");
			nAge = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");	
						
			Console.WriteLine((nAge >= 16) ?"You are old enough to legally drive." : "You are not old enough to legally drive.");			
		}
	}
}
