using System;

namespace numbrid_min_max
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[5] { 1, 4, -8, 4, 100 };
			//me võime alustada 0-st,

			int min = Int32.MaxValue;
			//tahan maksimaalset väärtust, mida tahan salvestada, see on üle 2 miljardi
            int max = Int32.MinValue;

			foreach (int number in numbers)
			{
				if(number < min )
				{
					min = number; //min on peale 1 korda 1, seejärel võtab 4, seejärel võtab -8 jne
					//min on alguses 2 miljardit, ja peale esimest if, muutub see min juba 1-ks
				}
				if (number > max)
				{
					max = number;
				}
			}
			Console.WriteLine($"the minimum value is {min}");
			Console.WriteLine($"The maximum value is {max}");

			Console.ReadLine();
		}
	}
}
