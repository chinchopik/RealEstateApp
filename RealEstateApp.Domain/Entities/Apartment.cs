

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateApp.Domain.Entities
{
    public class Apartment
    {
        [Key]
        [ForeignKey("RealEstate")]
        public new int Id { get; set; }
        public int TotalFloors { get; set; }
        public double TotalArea { get; set; }
        public int NumberOfRooms { get; set; }
		public virtual RealEstate RealEstate { get; set; }

	}
}
