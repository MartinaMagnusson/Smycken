﻿namespace DAL.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ArticleNr { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}