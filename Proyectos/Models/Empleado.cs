using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyectos.Models
{
    public class Empleado
    {
        public int ID { get; set; }

        [StringLength(250)]
        [Required]
        public string Nombre { get; set; }

        [StringLength(250)]
        [Required]
        public string Apellido { get; set; }

        public DateTime FechaContratacion { get; set; }        

        [StringLength(250)]
        [Required]
        public string Puesto { get; set; }
    }
}
