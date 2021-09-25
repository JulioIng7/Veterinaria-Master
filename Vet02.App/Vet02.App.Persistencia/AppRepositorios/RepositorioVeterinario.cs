using System;
using System.Linq;
using Vet02.App.Dominio;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vet02.App.Persistencia
{
    public class RepositorioVeterinario:IRepositorioVeterinario
    {
        private readonly AppContext appContext;

        public RepositorioVeterinario(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        
        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return null;
            //throw new System.NotImplementedException();
        }
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario vet)
        {
            var veterinarioAdicionado = this.appContext.Veterinarios.Add(vet);
            this.appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
            //throw new System.NotImplementedException();
        }
        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario vet)
        {
            return null;
            //throw new System.NotImplementedException();
        }
        void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
            if(veterinarioEncontrado != null)
            {
                this.appContext.Remove(veterinarioEncontrado);
                this.appContext.SaveChanges();
            }
            //throw new System.NotImplementedException();
        }
        Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
        {
            return this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
            //throw new System.NotImplementedException();
        }
    }
}