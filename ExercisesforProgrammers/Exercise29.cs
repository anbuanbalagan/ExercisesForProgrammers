using System;

namespace ExercisesforProgrammers
{
	class Exercise29
	{
		public void Solution29()
		{
			int nRateofReturn, nYears;
			bool num = true;
			while(num)
			{
				Console.Write("What is the rate of return? ");

				if(!int.TryParse(Console.ReadLine(), out nRateofReturn))
				{
					num = true;
					Console.WriteLine("Sorry. That's not a valid input.");
				}
				else
				{
					if(nRateofReturn == 0)
					{
						Console.WriteLine("Can't Divide a number by 0");
					}
					else
					{
						nYears = 72 / nRateofReturn;
						Console.WriteLine("It will take " + nYears + " years to double your initial investment.");
						num = false;
					}
				}
			}
			
		}
	}
}
