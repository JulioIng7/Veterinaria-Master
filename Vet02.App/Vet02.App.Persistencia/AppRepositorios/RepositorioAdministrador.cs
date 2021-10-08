using System;
using System.Linq;
using Vet02.App.Dominio;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vet02.App.Persistencia
{
    public class RepositorioAdministrador : IRepositorioAdministrador
    {
        private readonly AppContext appContext;
        public RepositorioAdministrador(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        //Obtener una coleccion de datos de tipo Administrador de la tabla Administradores en la base de datos
        IEnumerable<Administrador> IRepositorioAdministrador.GetAllAdministradores()
        {
            return this.appContext.Administradores;
        }
        //Adicionar registro a tabla Administradores de un objeto admin
        Administrador IRepositorioAdministrador.AddAdministrador(Administrador admin)
        {
            var adminAdicionado = this.appContext.Administradores.Add(admin);
            this.appContext.SaveChanges();
            return adminAdicionado.Entity;
        }
        //Actualizar un registro de la tabla Administradores con los datos del objeto nuevoAdmin
        Administrador IRepositorioAdministrador.UpdateAdministrador(Administrador nuevoAdmin)
        {
            var adminEncontrado = this.appContext.Administradores.FirstOrDefault(nuevoAdmin.Id);
            if(adminEncontrado != null)
            {
                adminEncontrado.Nombre = nuevoAdmin.Nombre;
                adminEncontrado.Apellidos = nuevoAdmin.Apellidos;
                adminEncontrado.Edad = nuevoAdmin.Edad;
                adminEncontrado.NumeroDocumento = nuevoAdmin.NumeroDocumento;
                adminEncontrado.Sexo = nuevoAdmin.Sexo;
                adminEncontrado.Email = nuevoAdmin.Email;
                adminEncontrado.Password = nuevoAdmin.Password;
                this.appContext.SaveChanges();
            }
            return adminEncontrado;
        }
        //Borrar un registro de la tabla Administradores en la base de datos
        void IRepositorioAdministrador.DeleteAdministrador(int adminId)
        {
            var adminEncontrado = this.appContext.Administradores.FirstOrDefault(a => a.Id == adminId);
            if(adminEncontrado != null)
            {
                return;
            }
            this.appContext.Remove(adminEncontrado);
            this.appContext.SaveChanges();
        }
        //Obtener un objeto de la clase Administrador registrado en la base de datos segun su Id
        Administrador IRepositorioAdministrador.GetAdministrador(int adminId)
        {
            return this.appContext.Administradores.FirstOrDefault(a => a.Id == adminId);
        }
    }
}
