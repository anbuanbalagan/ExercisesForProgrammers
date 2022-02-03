using System;

namespace ExercisesforProgrammers
{
	class Exercise17
	{
		public void Solution17()
		{
			double nAlcoholConsumed, nWeight,nHours,nTotal = 0;
			string strGender;

			Console.Write("Enter Gender : ");
			strGender = Console.ReadLine();
			Console.Write("Enter the amount of Alcohol consumed in ounces : ");
			nAlcoholConsumed = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the person weight : ");
			nWeight = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the number of hours since last drink : ");
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
				Console.WriteLine("\nYour BAC is " + nTotal + "\nIt is not Legal for you to Drive.");				
			}
			else
			{
				Console.WriteLine("\nYour BAC is " + nTotal + "\nIt is Legal for you to Drive.");
			}
		}
	}
}
