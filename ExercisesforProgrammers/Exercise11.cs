using System;

namespace ExercisesforProgrammers
{
	class Exercise11
	{
		public void Solution11()
		{
			int nEuros;
			double dDollars, dExchangeRate , dTotal;

			Console.Write("How many Euros are you exchanging? ");
			nEuros = int.Parse(Console.ReadLine());

			Console.Write("What is the exchange rate? ");
			dExchangeRate = float.Parse(Console.ReadLine());

			dDollars = (nEuros * dExchangeRate) / 100;
		    dTotal = Math.Round(dDollars,2);
			Console.WriteLine("\n" + nEuros + " euros at an exchange rate of " + dExchangeRate + " is " + dTotal + " U.S. dollars.");
		}
	}
}
