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
                            URL = i.URL,
                            ImageName = i.ImageName,
                            News = i.News,
                            Categori = i.Categori
                        }).ToList();
            }
        }

        //public List<JewelryHelper> GetAllJewelry()
        //{
        //    using (var _context = new SmyckenContext())
        //    {
        //        return (from j in _context.Jewelries
        //                select new JewelryHelper()
        //                {
        //                    AncleJewelries = j.AncleJewelries,
        //                    Bracelets = j.Bracelets,
        //                    Earrings = j.Earrings,
        //                    Necklaces = j.Necklaces
        //                }).Tolist();
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
                            ImgURL = a.Image.URL,
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
