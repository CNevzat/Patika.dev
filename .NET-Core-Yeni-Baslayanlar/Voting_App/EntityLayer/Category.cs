using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
	public class Category
	{
        public int CategoryID { get; set; } 
        public string CategoryName { get; set; } 
        public int CategoryVote { get; set; }
        public int CategoryStar { get; set; }
        public double VotingRatio { get; set; }

        public Category(int cID, string cName, int cVote, int cStar) 
        {
            CategoryID = cID;
            CategoryName = cName;
            CategoryVote = cVote;
            CategoryStar = cStar;
        }
    }
}
