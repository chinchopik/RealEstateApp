using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Domain.Entities
{
    public class Deal
    {
		[Key]
        public int Id { get; set; }
		[ForeignKey("RealEstate")]
		public int IdRealEstate { get; set; }
		[ForeignKey("Client")]
		public int IdClient { get; set; }

		[ForeignKey("Agent")]
		public int IdAgent { get; set; }
        public DateTime Date { get; set; }
		public virtual Agent Agent { get; set; }
		public virtual Client Client { get; set; }
		public virtual RealEstate RealEstate { get; set; }


	}
}
