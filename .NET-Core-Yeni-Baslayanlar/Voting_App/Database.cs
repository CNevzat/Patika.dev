using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
	public class Database
	{
		public List<Category> categories = new List<Category>();
		public List<User> users = new List<User>();	

		public Database()
		{
			categories.Add(new Category(1,"Action",0, 0));
			categories.Add(new Category(2,"Horror",0, 0));
			categories.Add(new Category(3,"Sport",0, 0));

			users.Add(new User(1010, "Nevzat", "123"));
			users.Add(new User(2020, "Patika", "123"));
			users.Add(new User(3030, "Yazılım", "123"));
		}
	}
}
