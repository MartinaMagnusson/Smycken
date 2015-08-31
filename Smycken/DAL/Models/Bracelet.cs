namespace DAL.Models
{
    public class Bracelet
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int ArticleNr { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public virtual Image Image { get; set; }
    }
}