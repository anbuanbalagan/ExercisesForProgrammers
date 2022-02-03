using System;

namespace ExercisesforProgrammers
{
	class Exercise20
	{
		public void Solution20()
		{
			double dAmount, dTotal,dTax;
			string strState;
			Console.Write("What is the order Amount? ");
			dAmount = Convert.ToDouble(Console.ReadLine());

			Console.Write("What State do you live in? ");
			strState = Console.ReadLine();			

			if(strState == "WI" || strState == "wi" || strState == "Wi" || strState == "wI" || strState == "Wisconsin" || strState == "WISCONSIN")
			{
				dTotal = (dAmount * 5.0) / 100;
				dTax = Math.Round(dTotal, 2);
				Console.WriteLine("\nThe Subtotal is $" + dAmount);
				Console.WriteLine("The Tax is $" + dTax);
				Console.WriteLine("The Total is $" + (dAmount + dTax));
				Environment.Exit(0);
			}

			else if(strState == "EW" || strState == "ew" || strState == "Ew" || strState == "eW" || strState == "Eau Claire" || strState == "eau claire" || strState == "EAU CLAIRE")
			{
				dTotal = (dAmount * 5.0) / 100;
				dTax = Math.Round(dTotal, 2);
				Console.WriteLine("\nThe Subtotal is $" + dAmount);
				Console.WriteLine("The Tax is $" + dTax);
				Console.WriteLine("The Total is $" + (dAmount + dTax + 0.005));
				Environment.Exit(0);
			}

			else if(strState == "NC" || strState == "nc" || strState == "Nc" || strState == "nC" || strState == "Dunn" || strState == "dunn" || strState == "DUNN")
			{
				dTotal = (dAmount * 5.0) / 100;
				dTax = Math.Round(dTotal, 2);
				Console.WriteLine("\nThe Subtotal is $" + dAmount);
				Console.WriteLine("The Tax is $" + dTax);
				Console.WriteLine("The Total is $" + (dAmount + dTax + 0.004));
				Environment.Exit(0);
			}

			else if(strState == "IL" || strState == "il" || strState == "Il" || strState == "iL" || strState == "Illinois" || strState == "illinois" || strState == "EAU CLAIRE")
			{
				dTotal = (dAmount * 8.0) / 100;
				dTax = Math.Round(dTotal, 2);
				Console.WriteLine("\nThe Subtotal is $" + dAmount);
				Console.WriteLine("The Tax is $" + dTax);
				Console.WriteLine("The Total is $" + (dAmount + dTax));
				Environment.Exit(0);
			}
			Console.WriteLine("\nThe Total is $" + dAmount);
		}
	}
}
