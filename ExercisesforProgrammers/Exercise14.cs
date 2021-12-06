using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise14
	{
		public void Solution14()
		{
			double dAmount, dTax ;
			string strState;

			Console.Write("What is the order Amount? ");
			dAmount = Convert.ToDouble(Console.ReadLine());

			Console.Write("What is the State? ");
			strState = Console.ReadLine();

			dTax = (dAmount * 5.5) / 100;

			if(strState == "WI" || strState =="wi" || strState == "Wi"|| strState == "wI" || strState == "wisconsin" || strState == "WISCONSIN")
			{				
					Console.WriteLine("The Subtotal is $" + dAmount);
					Console.WriteLine("The Tax is $" + dTax);
					Console.WriteLine("The Total is $" + (dAmount + dTax));
					Environment.Exit(0);				
			}

			Console.WriteLine("The Total is $" + dAmount);
		}
	}
}
