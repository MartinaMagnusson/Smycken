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
        //public List<JewelryHelper> GetAllJewelryCategories()
        //{
        //    using (var _context = new SmyckenContext())
        //    {
        //        return (from j in _context.Jewelries
        //                select new JewelryHelper()
        //                {
        //                    Bracelets = j.Bracelets,
        //                    Earrings = GetAllEarrings(),
        //                    Necklaces = GetAllNecklace(),
        //                }).toList();
        //    }
        //}
        public List<AncleJewelryHelper> GetAllAncleJewelry()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.AncleJewelries
                        select new AncleJewelryHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            ImageFileName = a.Image.FileName,
                            Category = "Ankelsmycke"
                        }).ToList();
            }
        }

        public List<BraceletHelper> GetAllBracelet()
        {
            using (var _context = new SmyckenContext())
            {
                return (from b in _context.Bracelets
                        select new BraceletHelper
                        {
                            ID = b.ID,
                            Description = b.Description,
                            ArticleNr = b.ArticleNr,
                            Name = b.Name,
                            Price = b.Price,
                            ImageFileName = b.Image.FileName,
                            Category = "Armband"
                        }).ToList();
            }
        }

        public List<EarringsHelper> GetAllEarrings()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Earrings
                        select new EarringsHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            ImageFileName = a.Image.FileName,
                            Category = "Örhängen"
                        }).ToList();
            }
        }

        public List<NecklaceHelper> GetAllNecklace()
        {
            using (var _context = new SmyckenContext())
            {
                return (from a in _context.Necklaces
                        select new NecklaceHelper
                        {
                            ID = a.ID,
                            Description = a.Description,
                            ArticleNr = a.ArticleNr,
                            Name = a.Name,
                            Price = a.Price,
                            ImageFileName = a.Image.FileName,
                            Category = "Halsband"
                        }).ToList();
            }
        }

        public List<ContactHelper> GetContactInformation()
        {
            using (var _context = new SmyckenContext())
            {
                return (from c in _context.Contact
                        select new ContactHelper()
                        {
                            Name = c.Name,
                            Email = c.Email,
                            Date = c.Date,
                            Message = c.Message,
                            Title = c.Title
                        }).ToList();
            }
        }
    }
}
