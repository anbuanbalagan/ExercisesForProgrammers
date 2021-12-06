using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise18
	{
		public void Solution18()
		{
			double dTemperature;
			char choice;

			Console.WriteLine("Press C to convert from Fahrenheit to Celsius.");
			Console.WriteLine("Press F to convert from Celsius to Fahrenheit.");
			Console.Write("Your choice: ");
			choice = Convert.ToChar(Console.ReadLine());		

			switch(choice)
			{
				case 'C':
							Console.Write("Please enter the Temperature in Fahrenheit : ");
							dTemperature = Convert.ToDouble(Console.ReadLine());
							toCelsius(dTemperature);								
							break;
				case 'F':
							Console.Write("Please enter the Temperature in Celsius : ");
							dTemperature = Convert.ToDouble(Console.ReadLine());
							toFahrenheit(dTemperature);
							break;
				default: break;
			}
		}

		public void toFahrenheit(double temperature)
		{
			double dFahrenheit = Math.Round(((temperature * 1.8000) + 32),2);   //Another way to calculate fahrenheit
			//double dFahrenheit = (temperature * 9 / 5) + 32;
			Console.WriteLine("The Temperature in Fahrenheit : " + dFahrenheit);
		}

		public void toCelsius(double temperature)
		{
			double dCelsius = Math.Round(((temperature - 32) / 1.8000),2);    //Another way to calculate celsius
			//double dCelsius = (temperature - 32) * 5 / 9;
			Console.WriteLine("The Temperature in Celsius : " + dCelsius);
		}
	}
}


