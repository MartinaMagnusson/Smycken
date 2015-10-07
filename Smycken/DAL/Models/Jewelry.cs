using DAL.HelperClasses;
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
        public double Price { get; set; }
        public string Name { get; set; }    
        public int ArticleNr { get; set; }
        public string Description { get; set; }
        public JewelryCategory Category { get; set; }
        public virtual Image Image { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }  
        public int Quantity { get; set; }   
        public bool Visibility { get; set; }
    }
}
