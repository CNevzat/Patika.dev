using ATM_App.BusinessLayer.Abstract;
using ATM_App.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.BusinessLayer.Concrete
{
	public class FraudManager : IFraud
	{
		Database db = new Database();

		public void AddFraud(Fraud fraud)
		{
			db.frauds.Add(fraud);
		}
		public List<Fraud> ListAllFrauds()
		{
			return db.frauds;
		}
	}
}
