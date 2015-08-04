using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.HelperClasses;
using DAL.Models;

namespace DAL.Repository
{
    public class SmyckenRepository
    {
        public SmyckenRepository()
        {
            
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
