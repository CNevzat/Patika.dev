using ATM_App.BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.Controller
{
	public class FraudController
	{
		FraudManager fm = new FraudManager();

		public void ListFrauds()
		{
			Console.WriteLine("Hatalı İşlemler");

			foreach (var item in fm.ListAllFrauds())
			{
				Console.WriteLine("Hatalı İşlem Kodu:"+ item.FraudID);
				Console.WriteLine("Hatalı İşlem Saati:"+ item.FraudTime);
			}
		}
	}
}
