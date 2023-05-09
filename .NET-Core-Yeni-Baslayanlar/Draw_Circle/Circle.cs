using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Circle
{
	public class Circle
	{
		public void DrawCircle(int radius)
		{
			int centerOfX = 20; // X coordinate of center of circle
			int centerOfY = 10; // Y coordinate of center of circle
			 // radius of circle

			// Draw circle
			for (int y = centerOfY - radius; y <= centerOfY + radius; y++)
			{
				for (int x = centerOfX - radius; x <= centerOfX + radius; x++)
				{
					double d = Math.Sqrt(Math.Pow(x - centerOfX, 2) + Math.Pow(y - centerOfY, 2));
					if (d < radius)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
