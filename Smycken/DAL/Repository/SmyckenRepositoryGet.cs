using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.HelperClasses;
using DAL.Models;

namespace DAL.Repository
{
    public class SmyckenRepositoryGet
    {
        public SmyckenRepositoryGet()
        {

        }

        public List<ImageHelper> GetAllNewsImage()
        {
            using (var _context = new SmyckenContext())
            {
                return (from i in _context.Images
                        where (i.News == true)
                        select new ImageHelper()
                        {
                            FileName = i.FileName,
                            Description = i.Description,
                            News = i.News,
                            Category = i.Category
                        }).ToList();
            }
        }
        public List<JewelryHelper> GetAllJewelryCategories()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        orderby a.ID descending
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            PictureFileName = a.Image.FileName,
                            Category = a.Category,
                            Quantity = a.Quantity,
                        }).ToList();
            }
        }

        public EditJewelry GetJewelryById(int jewelryID)
        {
            using (var _context = new SmyckenContext())
            {
                _context.Jewelries.AsNoTracking();
                return (from a in _context.Jewelries
                        where a.ID == jewelryID && a.Visibility == true
                        select new EditJewelry
                        {
                            ID = a.ID,
                            Description = a.Description,
                            Name = a.Name,
                            Price = a.Price,
                            Quantity = a.Quantity,
                            //ImageFileName = a.Image.FileName,
                            Category = a.Category
                        }).FirstOrDefault();
            }
        }

        public JewelryHelper GetOneJewelryById(int jewelryID)
        {
            using (var _context = new SmyckenContext())
            {
                _context.Jewelries.AsNoTracking();
                return (from a in _context.Jewelries
                        where a.ID == jewelryID && a.Visibility == true
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            Name = a.Name,
                            Price = a.Price,
                            Quantity = a.Quantity,
                            //ImageFileName = a.Image.FileName,
                            Category = a.Category
                        }).FirstOrDefault();
            }
        }

        public List<JewelryHelper> GetAllJewelry()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        orderby a.ID descending
                        where a.Visibility == true     
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            PictureFileName = a.Image.FileName,
                            Category = a.Category,
                            Quantity = a.Quantity
                        }).ToList();
            }
        }
        public List<JewelryHelper> GetAllAncleJewelry()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        orderby a.ID descending
                        where a.Category == JewelryCategory.AncleJewelry && a.Visibility == true
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            PictureFileName = a.Image.FileName,
                            Category = a.Category,
                            Quantity = a.Quantity
                        }).ToList();
            }
        }

        public List<JewelryHelper> GetAllBracelet()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        orderby a.ID descending
                        where a.Category == JewelryCategory.Bracelet && a.Visibility == true
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            PictureFileName = a.Image.FileName,
                            Category = a.Category,
                            Quantity =a.Quantity
                        }).ToList();
            }
        }

        public List<JewelryHelper> GetAllEarrings()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        orderby a.ID descending
                        where a.Category == JewelryCategory.Earrings && a.Visibility == true
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            PictureFileName = a.Image.FileName,
                            Category = a.Category,
                            Quantity = a.Quantity
                        }).ToList();
            }
        }

        public List<JewelryHelper> GetAllNecklace()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        orderby a.ID descending 
                        where a.Category == JewelryCategory.Necklace && a.Visibility == true
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            PictureFileName = a.Image.FileName,
                            Category = a.Category,
                            Quantity = a.Quantity
                        }).ToList();
            }
        }


        //public OrderHelper GetOrder(int OrderId)
        //{
        //    using (var _context = new SmyckenContext())
        //    {
        //        //_context.Order.AsNoTracking();
        //        return (from o in _context.Orders
        //                where o.ID == OrderId
        //                select new OrderHelper
        //                {
        //                    ID = o.ID,
        //                    FirstName = o.FirstName,
        //                    LastName = o.LastName,
        //                    Address = o.Address,
        //                    Name = o.ProductName,
        //                    Quantity = o.Quantity,
        //                    ArticleNr = o.ArticleNumber,
        //                    City = o.City,
        //                    Country = o.Country,
        //                    Email = o.Email,
        //                    Phone = o.Phone,
        //                    OrderDate = o.OrderDate,
        //                    UnitPrice = o.UnitPrice,
        //                    PostalCode = o.PostalCode,
        //                    Total = o.Total
        //                }).FirstOrDefault();
        //    }
        //}

        //public List<ContactHelper> GetContactInformation()
        //{
        //    using (var _context = new SmyckenContext())
        //    {
        //        return (from c in _context.Contact
        //                select new ContactHelper()
        //                {
        //                    Name = c.Name,
        //                    Email = c.Email,
        //                    Date = c.Date,
        //                    Message = c.Message,
        //                    Title = c.Title
        //                }).ToList();
        //    }
        //}
    }
}
