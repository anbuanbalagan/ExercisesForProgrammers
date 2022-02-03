using System;

namespace ExercisesforProgrammers
{
	class Exercise10
	{
		public void Solution10()
		{
			int[] nItem = new int[3];
			int[] nQuantity = new int[3];
			int i;
			float fTax, fTaxPercent= 5.5f, fsum = 0;

			for(i = 0; i < 3; i++)
			{
				Console.Write("Enter the price of item " + (i+1) +" : ");
				nItem[i] = int.Parse(Console.ReadLine());

				Console.Write("Enter the quantity of item " + (i+1) + " : ");
				nQuantity[i] = int.Parse(Console.ReadLine());

				fsum += (nItem[i] * nQuantity[i]);
			}

			Console.WriteLine("\nSubtotal: $ " + fsum);
			fTax = (fsum * fTaxPercent) / 100;
			Console.WriteLine("Tax: $ " + fTax);
			fsum += fTax;
			Console.WriteLine("Total: $ " +fsum);
		}
	}
}
