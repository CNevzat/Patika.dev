using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2__Console_ToDo_Uygulaması
{
	public class Card
	{
		private string title, content, assignedPerson, size, type;

		public Card(string title,string content, string assignedPerson, string size, string type) 
		{
			this.Title = title;
			this.Content = content;
			this.AssignedPerson = assignedPerson;
			this.Size = size;
			this.Type = type;
		}
		public string Title { get => title; set => title = value; }
		public string Content { get => content; set => content = value; }
		public string AssignedPerson { get => assignedPerson; set => assignedPerson = value; }
		public string Size { get => size; set => size = value; }
		public string Type { get => type; set => type = value; }
	}
}
