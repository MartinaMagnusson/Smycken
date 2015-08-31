using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HelperClasses
{
    public class BraceletHelper : IEnumerable
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int ArticleNr { get; set; }
        public string Description { get; set; }
        public int ImageID { get; set; }
        public string ImageFileName { get; set; }

        public string Category { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
