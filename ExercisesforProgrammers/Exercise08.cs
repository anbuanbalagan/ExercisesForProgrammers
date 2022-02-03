using System;

namespace ExercisesforProgrammers
{
	class Exercise08
	{
		public void Solution08()
		{
			int nPeople, nPizzas;
			Console.Write("How many People? ");
			nPeople = int.Parse(Console.ReadLine());

			Console.Write("How many Pizzas? ");
			nPizzas = int.Parse(Console.ReadLine());
			 
			Console.WriteLine("\n" + nPeople + " people with " + nPizzas + " pizzas");
			Console.WriteLine("\nEach person gets " + nPizzas + " pieces of pizza.");
			Console.WriteLine("\nThere are " + (nPeople % nPizzas) + " leftover pieces.");
		}
	}
}
