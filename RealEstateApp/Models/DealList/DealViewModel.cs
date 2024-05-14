using RealEstateApp.Domain.Entities;

namespace RealEstateApp.Models.DealList
{
    public class DealViewModel
    {
        public IEnumerable<Deal> Deals { get; set; }
        public int Id { get; set; }
        public int IdRealEstate { get; set; }
        public int IdClient { get; set; }
        public int IdAgent { get; set; }
        public DateTime Date { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual Client Client { get; set; }
        public virtual RealEstate RealEstate { get; set; }
    }
}
