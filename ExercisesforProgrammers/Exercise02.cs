using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise02
	{
		public void Solution02()
		{
			string strName;
			int nLength;
			Console.Write("What is the input String? ");

			strName = Console.ReadLine();
			nLength = strName.Length;

			Console.WriteLine(strName +" has " + nLength +" characters.");
		}
	}
}
