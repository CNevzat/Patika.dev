using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
	public class User
	{
        public int  UserID { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }    

        public User(int uID, string uName, string password)
        {
            UserID = uID;
            UserName = uName;
            Password = password;
        }
    }
}
