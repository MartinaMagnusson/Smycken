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
    public class SmyckenInitializer : DropCreateDatabaseAlways<SmyckenContext>
    {
        private List<Contact> _contact;
        private List<About> _about;
        private List<Jewelry> _jewelries;
        private List<Earrings> _earrings;
        private List<Necklace> _necklaces;
        private List<Product> _products;
        private List<AncleJewelry> _ancleJewelries;
        private List<Cart> _carts;
        private List<Bracelet> _bracelets;
        private List<Image> _images;
        public SmyckenInitializer()
        {
            _contact = new List<Contact>();
            _about = new List<About>();
            _bracelets = new List<Bracelet>();
            _ancleJewelries = new List<AncleJewelry>() {
             new AncleJewelry()
                        {
                            Name = "Ankelsmycke",
                            Price = 59,
                            ArticleNr = 0001,
                            Description = "Ett ankelsmycke", 
                            Images_ID = 1,
                        }};
            _necklaces = new List<Necklace>();
            _carts = new List<Cart>();
            _earrings = new List<Earrings>();
            _jewelries = new List<Jewelry>() {
                new Jewelry() {
                    Bracelets = new List<Bracelet>()
                    {
                        new Bracelet()
                        {
                            Name = "Armband",
                            Price = 49,
                            ArticleNr = 0002,
                            Description = "Ett armband",
                        }
                    },
                    Earrings = new List<Earrings>()
                    {
                        new Earrings()
                        {
                            Name = "Örhänge",
                            Price = 69,
                            ArticleNr = 0003,
                            Description = "Fina örhänge",
                        }
                    },
                    Necklaces = new List<Necklace>()
                    {
                        new Necklace()
                        {
                            Name = "Halsband",
                            Price = 79,
                            ArticleNr = 0004,
                            Description = "Finat halsband",
                        }
                    }
                }
            };
            _products = new List<Product>();
            _images = new List<Image>()
            {
                new Image()
                {
                    URL = "lovepeace1.jpg",
                    ImageName = "Ankelsmycken",
                    News = true,
                    Categori = "AncleJewelry"
                },
                new Image()
                {
                    URL = "lovepeace1.jpg",
                    ImageName = "Armband",
                    News = true
                },
                new Image()
                {
                    URL = "lovepeace1.jpg",
                    ImageName = "Halsband",
                    News = true
                },
                new Image()
                {
                    URL = "lovepeace1.jpg",
                    ImageName = "Örhängen",
                    News = true
                },
                           new Image()
                {
                    URL = "lovepeace1.jpg",
                    ImageName = "Nyheter",
                    News = true
                },
                new Image()
                {
                    URL = "lovepeace1.jpg",
                    ImageName = "Text",
                    News = true
                },
                new Image()
                {
                    URL = "lovepeace1.jpg",
                    ImageName = "Text",
                    News = true
                },
                new Image()
                {
                    URL = "lovepeace1.jpg",
                    ImageName = "Text",
                    News = true
                }
            };
        }

        public override void InitializeDatabase(SmyckenContext context)
        {
            _contact.ForEach(x => context.Contact.Add(x));
            _about.ForEach(x => context.About.Add(x));
            _bracelets.ForEach(x => context.Bracelets.Add(x));
            _ancleJewelries.ForEach(x => context.AncleJewelries.Add(x));
            _carts.ForEach(x => context.Carts.Add(x));
            _earrings.ForEach(x => context.Earrings.Add(x));
            _jewelries.ForEach(x => context.Jewelries.Add(x));
            _necklaces.ForEach(x => context.Necklaces.Add(x));
            _products.ForEach(x => context.Products.Add(x));
            _images.ForEach(x => context.Images.Add(x));
            base.InitializeDatabase(context);
        }
    }
}
