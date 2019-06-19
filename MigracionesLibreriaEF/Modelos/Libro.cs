using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigracionesLibreriaEF.Modelos
{
    [Table("Libros")]
    public class Libro
    {
        public int Id { get; set; }
        [Column("SSID_LibroCod", TypeName = "VARCHAR")]
        [StringLength(120)]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual Editorial CasaEditora { get; set; }
    }
}