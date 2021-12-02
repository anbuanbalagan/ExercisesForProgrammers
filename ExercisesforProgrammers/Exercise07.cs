using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise07
	{
		public void Solution07()
		{
			int Length, Width, Area;
			float F = 0.09290304f;  // to convert Square feet into Square meter 

			Console.Write("What is the Length of the Room in feet? ");
			Length = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");

			Console.Write("What is the Width of the Room in feet? ");
			Width = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");

			Console.WriteLine("You entered dimensions of " + Length + " feet by " + Width + " feet.");
			Console.WriteLine("\nThe Area is ");
			Area = Length * Width;

			float Squaremeter = Area * F;
			Console.WriteLine(Squaremeter + " square meters");
		}
	}
}
