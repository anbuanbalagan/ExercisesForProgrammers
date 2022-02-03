using System;
using System.Text.RegularExpressions;

namespace ExercisesforProgrammers
{
	class Exercise25
	{
		public void Solution25()
		{
			string strPassword;
			Console.WriteLine("Enter the Password");
			strPassword = Console.ReadLine();
			passwordValidator(strPassword);
		}

		public void passwordValidator(string pass)
		{
			var password = pass;
			int nLength = password.Length;
			var hasNumber = new Regex(@"[0-9]+");
			var hasChar = new Regex(@"[A-Za-z]+");
			var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

			if(hasNumber.IsMatch(password) && nLength < 8)
			{
				Console.WriteLine("\nVery Weak Password");
			}

			else if(hasChar.IsMatch(password) && nLength < 8)
			{
				Console.WriteLine("\nWeak Password");
			}

			else if(hasNumber.IsMatch(password) && hasChar.IsMatch(password) && hasSymbols.IsMatch(password) && nLength >= 8)
			{
				Console.WriteLine("\nVery Strong Pass");
			}

			else if(hasNumber.IsMatch(password) && hasChar.IsMatch(password) && nLength >= 8)
			{
				Console.WriteLine("\nStrong Password");
			}					
		}
	}
}
