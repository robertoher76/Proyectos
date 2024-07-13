using Microsoft.EntityFrameworkCore;

namespace Proyectos.Models
{
    public class ProyectosDBContext : DbContext
    {
        public ProyectosDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Proyecto> Proyectos { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Asignacion> Asignaciones { get; set; }
    }
}
