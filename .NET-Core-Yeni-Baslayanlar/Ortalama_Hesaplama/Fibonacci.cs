using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
	public class Fibonacci
	{
		public int[] CalculateFibonacci(int depth)
		{
			int[] arr = new int[depth];
			int n1 = 0, n2 = 1, n3 = 0;
			arr[0] = n1;
			arr[1] = n2;
			for (int i = 2; i < depth; i++) // i'nin 2 den başlamasının sebebi ilk elementin önceden tanımlı olmasıdır
				{ // iterasyon ile her sayı bir sonraki sayının değerini alır. 
					n3 = n1 + n2;
				    arr[i] = n3;
					n1 = n2;
					n2 = n3;		
				}
				return arr;
		}
	}
}
