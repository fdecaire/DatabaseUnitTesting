using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    public static class StoreConfig
    {
	    public static void StoreMapping(this ModelBuilder modelBuilder)
	    {
		    modelBuilder.Entity<Store>(entity =>
		    {
			    entity.ToTable("Store");
			    entity.Property(e => e.Address).HasColumnType("varchar(50)");
			    entity.Property(e => e.Name).HasColumnType("varchar(50)");
			    entity.Property(e => e.State).HasColumnType("varchar(50)");
			    entity.Property(e => e.Zip).HasColumnType("varchar(50)");
			});
	    }
	}
}
