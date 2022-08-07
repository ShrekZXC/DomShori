namespace DomShori.Models
{
    public class Curtain
    {
        public int id { get; set; }
        public string name { get; set; }

        public string img { get; set; }

        public ushort priceWithTulle { get; set; }
        public ushort priceWithoutTulle { get; set; }

        public bool isFavorit { get; set; }

        public bool available { get; set; }

        public double size { get; set; }
        public string textill { get; set; }

        public virtual Category category { get; set; }

    }
}
