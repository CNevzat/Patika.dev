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
		private List<TeamMember> teamMembers;

		public Board() 
		{
			toDo = new List<Card>();
			inPogress = new List<Card>();
			done = new List<Card>();

			teamMembers = new List<TeamMember>();
			{
				new TeamMember(10,"Nevzat");
				new TeamMember(20,"Furkan");
				new TeamMember(30,"Yahya");
			}
		}
		//props 
		public List<Card> ToDo { get => toDo; set => toDo = value; }
		public List<Card> InPogress { get => inPogress; set => inPogress = value; }
		public List<Card> Done { get => done; set => done = value; }
		public List<TeamMember> TeamMembers { get => teamMembers; set => teamMembers = value; }

		public void AddCard(Board board)
		{   // Kullanıcıdan kart bilgileri alma
			Console.WriteLine("Kart Ekleme");
			Console.Write("Başlık Giriniz                                    :");
			string title = Console.ReadLine();
			Console.Write("İçerik Giriniz                                    :");
			string content = Console.ReadLine();
			Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)    :");
			string size = Console.ReadLine();	
			Console.Write("Atanacak kişinin ID'sini giriniz                  :");
			int ID = int.Parse(Console.ReadLine());
			TeamMember assignedPerson = board.GetTeamMemberByID(ID);
			Console.Write("Tür Seçiniz -> TODO(1),INPROGRESS(2),DONE(3)      :");
			string type  = Console.ReadLine();
			if (type == "1")
			{
				type = "TODO";
				board.toDo.Add(new Card(title, content,assignedPerson, size, type));
			}
			else if (type == "2")
			{
				type = "INPROGRESS";
			}
			else if (type == "3")
			{
				type = "DONE";
			}
		}



		public void List(Board board)
		{
			Console.WriteLine("Yapılacaklar Listesi");
			foreach (var item in board.ToDo)
			{			
				Console.WriteLine("Title: "+item.Title);
				Console.WriteLine("Content: "+item.Content);
				Console.WriteLine("Assigned Person: "+item.AssignedPerson.TeamMemberName);
				Console.WriteLine("Size: "+item.Size);
				Console.WriteLine("Type: "+item.Type);
				Console.WriteLine("*****************");
			}
			Console.WriteLine("İşlemdeki Görevler");
			foreach (var item in board.inPogress)
			{
				Console.WriteLine("Title: " + item.Title);
				Console.WriteLine("Content:"+item.Content);
				Console.WriteLine("Assigned Person: " + item.AssignedPerson.TeamMemberName);
				Console.WriteLine("Size: " + item.Size);
				Console.WriteLine("Type: " + item.Type);
				Console.WriteLine("*****************");
			}
			Console.WriteLine("Tamamlanan Görevler");
			foreach (var item in board.done)
			{
				Console.WriteLine("Title: " + item.Title);
				Console.WriteLine("Content: "+item.Content);
				Console.WriteLine("Assigned Person: " + item.AssignedPerson.TeamMemberName);
				Console.WriteLine("Size: " + item.Size);
				Console.WriteLine("Type: " + item.Type);
				Console.WriteLine("*****************");
			}
		}

	}

}
