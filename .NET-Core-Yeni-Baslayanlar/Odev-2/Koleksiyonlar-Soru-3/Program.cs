using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Koleksiyonlar_Soru_3
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("İfade Giriniz: ");
			string ifade = Console.ReadLine().ToLower(); // girilen ifadeki harfleri küçük harfe dönüştürür
			char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
			string[] arr = new string[ifade.Length]; //girilen ifadedeki harf sayısı kadar dizide yer açıyor

			int sayac = 0;
			foreach (char karakter in ifade)
			{
				foreach (char sesli in sesliler)
				{
					if (karakter == sesli)
					{
						sayac++;
						arr[sayac] = karakter.ToString();
					}
				}
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			Console.ReadKey();		
		}
	}
}
