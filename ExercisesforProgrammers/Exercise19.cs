using System;

namespace ExercisesforProgrammers
{
	class Exercise19
	{
		public void Solution19()
		{
			double dWeight, dHeight, dTotal,dbmi;

			Console.Write("Enter the person Weight in pounds : ");
			dWeight = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the person Height in inches : ");
			dHeight = Convert.ToDouble(Console.ReadLine());

			dTotal = (dWeight / (dHeight * dHeight)) * 703;
			dbmi = Math.Round(dTotal, 1);

			if(dbmi >= 18.5 && dbmi <= 25)
			{
				Console.WriteLine("\nYour BMI is " + dbmi + "\nYou are within the ideal weight range.");
			}

			else if(dbmi < 18.5)
			{
				Console.WriteLine("\nYour BMI is " + dbmi + "\nYou are underweight. You should see your Doctor.");
			}

			else if(dbmi > 25)
			{
				Console.WriteLine("\nYour BMI is " + dbmi + "\nYou are overweight. You should see your Doctor.");
			}			
		}
	}
}
