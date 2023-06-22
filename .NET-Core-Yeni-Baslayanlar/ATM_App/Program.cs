using ATM_App.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
	public class Program
	{
		public static void Menu()
		{
			UserContoller userContoller = new UserContoller();
			TransactionController transactionController = new TransactionController();
			FraudController fraudController = new FraudController();

			if (userContoller.Login()) //login true dönüyorsa
			{
				Menu:
				Console.WriteLine("1- Para Çekme \n2- Para Yatırma \n3- Para Transferi \n4- Gun Sonu");
				int choice = int.Parse(Console.ReadLine());

				if (choice == 1)
				{
					transactionController.drawMoney();
					goto Menu;
				}
				else if (choice == 2)
				{
					transactionController.depositMoney();
					goto Menu;
				}
				else if (choice == 3) 
				{
					transactionController.MoneyTransfer();
					goto Menu;
				}
				else if(choice == 4) 
				{
					transactionController.ListTransactions();
					goto Menu;
				}
			}
		}

		static void Main(string[] args)
		{	
			//userContoller.ListUsers(); ++
			//userContoller.AddUser(); ++
			//transactionController.depositMoney(); ++
			//transactionController.drawMoney(); ++
			//transactionController.MoneyTransfer();//++
			//transactionController.ListTransactions(); //++ (Gün sonu alma dahil)

			Menu();
			Console.ReadKey();
		}
	}
}
