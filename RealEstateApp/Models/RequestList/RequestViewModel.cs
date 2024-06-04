using RealEstateApp.Domain.Entities;

namespace RealEstateApp.Models.RequestList
{
    public class RequestViewModel
    {
        public IEnumerable<Request> Requests { get; set; }
        public Request Request { get; set; }
    }
}
