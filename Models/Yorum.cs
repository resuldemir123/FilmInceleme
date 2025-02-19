namespace FilmInceleme.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        public string Icerik { get; set; } = string.Empty;
        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
