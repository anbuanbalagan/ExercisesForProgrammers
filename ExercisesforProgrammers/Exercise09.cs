using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise09
	{
		public void Solution09()
		{
			int nLength, nWidth, nArea,nGallons;
			nLength = int.Parse(Console.ReadLine());
			nWidth = int.Parse(Console.ReadLine());

			nArea = nLength * nWidth;

			if(nArea % 350 == 0)
			{
				nGallons = nArea / 350;
			}
			else
			{
				nGallons = (nArea / 350) + 1;
			}

			Console.WriteLine("You will need to purchase " + nGallons + " gallons of paint to cover " + nArea + " square feet.");
		}
	}
}
