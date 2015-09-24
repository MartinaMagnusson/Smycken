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
            _ancleJewelries = new List<AncleJewelry>();
            _necklaces = new List<Necklace>();
            _carts = new List<Cart>();
            _earrings = new List<Earrings>();
            _jewelries = new List<Jewelry>() {
                new Jewelry() {
                    AncleJewelries = new List<AncleJewelry>()
                    {
                        new AncleJewelry()
                        {
                            Name = "Ankelsmycke",
                            Price = 49,
                            ArticleNr = 0002,
                            Description = "Ett ankelsmycke",
                            Image = new Image()
                            {
                                Description = "Ett ankelsmycke",
                                News = false,
                                FileName = "lovepeace1.jpg"
                            }
                        }
                    },
                    Necklaces = new List<Necklace>()
                    {
                        new Necklace()
                        {
                            Name = "Halsband",
                            Price = 59,
                            ArticleNr = 0001,
                            Description = "Ett halsband",
                            Image = new Image
                            {
                                Description = "Ett halsband",
                                News = false,
                                FileName = "lovepeace1.jpg"
                            }
                        }
                    },

                    Bracelets = new List<Bracelet>()
                    {
                        new Bracelet()
                        {
                            Name = "Armband",
                            Price = 59,
                            ArticleNr = 0003,
                            Description = "Ett Armband",
                            Image = new Image
                            {
                                Description = "Ett armband",
                                News = false,
                                FileName = "lovepeace1.jpg"
                            }
                        }
                    },

                    Earrings = new List<Earrings>()
                    {
                        new Earrings()
                        {
                            Name = "Örhänge",
                            Price = 59,
                            ArticleNr = 0003,
                            Description = "Ett örhänge",
                            Image = new Image
                            {
                                Description = "Ett örhänge",
                                News = false,
                                FileName = "lovepeace1.jpg"
                            }
                        }
                    }
                }
            };


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
