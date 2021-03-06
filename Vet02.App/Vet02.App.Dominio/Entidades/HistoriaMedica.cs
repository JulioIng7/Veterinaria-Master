using System;
using System.Collections.Generic;

namespace Vet02.App.Dominio
{
    public class HistoriaMedica
    {
        public int Id{set; get;}
        public DateTime FechaHClinica{set; get;}
        public string EstadoMascota{set; get;}
        public string Observaciones{set; get;}
        //Relacion con la entidad Diagnostico
        public List<Diagnostico> Diagnosticos{set; get;}
        //Relacion con la entidad Mascota
        public Mascota Mascota{set; get;}
        public int MascotaId{set; get;}
    }
}
