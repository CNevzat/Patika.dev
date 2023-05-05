using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte
{
	public class Program
	{
		public static int CheckNums(int num1, int num2)
		{
			if (num2 > num1)
			{ Console.WriteLine("true"); }
			else if (num1 > num2)
			{
				Console.WriteLine("false");
			}
			else { Console.WriteLine("-1"); }
			return num2;		
  }
		static void Main(string[] args)
		{
			CheckNums(2,1);
			Console.ReadKey();
		}
	}
}
