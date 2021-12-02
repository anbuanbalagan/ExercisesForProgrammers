using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise09
	{
		public void Solution09()
		{
			int Length, Width, Area,Gallons;
			Length = int.Parse(Console.ReadLine());
			Width = int.Parse(Console.ReadLine());

			Area = Length * Width;

			if(Area % 350 == 0)
			{
				Gallons = Area / 350;
			}
			else
			{
				Gallons = (Area / 350) + 1;
			}
			Console.WriteLine("You will need to purchase " + Gallons + " gallons of paint to cover " + Area + " square feet.");
		}
	}
}
