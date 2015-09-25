using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repository
{
    public class SmyckenInitializer : DropCreateDatabaseIfModelChanges<SmyckenContext>
    {
        private List<Contact> _contact;
        private List<About> _about;
        private List<Jewelry> _jewelries;
        private List<Product> _products;
        private List<Cart> _carts;
        private List<Image> _images;
        public SmyckenInitializer()
        {
            _contact = new List<Contact>();
            _about = new List<About>();
            _carts = new List<Cart>();
            _jewelries = new List<Jewelry>();
            _products = new List<Product>();
            _images = new List<Image>()
            {
                new Image()
                {
                    FileName = "lovepeace1.jpg",
                    Description = "Ankelsmycken",
                    News = true,
                    Categori = "AncleJewelry"
                },
                new Image()
                {
                    FileName = "lovepeace1.jpg",
                    Description = "Armband",
                    News = true,
                    Categori = "Bracelet"
                },
                new Image()
                {
                    FileName = "lovepeace1.jpg",
                    Description = "Halsband",
                    News = true,
                    Categori = "Necklace"
                },
                new Image()
                {
                    FileName = "lovepeace1.jpg",
                    Description = "Örhängen",
                    News = true,
                    Categori ="Earrings"
                },
                new Image()
                {
                    FileName = "lovepeace1.jpg",
                    Description = "Nyheter",
                    News = true
                },
                new Image()
                {
                   FileName = "lovepeace1.jpg",
                    Description = "Nyheter",
                    News = true
                },
                new Image()
                {
                    FileName = "lovepeace1.jpg",
                    Description = "Nyheter",
                    News = true
                },
                new Image()
                {
                    FileName = "lovepeace1.jpg",
                    Description = "Nyheter",
                    News = true
                }
            };
        }

        public override void InitializeDatabase(SmyckenContext context)
        {
            _contact.ForEach(x => context.Contact.Add(x));
            _about.ForEach(x => context.About.Add(x));
            _carts.ForEach(x => context.Carts.Add(x));
            _jewelries.ForEach(x => context.Jewelries.Add(x));
            _products.ForEach(x => context.Products.Add(x));
            _images.ForEach(x => context.Images.Add(x));
            base.InitializeDatabase(context);
        }
    }
}
