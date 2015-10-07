using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public List<Product> Products { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
    