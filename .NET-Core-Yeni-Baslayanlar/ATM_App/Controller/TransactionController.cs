using ATM_App.BusinessLayer;
using ATM_App.EntityLayer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.Controller
{
	public class TransactionController
	{
		TransactionManager tm = new TransactionManager();
		UserManager um = new UserManager();	

		public void depositMoney()
		{
			Console.WriteLine("*** Para Yatırma ***");
			Console.Write("ID'nizi giriniz:");
			long id = long.Parse(Console.ReadLine());
			Console.WriteLine("Yatırmak istediğiniz miktarı giriniz:");
			int amount = int.Parse(Console.ReadLine());

			var user = um.GetUserByID(id);
			if (user != null)
			{
				if (amount > 0)
				{									
					Console.WriteLine("Yeni Hesap Bakiyesi:"+tm.depositMoney(id,amount));
					//Transaction Session
					long transaction_id = um.Randomizer();
					string transaction_name = "Para Yatırma İşlemi";
					DateTime transaction_time = DateTime.Now;
					Transaction new_transaction = new Transaction(transaction_id,transaction_name,transaction_time);
					tm.addTransaction(new_transaction);
				}
				else 
				{
					Console.WriteLine("Miktar 0'dan küçük olamaz");
				}
			}
		}
		public void drawMoney()
		{
			Console.WriteLine("*** Para Çekme ***");
			Console.Write("ID'nizi giriniz:");
			long id = long.Parse(Console.ReadLine());
			Console.Write("Çekmek istediğiniz miktarı giriniz:");
			int amount = int.Parse(Console.ReadLine());

			var user = um.GetUserByID(id);
			if (user != null)
			{
				if (user.Balance > amount)
				{
						
					Console.WriteLine("Para çekme işlemi başarıyla gerçekleştirildi");
					Console.WriteLine("Yeni bakiye:" + tm.withDrawMoney(id, amount)); 

					//Transaction Session
					long transaction_id = um.Randomizer();
					string transaction_name = "Para Çekme İşlemi";
					DateTime transaction_time = DateTime.Now;
					Transaction new_transaction = new Transaction(transaction_id, transaction_name, transaction_time);
					tm.addTransaction(new_transaction);
				}
				else
				{
					Console.WriteLine("Yetersiz hesap bakiyesi");
				}
			}
		}
		public void MoneyTransfer()
		{
			Console.WriteLine("*** Para Transferi ***");
			Console.Write("ID'nizi giriniz:");
			long sender_id = long.Parse(Console.ReadLine());
			var sender = um.GetUserByID(sender_id); //gönderen bilgileri veritabanından getirilir
			Console.WriteLine("Hesabına para yatırmak istediğiniz kişinin ID'sini giriniz: ");
			long receiver_id = long.Parse(Console.ReadLine());
			Console.WriteLine("Alıcı adını giriniz:");
			string receiver_name = Console.ReadLine();
			Console.WriteLine("Alıcı soyadını giriniz:");
			string receviver_surname = Console.ReadLine();
			var receiver = um.GetUserByID(receiver_id); //alıcı bilgileri veritabanından getirilir 
			Console.WriteLine("Yatırmak istediğiniz miktarı giriniz:");
			int amount = int.Parse(Console.ReadLine());
			
			if (sender != null && receiver != null) //alıcı ve gönderen veritabanından check edilir
			{
				if (string.IsNullOrEmpty(receiver_name) && string.IsNullOrEmpty(receviver_surname)
					 && amount < 0 && sender.Balance < amount)
				{
					Console.WriteLine("Hata! Para transferi gerçekleştirilmedi");
				}
				else if (sender.Balance < amount)
				{
					Console.WriteLine("Hesap bakiyesi yetersiz");
				}
				else 
				{
					sender.Balance -= amount;
					tm.transferMoney(receiver_id, amount, receiver_name, receviver_surname);
					Console.WriteLine("Para transferi başarıyla gerçekleştirilmiştir.");
					Console.WriteLine("Yeni Bakiyeniz:"+sender.Balance);

					//Transaction Session
					long transaction_id = um.Randomizer();
					string transaction_name = "Para Transfer İşlemi";
					DateTime transaction_time = DateTime.Now;
					Transaction new_transaction = new Transaction(transaction_id, transaction_name, transaction_time);
					tm.addTransaction(new_transaction);
				}
			}
			else
			{
				Console.WriteLine("Gönderen ya yada alıcı bilgileri yanlış girildi");
			}
		}
		public void ListTransactions()
		{
			Console.WriteLine("Tüm İşlemler");

			//create .txt file and process
			if (tm.ListAllTransactions() != null)
			{
				StreamWriter File = new StreamWriter("C://Users//ncirp//Desktop//"+DateTime.Now.ToString("MM/dd/yyyy")+".txt");
				//Metin belgesi oluşturma kısmını generic yapamadım. Oluşturulan dosyalar benim masaüstümde geçerli. 
				//Test edilmesi için url kısmına kendi masaüstü yolunuzu girmeniz gerekmektedir.
				foreach (var item in tm.ListAllTransactions())
				{
					Console.WriteLine("*************");
					Console.WriteLine("İşlem Kodu:" + item.TransactionID);
					Console.WriteLine("İşlem Türü:" + item.TransactionName);
					Console.WriteLine("İşlem Saati:" + item.TransactionTime);

					File.WriteLine("*************");
					File.WriteLine(item.TransactionID);
					File.WriteLine(item.TransactionName);
					File.WriteLine(item.TransactionTime);
				}
				File.Close();
			}
			else 
			{
				Console.WriteLine("Henüz işlem yapılmamıştır.");
			}	
		}

	}
}
