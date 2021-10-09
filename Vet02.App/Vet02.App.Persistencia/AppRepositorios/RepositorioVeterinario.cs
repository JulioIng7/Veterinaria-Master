using System;
using System.Linq;
using Vet02.App.Dominio;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vet02.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext appContext;

        public RepositorioVeterinario(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        //Obtener una coleccion de datos de tipo Veterinario de la tabla Veterinarios de la base de datos
        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return this.appContext.Veterinarios;
        }
        //Adicionar registro a tabla Veterinarios de un objeto vet
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario vet)
        {
            var veterinarioAdicionado = this.appContext.Veterinarios.Add(vet);
            this.appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        //Actualizar un registro de la tabla Veterinarios con los datos del objeto nuevoVet
        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario nuevoVet)
        {
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == nuevoVet.Id);
            if(veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombre = nuevoVet.Nombre;
                veterinarioEncontrado.Apellidos = nuevoVet.Apellidos;
                veterinarioEncontrado.Edad = nuevoVet.Edad;
                veterinarioEncontrado.NumeroDocumento = nuevoVet.NumeroDocumento;
                veterinarioEncontrado.Sexo = nuevoVet.Sexo;
                veterinarioEncontrado.Email = nuevoVet.Email;
                veterinarioEncontrado.Password = nuevoVet.Password;
                veterinarioEncontrado.TarjetaProfesional = nuevoVet.TarjetaProfesional;
                veterinarioEncontrado.Especializacion = nuevoVet.Especializacion;
                veterinarioEncontrado.TelefonoContacto = nuevoVet.TelefonoContacto;
                this.appContext.SaveChanges();
            }
            
            return veterinarioEncontrado;
        }
        //Borrar un registro de la tabla Veterinarios en la base de datos
        void IRepositorioVeterinario.DeleteVeterinario(int veterinarioId)
        {
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioId);
            if(veterinarioEncontrado == null)
            {
                return;
            }
            this.appContext.Remove(veterinarioEncontrado);
            this.appContext.SaveChanges();
        }
        //Obtener un objeto de la clase Administrador registrado en la base de datos segun su Id
        Veterinario IRepositorioVeterinario.GetVeterinario(int veterinarioId)
        {
            return this.appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioId);
        }
    }
}
