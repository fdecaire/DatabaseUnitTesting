using System.Collections.Generic;
using System.Linq;
using Repository;
using Repository.Models;

namespace BusinessLogic
{
	public class ProductList
	{
		private readonly IDatabaseContext _databaseContext;

		public ProductList(IDatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
		}

		public List<Product> GetTopTen()
		{
			var result = (from p in _databaseContext.Products select p).Take(10).ToList();

			return result;
		}
	}
}
