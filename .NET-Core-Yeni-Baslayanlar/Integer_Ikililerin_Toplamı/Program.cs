using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Ikililerin_Toplamı
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Boşluk bırakarak sayıları giriniz: ");
			var numbers = Console.ReadLine();
			var ifade = numbers.Split(' '); // sayılar boşluğa göre ayrılır
			String result = String.Empty;

			for (int i = 0; i < ifade.Length; i += 2) // i'nin ikişer atlamasının sebebi sayıları ikişer gruplara ayırmak için
			{

				if (ifade[i] == ifade[i + 1])
				{
					result += Math.Pow((Convert.ToInt32(ifade[i]) + Convert.ToInt32(ifade[i + 1])), 2) + " "; //ikilinin ilk sayısı
					//ve ikinci sayısının toplamının karesini alır. 
				}
				else
				{
					result += Convert.ToInt32(ifade[i]) + Convert.ToInt32(ifade[i + 1]) + " ";
				}
			}
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
