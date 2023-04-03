using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Task2
{
	public class Program
	{
		class Result
		{
			public void solve(double meal_cost, int tip_percent, double tax_percent)
			{
				//meal_cost = 12; tip_percent = 20; tax_percent 8 
				double tip = (meal_cost / 100) * tip_percent; // (12 / 100) + 20 = 2.4
				double tax = (tax_percent / 100) * meal_cost; // (8 / 100) + 12 = 0,96
				double total_cost = meal_cost + tip + tax; // 12 + 2.4 + 0.96				
				Console.WriteLine(Math.Round(total_cost));			
			}
		}
		class Solution
		{
			static void Main(string[] args)
			{
				Console.WriteLine("Meal Cost");
				double meal_cost = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Tip Percent");
				int tip_percent = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Tax Percent");
				double tax_percent = Convert.ToInt32(Console.ReadLine());
				Result r = new Result();
				r.solve(meal_cost, tip_percent, tax_percent);
				Console.ReadKey();
			}
		}
	}
}
