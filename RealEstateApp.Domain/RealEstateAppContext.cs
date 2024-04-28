using Microsoft.EntityFrameworkCore;
using RealEstateApp.Domain.Entities;


namespace RealEstateApp.Domain
{
    public class RealEstateAppContext : DbContext
    {
        public virtual DbSet<RealEstate> RealEstates { get; set; }
        public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Person> People { get; set; }

		public virtual DbSet<Agent> Agents { get; set; }
		public virtual DbSet<Apartment> Apartments { get; set; }
		public virtual DbSet<Client> Clients { get; set; }
		public virtual DbSet<Deal> Deals { get; set; }
		public virtual DbSet<House> Houses { get; set; }
		public virtual DbSet<Land> Lands { get; set; }
		

		public RealEstateAppContext(DbContextOptions options) : base(options)
        {
                
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{;

			base.OnModelCreating(modelBuilder);	
		}
	}

}
