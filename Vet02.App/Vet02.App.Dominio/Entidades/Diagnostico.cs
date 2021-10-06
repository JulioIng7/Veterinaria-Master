using System;

namespace Vet02.App.Dominio
{
    public class Diagnostico
    {
        public int Id{set; get;}
        public string DiagnosticoMascota{set; get;}
        public string Recomendaciones{set; get;}
        public int IdHistoriaMedica{set; get;}
        //Relacion con la entidad HistoriaMedica
        public HistoriaMedica HistoriaMedica{set; get;}
        public int HistoriaMedicaId{set;get;}
    }
}
