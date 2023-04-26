using Proje_2__Console_ToDo_Uygulaması.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2__Console_ToDo_Uygulaması
{
	public class Board:Methods //Methods interface'inden miras
	{
		//lists
		public List<Card> toDo;
		public List<Card> inPogress;
		public List<Card> done;

		public Board() 
		{
			toDo = new List<Card>();
			inPogress = new List<Card>();
			done = new List<Card>();
		}

		public List<Card> ToDo { get => toDo; set => toDo = value; }
		public List<Card> InPogress { get => inPogress; set => inPogress = value; }
		public List<Card> Done { get => done; set => done = value; }

		public void List(Board board)
		{
			Console.WriteLine("Yapılacaklar Listesi");
			foreach (var item in board.ToDo)
			{			
				Console.WriteLine("Title: "+item.Title);
				Console.WriteLine("Content: "+item.Content);
				Console.WriteLine("Assigned Person: "+item.AssignedPerson);
				Console.WriteLine("Size: "+item.Size);
				Console.WriteLine("Type: "+item.Type);
				Console.WriteLine("*****************");
			}
			Console.WriteLine("İşlemdeki Görevler");
			foreach (var item in board.inPogress)
			{
				Console.WriteLine("Title: " + item.Title);
				Console.WriteLine("Content:"+item.Content);
				Console.WriteLine("Assigned Person: " + item.AssignedPerson);
				Console.WriteLine("Size: " + item.Size);
				Console.WriteLine("Type: " + item.Type);
				Console.WriteLine("*****************");
			}
			Console.WriteLine("Tamamlanan Görevler");
			foreach (var item in board.done)
			{
				Console.WriteLine("Title: " + item.Title);
				Console.WriteLine("Content: "+item.Content);
				Console.WriteLine("Assigned Person: " + item.AssignedPerson);
				Console.WriteLine("Size: " + item.Size);
				Console.WriteLine("Type: " + item.Type);
				Console.WriteLine("*****************");
			}
		}

	}

}
