using ATM_App.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.BusinessLayer.Abstract
{
	public interface IUser
	{
		void addUser(User user);
		List<User> ListAll();
		long Randomizer();
		User GetUser(long id, string username, string usersurname);
		User Login(long id, string password);
		User GetUserByID(long id);
	}
}
