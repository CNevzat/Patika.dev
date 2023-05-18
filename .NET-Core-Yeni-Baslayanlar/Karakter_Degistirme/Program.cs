using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter_Degistirme
{
	public class Program
	{
		//Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip
		//tekrar ekrana yazdıran console uygulamasını yazınız.
		//Örnek: Input: Merhaba Hello Algoritma x
		//Output: aerhabM oellH algoritmA x

		static void Main(string[] args)
		{
			Console.Write("İfade giriniz: ");
			string data = Console.ReadLine();

			string[] words = data.Split(' '); // Data'daki kelimeleri boluşa göre ayırır words dizisine atar
			string[] newWords = new string[words.Length]; // words dizisinin uzunluğu kadar yeni bir dizi

			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].Length == 1) // Eğer kullanıcı tek harf girişi yaparsa
				{
					newWords[i] = words[i];
				}
				else
				{
					char first = words[i][0]; // ilk kelimenin ilk harfi
					char last = words[i][words[i].Length - 1]; // ilk kelimenin son harfi 

					//harfleri değiştirdikten sonra kelimenin devamını yazabilmek için substring metodu ile
					// değiştirelen harfin sonrası ve öncesi words dizinden alınır
					string newWord = last + words[i].Substring(1, words[i].Length - 2) + first;
					newWords[i] = newWord;
				}
			}
			string newData = string.Join(" ", newWords); //dizideki tüm kelimeler boşluk bırakılarak birleştirilir 
														 // girilen cümle tekrar elde edilmiş olur

			Console.WriteLine("Güncellenmiş metin: "+newData);
			Console.ReadKey();
		}
	}
}
