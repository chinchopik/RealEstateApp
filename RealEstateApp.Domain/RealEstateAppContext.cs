using Microsoft.EntityFrameworkCore;
using RealEstateApp.Domain.Entities;


namespace RealEstateApp.Domain
{
    public class RealEstateAppContext : DbContext
    {
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<User> Users { get; set; }
        public RealEstateAppContext(DbContextOptions options) : base(options)
        {
                
        }
    }

}
