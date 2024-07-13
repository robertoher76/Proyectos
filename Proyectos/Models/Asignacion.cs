using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyectos.Models
{
    public class Asignacion
    {
        public int ID { get; set; }

        //propiedad para la llave foranea Empleado        
        [Required]
        [ForeignKey("Empleado")]
        public int? EmpleadoId { get; set; }

        //propiedad de navegacion Empleado
        public Empleado Empleado { get; set; }

        //propiedad para la llave foranea Empleado        
        [Required]
        [ForeignKey("Proyecto")]
        public int? ProyectoId { get; set; }

        //propiedad de navegacion Empleado
        public Proyecto Proyecto { get; set; }

        public DateTime FechaAsignacion { get; set; }

        [StringLength(250)]
        [Required]
        public string Rol { get; set; }
    }
}
