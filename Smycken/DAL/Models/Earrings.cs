namespace DAL.Models
{
    public class Earrings
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int ArticleNr { get; set; }
        public string Description { get; set; }
        public virtual Jewelry Jewelry { get; set; }
        public Image Images { get; set; }
    }
}