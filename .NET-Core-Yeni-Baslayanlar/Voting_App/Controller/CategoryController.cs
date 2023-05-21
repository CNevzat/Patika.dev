using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_App.BusinessLayer.Concrete;

namespace Voting_App.Controller
{
	public class CategoryController
	{
		CategoryManager cm = new CategoryManager();

		int count = 0;
		public void ListAllCategories()
		{
			Console.WriteLine("Tüm Categoriler");
			Console.WriteLine(" ");

			foreach (var item in cm.ListCategory())
			{
				Console.WriteLine("Category ID: " + item.CategoryID);
				Console.WriteLine("Kategori Adı: " + item.CategoryName);
				Console.WriteLine("Değerlendirme Sayısı: " + item.CategoryVote);	
				Console.WriteLine("Kategori Puanı: " + item.CategoryStar);					
				Console.WriteLine("Category Ratio: " + item.VotingRatio);			
				Console.WriteLine("**************");
			}
		}

		public void VoteCategory()
		{
			ListAllCategories();
			Console.Write("Değerlendirme yapmak istediğiniz kategorinin ID'sini giriniz: ");
			int id = int.Parse(Console.ReadLine());
			var result = cm.getCategory(id);

			if (result != null)
			{
				Console.Write("1-10 arası puan veriniz: ");
				int star = int.Parse(Console.ReadLine());

				if (star < 11 && star > 0)
				{
					result.CategoryVote += 1;
					result.CategoryStar += star;
					result.CategoryStar = result.CategoryStar / result.CategoryVote;
				}
				else 
				{
					Console.WriteLine("Lütfen belirtilen aralıkta puan giriniz");
				}
			}
			else 
			{
				Console.WriteLine("Hatalı seçim yaptınız");
			}
		}
		public void AllVoteRatio()
		{
			int sum = 0;
			Console.WriteLine("***** Tüm Kategorilerin Yüzdelik Gösterimi  *****");
			foreach (var item in cm.ListCategory())
			{
				sum += item.CategoryStar;
			}
			//Bu işlem üstteki foreach içinde yapılırsa birinci kategori her zaman %100 olur
			// Bu nedenle sum toplandıktan sonra her bir kategorinin ayrı ayrı hesaplanması gerekir
			foreach (var result in cm.ListCategory())
			{
				double star = result.CategoryStar;
				double avg = (star / sum) * 100;
				Console.WriteLine("Beğenilme Oranı: %"+avg);
			}
		}

	}
}
