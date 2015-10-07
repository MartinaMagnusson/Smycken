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

        //public void CreateOrder(OrderHelper order)
        //{
        //    SmyckenRepositoryGet getContext = new SmyckenRepositoryGet();

        //    using (var _context = new SmyckenContext())
        //    {
        //        var getOrder = getContext.GetOneJewelryById(order.JewelryId);

        //        var newOrder = _context.Orders.Add(new Order()
        //        {
        //            FirstName = order.FirstName,
        //            LastName = order.LastName,
        //            Email = order.Email,
        //            Phone = order.Phone,
        //            Address = order.Address,
        //            City = order.City,
        //            Country = order.Country,
        //            PostalCode = order.PostalCode,
        //            OrderDate = order.OrderDate,
        //            Total = order.Total,
        //            ArticleNumber = order.ArticleNr
        //        });
        //        _context.Orders.Add(newOrder);
        //        _context.SaveChanges();
        //        // Empty the shopping cart
        //        //EmptyCart();
        //    }
        //}
    }
}
