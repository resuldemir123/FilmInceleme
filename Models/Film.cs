namespace FilmInceleme.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Aciklama { get; set; } = string.Empty;

        public List<Yorum> Yorumlar { get; set; } = new List<Yorum>();
    }
}
