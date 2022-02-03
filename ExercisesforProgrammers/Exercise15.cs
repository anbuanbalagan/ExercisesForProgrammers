using System;

namespace ExercisesforProgrammers
{
	class Exercise15
	{
		public void Solution15()
		{
			string strUserName,strPassword;

			Console.Write("Enter the Username : ");
			strUserName = Console.ReadLine();
			Console.Write("What is the Password? ");
			strPassword = Console.ReadLine();

			if(strUserName == "Jack" &&  strPassword == "abc*12345")
			{
				Console.WriteLine("\nWelcome!");
			}
			else
			{
				Console.WriteLine("\nI don't know you.");
			}
		}
	}
}
