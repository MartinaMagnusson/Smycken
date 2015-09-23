using DAL.HelperClasses;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SmyckenRepositoryCreate
    {
        public void AddJewelry(AddJewelry jewelry)
        //public void AddJewelry(AddJewelry jewelry, ImageHelper image)
        {
            using (var _context = new SmyckenContext())
            {
                _context.Jewelries.Add(new Jewelry()
                {                 
                        Name = jewelry.Name,
                        Price = jewelry.Price,
                        ArticleNr = jewelry.ArticleNr,
                        Quantity = jewelry.Quantity,
                        Description = jewelry.Description,
                        Category = jewelry.Category,
                        //Image = new Image()
                        //{
                        //    Categori = image.Categori,
                        //    Description = image.Description,
                        //    FileName = image.FileName
                        //}
                });
                _context.SaveChanges();
            }
        }
    }
}
