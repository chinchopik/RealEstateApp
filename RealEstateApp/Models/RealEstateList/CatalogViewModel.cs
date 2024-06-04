using RealEstateApp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Models.RealEstateList
{
    public class CatalogViewModel : RealEstateViewModel
    {
        public RealEstate? RealEstate { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно")]
        public Request Request { get; set; }
    }
}
