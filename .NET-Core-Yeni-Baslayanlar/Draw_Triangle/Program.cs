using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Triangle
{
	public class Program
	{
		static void Main(string[] args)
		{
			int length = 0;
			Console.Write("Boyut bilgisini giriniz: ");
			length = int.Parse(Console.ReadLine());

			int i, j, k;
			for (i = 1; i <= length; i++)
			{
				for (j = 1; j <= length - i; j++)
				{
					// Console.Write("");  
				}
				for (k = 1; k <= i; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}
			Console.ReadKey();
		}
	}
}
