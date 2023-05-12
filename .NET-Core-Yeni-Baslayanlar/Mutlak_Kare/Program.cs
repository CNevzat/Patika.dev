using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutlak_Kare
{
	public class Program
	{
		//Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan.
		//Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak
		//	toplayıp ekrana yazdıran console uygulamasını yazınız.
		static void Main(string[] args)
		{
			Console.Write("Aralarına birer boşluk bırakarak sayı giriniz: ");
			string inputs = Console.ReadLine();
			//arrays
			string[] arr_inputs = inputs.Split(' ');
			int[] arr_numbers = new int[arr_inputs.Length];
			//variables
			int diff = 0;
			double absolute = 0;
			
			for (int i = 0; i < arr_inputs.Length; i++)
			{
				int current = int.Parse(arr_inputs[i]);
				arr_numbers[i] = current;

				if (arr_numbers[i] < 68)
				{
					diff += 67 - arr_numbers[i];
					
				}
				else if (arr_numbers[i] > 68)
				{
					absolute += Math.Pow(Convert.ToDouble(arr_numbers[i] - 67), 2);
					
				}
			}
			Console.WriteLine("Farkların toplamı:" + diff);
			Console.Write("Farkların mutlak karelerinin toplamı:" + absolute);

			Console.ReadKey();
		}
	}
}
