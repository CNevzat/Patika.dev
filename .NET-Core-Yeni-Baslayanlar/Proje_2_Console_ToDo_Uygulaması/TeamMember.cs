using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2_Console_ToDo_Uygulaması
{
	public class TeamMember
	{
        public int ID { get; set; }
		public string MemberName { get; set; }	
		public TeamMember(int id, string membername)
		{
			this.ID = id;
			this.MemberName = membername;
		}
    }
}
