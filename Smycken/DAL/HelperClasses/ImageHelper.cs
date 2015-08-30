using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HelperClasses
{
    public class ImageHelper : IEnumerable
    {
        public int ID { get; set; }
        public string ImageName { get; set; }
        public string URL { get; set; }
        public bool News { get; set; }
        public string Categori { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }   
    }
}
