using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App.BusinessLayer.Abstract
{
	public interface ICategory
	{
		List<Category> ListCategory();

		void VoteCategory();//AddCategory eklenebilir

		Category getCategory(int id);
	}
}
