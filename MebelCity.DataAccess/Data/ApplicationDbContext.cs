using MebelCity.Models;
using Microsoft.EntityFrameworkCore;

namespace MebelCity.DataAccess.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<PriceList> PriceLists { get; set; }
		public DbSet<Column> Columns { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductColumnValue> ProductColumnValues { get; set; }

		/*protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder
			.Entity<Column>()
			.Property(e => e.TypeOfContent)
			.HasConversion<string>();
		}*/
	}
}