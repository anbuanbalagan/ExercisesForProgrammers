using System;

namespace ExercisesforProgrammers
{
	class Exercise35
	{
		public void Solution35()
		{
			int i;
			string[] strName = new string[10];

			for(i = 0; i < 10; i++)
			{
				Console.Write("Enter a Name : ");
				strName[i] = Console.ReadLine();
				if(strName[i] == String.Empty)
				{
					int randomNumber = new Random().Next(1, i-1);
					Console.WriteLine("The Winner is... " +strName[randomNumber]);
					break;
				}
			}

		}
	}
}
