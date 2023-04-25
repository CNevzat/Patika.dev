using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1_Console_Telefon_Rehberi_Uygulaması
{
	public class Program
	{
		public static void Menu()
		{
			Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
			Console.WriteLine("******************");
			Console.WriteLine(""
				+ "1- Yeni Numara Kaydet \n"
				+ "2- Numara Sil \n"
				+ "3- Numara Güncelle \n"
				+ "4- Rehberi Listele \n"
				+ "5- Rehberde Arama Yap");
			Console.WriteLine("******************");
		}
		static void Main(string[] args)
		{				
			Rehber rehber = new Rehber();			
			Menu(); // Açılışta kullanıcını menuyu görüntüler
			int input;
			//Kullanıcı menu ekranında yanlış giriş yaptığı sürece menu tekrarlanır
			while ((!int.TryParse(Console.ReadLine(), out input)) || input < 0 || input > 5)
			{ 
				Menu();
			}
			switch (input)
			{
				case 1:
					rehber.AddNo();
					break;

				case 2:
					rehber.DeleteNo();
					break;

				case 3:
					rehber.UpdateNo();
					break;

				case 4:
					rehber.List();
					break;

				case 5:
					rehber.Search();
					break;

				default:
					Console.WriteLine("Hatalı seçim yaptınız!");
					break;
			}
			Console.ReadKey();
		}
	}
}
