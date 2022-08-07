namespace DomShori.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }

        public List<Curtain>curtains { get; set; }
    }
}
