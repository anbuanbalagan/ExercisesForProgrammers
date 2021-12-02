using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise08
	{
		public void Solution08()
		{
			int People, Pizzas;
			Console.Write("How many People? ");
			People = int.Parse(Console.ReadLine());
			Console.WriteLine("");

			Console.Write("How many Pizzas? ");
			Pizzas = int.Parse(Console.ReadLine());
			Console.WriteLine("");
			 
			Console.WriteLine(People + " people with " + Pizzas + " pizzas");
			Console.WriteLine("Each person gets " + Pizzas + " pieces of pizza.");
			Console.WriteLine("There are " + (People % Pizzas) + " leftover pieces.");
		}
	}
}
