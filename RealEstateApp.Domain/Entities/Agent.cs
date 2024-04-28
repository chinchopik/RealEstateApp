
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateApp.Domain.Entities
{
    public class Agent
    {
        [Key]
        [ForeignKey("Person")]
        public new int Id { get; set; }
        public new string FirstName { get; set; }
        public new string LastName { get; set; }
        public new string Patronymic { get; set; }
        public int DealShare { get; set; }
        public virtual Person Person { get; set; }
    }
}
