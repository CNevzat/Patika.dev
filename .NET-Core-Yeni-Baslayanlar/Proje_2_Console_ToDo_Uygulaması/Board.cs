using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2_Console_ToDo_Uygulaması
{
	public class Board
	{
		public List<TeamMember> membersList { get; set; }
		public List<Card> cards { get; set; } //all
		public Board() //Constructor
		{   //Default Members
			membersList = new List<TeamMember>()
			{
				new TeamMember(10,"Nevzat Çırpıcıoğlu"),
				new TeamMember(20,"Yahya Çırpıcıoğlu"),
				new TeamMember(30,"Furkan Demir"),
				new TeamMember(40,"Erman Kaymaz"),
				new TeamMember(50,"Cem Çırpıcıoğlu"),
				new TeamMember(60,"Berk Sayit")
				
			};
			//Default Cards
			cards = new List<Card>()
			{
				new Card("Yazılım1","Patika",Type.TODO,CardSize.XS,membersList[0]),
				new Card("Yazılım2","Frontend",Type.INPROGRESS,CardSize.S,membersList[1]),
				new Card("Yazılım3","Backend",Type.DONE,CardSize.L,membersList[2])
			};
		}
		public void AddCard()
		{
			bool secimIsValid = false;
			Console.WriteLine("*** KART EKLEME ***");
			Console.Write("Başlık Giriniz: ");
			string title = Console.ReadLine();
			Console.Write("İçerik Giriniz: ");
			string content = Console.ReadLine();
			Console.Write("Büyüklük Giriniz: ");
			int size = int.Parse(Console.ReadLine());
			Console.Write("Atama yapmak istediğiniz kişinin ID'sini giriniz: ");
			int id = int.Parse(Console.ReadLine());
			TeamMember teamMember = GetTeamMemberByID(id);

			while (!secimIsValid) //Secimin kontrolünün sağlanması
			{
				Console.Write("Tür Giriniz -> 1- ToDo 2- In Progress 3- Done	 : ");
				int secim = int.Parse(Console.ReadLine());
				if (secim == 1) 
				{			
					Card card = new Card(title, content, (Type)secim, (CardSize)size, teamMember);
					cards.Add(card);
					secimIsValid = true; 
				}
				else if (secim == 2)
				{
					Card card = new Card(title, content, (Type)secim, (CardSize)size, teamMember);
					cards.Add(card);
					secimIsValid = true;
				}
				else if (secim == 3)
				{
					Card card = new Card(title, content, (Type)secim, (CardSize)size, teamMember);
					cards.Add(card);
					secimIsValid = true;
				}
				else { Console.WriteLine("Hatalı Seçim Yaptınız"); }
			}
		}
		public TeamMember GetTeamMemberByID(int id)
		{
			return membersList.Find(x => x.ID == id);
		}
		public Card GetCardByTitle(string title)
		{
			return cards.Find(x => x.Title == title);		
		}
		public void List()
		{
			Console.WriteLine("*** LİST ***");
			Console.WriteLine("TODO Line");
			ListCardByType(Type.TODO);
			Console.WriteLine("*******");
			Console.WriteLine("INPROGRESS Line");
			ListCardByType(Type.INPROGRESS);
			Console.WriteLine("*******");
			Console.WriteLine("DONE Line");
			ListCardByType(Type.DONE);
		}
		public void ListCardByType(Type type)
		{
			int i = 1;
			foreach (var item in cards)
			{
				if (item.Type == type)
				{
					Console.WriteLine("Başlık: "+item.Title);
					Console.WriteLine("İçerik: "+item.Content);
					Console.WriteLine("Atanan Kişi: "+item.Member.MemberName);
					Console.WriteLine("Size: "+item.Size);
					Console.WriteLine("-");
					i++;
				}
			}
		}
		public void DeleteCard()
		{
			Console.WriteLine("*** KART SİLME ***");
			Console.WriteLine("***********************");
			Console.Write("Silmek istediğiniz kartın başlığını giriniz: ");
			Card willDeleted = GetCardByTitle(Console.ReadLine());

			if (willDeleted != null) { cards.Remove(willDeleted); Console.WriteLine("Kart başarıyla silindi"); }
			else 
			{ Console.WriteLine("Kart Bulunamadı"); }
		}
		public void MoveCard()
		{
			Console.WriteLine("*** KART TAŞIMA ***");
			Console.Write("Taşımak istediğiniz kartın başlığını yazınız: ");
			string title = Console.ReadLine();	
			Card willMoved = GetCardByTitle(title);

			if (willMoved != null)
			{
				Console.WriteLine("Aradığınız kart bulundu");
				Console.WriteLine("Kart Bilgileri: " +
					"Baslık:"+ willMoved.Title+
					" İçerik:"+ willMoved.Content+
					" Atanan Kişi:"+ willMoved.Member.MemberName+
					" Büyüklük:"+ willMoved.Size);

				Console.WriteLine("Taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) INPROGRESS (3) DONE");
				int lineSecim = int.Parse(Console.ReadLine());
				if (lineSecim == 1)
				{
					willMoved.Type = Type.TODO;
					List();
				}
				else if (lineSecim == 2)
				{
					willMoved.Type = Type.INPROGRESS;
					List();
				}
				else if (lineSecim == 3)
				{
					willMoved.Type = Type.DONE;
					List();
				}
			}
			else 
			{
				Console.WriteLine("Aradığınız kart bulunamadı\n" +
					"Lütfen bir seçim yapınız.\n" +
					"İşlemi sonlandırmak için : (1)\n" +
					"Yeniden denemek için     : (2)");
				int secim = int.Parse(Console.ReadLine());
				if (secim == 1)
				{
					//Menu Çağrılcak
				}
				else if (secim == 2)
				{
					MoveCard();
				}
				else 
				{
					Console.WriteLine("Hatalı seçim yaptınız");
				}
			}
		}
	}
}
