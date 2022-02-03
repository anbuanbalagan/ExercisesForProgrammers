using System;

namespace ExercisesforProgrammers
{
	class Exercise24
	{
		public void Solution24()
		{
			string strName1, strName2;
			Console.WriteLine("Enter two strings and I'll tell you if they are anagrams:");
			Console.Write("Enter the First string : ");
			strName1 = Console.ReadLine();
			Console.Write("Enter the Second string : ");
			strName2 = Console.ReadLine();
			isAnagram(strName1, strName2);
		}

		public void isAnagram(string one, string two)
		{
			char[] cone = one.ToLower().ToCharArray();
			char[] ctwo = two.ToLower().ToCharArray();
			Array.Sort(cone);
			Array.Sort(ctwo);
			string name1 = new string(cone);
			string name2 = new string(ctwo);

			if(name1 == name2)
			{
				Console.WriteLine("\n" +'"' + one + '"' + " and " +'"' + two + '"' + " are Anagram.");
			}
			else
			{
				Console.WriteLine("\n" + '"' + one + '"' + " and " + '"' + two + '"' + " are not Anagram.");
			}
		}
	}
}
