using System;

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
			Console.WriteLine("\n" + strName +" has " + nLength +" characters.");
		}
	}
}
