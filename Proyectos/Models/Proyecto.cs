using System.ComponentModel.DataAnnotations;

namespace Proyectos.Models
{
    public class Proyecto
    {
        public int ID { get; set; }

        [StringLength(250)]
        [Required]
        public string Nombre { get; set; }

        [StringLength(500)]
        [Required]
        public string Descripcion { get; set; }

        public DateTime FechaInicio { get; set; }
    }
}
