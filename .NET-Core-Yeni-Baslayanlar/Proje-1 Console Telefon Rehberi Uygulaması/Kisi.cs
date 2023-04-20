using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1_Console_Telefon_Rehberi_Uygulaması
{
	public class Kisi
	{ //encapsulation
		private string name, surName, phoneNumber;
		
		public Kisi(string name, string surName, string phoneNumber)
		{
			this.Name = name;
			this.Surname = surName;
			this.Phone_Number = phoneNumber;
		}

		public string Name { get; set; }
		public string Surname { get; set; }
		public string Phone_Number { get; set; }
	}
}
