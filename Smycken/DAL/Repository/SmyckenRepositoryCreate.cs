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
        public void AddAncleJewelry(AncleJewelryHelper ancleJewelry, Image image)
        {
            using (var _context = new SmyckenContext())
            {
                _context.AncleJewelries.Add(new AncleJewelry()
                {
                    ArticleNr = ancleJewelry.ArticleNr,
                    Description = ancleJewelry.Description,
                    Name = ancleJewelry.Name,
                    Price = ancleJewelry.Price,
                    Image = _context.Images.Add(new Image()
                    {
                        Categori = image.Categori,
                        Description = image.Description,
                        FileName = image.FileName,
                        News = image.News,
                    })

                });
                _context.SaveChanges();
            }
        }

        public void AddAnkleJewelry(AddJewelry jewelry)
        //public void AddAnkleJewelry(AddJewelry jewelry, ImageHelper image)
        {
            using (var _context = new SmyckenContext())
            {
                _context.Jewelries.Add(new Jewelry()
                {
                    AncleJewelries = new List<AncleJewelry>()
                    {
                        new AncleJewelry()
                    {
                        Name = jewelry.Name,
                        Price = jewelry.Price,
                        ArticleNr = jewelry.ArticleNr,
                        Description = jewelry.Description,
                        //Image = new Image()
                        //{
                        //    Categori = image.Categori,
                        //    Description = image.Description,
                        //    FileName = image.FileName
                        //}
                    }
                }
                });
                _context.SaveChanges();
            }
        }

        public void AddEarrings(AddJewelry jewelry)
        //public void AddAnkleErrings(AddJewelry jewelry, ImageHelper image)
        {
            using (var _context = new SmyckenContext())
            {
                _context.Jewelries.Add(new Jewelry()
                {
                    Earrings = new List<Earrings>()
                    {
                        new Earrings()
                    {
                        Name = jewelry.Name,
                        Price = jewelry.Price,
                        ArticleNr = jewelry.ArticleNr,
                        Description = jewelry.Description,
                        //Image = new Image()
                        //{
                        //    Categori = image.Categori,
                        //    Description = image.Description,
                        //    FileName = image.FileName
                        //}
                    }
                }
                });
                _context.SaveChanges();
            }
        }

        public void AddNecklace(AddJewelry jewelry)
        //public void AddAnkleNecklace(AddJewelry jewelry, ImageHelper image)
        {
            using (var _context = new SmyckenContext())
            {
                _context.Jewelries.Add(new Jewelry()
                {
                    Necklaces = new List<Necklace>()
                    {
                        new Necklace()
                    {
                        Name = jewelry.Name,
                        Price = jewelry.Price,
                        ArticleNr = jewelry.ArticleNr,
                        Description = jewelry.Description,
                        //Image = new Image()
                        //{
                        //    Categori = image.Categori,
                        //    Description = image.Description,
                        //    FileName = image.FileName
                        //}
                    }
                }
                });
                _context.SaveChanges();
            }
        }

        public void AddBracelet(AddJewelry jewelry)
        //public void AddAnkleBracelet(AddJewelry jewelry, ImageHelper image)
        {
            using (var _context = new SmyckenContext())
            {
                _context.Jewelries.Add(new Jewelry()
                {
                    Bracelets = new List<Bracelet>()
                    {
                        new Bracelet()
                    {
                        Name = jewelry.Name,
                        Price = jewelry.Price,
                        ArticleNr = jewelry.ArticleNr,
                        Description = jewelry.Description,
                        //Image = new Image()
                        //{
                        //    Categori = image.Categori,
                        //    Description = image.Description,
                        //    FileName = image.FileName
                        //}
                    }
                }
                });
                _context.SaveChanges();
            }
        }
    }
}
