using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
	public class UserController
	{
		UserManager userManager = new UserManager();
		
		public void AddUser()
		{
			Console.Write("Write your username: ");
			string username = Console.ReadLine();
			Console.Write("Write your password: ");
			string password = Console.ReadLine();
			int id = userManager.Randomizer();
			new User(id, username, password);

			if (string.IsNullOrEmpty(username))
			{
				Console.Write("Kullanıcı adı boş geçilemez");
			}
			else if (string.IsNullOrEmpty(password))
			{
				Console.Write("Password boş geçilemez");
			}
			else
			{
				User new_user = new User(id,username,password);
				userManager.addUser(new_user);
				Console.WriteLine("Kullanıcı sisteme başarıyla kaydedildi.");
			}
		}
		public void RemoveUser() 
		{
			Console.Write("Silmek istediğiniz kullanıcının ID'sini giriniz: ");
			int id = int.Parse(Console.ReadLine());
			Console.Write("Kullanıcı adını giriniz: ");
			string username = Console.ReadLine();

			var result = userManager.GetUser(id,username);
			if (result != null)
			{		
				userManager.removeUser(userManager.GetUser(id,username));
				Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi.");
				Console.WriteLine(" ");
			}
			else
			{
				Console.WriteLine("Kullanıcı bulunamadı");
				Console.WriteLine(" ");
			}
		}
		public bool LoginUser()
		{

			Console.Write("Username giriniz: ");
			string username = Console.ReadLine();
			Console.Write("Şifre giriniz: ");
			string password = Console.ReadLine();

			var result = userManager.Login(username, password);
			
			if(result != null)
			{
				Console.WriteLine("Sisteme başarıyla giriş yapıldı");
				Console.WriteLine("Hoşgeldiniz: "+username);
				return true;
			}
			else
			{
				return false;
			}

		}
		public void ListUsers()
		{
			Console.WriteLine("Kayıtlı Tüm Kullanıcılar");
			Console.WriteLine(" ");
			foreach (var item in userManager.ListAll())
			{
				Console.WriteLine("User ID: "+item.UserID);	
				Console.WriteLine("Username: "+item.UserName);
				Console.WriteLine("**************");
			}
		}
	}
}
