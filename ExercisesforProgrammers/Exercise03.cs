using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise03
	{
		public void Solution03()
		{
			string strQuote,strName;
			Console.Write("What is the Quote? ");
			strQuote = Console.ReadLine();

			Console.WriteLine(" ");
			Console.Write("Who said it? ");
			strName = Console.ReadLine();

			Console.WriteLine(strName + " says, "+ '"' +strQuote+ '"');
		}
	}
}
