using System;

namespace Vet02.App.Dominio
{
    public class Cita
    {
        public int Id{set; get;}
        public DateTime FechaCita{set; get;}
        public DateTime FechaRegistro{set; get;}
        //Relacion con la entidad Veterinario
        public Veterinario Veterinario{set; get;}
        //Relacion con la entidad Mascota
        public Mascota Mascota{set; get;}
    }
}
