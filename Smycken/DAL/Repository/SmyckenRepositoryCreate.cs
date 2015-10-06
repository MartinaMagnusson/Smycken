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
                var image = new Image()
                {
                    FileName = jewelry.PictureFileName,
                    Url = jewelry.PictureURL,
                    News = false,
                    Description = "",
                    Category = jewelry.Category
                };
                _context.Images.Add(image);
                _context.SaveChanges();
               var newJewelry = _context.Jewelries.Add(new Jewelry()
                {
                    Name = jewelry.Name,
                    Price = jewelry.Price,
                    Quantity = jewelry.Quantity,
                    Description = jewelry.Description,
                    Category = jewelry.Category,
                    Visibility = true,
                    Image = image
                });
                _context.Jewelries.Add(newJewelry);
                _context.SaveChanges();
            }
        }
    }
}
