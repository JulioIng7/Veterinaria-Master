using System;

namespace Vet02.App.Dominio
{
    public class Persona
    {
        public int Id{set; get;}
        public string Nombre{set; get;}
        public string Apellidos{set; get;}
    	public int NumeroDocumento{set; get;}
        public DateTime FechaRegistro{set; get;}
        public string Email{set; get;}
        public string Password{set; get;}
        public string Sexo{set; get;}
        public int Edad{set; get;}
    }
}