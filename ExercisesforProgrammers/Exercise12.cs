using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise12
	{
		public void Solution12()
		{
			double dPrincipal, dTotal;
			int  nYears;
			float fRateofInterest;

			Console.Write("Enter the Principal: ");
			dPrincipal = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(" ");

			Console.Write("Enter the Rate of Interest: ");
			fRateofInterest = float.Parse(Console.ReadLine());
			Console.WriteLine(" ");

			Console.Write("Enter the Number of years: ");
			nYears = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" ");

			dTotal = (dPrincipal * fRateofInterest * nYears) / 100;		
			dPrincipal += dTotal;

			Console.WriteLine("After " + nYears + " years at " + fRateofInterest + "%, the investment will be worth $" + Math.Round(dPrincipal) + ".");

		}
	}
}
