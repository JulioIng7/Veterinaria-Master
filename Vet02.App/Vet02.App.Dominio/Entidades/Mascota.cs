using System;

namespace Vet02.App.Dominio
{
    public class Mascota
    {
        public int Id{set; get;}
        public string Nombre{set; get;}
        public string TipoAnimal{set; get;}
        public string Raza{set; get;}
        //public Cuidador CuidadorM{set; get;} // Composicion
        public Genero GeneroM{set; get;}
        public int IdCuidador{set; get;}
        public int IdHistoriaClinica{set; get;}
        public int Edad{set; get;}
    }
}