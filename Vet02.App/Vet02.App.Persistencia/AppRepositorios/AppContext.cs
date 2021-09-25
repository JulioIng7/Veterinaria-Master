using Microsoft.EntityFrameworkCore;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Veterinario> Veterinarios{set; get;}
        public DbSet<Cuidador> Cuidadores{set; get;}
        public DbSet<Mascota> Mascotas{set; get;}
        public DbSet<Persona> Personas{set; get;}
        public DbSet<Administrador> Administradores{set; get;}
        public DbSet<Cita> Citas{set; get;}
        public DbSet<HistoriaMedica> Historias{set; get;}
        public DbSet<Diagnostico> Diagnosticos{set; get;}
        public DbSet<Vacuna> Vacunas{set; get;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VeterinariaData");
            }
        }
    }
}