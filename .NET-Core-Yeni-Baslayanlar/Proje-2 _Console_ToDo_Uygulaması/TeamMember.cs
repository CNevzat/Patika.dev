using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2__Console_ToDo_Uygulaması
{
	public class TeamMember
	{
		private int teamMemberID;
		private string teamMemberName;

		public TeamMember(int teamMemberID, string teamMemberName)
		{
			this.TeamMemberID = teamMemberID;
			this.TeamMemberName = teamMemberName;
		}
		public int TeamMemberID { get => teamMemberID; set => teamMemberID = value; }
		public string TeamMemberName { get => teamMemberName; set => teamMemberName = value; }

		public TeamMember GetTeamMemberByID(int id)
		{
			return teamMembers.Find(x => x.TeamMemberID == id);
		}
	}
}
