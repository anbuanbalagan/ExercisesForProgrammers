using System;

namespace ExercisesforProgrammers
{
	class Exercise09
	{
		public void Solution09()
		{
			int nLength, nWidth, nArea,nGallons;
			Console.WriteLine("Enter the Length and Width of the room ");
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

			Console.WriteLine("\nYou will need to purchase " + nGallons + " gallons of paint to cover " + nArea + " square feet.");
		}
	}
}
