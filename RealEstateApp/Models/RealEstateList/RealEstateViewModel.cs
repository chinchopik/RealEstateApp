using RealEstateApp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
namespace RealEstateApp.Models.RealEstateList
{
    public abstract class RealEstateViewModel
    {
        public IEnumerable<RealEstate>? RealEstates { get; set; }
        static RealEstateViewModel()
        {
            
        }

        /*
        public int TotalFloors { get; set; }
        public int TotalArea { get; set; }
        public int NumbersOfRooms { get; set; }
        public int Id {  get; set; }
        [Required(ErrorMessage = "Данное поле обязательно")]
        public string Address { get; set; }
        public decimal Price { get; set; }*/
    }

}
