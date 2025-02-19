using Microsoft.EntityFrameworkCore;
using FilmInceleme.Models;

namespace FilmInceleme.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
    }
}
