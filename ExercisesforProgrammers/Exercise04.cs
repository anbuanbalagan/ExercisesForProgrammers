using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise04
	{
		public void Solution04()
		{
			string Noun, Verb, Adjective, Adverb;
			Console.Write("Enter a Noun: ");
			Noun = Console.ReadLine();
			Console.WriteLine("");

			Console.Write("Enter a Verb: ");
			Verb = Console.ReadLine();
			Console.WriteLine("");

			Console.Write("Enter a Adjective: ");
			Adjective = Console.ReadLine();
			Console.WriteLine("");

			Console.Write("Enter a Adverb: ");
			Adverb = Console.ReadLine();
			Console.WriteLine("");

			Console.WriteLine("Do you " + Verb + " your " + Adjective + " " + Noun + " " + Adverb + "? That's Hilarious!");
			Console.WriteLine("\n");

		}
	}
}
