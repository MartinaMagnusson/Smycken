using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Image
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public bool News { get; set; }
        public string Categori { get; set; }
    }
}   
    