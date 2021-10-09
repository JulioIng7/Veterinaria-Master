using System;

namespace Vet02.App.Dominio
{
    public class Vacuna
    {
        public int Id{set;get;}
        public string Laboratorio{set; get;}
        public string Serie{set; get;}
        public string Lote{set; get;}
        public DateTime FechaProduccion{set; get;}
        public DateTime FechaVencimiento{set; get;}
        public DateTime FechaAplicacion{set; get;} = DateTime.Now;
        //Relacion con la entidad Mascota
        public Mascota Mascota{set; get;}
        public Mascota MascotaId{set; get;}
    }
}
