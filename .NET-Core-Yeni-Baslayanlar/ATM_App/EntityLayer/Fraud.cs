using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.EntityLayer
{
	public class Fraud
	{
		public long FraudID { get; set; }
		public DateTime FraudTime { get; set; }

        public Fraud(long fID, DateTime dt)
        {
            this.FraudID = fID;
            this.FraudTime = dt;    
        }

    }
}
