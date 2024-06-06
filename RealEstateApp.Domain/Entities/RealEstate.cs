

namespace RealEstateApp.Domain.Entities
{
    public class RealEstate
    {
        public int Id { get; set; }
        public string Address { get; set; } 
        public decimal Price { get; set; }
        public int TotalFloors { get; set; }
        public double TotalArea { get; set; }
        public int NumberOfRooms { get; set; } 
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string? Photo { get; set; }
	}
}
