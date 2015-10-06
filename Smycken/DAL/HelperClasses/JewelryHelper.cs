using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HelperClasses
{
    public class JewelryHelper : IEnumerable
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int ArticleNr { get; set; }
        public string Description { get; set; }
        public int ImageID { get; set; }
         public string PictureURL { get; set; }
        public string PictureFileName { get; set; }
        public JewelryCategory Category { get; set; }
        public int Quantity { get; set; }
        public bool Visibility { get; set; }
        public JewelryHelper()
        {
            ArticleNr = ID;
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
