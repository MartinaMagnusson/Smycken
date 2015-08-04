using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Jewelry
    {
        public int ID { get; set; }
        public List<Necklace> Necklaces { get; set; }
        public List<Bracelet> Bracelets { get; set; }
        public List<AncleJewelry> AncleJewelries { get; set; }
        public List<Earrings> Earrings { get; set; }
    }
}
