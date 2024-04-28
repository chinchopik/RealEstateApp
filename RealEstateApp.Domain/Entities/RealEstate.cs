using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Domain.Entities
{
    public class RealEstate
    {
        public int Id { get; set; }
        public string Address { get; set; } 
        public decimal Price { get; set; }
    }
}
