using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
	public class Program //Beklenilen sonuçları vermektedir
	{ 
		static void Main(string[] args)
		{	
			Fibonacci fibonacci = new Fibonacci();
			Average average = new Average();

			Console.Write("Derinlik giriniz:");
			int depth = int.Parse(Console.ReadLine());

			int[] series = fibonacci.CalculateFibonacci(depth); // CalculateFibonacci metodunda return edilen diziyi series int dizisine atadım	
			double series_average = average.CalculateAverage(series);
			Console.Write("Fibonacci serisinin ortalaması: "+series_average);

			Console.ReadKey();
		}
	}
}
