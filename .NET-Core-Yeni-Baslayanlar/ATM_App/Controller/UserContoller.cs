using ATM_App.BusinessLayer;
using ATM_App.BusinessLayer.Concrete;
using ATM_App.EntityLayer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App.Controller
{
	public class UserContoller
	{
		UserManager um = new UserManager();	
		FraudManager fm = new FraudManager();	
		public void AddUser()
		{
			Console.WriteLine("*** Yeni Kullanıcı ***");
			Console.Write("Adınızı giriniz:");
			string username = Console.ReadLine();
			Console.Write("Soyadınızı giriniz:");
			string usersurname = Console.ReadLine();
			Console.Write("Şifre Belirleyiniz:");
			string password = Console.ReadLine();
			long ID = um.Randomizer();

			if (string.IsNullOrEmpty(username))
			{
				Console.Write("Kullanıcı adı boş geçilemez");
			}
			else if (string.IsNullOrEmpty(usersurname))
			{
				Console.Write("Kullanıcı soyadı boş geçilemez");
			}
			else if (string.IsNullOrEmpty(password))
			{
				Console.Write("Şifre boş geçilemez");
			}
			else 
			{
				User new_user = new User(ID, username, usersurname, password,0);
				um.addUser(new_user);
				Console.WriteLine("ID'niz:"+new_user.UserID);
				Console.WriteLine("Kullanıcı kayıt işlemi başarıyla tamamlandı");
			}
		}
		public bool Login()
		{
			Console.WriteLine("ATM Uygulamasına Hoşgeldiniz\n" +
				"Lütfen ID'nizi Giriniz:");
			long id = long.Parse(Console.ReadLine());
			Console.Write("Şifrenizi giriniz:");
			string password = Console.ReadLine();

			var result = um.Login(id, password);

			if (result != null)
			{
				Console.WriteLine("Sisteme başarıyla giriş yapıldı");
				Console.WriteLine("Hoşgeldiniz:"+result.Username+" "+result.Usersurname);
				return true;

			}
			else
			{
				long fraud_id = um.Randomizer();
				DateTime fraud_time = DateTime.Now;
				Fraud new_fraud = new Fraud(fraud_id, fraud_time);
				fm.AddFraud(new_fraud);

				Console.WriteLine("Hatalı giriş yapıldı");
				return false;
	
			}
			
		}
		public void ListUsers()
		{
			Console.WriteLine("Kayıtlı Kullanıcılar");

			foreach (var item in um.ListAll())
			{
				Console.WriteLine("Kullanıcı ID:"+item.UserID);
				Console.WriteLine("Kullanıcı Adı Soyadı:"+item.Username+" "+item.Usersurname);
				Console.WriteLine("Kullanıcı Bakiyesi:"+item.Balance);
				Console.WriteLine("**********************");
			}
		}

	}
}
