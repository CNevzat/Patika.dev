using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.EntityLayer
{
	public class Transaction
	{
        public long TransactionID { get; set; }
        public string TransactionName { get; set; }
        public DateTime TransactionTime { get; set; }

        public Transaction(long tID, string tName, DateTime tTime)
        {
            this.TransactionID = tID;
            this.TransactionName = tName;   
            this.TransactionTime = tTime;
        }
    }
}
