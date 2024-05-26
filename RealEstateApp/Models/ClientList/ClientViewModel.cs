using RealEstateApp.Domain.Entities;
namespace RealEstateApp.Models.ClientList
{
    public class ClientViewModel
    {
        public IEnumerable<Client>? Clients { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
