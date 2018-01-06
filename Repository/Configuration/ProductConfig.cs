using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
	public static class ProductConfig
	{
		public static void ProductMapping(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>(entity =>
			{
				entity.ToTable("Product");
				entity.Property(e => e.Name).HasColumnType("varchar(50)");

				entity.Property(e => e.Price).HasColumnType("money");

				entity.HasOne(d => d.StoreNavigation)
					.WithMany(p => p.Product)
					.HasForeignKey(d => d.Store)
					.OnDelete(DeleteBehavior.Restrict)
					.HasConstraintName("FK_store_product");
			});
		}
	}
}
