

namespace RealEstateApp.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
	}
}
