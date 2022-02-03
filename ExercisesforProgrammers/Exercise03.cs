using System;

namespace ExercisesforProgrammers
{
	class Exercise03
	{
		public void Solution03()
		{
			string strQuote,strName;
			Console.Write("What is the Quote? ");
			strQuote = Console.ReadLine();
			Console.Write("Who said it? ");
			strName = Console.ReadLine();
			Console.WriteLine("\n" + strName + " says, "+ '"' +strQuote+ '"');
		}
	}
}
