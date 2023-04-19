using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Söz dizimi
			// class sinifAdi
			//{
			//[Erişim belirleyici] [Veri tipi] OzellikAdi;
			//[Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
			//{
			//Metot komutları
			//}
			//}

			//Erişim belirleyiciler
			// * Public
			// * Private
			// * Internal
			// * Protected
			Calisan calisan1 = new Calisan();
			calisan1.Ad = "Nevzat";
			calisan1.Soyad = "Çırpıcıoğlu";
			calisan1.No = 12345;
			calisan1.Departman = "IT";
			calisan1.CalisanBilgileri();

			Console.WriteLine("***********");

			Calisan calisan2 = new Calisan();
			calisan1.Ad = "Yahya";
			calisan1.Soyad = "Çırpıcıoğlu";
			calisan1.No = 123456;
			calisan1.Departman = "Finans";
			calisan1.CalisanBilgileri();
		}

		class Calisan
		{
			public string Ad;
			public string Soyad;
			public int No;
			public string Departman;

			public void CalisanBilgileri()
			{
				Console.WriteLine("Çalışanın Adı: {0}", Ad);
				Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
				Console.WriteLine("Çalışanın Numarası: {0}", No);
				Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
			}
		}
	}
}
