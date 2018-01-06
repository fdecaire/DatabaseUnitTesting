using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository
{
    public partial class DatabaseContext : DbContext, IDatabaseContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server={YOURSQLSERERNAME};Database=DemoData;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.StoreMapping();
			modelBuilder.ProductMapping();
		}

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
    }
}