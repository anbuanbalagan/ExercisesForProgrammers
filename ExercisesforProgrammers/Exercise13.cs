using System;

namespace ExercisesforProgrammers
{
	class Exercise13
	{
		public void Solution13()
		{
			double dPrincipal,dTotal = 0;
			int nYears, nAnnualCompound;
			float RateofInterest;

			Console.Write("What is the Principal amount? ");
			dPrincipal = Convert.ToDouble(Console.ReadLine());

			Console.Write("What is the Rate of Interest? ");
			RateofInterest = float.Parse(Console.ReadLine());

			Console.Write("What is the number of years? ");
			nYears = int.Parse(Console.ReadLine());

			Console.Write("What is the Number of times the Interest is Compounded per year? ");
			nAnnualCompound = int.Parse(Console.ReadLine());

			dTotal = dPrincipal * Math.Pow((1 + (RateofInterest / 100) / nAnnualCompound), (nAnnualCompound * nYears));
			Console.WriteLine("\n$" +dPrincipal + " invested at " + RateofInterest + "% for " + nYears + " years compounded " + nAnnualCompound + " times per year is $" + Math.Round(dTotal,2) + ".");
		}
	}
}
