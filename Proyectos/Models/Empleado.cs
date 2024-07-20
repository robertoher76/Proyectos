using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyectos.Models
{
    public class Empleado
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo apellido es requerido")]
        public string Apellido { get; set; }

        [Display(Name = "Fecha de Contratación")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo contratación es requerido")]
        public DateTime FechaContratacion { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Display(Name = "Puesto")]
        [Required(ErrorMessage = "El campo puesto es requerido")]
        public string Puesto { get; set; }
    }
}
