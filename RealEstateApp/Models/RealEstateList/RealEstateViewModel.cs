using RealEstateApp.Domain.Entities;
namespace RealEstateApp.Models.RealEstateList
{
    public class RealEstateViewModel
    {
        public IEnumerable<RealEstate>? RealEstates { get; set; }
        public IEnumerable<Apartment>? Apartments { get; set; }
        public IEnumerable<Land>? Land { get; set; }
        public IEnumerable<House>? Houses { get; set; }
        public int TotalFloors { get; set; }
        public int TotalArea { get; set; }
        public int NumbersOfRooms { get; set; }
        public int Id {  get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
    }

}
