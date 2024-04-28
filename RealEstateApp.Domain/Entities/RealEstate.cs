

namespace RealEstateApp.Domain.Entities
{
    public class RealEstate
    {
        public int Id { get; set; }
        public string Address { get; set; } 
        public decimal Price { get; set; }

        public ICollection<Apartment> Apartments { get; set; }
        public ICollection<House> Houses { get; set; }
        public ICollection<Land> Lands { get; set; }
        public ICollection<Deal> Deals { get; set; }


	}
}
