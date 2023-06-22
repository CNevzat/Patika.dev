using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.BusinessLayer.Abstract
{
	public interface ITransaction
	{
		int depositMoney(long id, int amount);
		int withDrawMoney(long id, int amount);
		int transferMoney(long receiverID, int amount, string receiver_name, string receiver_surname);
		


	}
}
