using Microsoft.EntityFrameworkCore;
using Proyectos.Models.Seeds;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpleadoSeed());
            modelBuilder.ApplyConfiguration(new ProyectoSeed());
            modelBuilder.ApplyConfiguration(new AsignacionSeed());
        }
    }
}
