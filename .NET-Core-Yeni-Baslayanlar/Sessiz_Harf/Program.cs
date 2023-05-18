using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessiz_Harf
{
	public class Program
	{
		public static void SessizHarf()
		{
			Console.Write("İfade giriniz: ");
			string data = Console.ReadLine();
			string[] words = data.Split(' '); //girilen kelimeler boşluğa göre ayrılır ve words dizisine eklenir

			string consonants = "bcçdfgğhjklmnprsştvyz";

			foreach (var item in words)
			{
				bool result = false;

				for (int i = 0; i < item.Length - 1; i++) //son harfe gelindiğinde i + 1 de range hatası verilmemesi için (aynı harfi döndürür)
				{
					if (consonants.Contains(item[i]) && consonants.Contains(item[i + 1])) //anlık harf ve bir sonrakinin
																						  //sessiz harf içerip içermediği kontrol edilir
					{
						result = true;
						break; //iki sessiz harfin yanyana gelmesinde döngü sonlanır (devamını kontrol etmeye gerek olmadığı için)
					}
				}
				Console.WriteLine(result);
			}
		}
		static void Main(string[] args)
		{
			SessizHarf();	
			Console.ReadKey();
		}
	}
}
