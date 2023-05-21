using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
	public interface IUser
	{
		void addUser(User user);
		void removeUser(User user);
		List<User> ListAll();
		int Randomizer();
		User GetUser(int id,string username);
		User Login(string username, string password);

	}
}
