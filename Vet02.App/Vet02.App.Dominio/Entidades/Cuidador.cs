using System;
using System.Collections.Generic;

namespace Vet02.App.Dominio
{
    public class Cuidador : Persona
    {
        public string Direccion{set; get;}
        public string NumeroTelefono{set; get;}
        
        public ICollection<Mascota> Mascotas {set; get;}
    }
}
