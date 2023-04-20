using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1_Console_Telefon_Rehberi_Uygulaması
{
	public class Program
	{
		static void Main(string[] args)
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

			Rehber rehber = new Rehber();
			rehber.List();
			
			
			Console.ReadKey();
		}
	}
}
