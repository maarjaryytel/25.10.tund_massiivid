using System;

namespace _25._10tund_massiivid
{
	class Program
	{
		static void Main(string[] args)
		{
			//3 meetodit
			//array static methods

			//loome uue massiivi kuhu salvest string tüüpi massiivi, arvuti küsib kasutajalt 5 korda värve

			string[] colors = new string[5];

			for (int i = 0; i < colors.Length; i++) 
			{
				Console.WriteLine("Enter a color: ");
				//kui arvuti on värvi öelnud, siis hakkame salvestama
				colors[i] = Console.ReadLine();
			}

			//automaatselt sorteerida array.sort- ütleme mis massiiviga tahame tööd teha

			Array.Sort(colors); //sorteeris tähestiku järgi
			

			foreach (string color in colors)
			{
				Console.WriteLine(color);
			}
			//sort an array
			Array.Sort(colors); //sort sorteerib
			
			//reverse an array
			Array.Reverse(colors);
			Console.WriteLine("Array reversed: ");
			PrintArray(colors);//kutsun funktsiooni välja
			Console.ReadLine();
		}
		//teeme eraldi funktsiooni
		public static void PrintArray(string[]array) // see on funktsioon
		{
			foreach(string item in array)
			{
               Console.WriteLine(item);
			}
		}
		//kui ma tahan elementi massiivist üles leida- index of

			
	}
}
