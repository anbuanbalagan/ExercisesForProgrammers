using System;

namespace ExercisesforProgrammers
{
	class Exercise23
	{
		public void Solution23()
		{
			char cAnswer;
			Console.WriteLine("Is the car silent when you turn the key?");
			cAnswer = Convert.ToChar(Console.ReadLine());

			if(cAnswer == 'y')
			{
				Console.WriteLine("Are the battery terminals corroded ? ");
				cAnswer = Convert.ToChar(Console.ReadLine());
				if(cAnswer == 'y')
				{
					Console.WriteLine("Clean terminals and try starting again.");
				}
				else
				{
					Console.WriteLine("The Battery cables may be damaged .\nReplace cables and try again.");
				}
			}
			else
			{
				Console.WriteLine("Does the car make a clicking noise ?");
				cAnswer = Convert.ToChar(Console.ReadLine());
				if(cAnswer == 'y')
				{
					Console.WriteLine("Replace the battery.");
				}
				else
				{
					Console.WriteLine("Does the car crank up but fail to start ?");
					cAnswer = Convert.ToChar(Console.ReadLine());
					if(cAnswer == 'y')
					{
						Console.WriteLine("Check spark plug connections.");
					}
					else
					{
						Console.WriteLine("Does the engine start and then die?");
						cAnswer = Convert.ToChar(Console.ReadLine());
						if(cAnswer == 'y')
						{
							Console.WriteLine("Does your car have fuel injection?");
							cAnswer = Convert.ToChar(Console.ReadLine());
							if(cAnswer == 'y')
							{
								Console.WriteLine("Get it in for service.");
							}
							else
							{
								Console.WriteLine("Check to ensure the choke is opening and closing.");
							}
						}
						else
						{
							Console.WriteLine("Ask Mechanic for help.");
						}
					}
				}
			}
		}
	}
}
