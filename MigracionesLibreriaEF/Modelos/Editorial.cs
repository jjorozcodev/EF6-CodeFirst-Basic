using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigracionesLibreriaEF.Modelos
{
    public class Editorial
    {
        [Key]
        public int Id { get; set; }
        [Column("Descripcion", TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Name { get; set; }

        public ICollection<Libro> Libros { get; set; }
    }
}