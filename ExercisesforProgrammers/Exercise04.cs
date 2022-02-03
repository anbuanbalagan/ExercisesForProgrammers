using System;

namespace ExercisesforProgrammers
{
	class Exercise04
	{
		public void Solution04()
		{
			string strNoun, strVerb, strAdjective, strAdverb;
			Console.Write("Enter a Noun: ");
			strNoun = Console.ReadLine();

			Console.Write("Enter a Verb: ");
			strVerb = Console.ReadLine();

			Console.Write("Enter a Adjective: ");
			strAdjective = Console.ReadLine();

			Console.Write("Enter a Adverb: ");
			strAdverb = Console.ReadLine();

			Console.WriteLine("\nDo you " + strVerb + " your " + strAdjective + " " + strNoun + " " + strAdverb + "? That's Hilarious!");			
		}
	}
}
