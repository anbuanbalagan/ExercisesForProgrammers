using System;

namespace ExercisesforProgrammers
{
	class Exercise26
	{
		public void Solution26()
		{
			double dBalance, dRate;
			int nMonthlyPayment;
			Console.Write("What is your Balance? ");
			dBalance = Convert.ToDouble(Console.ReadLine());
			Console.Write("What is the APR on the card (as a percent)? ");
			dRate = Convert.ToDouble(Console.ReadLine());
			Console.Write("What is the monthly payment you can make? ");
			nMonthlyPayment = Convert.ToInt32(Console.ReadLine());
			Calculate(dBalance, dRate, nMonthlyPayment);
		}

		public void Calculate(double dBalance, double dRate, int nMonthlyPayment)
		{
			double num1, num2, num4, dTotal;
			num1 = 1 + dRate / 365;
			num2 = Math.Pow(num1, 30);
						
			double num3 = Math.Log(1 + dBalance / nMonthlyPayment * (1 - num2));
			num4 = Math.Log(num1);

			dTotal = - 1 / 30 * num3 / num4;
			Console.WriteLine(dTotal);
		}		
	}
}
