using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Domain.Entities
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public DateTime RequestDate { get; set; }
        public bool Status { get; set; }
        [ForeignKey("RealEstate")]
        public int IdRealEstate { get; set; }

        public bool IsValid() => Name is not null && Phone is not null && Email is not null;
    }
}
