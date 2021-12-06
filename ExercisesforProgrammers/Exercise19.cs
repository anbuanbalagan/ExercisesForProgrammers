using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise19
	{
		public void Solution19()
		{
			double dWeight, dHeight, dTotal,dbmi;

			dWeight = Convert.ToDouble(Console.ReadLine());
			dHeight = Convert.ToDouble(Console.ReadLine());

			dTotal = (dWeight / (dHeight * dHeight)) * 703;
			dbmi = Math.Round(dTotal, 1);

			if(dbmi >= 18.5 && dbmi <= 25)
			{
				Console.WriteLine("Your BMI is " + dbmi + "\nYou are within the ideal weight range.");
			}

			else if(dbmi < 18.5)
			{
				Console.WriteLine("Your BMI is " + dbmi + "\nYou are underweight. You should see your Doctor.");
			}

			else if(dbmi > 25)
			{
				Console.WriteLine("Your BMI is " + dbmi + "\nYou are overweight. You should see your Doctor.");
			}			
		}
	}
}
