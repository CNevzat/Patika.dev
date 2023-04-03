using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
	public class Program
	{
		static void Main(string[] args)
		{
			// ATAMA VE İŞLEMLİ ATAMA

			int x = 3;
			int y = 3;
			y = y + 2;
			Console.WriteLine(y);
			y += 2;
			Console.WriteLine(y);
			y /= 1;
			Console.WriteLine(y);
			x *= 2;
			Console.WriteLine(x);

			// MANTIKSAL OPERETÖRLER
			// && , || !

			bool isSucces = true;
			bool isCompleted = false;

			if (isSucces && isCompleted)
				Console.WriteLine("Perfesct!");

			if (isSucces || isCompleted)
				Console.WriteLine("Great!");

			if (isSucces && isCompleted)
				Console.WriteLine("Fine!");


			//İLİŞKİSEL OPERATÖRLER
			// <, >, <=, >=, ==, !=

			int a = 3;
			int b = 4;
			bool sonuc = a < b;

			Console.WriteLine(sonuc);
			sonuc = a > b;
			Console.WriteLine(sonuc);
			sonuc = a >= b;
			Console.WriteLine(sonuc);
			sonuc = a <= b;
			Console.WriteLine(sonuc);
			sonuc = a == b;
			Console.WriteLine(sonuc);
			sonuc = a != b;
			Console.WriteLine(sonuc);

			Console.WriteLine("***Aritmetik Operatorler***");

			int sayi1 = 10;
			int sayi2 = 5;
			int sonuc1 = sayi1 / sayi2;
			Console.WriteLine(sonuc1);
			sonuc1 = sayi1 + sayi2;
			Console.WriteLine(sonuc1);
			sonuc1 = sayi1 + sayi2;
			Console.WriteLine(sayi1);
			sonuc1 = sayi1++;

			// % mod alır
			int sonuc2 = 20 % 3;
			Console.WriteLine(sonuc2);
		}
	}
}
