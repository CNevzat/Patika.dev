using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
	public class Program
	{   // NOTES
		// Static olan elemanlara o sınıfın adıyla erişilir (o sınıftan nesne türeterek değil)
		// İlk static olan constructor çalışır ve 1 kez çalışır
		// Static constructor'ların erişim belirleyicisi olmaz
		// Static sınıfların barındırdığı her şey static olmak zorundadır
		// Static sınıflardan kalıtım uygulanamaz !!
		static void Main(string[] args)
		{
			Console.WriteLine("Çalışan sayısı: {0}" , Calisan.CalisanSayisi); // ilk static olan const. çalışır ve 1 kez çalışır

			Calisan calisan = new Calisan("Nevzat", "Çırpıcıoğlu", "IT");
			Calisan calisan2 = new Calisan("Yahya", "Çırpıcıoğlu", "IT");
			Calisan calisan3 = new Calisan("Furkan", "Demir", "IT");

			Console.WriteLine("Çalışan sayısı: {0}" ,Calisan.CalisanSayisi);
			Console.WriteLine("Toplama işleminin sonucu: {0}" , Islemler.Topla(100,200));
			Console.WriteLine("Çıkarma işleminin sonucu: {0}" , Islemler.Cıkar(200,100));
		}

		class Calisan 
		{
			private static int calisanSayisi; //field

			public static int CalisanSayisi { get => calisanSayisi;} //property

			private string Isim;
			private string Soyisim;
			private string Departman;

			static Calisan() //Static constructor'ların erişim belirleyicisi olmaz
			{
				calisanSayisi = 0;
			}
			public Calisan(string isim, string soyisim, string departman) //constructor
			{
				this.Isim = isim;
				this.Soyisim = soyisim;
				this.Departman = departman;
				calisanSayisi++;
			}
		}

		static class Islemler
		{
			public static long Topla(int sayi1, int sayi2)
			{
				return sayi1 + sayi2;
			}
			public static long Cıkar(int sayi1, int sayi2)
			{
				return sayi1 - sayi2;
			}
		}
	}
}
