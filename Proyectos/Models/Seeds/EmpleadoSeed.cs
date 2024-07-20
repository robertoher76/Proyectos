using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Proyectos.Models.Seeds
{
    public class EmpleadoSeed : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasData(
                new Empleado
                {
                    ID = 1,
                    Nombre = "Roberto",
                    Apellido = "Meléndez",
                    FechaContratacion = DateTime.Parse("2024-07-15"),
                    Puesto = "Web Developer"
                }                
            );
        }
    }
}
