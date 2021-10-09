using System;
using System.Collections.Generic;
using System.Linq;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public class RepositorioCuidador : IRepositorioCuidador
    {
        private readonly AppContext appContext;
        public RepositorioCuidador(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        //Obtener una coleccion de datos de tipo Cuidador de la tabla Cuidadores en la base de datos
        IEnumerable<Cuidador> IRepositorioCuidador.GetAllCuidadores()
        {
            return this.appContext.Cuidadores;
        }
        //Adicionar registro a tabla Cuidadores de un objeto cuidador
        Cuidador IRepositorioCuidador.AddCuidador(Cuidador cuidador)
        {
            var cuidadorAdicionado = this.appContext.Cuidadores.Add(cuidador);
            this.appContext.SaveChanges();
            return cuidadorAdicionado.Entity;
        }
        //Actualizar un registro de la tabla Cuidadores con los datos del objeto nuevoCuidador
        Cuidador IRepositorioCuidador.UpdateCuidador(Cuidador nuevoCuidador)
        {
            var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault(c => c.Id == nuevoCuidador.Id);
            if(cuidadorEncontrado != null)
            {
                cuidadorEncontrado.Nombre = nuevoCuidador.Nombre;
                cuidadorEncontrado.Apellidos = nuevoCuidador.Apellidos;
                cuidadorEncontrado.Edad = nuevoCuidador.Edad;
                cuidadorEncontrado.NumeroDocumento = nuevoCuidador.NumeroDocumento;
                cuidadorEncontrado.Sexo = nuevoCuidador.Sexo;
                cuidadorEncontrado.Email = nuevoCuidador.Email;
                cuidadorEncontrado.Password = nuevoCuidador.Password;
                cuidadorEncontrado.Direccion = nuevoCuidador.Direccion;
                cuidadorEncontrado.NumeroTelefono = nuevoCuidador.NumeroTelefono;
                this.appContext.SaveChanges();
            }
            return cuidadorEncontrado;
        }
        //Borrar un registro de la tabla Cuidadores en la base de datos
        void IRepositorioCuidador.DeleteCuidador(int cuidadorId)
        {
            var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault(c => c.Id == cuidadorId);
            if(cuidadorEncontrado == null)
            {
                return;
            }
            this.appContext.Remove(cuidadorEncontrado);
            this.appContext.SaveChanges();
        }
        //Obtener un objeto de la clase Administrador registrado en la base de datos segun su Id
        Cuidador IRepositorioCuidador.GetCuidador(int cuidadorId)
        {
            return this.appContext.Cuidadores.FirstOrDefault(c => c.Id == cuidadorId);
        }
    }
}
