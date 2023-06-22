using ATM_App.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.BusinessLayer.Abstract
{
	public interface IFraud
	{
		List<Fraud> ListAllFrauds();
		void AddFraud(Fraud fraud);
	}
}
