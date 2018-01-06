using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository
{
	public interface IDatabaseContext
	{
		DbSet<Product> Products { get; set; }
		DbSet<Store> Stores { get; set; }
	}
}
