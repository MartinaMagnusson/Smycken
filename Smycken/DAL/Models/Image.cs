using DAL.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Image
    {
        public Image()
        {
            this.Jewelry = new HashSet<Jewelry>();
        }
        public int ID { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public bool News { get; set; }
        public JewelryCategory Category { get; set; }

        public virtual ICollection<Jewelry> Jewelry { get; set; }
    }
}   
        