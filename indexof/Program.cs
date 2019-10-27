using System;

namespace indexof
{
	class Program
	{
		static void Main(string[] args)
		{
			//otsib meie loetelust mingi puuvilja ja ütleb, mitmendal kohal see puuvili on. Orange on 3-ndal kohal, st 0- apple, 1- banana jne
			string[] fruit = new string[5] { "apple", "banana", "pear", "orange", "lemon" }; //apple on 0, banana on 1 jne
			PrintArray(fruit); //kutsub funktsiooni välja

			//Array.IndexOf(fruit, "orange") //ta tahab massiivi, kust hakkame otsima ja mida hakkame otsima
			int index;
			index = Array.IndexOf(fruit, "orange");

			Console.WriteLine($"the index of your element is: {index}");
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
