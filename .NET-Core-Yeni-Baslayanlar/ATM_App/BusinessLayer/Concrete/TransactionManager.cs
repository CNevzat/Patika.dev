using ATM_App.BusinessLayer.Abstract;
using ATM_App.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.BusinessLayer
{
	public class TransactionManager : ITransaction
	{
		UserManager um = new UserManager();
		Database db = new Database();	
		public int depositMoney(long id, int amount)
		{
		 var user = db.users.Find(x => x.UserID == id);
			user.Balance += amount;
			return user.Balance;
		}
		public int transferMoney(long receiverID, int amount, string receiver_name, string receiver_surname)
		{
			var user = db.users.Find(x => x.UserID == receiverID && x.Username == receiver_name 
			&& x.Usersurname == receiver_surname);
			user.Balance += amount;
			return user.Balance;
		}
		
		public int withDrawMoney(long id, int amount)
		{
			var user = db.users.Find(x => x.UserID == id);
			user.Balance -= amount;
			return user.Balance;
		}
		public void addTransaction(Transaction transaction)
		{
			db.transactions.Add(transaction);
		}
		public List<Transaction> ListAllTransactions()
		{
			return db.transactions;
		}


	}
}
