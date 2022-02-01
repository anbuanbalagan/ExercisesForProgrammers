using System;

namespace ExercisesforProgrammers
{
	class Exercise31
	{
		public void Solution31()
		{
			int nRestingPulse, nIntensity, nRate, nAge;
			Console.Write("Resting Pulse : ");
			nRestingPulse = int.Parse(Console.ReadLine());
			Console.Write("Age : ");			
			nAge = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");
			Console.WriteLine("Intensity\tRate");

			for(nIntensity = 55; nIntensity <= 95; nIntensity += 5)
			{				
				nRate = ((((220 - nAge) - nRestingPulse) * nIntensity) / 100) + nRestingPulse ;
				Console.Write(nIntensity + "% \t\t" + nRate + " bpm");
				Console.WriteLine(" ");				
			}
		}
	}
}
