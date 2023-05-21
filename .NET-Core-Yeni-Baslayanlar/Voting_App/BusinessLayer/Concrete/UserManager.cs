using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
	public class UserManager : IUser
	{
		Database db = new Database();
		public void addUser(User user)
		{
			db.users.Add(user);
		}

		public User GetUser(int id, string username)
		{
			return db.users.Find(x => x.UserID == id && x.UserName == username);
		}
		public List<User> ListAll()
		{
			return db.users;
		}

		public User Login(string username, string password)
		{
			return db.users.Find(x => x.UserName == username && x.Password == password);
		}

		public int Randomizer()
		{
			Random rnd = new Random();
			int num = rnd.Next();
			return num;
		}

		public void removeUser(User user)
		{
			db.users.Remove(user);
		}
	}
}
