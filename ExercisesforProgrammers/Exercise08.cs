using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise08
	{
		public void Solution08()
		{
			int nPeople, nPizzas;
			Console.Write("How many People? ");
			nPeople = int.Parse(Console.ReadLine());
			Console.WriteLine("");

			Console.Write("How many Pizzas? ");
			nPizzas = int.Parse(Console.ReadLine());
			Console.WriteLine("");
			 
			Console.WriteLine(nPeople + " people with " + nPizzas + " pizzas");
			Console.WriteLine("Each person gets " + nPizzas + " pieces of pizza.");
			Console.WriteLine("There are " + (nPeople % nPizzas) + " leftover pieces.");
		}
	}
}
