using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
	//Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden
	//verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("İfade ve index numarasını giriniz (İfade ile index arasına virgül koyunuz) :");
			string ifade = Console.ReadLine();
			// sayıyı kelimeden ayırıp kelimeyi word değişkenine atar.
			string word = ifade.Split(',')[0];
			int index;
			//silinmesi istenilen harfin indexini try parse metodu ile index değişkenine atar
			// TryParse metodunun kullanılmasının sebebi kullanıcı virgülden sonra integer bir değer girmezse hata alır.
			bool res = int.TryParse(ifade.Split(',')[1], out index );
			// res true dönerse ve girilen index değeri ifadenin index değerinden küçük olursa silme işlemi yapılır
			if (res == true && index < ifade.Length)
			{
				List<char> harfler = word.ToList();
				harfler.RemoveAt(index); // girilen index'e göre harf listeden silindi
										 //listenin yeni hali
				foreach (char item in harfler)
				{
					Console.Write(item);
				}
			}
			// index değeri ifadenin uzunluğundan büyük olursa hata verilir. Örneğin Nevzat,12
			else
			{
				Console.WriteLine("Index ifadenin uzunluğundan büyük olamaz.");
			}
			Console.ReadKey();
		}
	}
}
