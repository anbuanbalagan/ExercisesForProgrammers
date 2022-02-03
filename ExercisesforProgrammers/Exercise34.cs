using System;

namespace ExercisesforProgrammers
{
	class Exercise34
	{
		public void Solution34()
		{
			int nInput, i = 0, nPosition = -1;
			Console.Write("Enter the number of Employee :");
			nInput = int.Parse(Console.ReadLine());

			string[] strEmployeeName = new string[nInput];
			Console.WriteLine("Enter the Employee Name ");			

			for(i = 0; i < nInput; i++)
			{
				strEmployeeName[i] = Console.ReadLine();
			}

			Console.WriteLine("There are " + nInput + " Employees.");

			for(i = 0; i < nInput; i++)
			{
				Console.WriteLine(strEmployeeName[i]);
			}

			Console.Write("\nEnter the Employee name to remove: ");
			string strRemoveName = Console.ReadLine();
			Console.WriteLine(" ");

			for(i = 0; i < nInput; i++)
			{
				if(strRemoveName == strEmployeeName[i])
				{
					nPosition = i;
					break;
				}
			}

			if(nPosition == -1)
			{
				Console.WriteLine("Employee Name did not found.");
			}
			else
			{
				for(i = nPosition; i < strEmployeeName.Length - 1; i++)
				{
					strEmployeeName[i] = strEmployeeName[i + 1];
				}

				Console.WriteLine("Now there are " + --nInput + " Employees.");

				for(i = 0; i < nInput; i++)
				{
					Console.WriteLine(strEmployeeName[i]);
				}
			}
		}
	}
}
