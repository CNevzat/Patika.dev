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
		//	List<TeamMember> members = new List<TeamMember>();
		//	members.Add(new TeamMember(14, "Nevzat Çırpıcıoğlu"));
		//	members.Add(new TeamMember(36, "Yahya Çırpıcıoğlu"));
		//	members.Add(new TeamMember(45, "Furkan Demir"));
			//Sample Board and its cards in different types
			Board board1 = new Board();
			//SingleOrDefault komutu ile tek bir sonuç döndürüyorum. ID si 45 olan kişiyi yani Furkan Demir'i getiriyor
			//board1.toDo.Add(new Card("Title1", "Content1", members.SingleOrDefault(x=>x.TeamMemberID == 36), "XL", "TODO"));
			//board1.inPogress.Add(new Card("Title2", "Content2", members.SingleOrDefault(x => x.TeamMemberID == 45), "L", "INPROGRESS"));
			//board1.done.Add(new Card("Title3", "Content3", members.SingleOrDefault(x => x.TeamMemberID == 14),"M", "DONE"));
			board1.AddCard(board1);
			board1.List(board1);

			Console.ReadKey();
		}
	}
}
