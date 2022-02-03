using System;

namespace ExercisesforProgrammers
{
	class Exercise30
	{
		public void Solution30()
		{
			int i, j, nValue;

			for(i = 0; i <= 12; i++)
			{
				for(j = 0; j <= 12; j++)
				{
					nValue = i * j;
					Console.WriteLine(i + " * " + j + " = " + nValue);
				}
			}
		}
	}
}
