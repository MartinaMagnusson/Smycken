using System.Collections.Generic;

namespace DAL.Models
{
    public class Product
    {
        public int ID { get; set; }
        public List<Jewelry> jewelry { get; set; }
    }
}   