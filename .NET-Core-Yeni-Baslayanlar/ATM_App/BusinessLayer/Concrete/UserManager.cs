using ATM_App.BusinessLayer.Abstract;
using ATM_App.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.BusinessLayer
{
	public class UserManager : IUser
	{
		Database db = new Database();
		public void addUser(User user)
		{
			db.users.Add(user);
		}

		public User GetUser(long id, string username, string usersurname)
		{
			return db.users.Find(x => x.UserID == id && x.Username == username && x.Usersurname == usersurname);
		}

		public User GetUserByID(long id)
		{
			return db.users.Find(x=> x.UserID == id);
		}

		public List<User> ListAll()
		{
			return db.users;
		}

		public User Login(long id, string password)
		{
			return db.users.Find(x => x.UserID == id && x.Password == password);
		}

		public long Randomizer()
		{
			Random rnd = new Random();
			long num = rnd.Next();
			return num;
		}
	}
}
