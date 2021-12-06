using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise17
	{
		public void Solution17()
		{
			double nAlcoholConsumed, nWeight,nHours,nTotal = 0;
			string strGender;

			strGender = Console.ReadLine();
			nAlcoholConsumed = Convert.ToDouble(Console.ReadLine());
			nWeight = Convert.ToDouble(Console.ReadLine());			
			nHours = Convert.ToDouble(Console.ReadLine());

			if(strGender == "Male")
			{
				nTotal = ((nAlcoholConsumed * 5.14) / (nWeight * 0.73)) - (0.015 * nHours);
			}

			else if(strGender == "Female")
			{
				nTotal = (nAlcoholConsumed * 5.14 / nWeight * 0.66) - (0.015 * nHours);
			}

			if(nTotal >= 0.08)
			{
				Console.WriteLine("Your BAC is " + nTotal + "\nIt is not Legal for you to Drive.");				
			}
			else
			{
				Console.WriteLine("Your BAC is " + nTotal + "\nIt is Legal for you to Drive.");
			}
		}
	}
}
