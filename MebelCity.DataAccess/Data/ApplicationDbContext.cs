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
    }
}
