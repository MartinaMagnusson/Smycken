using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repository
{
   public class SmyckenContext : DbContext
    {
        public DbSet<About> About { get; set; } 
        public DbSet<Contact> Contact { get; set; } 
        public DbSet<Jewelry> Jewelries { get; set; } 
        public DbSet<AncleJewelry> AncleJewelries { get; set; } 
        public DbSet<Bracelet> Bracelets { get; set; } 
        public DbSet<Necklace> Necklaces { get; set; } 
        public DbSet<Earrings> Earrings { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<Cart> Carts { get; set; } 
    }
}
