using System.ComponentModel.DataAnnotations;

namespace Proyectos.Models
{
    public class Proyecto
    {
        public int ID { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }

        [StringLength(500, MinimumLength = 3)]
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo descripción es requerido")]
        public string Descripcion { get; set; }

        [Display(Name = "Fecha de Inicio")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo fecha de inicio es requerido")]
        public DateTime FechaInicio { get; set; }
    }
}
