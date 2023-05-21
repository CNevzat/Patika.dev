using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_App.BusinessLayer.Abstract;

namespace Voting_App.BusinessLayer.Concrete
{
	public class CategoryManager : ICategory
	{
		Database db = new Database();

		public Category getCategory(int id)
		{
			return db.categories.Find(x => x.CategoryID == id);
		}

		public List<Category> ListCategory()
		{
			return db.categories;
		}

		public void VoteCategory()
		{	
			
		}
	}
}
