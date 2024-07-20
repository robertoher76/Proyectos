using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Proyectos.Models.Seeds
{
    public class AsignacionSeed : IEntityTypeConfiguration<Asignacion>
    {
        public void Configure(EntityTypeBuilder<Asignacion> builder)
        {
            builder.HasData(
                new Asignacion
                {
                    ID = 1,
                    EmpleadoId = 1,
                    ProyectoId = 1,
                    FechaAsignacion = DateTime.Parse("2024-07-15"),
                    Rol = "Programador"
                }                
            );
        }
    }
}
