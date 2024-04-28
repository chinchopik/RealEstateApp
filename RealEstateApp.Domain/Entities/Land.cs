using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Domain.Entities
{
	public class Land
	{
		[Key]
		[ForeignKey("RealEstate")]
		public new int Id { get; set; }
		public double TotalArea { get; set; }
		public virtual RealEstate RealEstate { get; set; }

	}
}
