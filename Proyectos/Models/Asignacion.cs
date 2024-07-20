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

        [Display(Name = "Fecha de Asignación")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo fecha de asignación es requerido")]
        public DateTime FechaAsignacion { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "El campo rol es requerido")]
        public string Rol { get; set; }
    }
}
