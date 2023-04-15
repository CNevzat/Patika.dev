using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_Soru1
{
	public class Program
	{
		static void Main(string[] args)
		{
			ArrayList asalSayılar = new ArrayList();
			ArrayList asalOlmayanSayılar = new ArrayList();
			double avg_asal = 0;
			double avg_asal_olmayan = 0;
			string sayi;
			int sayac = 0;

			for (int i = 0; i < 19; i++) // 20 adet sayı girişi
			{
				Console.WriteLine("Sayı giriniz: ");
				sayi = Console.ReadLine(); // Kullanıcıdan sayı alma
				if (int.TryParse(sayi, out int result) && result > 0) // Girdi TryParse metodu ile integer'a dönüştürülebiyor mu
					//diye check edilir dönüştürülemezse integer değildir ve kod else bloğuna düşer. İkinci bir validation ise
					// dönüştürülen sayının 0'dan büyük olması (eksi sayı girilmemesi için)
				{
					for (int j = 1; j <= result; j++) //Asal olup olmadığını belirleme
					{
						if (result % j == 0)
						{
							sayac++;
						}
					}
					if (sayac == 2) // Asal sayı | Yalnızca kendine ve 1'e bölündüğü için sayac 2 olur
					{
						asalSayılar.Add(result);
					}
					else // Asal sayı değil
					{
						asalOlmayanSayılar.Add(result);
					}
					sayac = 0;
				}
				else 
				{
					Console.WriteLine("Hatalı giriş yaptınız !");
					i--; // Hatalı giriş yapıldığında o girişi saymaması için 
				}
			}

			// Asal Sayılar ArrayList'inin ortalaması
			if (asalSayılar.Count > 0) //Liste boş değilse
			{
				Console.WriteLine("***Asal Sayılar*** ");
				for (int i = 0; i < asalSayılar.Count; i++)
				{
					avg_asal += Convert.ToDouble(asalSayılar[i]);					
					Console.WriteLine(asalSayılar[i]);
				}
				avg_asal = avg_asal / asalSayılar.Count;
				Console.WriteLine("Girilen asal sayıların ortalaması:" + avg_asal);
				Console.WriteLine("Eleman sayısı: "+asalSayılar.Count);
			}

			// Asal Olmayan Sayılar ArrayList'inin ortalaması
			if (asalOlmayanSayılar.Count > 0)
			{
				Console.WriteLine("***Asal Olmayan Sayılar*** ");
				for (int j = 0; j < asalOlmayanSayılar.Count; j++)
				{
					avg_asal_olmayan += Convert.ToDouble(asalOlmayanSayılar[j]);
					Console.WriteLine(asalOlmayanSayılar[j]);
				}
				avg_asal_olmayan = avg_asal_olmayan / asalOlmayanSayılar.Count;
				Console.WriteLine("Girilen asal olmayan sayıların ortalaması:" + avg_asal_olmayan);
				Console.WriteLine("Eleman sayısı: " +asalOlmayanSayılar.Count);
			}
			Console.ReadKey();
		}
	}
}
