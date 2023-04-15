using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
	public class Program
	{
		static void Main(string[] args)
		{
			int sayi, min, max;
			double ortalama = 0;
			double ortalama_max = 0;
			int[] arr = new int[6];

			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("Sayı giriniz: ");
				sayi = int.Parse(Console.ReadLine());
				arr[i] = sayi;
			}
			Array.Sort(arr);
			Console.WriteLine("Elemanlar: ");
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("En küçük elemanlar: " + arr[i]);
				ortalama += arr[i];
			}
			ortalama = ortalama / 3;
			Console.WriteLine("Ortalama: " + ortalama);

			Console.WriteLine("-----------");

			for (int i = arr.Length - 3; i < arr.Length; i++)
			{
				Console.WriteLine("En büyük elemanlar: " + arr[i]);
				ortalama_max += arr[i];
			}
			ortalama_max = ortalama_max / 3;
			Console.WriteLine("Ortalama: " + ortalama_max);
			Console.WriteLine("Ortalamaların toplamı: " + (ortalama + ortalama_max));
			Console.ReadKey();
		}
	}
}
