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
    }
}
