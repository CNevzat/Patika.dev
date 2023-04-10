using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
	public class Program
	{
		static void Main(string[] args)
		{
			//SORU 1 
			Console.WriteLine("**** SORU 1 ****");
			Console.WriteLine("Giriş yapmak istediğiniz adedi giriniz: ");
			int adet = Convert.ToInt32(Console.ReadLine());
			if (adet > 1)
			{
				int[] sayilar = new int[adet];
				for (int i = 0; i < adet; i++)
				{
					Console.WriteLine($"{i + 1}.Sayıyı giriniz: ");
					sayilar[i] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine("Çift Sayılar:");
				for (int i = 0; i < adet; i++)
				{
					if (sayilar[i] % 2 == 0)
					{
						Console.WriteLine(sayilar[i]);
					}
				}
			}
			// ----------------------------//
			//SORU 2
			Console.WriteLine("**** SORU 2 ****");
			Console.WriteLine("Adet giriniz:");
			int adet2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Sayı giriniz:");
			int m = int.Parse(Console.ReadLine());
			if (adet2 > 1)
			{
				int[] sayilar2 = new int[adet2];
				for (int i = 0; i < adet2; i++)
				{
					Console.WriteLine("Pozitif sayı giriniz:");
					sayilar2[i] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine("Girdiğiniz sayıya eşit ya da tam bölünen sayılar:");
				for (int i = 0; i < adet2; i++)
				{
					if (sayilar2[i] % m == 0 || sayilar2[i] == m)
					{
						Console.WriteLine(sayilar2[i]);
					}
				}
			}
			//----------------------------//
		    //SORU 3
			Console.WriteLine("**** SORU 3 ****");
			Console.WriteLine("Adet giriniz:");
			int adet3 = int.Parse(Console.ReadLine());
			if (adet3 > 1)
			{
				string[] kelimeler = new string[adet3];
				for (int i = 0; i < adet3; i++)
				{
					Console.WriteLine("Kelime giriniz");
					kelimeler[i] = Console.ReadLine();
				}
				Array.Reverse(kelimeler);
				for (int i = 0; i < adet3; i++)
				{
					Console.Write(kelimeler[i]);
				}
			}
		   //----------------------------//
		   //SORU 4
			Console.WriteLine("**** SORU 4 ****");					
			Console.WriteLine("Bir cümle yazınız:");
			string ifade = Console.ReadLine();
			string[] kelimeler_dizi = ifade.Split(' ');
			Console.WriteLine("Kelime sayısı: "+ kelimeler_dizi.Length);
			int space = ifade.Count(char.IsWhiteSpace);
			int char_count = ifade.Length - space;
			Console.WriteLine("Harf sayısı: " + char_count);
			Console.ReadKey();
		}
	}
}
