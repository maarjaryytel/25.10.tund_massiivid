using System;

namespace ylesanne3
{
	class Program
	{
		static void Main(string[] args)
		{
			//compare arrays
			//meil on 2 massiivi - fruit ja vegetables
            //kui kasutaja ütleb -kas puu või juurvili ja meie peame ütlema, et see on siis puuvili või juurvili
			// ja kui seda pole, siis arvuti ütleb, et pole üks ega teine
			//võib funktsioonidega teha

			string[] fruit = new string[5] { "apple", "banana", "pear", "orange", "lemon" };
			string[] vegetable = new string[5] { "potato", "carrot", "tomato", "onion", "cucumber" };
            Console.WriteLine("Enter a word: ");
			string userSearch = Console.ReadLine();
			

			//PrintArray(fruit); //see rida kuvab mul üleval nimetatud puuviljad
			//PrintArray(vegetable);

			int indexFruit = Array.IndexOf(fruit, userSearch);
			int indexVegetables = Array.IndexOf(vegetable, userSearch);

			
			//string userAnswer;
			//userAnswer = Console.ReadLine();

			int index = Array.IndexOf(fruit, userSearch);


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

		public static void PrintArray(string[] array)
		{
			foreach (string item in array)
			{
				Console.WriteLine(item);
			}
		}
	}
}
