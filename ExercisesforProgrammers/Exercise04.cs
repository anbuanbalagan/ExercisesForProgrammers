using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise04
	{
		public void Solution04()
		{
			string strNoun, strVerb, strAdjective, strAdverb;
			Console.Write("Enter a Noun: ");
			strNoun = Console.ReadLine();
			Console.WriteLine("");

			Console.Write("Enter a Verb: ");
			strVerb = Console.ReadLine();
			Console.WriteLine("");

			Console.Write("Enter a Adjective: ");
			strAdjective = Console.ReadLine();
			Console.WriteLine("");

			Console.Write("Enter a Adverb: ");
			strAdverb = Console.ReadLine();
			Console.WriteLine("");

			Console.WriteLine("Do you " + strVerb + " your " + strAdjective + " " + strNoun + " " + strAdverb + "? That's Hilarious!");
			Console.WriteLine("\n");

		}
	}
}
