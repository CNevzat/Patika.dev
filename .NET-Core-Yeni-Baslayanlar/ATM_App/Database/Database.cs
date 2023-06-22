using ATM_App.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
	public class Database
	{
		public List<User> users = new List<User>();
		public List<Transaction> transactions = new List<Transaction>();
		public List<Fraud> frauds = new List<Fraud>();
		
		public Database()
		{
			users.Add(new User(12345678911, "Nevzat", "Çırpıcıoğlu", "123",100));
			users.Add(new User(12345678912, "Patika", "Yazılım", "123", 100));
			users.Add(new User(12345678913, "Yahya", "Yazılım", "123", 100));
		}
	}
}
