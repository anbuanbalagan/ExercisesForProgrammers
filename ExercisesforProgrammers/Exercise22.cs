using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesforProgrammers
{
	class Exercise22
	{
		public void Solution22()
		{			
			int[] array = new int[10];
			int i;

			Console.Write("Enter the First Number ");
			array[0] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Second Number ");
			array[1] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Third Number ");
			array[2] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Fourth Number ");
			array[3] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Fifth Number ");
			array[4] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Sixth Number ");
			array[5] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Seventh Number ");
			array[6] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Eight Number ");
			array[7] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Ninenth Number ");
			array[8] = int.Parse(Console.ReadLine());

			Console.Write("Enter the Tenth Number ");
			array[9] = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");

			int big = array[0];

			for( i = 1; i < array.Length;i++)
			{
				if(array[i] > big)
				{
					big = array[i];
				}
			}
			Console.WriteLine("The Largest number is " + big);
		}
	}
}
