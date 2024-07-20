using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Proyectos.Models.Seeds
{
    public class ProyectoSeed : IEntityTypeConfiguration<Proyecto>
    {
        public void Configure(EntityTypeBuilder<Proyecto> builder)
        {
            builder.HasData(
                new Proyecto
                {
                    ID = 1,
                    Nombre = "Web Ecommerce",
                    Descripcion = "Tienda en línea",
                    FechaInicio = DateTime.Parse("2024-07-15"),
                }                
            );
        }
    }
}
