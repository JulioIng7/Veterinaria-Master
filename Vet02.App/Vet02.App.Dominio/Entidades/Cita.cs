using System;

namespace Vet02.App.Dominio
{
    public class Cita
    {
        public int Id{set; get;}
        public int IdVeterinario{set; get;}
        //public Veterinario VeterinarioC{set; get;}
        public int IdMascota{set; get;}
        //public Mascota MascotaC{set; get;}
        public string HoraCita{set; get;}
        public DateTime FechaCita{set; get;}
        //public EstadoCita EstadoCita{set; get;}
    }
}