using System;
using System.Collections.Generic;
using System.Text;

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
				dTotal = (dAmount * 5.05) / 100;
				dTax = Math.Round(dTotal, 2);
				Console.WriteLine("The Subtotal is $" + dAmount);
				Console.WriteLine("The Tax is $" + dTax);
				Console.WriteLine("The Total is $" + (dAmount + dTax));
				Environment.Exit(0);
			}

			else if(strState == "EC" || strState == "ec" || strState == "Ec" || strState == "eC" || strState == "Eau Claire" || strState == "eau claire" || strState == "EAU CLAIRE")
			{
				dTotal = (dAmount * 5.055) / 100;
				dTax = Math.Round(dTotal, 2);
				Console.WriteLine("The Subtotal is $" + dAmount);
				Console.WriteLine("The Tax is $" + dTax);
				Console.WriteLine("The Total is $" + (dAmount + dTax));
				Environment.Exit(0);
			}

			else if(strState == "DN" || strState == "dn" || strState == "Dn" || strState == "dN" || strState == "Dunn" || strState == "dunn" || strState == "DUNN")
			{
				dTotal = (dAmount * 5.054) / 100;
				dTax = Math.Round(dTotal, 2);
				Console.WriteLine("The Subtotal is $" + dAmount);
				Console.WriteLine("The Tax is $" + dTax);
				Console.WriteLine("The Total is $" + (dAmount + dTax));
				Environment.Exit(0);
			}

			else if(strState == "IL" || strState == "il" || strState == "Il" || strState == "iL" || strState == "Illinois" || strState == "illinois" || strState == "EAU CLAIRE")
			{
				dTotal = (dAmount * 8.0) / 100;
				dTax = Math.Round(dTotal, 2);
				Console.WriteLine("The Subtotal is $" + dAmount);
				Console.WriteLine("The Tax is $" + dTax);
				Console.WriteLine("The Total is $" + (dAmount + dTax));
				Environment.Exit(0);
			}
			Console.WriteLine("The Total is $" + dAmount);
		}
	}
}
