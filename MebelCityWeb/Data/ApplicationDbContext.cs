using MebelCityWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MebelCityWeb.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<PriceList> PriceLists { get; set; }
    }
}
