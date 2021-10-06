using System;
using System.Collections.Generic;

namespace Vet02.App.Dominio
{
    public class Mascota
    {
        public int Id{set; get;}
        public string Nombre{set; get;}
        public string TipoAnimal{set; get;}
        public string Raza{set; get;}
        public int Edad{set; get;}
        public string Genero{set; get;}
        //Relacion con la entidad Cita
        public ICollection<Cita> Citas{set; get;}
        //Relacion con la entidad Vacuna
        public ICollection<Vacuna> Vacunas{set; get;}
        //Relacion con la entidad HistoriaMedica
        public HistoriaMedica HistoriaMedica{set; get;}
    }
}
