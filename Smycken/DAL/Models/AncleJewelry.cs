namespace DAL.Models
{
    public class AncleJewelry
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int ArticleNr { get; set; }
        public string Description { get; set; }
        public virtual Jewelry Jewelry { get; set; }

        public int Images_ID { get; set; }
        public virtual Image Image { get; set; }
    }
}