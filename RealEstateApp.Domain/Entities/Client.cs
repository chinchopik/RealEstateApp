

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Domain.Entities
{
    public class Client
    {
		[Key]
		[ForeignKey("Person")]
		public new int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
		public virtual Person Person { get; set; }

	}

}
