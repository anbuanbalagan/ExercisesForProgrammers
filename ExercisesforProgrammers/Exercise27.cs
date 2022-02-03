using System;
using System.Text.RegularExpressions;

namespace ExercisesforProgrammers
{
	class Exercise27
	{
		int num = 0;
		public void Solution27()
		{
			string strFirstName, strLastName, strEmployeeID;
			int nZIPcode;
			Console.Write("Enter the First Name : ");
			strFirstName = Console.ReadLine();
			Console.Write("Enter the Last Name : ");
			strLastName = Console.ReadLine();
			Console.Write("Enter the ZIP code : ");

			if(!int.TryParse(Console.ReadLine(), out nZIPcode))
			{
				num = 1;
			}			

			Console.Write("Enter the Employee ID : ");
			strEmployeeID = Console.ReadLine();
			string val = ValidateName(strFirstName,strLastName);

			if(num == 1)
			{
				Console.WriteLine("\nInvalid ZIP code.");
			}

			bool id = ValidateEmployeeID(strEmployeeID);

			if(val == "1" && num == 0 && id )
			{
				Console.WriteLine("\nThere were no Errors found.");
			}
		}

		public string ValidateName(string strFirstName, string strLastName)
		{
			string valid;
			int nLength1, nLength2;
			nLength1 = strFirstName.Length;
			nLength2 = strLastName.Length;

			var hasChar = new Regex(@"[A-Za-z]+");

			if(nLength1 < 2 || nLength2 < 2)
			{
				if(hasChar.IsMatch(strFirstName) && nLength1 < 2)
				{
					Console.WriteLine("\n" + strFirstName + " is not a valid FirstName. It is too short");
				}
				else if(strFirstName == String.Empty)
				{
					Console.WriteLine("\nThe FirstName must be filled in.");
				}

				if(hasChar.IsMatch(strLastName) && nLength2 < 2)
				{
					Console.WriteLine(strLastName + " is not a valid LastName. It is too short");
				}
				else if(strLastName == String.Empty)
				{
					Console.WriteLine("\nThe LastName must be filled in.");
				}
				valid = "0";
			}
			else
			{
				valid = "1";
			}
			return valid;
		}

		public bool ValidateEmployeeID(string strEmployeeID)
		{
			bool id = Regex.IsMatch(strEmployeeID, @"[A-Z][A-Z]-[0-9][0-9][0-9][0-9]");

			if(id)
			{
				return true;
			}

			else
			{
				Console.WriteLine("\n" + strEmployeeID + " is not a valid ID.");
				return false;
			}
		}
	}
}
