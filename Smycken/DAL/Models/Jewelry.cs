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
        public virtual List<Necklace> Necklaces { get; set; }
        public virtual List<Bracelet> Bracelets { get; set; }
        public virtual List<AncleJewelry> AncleJewelries { get; set; }
        public virtual List<Earrings> Earrings { get; set; }
    }
}
