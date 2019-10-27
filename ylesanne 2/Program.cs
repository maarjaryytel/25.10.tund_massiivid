using System;

namespace ylesanne_2
{
	class Program
	{
		static void Main(string[] args)
         //küsib kasutajalt mis puuvilja ta otsib ja kui on olemas, siis ütleb, kus asub ja kui ei ole, siis ütleb, et ei ole

		{
		    string[] fruit = new string[5] { "apple", "banana", "pear", "orange", "lemon" }; //apple on 0, banana on 1 jne
			PrintArray(fruit); //kutsub funktsiooni välja

			int index;
			

			Console.WriteLine("What are you looking for?");
			string userSearch = Console.ReadLine(); //salvestab need andmed mida user annab
			index = Array.IndexOf(fruit, userSearch);

			if (index != -1) //kui ei ole seda toodet, siis arvuti ütleb seda
			{
				Console.WriteLine($"here is your {userSearch}");

			}
			else
			{
				Console.WriteLine($"404 {userSearch} not found");
			}
		
			Console.ReadLine();
		}
		public static void PrintArray(string[] array) // see on funktsioon
		{
			foreach (string item in array)
			{
				Console.WriteLine(item);
			}
		}
	}
}
