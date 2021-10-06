using System;
using System.Collections.Generic;

namespace Vet02.App.Dominio
{
    public class Cuidador : Persona
    {
        public DateTime FechaInscripcion{set; get;}
        public string Direccion{set; get;}
        public string NumeroTelefono{set; get;}
        
        public ICollection<Mascota> Mascotas {set; get;}
    }
}
