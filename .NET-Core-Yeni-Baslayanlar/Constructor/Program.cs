﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
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
			Console.WriteLine("*****Çalışan 1******");
			Calisan calisan1 = new Calisan("Nevzat", "Çırpıcıoğlu", 1806538, "IT");
			calisan1.CalisanBilgileri();

			Console.WriteLine("*****Çalışan 2******");
			Calisan calisan2 = new Calisan();
			calisan1.Ad = "Yahya";
			calisan1.Soyad = "Çırpıcıoğlu";
			calisan1.No = 123456;
			calisan1.Departman = "Finans";
			calisan1.CalisanBilgileri();

			Console.WriteLine("*****Çalışan 3******");
			Calisan calisan3 = new Calisan("Nevzat","Çırpıcıoğlu");
			calisan3.CalisanBilgileri();
			Console.ReadKey();
		}

		class Calisan
		{
			public string Ad;
			public string Soyad;
			public int No;
			public string Departman;

			public Calisan(string ad, string soyad, int no, string departman) // Constructor 
			{
				this.Ad = ad;
				this.Soyad = soyad;
				this.No = no;
				this.Departman = departman;
			}
			public Calisan() { } //Constructor 2

			public Calisan(string ad, string soyad) 
			{
				this.Ad= ad;
				this.Soyad= soyad;
			} 
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
