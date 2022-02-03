using System;

namespace ExercisesforProgrammers
{
	class Exercise07
	{
		public void Solution07()
		{
			int nLength, nWidth, nArea;
			float fSquaremeter,fConversion = 0.09290304f;  // to convert Square feet into Square meter 

			Console.Write("What is the Length of the Room in feet? ");
			nLength = int.Parse(Console.ReadLine());

			Console.Write("What is the Width of the Room in feet? ");
			nWidth = int.Parse(Console.ReadLine());

			Console.WriteLine("\nYou entered dimensions of " + nLength + " feet by " + nWidth + " feet.");
			Console.WriteLine("\nThe Area is ");
			nArea = nLength * nWidth;

			fSquaremeter = nArea * fConversion;
			Console.WriteLine(fSquaremeter + " square meters");
		}
	}
}
