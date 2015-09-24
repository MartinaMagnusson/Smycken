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
                            Categori = i.Categori
                        }).ToList();
            }
        }
        public List<JewelryHelper> GetAllJewelryCategories()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            ImageFileName = a.Image.FileName,
                            Category = a.Category
                        }).ToList();
            }
        }
        public List<JewelryHelper> GetAllAncleJewelry()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        where a.Category == JewelryCategory.AncleJewelry
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            ImageFileName = a.Image.FileName,
                            Category = a.Category
                        }).ToList();
            }
        }

        public List<JewelryHelper> GetAllBracelet()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        where a.Category == JewelryCategory.Bracelet
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            ImageFileName = a.Image.FileName,
                            Category = a.Category
                        }).ToList();
            }
        }

        public List<JewelryHelper> GetAllEarrings()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        where a.Category == JewelryCategory.Earrings
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            ImageFileName = a.Image.FileName,
                            Category = a.Category
                        }).ToList();
            }
        }

        public List<JewelryHelper> GetAllNecklace()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Jewelries
                        where a.Category == JewelryCategory.Necklace
                        select new JewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            ImageFileName = a.Image.FileName,
                            Category = a.Category
                        }).ToList();
            }
        }

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
