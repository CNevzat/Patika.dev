using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
//İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı(Daire, Üçgen, Kare, Dikdörtgen vb..)
//Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
//Hesaplanmak istenen boyutu kullanıcıdan alınmalı(Çevre, Alan, Hacim vb..)
//Hesap sonucunu anlaşılır şekilde geri döndürmeli.
	public class Program
	{

		//Main Functions
		public static void Alan_Hesapla(double choice)
		{
			if (choice == 1)
			{
				Console.WriteLine("Dairenin çapını giriniz: ");
				double radius = double.Parse(Console.ReadLine());
				double area = Daire_Alan(radius);

				Console.Write("Dairenin alanı: "+area);
			}	
			else if (choice == 2)
			{
				Console.Write("Dikdörtgenin kısa kenarını giriniz: ");
				double shortEdge = double.Parse(Console.ReadLine());
				Console.Write("Dikdörtgenin uzun kenarını giriniz: ");
				double longEdge = double.Parse(Console.ReadLine());
				double area = Dikdortgen_Alan(shortEdge, longEdge);

				Console.WriteLine("Dikdörtgenin Alanı: "+area);
			}
			else if (choice == 3)
			{
				Console.Write("Kenar giriniz: ");
				double edge = double.Parse(Console.ReadLine());
				double area = Kare_Alan(edge);

				Console.Write("Karenin Alanı: "+area);
			}
			else if (choice == 4)
			{
				Console.Write("Taban giriniz: ");
				double t_base = double.Parse(Console.ReadLine());
				Console.Write("Yükseklik giriniz: ");
				double h = double.Parse(Console.ReadLine());
				double area = Ucgen_Alan(t_base, h);

				Console.Write("Üçgenin Alanı: "+area);
			}
			else 
			{
				Console.Write("Hatalı giriş yaptınız");
			}

		}
		public static void Cevre_Hesapla(double choice)
		{
			double perimeter = 0;
			if (choice == 1)
			{
				Console.Write("Çap giriniz: ");
				double edge = double.Parse(Console.ReadLine());
				perimeter = Daire_Cevre(edge);

				Console.WriteLine("Dairenin çevresi: " + perimeter);
			}
			else if (choice == 2)
			{
				Console.Write("Kısa kenarı giriniz: ");
				double short_edge = double.Parse(Console.ReadLine());
				Console.WriteLine("Uzun kenarı giriniz: ");
				double long_edge = double.Parse(Console.ReadLine());
				perimeter = Dikdörtgen_Cevre(short_edge, long_edge);

				Console.WriteLine("Dikdörtgenin çevresi: " + perimeter);
			}
			else if (choice == 3)
			{
				Console.Write("Kenar giriniz: ");
				double edge = double.Parse(Console.ReadLine());
				perimeter = Kare_Cevre(edge);

				Console.Write("Karenin Çevresi: " + perimeter);
			}
			else if (choice == 4)
			{
				Console.Write("Taban giriniz: ");
				double t_base = double.Parse(Console.ReadLine());
				Console.WriteLine("Yükseklik giriniz: ");
				double h = double.Parse(Console.ReadLine());
				Console.WriteLine("Kenar giriniz: ");
				double edge = double.Parse(Console.ReadLine());
				perimeter = Ucgen_Cevre(t_base, h, edge);

				Console.WriteLine("Üçgenin Çevresi: " + perimeter);
			}
		}

		//Methods
		public static double Daire_Alan(double radius)
		{
			double area = Math.PI * radius * radius;
			return area;
		}
		public static double Dikdortgen_Alan(double a, double b)
		{
			double area = a * b;
			return area;
		}
		public static double Kare_Alan(double a)
		{
			double area = a * a;
			return area;
		}
		public static double Ucgen_Alan(double a, double h) 
		{
			double area = (a * h) / 2;
			return area;
		}
		public static double Daire_Cevre(double radius)
		{
			double perimeter = 2 * Math.PI * radius;
			return perimeter;
		}
		public static double Dikdörtgen_Cevre(double a, double b)
		{
			double perimeter = (2 * a) + (2 * b);
			return perimeter;
		}
		public static double Kare_Cevre (double a)
		{
			double perimeter = a * 4;
			return perimeter;
		}
		public static double Ucgen_Cevre(double a, double h, double z)
		{
			double perimeter = a + h + z;
			return perimeter;
		}			

		static void Main(string[] args)
		{	
			Console.Write("1-Daire 2-Dikdörtgen 3-Kare 4-Üçgen\n" +
			"Seçim yapınız: ");
			double choice_shape = double.Parse(Console.ReadLine());
			Console.WriteLine("1-Alan\n2-Çevre");
			double choice_type = double.Parse(Console.ReadLine());
			
			if (choice_type == 1)
			{
				Alan_Hesapla(choice_shape);
			}
			else if (choice_type == 2)
			{
				Cevre_Hesapla(choice_shape);
			}


			Console.ReadKey();
		}
	}
}
