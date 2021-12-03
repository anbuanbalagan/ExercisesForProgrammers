using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise15
	{
		public void Solution15()
		{
			string strUserName,strPassword;
			
			strUserName = Console.ReadLine();
			Console.Write("What is the Password? ");
			strPassword = Console.ReadLine();

			if(strUserName == "Jack" &&  strPassword == "abc$12345")
			{
				Console.WriteLine("Welcome!");
			}
			else
			{
				Console.WriteLine("I don't know you.");
			}
		}
	}
}
