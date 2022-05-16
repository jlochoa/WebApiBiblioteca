using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Entidades;
using WebApiBiblioteca.Entidades.Seed;

namespace WebApiBiblioteca
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData.Seed(modelBuilder);
        }

        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }

    }
}
