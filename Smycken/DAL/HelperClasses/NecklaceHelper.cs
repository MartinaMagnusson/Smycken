using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HelperClasses
{
    public class NecklaceHelper : IEnumerable
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int ArticleNr { get; set; }
        public string Description { get; set; }
        public ImageHelper Images { get; set; }

        public virtual JewelryHelper Jewelry { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
