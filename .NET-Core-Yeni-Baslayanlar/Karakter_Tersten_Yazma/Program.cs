using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter_Tersten_Yazma
{//Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer
 //değiştiren console uygulamasını yazınız.
 //Örnek: Input: Merhaba Hello Question
 //Output: erhabaM elloH uestionQ
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("İfade giriniz:");
			string ifade = Console.ReadLine();
			string result = "";

			for (int i = ifade.Length - 1; i >= 0; i--)
			{
				result += ifade[i];
			}
			Console.WriteLine("Sonuç: " + result);
			Console.ReadKey();
		}
	}
}
