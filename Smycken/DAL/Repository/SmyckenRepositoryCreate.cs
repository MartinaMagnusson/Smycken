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
        public void AddAncleJewelry(AncleJewelryHelper ancleJewelry)
        {
            using (var _context = new SmyckenContext())
            {
                _context.AncleJewelries.Add(new AncleJewelry
                {
                    ArticleNr = ancleJewelry.ArticleNr,
                    Description = ancleJewelry.Description,
                    Name = ancleJewelry.Name,
                    Price = ancleJewelry.Price,
                    Images_ID = ancleJewelry.ImgID,
                });
                _context.SaveChanges();
            }
        }
    }
}
