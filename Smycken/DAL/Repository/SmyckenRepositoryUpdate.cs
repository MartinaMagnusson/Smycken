using DAL.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SmyckenRepositoryUpdate
    {
        public void UpdateJewelry(EditJewelry jewelry)
        {
            using (var _context = new SmyckenContext())
            {
                var updateJewelry =
                    (from j in _context.Jewelries
                     where j.ID == jewelry.ID && j.Visibility == true
                     select j).FirstOrDefault();
                if (updateJewelry != null)
                {
                    updateJewelry.ID = jewelry.ID;
                    updateJewelry.Name = jewelry.Name;
                    updateJewelry.Price = jewelry.Price;
                    updateJewelry.Quantity = jewelry.Quantity;
                    updateJewelry.Category = jewelry.Category;
                    updateJewelry.Description = jewelry.Description;
                }

                _context.SaveChanges();
            }
        }

        public void RemoveJewelry(int jewelry)
        {
            using (var _context = new SmyckenContext())
            {
                var updateJewelry =
                    (from j in _context.Jewelries
                     where j.ID == jewelry
                     select j).FirstOrDefault();
                if (updateJewelry != null)
                {
                    updateJewelry.Visibility = false;
                }
                _context.SaveChanges();
            }
        }
    }
}
