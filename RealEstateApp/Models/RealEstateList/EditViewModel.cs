using RealEstateApp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Models.RealEstateList
{
    public class EditViewModel : RealEstateViewModel
    {
        public RealEstate RealEstate { get; set; }

		public int TotalFloors { get; set; }
		public int TotalArea { get; set; }
		public int NumberOfRooms { get; set; }
		public int Id { get; set; }
		public string? Address { get; set; }
		public decimal Price { get; set; }
	}
}
