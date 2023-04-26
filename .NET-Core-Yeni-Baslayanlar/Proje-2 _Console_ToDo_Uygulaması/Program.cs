using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2__Console_ToDo_Uygulaması
{
	public class Program
	{
		public static void Menu()
		{
			Console.WriteLine("" +
				"1- Board Listele\n" +
				"2- Board'a Kart Ekle\n" +
				"3- Board'dan Kart Sil\n" +
				"4- Kart Taşı");
			Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
		}
		static void Main(string[] args)
		{  // Default Team Members 
			List<TeamMember> members = new List<TeamMember>();
			members.Add(new TeamMember(1, "Nevzat Çırpıcıoğlu"));
			members.Add(new TeamMember(2, "Yahya Çırpıcıoğlu"));
			members.Add(new TeamMember(3, "Furkan Demir"));
			//Sample Board and its cards in different types
			Board board1 = new Board();
			board1.toDo.Add(new Card("Title1", "Content1", "AssignedPerson1", "XL", "TODO"));
			board1.inPogress.Add(new Card("Title2", "Content2", "AssignedPerson2", "L", "INPROGRESS"));
			board1.done.Add(new Card("Title3", "Content3", "AssignedPerson3", "M", "DONE"));
			board1.List(board1);

			Console.ReadKey();
		}
	}
}
