using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.EntityLayer
{
	public class User
	{
        public long UserID { get; set; } //identification number
        public string Username { get; set; }
        public string Usersurname { get; set; }
        public string Password { get; set; }
		public int Balance { get; set; }
		public User(long uID, string uName, string uSurname, string password, int balance)
		{
			this.UserID = uID;
			this.Username = uName;
			this.Usersurname = uSurname;
			this.Password = password;
			this.Balance = balance;
		}
	}

}
