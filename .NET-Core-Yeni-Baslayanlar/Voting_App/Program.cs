using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Voting_App.Controller;

namespace Voting_App
{
	public class Program
	{
		//Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak
		//üzere listelenmelidir.Yalnızca sisemde kayırlı olan kullanıcılar oy verebilir.
		//Oylama sırasında öncelikle kullanıcının username'i istenmelidir. Eğer sistemde
		//kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir.
		//Kategoriler isteğe bağlı olarak belirlenebilir.
		//Bazı Örnek Kategoriler: Film Kategorileri Tech Stack Kategorileri Spor Kategorileri
		//Son olarak uygulama sonlandırılırken, Voting sonuçları hem rakamsal hem de yüzdesel olarak gösterilmelidir.
		//Kullanılması gereken teknikler:
		//Kategoriler pre-defined kullanılabilir.
		public static void Menu()
		{
			UserController userController = new UserController();
			CategoryController categoryController = new CategoryController();
			

			Console.Write("Kayıtlı kullanıcıysanız 0 değilseniz 1 tuşlayınız: ");
			int login_choice = int.Parse(Console.ReadLine());

			if (login_choice == 0)
			{				
					int exit = 0;
					if (userController.LoginUser()) // LoginUser true dönüyorsa
					{
						while (exit != 9)
						{
							categoryController.VoteCategory();
							Console.WriteLine("Çıkış yapmak için 9\nOylamaya devam etmek istiyorsanız" +
											  " 0 tuşlayınız: ");
							exit = int.Parse(Console.ReadLine());
						}
						Console.WriteLine("Çıkış yapıldı");
					categoryController.AllVoteRatio();
					}
					else
					{
						Console.WriteLine("Hatalı giriş yaptınız");
					}				
			}
			else if (login_choice == 1)
			{
				userController.AddUser();
				int exit = 0;
				if (userController.LoginUser()) // LoginUser true dönüyorsa
				{
					while (exit != 9)
					{
						categoryController.VoteCategory();
						Console.WriteLine("Çıkış yapmak için 9\nOylamaya devam etmek istiyorsanız" +
										  " 0 tuşlayınız: ");
						exit = int.Parse(Console.ReadLine());
					}
					Console.WriteLine("Çıkış yapıldı");
				}
				else
				{
					Console.WriteLine("Hatalı giriş yaptınız");
				}
			}
		}

		static void Main(string[] args)
		{
			Menu();
			Console.ReadKey();
		}
	}
}
