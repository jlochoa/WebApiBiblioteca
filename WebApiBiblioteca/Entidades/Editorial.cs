using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Entidades
{
    public class Editorial
    {
        public int EditorialId { get; set; }
        // Obligatorio y ancho máximo
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public ICollection<Libro> Libros { get; set; }
    }
}
