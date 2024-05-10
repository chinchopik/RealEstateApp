using RealEstateApp.Domain.Entities;
namespace RealEstateApp.Models.RealEstateList
{
    public class RealEstateViewModel
    {
        public IEnumerable<RealEstate>? RealEstates { get; set; }
        public int Id {  get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
    }

}
