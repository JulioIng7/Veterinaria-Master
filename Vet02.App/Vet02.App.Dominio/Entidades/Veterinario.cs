using System;
using System.Collections.Generic;

namespace Vet02.App.Dominio
{
    public class Veterinario : Persona
    {
        public string TarjetaProfesional{set; get;}
        public string Especializacion{set; get;}
        public string TelefonoContacto{set; get;}
        //Relacion con la entidad Cita
        public ICollection<Cita> Citas{set; get;}
    }
}
