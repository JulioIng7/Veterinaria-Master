using System;
using System.Linq;
using System.Collections.Generic;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public class RepositorioVacuna : IRepositorioVacuna
    {
        private readonly AppContext appContext;
        public RepositorioVacuna(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        //Obtener una coleccion de datos de tipo Vacuna de la tabla Vacunas en la base de datos        
        IEnumerable<Vacuna> IRepositorioVacuna.GetAllVacunas()
        {
            return this.appContext.Vacunas;
        }
        //Adicionar registro a tabla Vacunas de un objeto vacuna        
        Vacuna IRepositorioVacuna.AddVacuna(Vacuna vacuna)
        {
            var vacunaAdicionada = this.appContext.Vacunas.Add(vacuna);
            this.appContext.SaveChanges();
            return vacunaAdicionada.Entity;
        }
        //Actualizar un registro de la tabla Vacunas con los datos del objeto nuevaVacuna        
        Vacuna IRepositorioVacuna.UpdateVacuna(Vacuna nuevaVacuna)
        {
            var vacunaEncontrada = this.appContext.Vacunas.FirstOrDefault(v => v.Id == nuevaVacuna.Id);
            if(vacunaEncontrada != null)
            {
                vacunaEncontrada.Laboratorio = nuevaVacuna.Laboratorio;
                vacunaEncontrada.Lote = nuevaVacuna.Lote;
                vacunaEncontrada.Serie = nuevaVacuna.Serie;
                vacunaEncontrada.FechaProduccion = nuevaVacuna.FechaProduccion;
                vacunaEncontrada.FechaVencimiento = nuevaVacuna.FechaVencimiento;
                vacunaEncontrada.FechaAplicacion = nuevaVacuna.FechaAplicacion;
                vacunaEncontrada.MascotaId = nuevaVacuna.MascotaId;
                this.appContext.SaveChanges();
            }
            return vacunaEncontrada;
        }
        //Obtener un objeto de la clase Vacuna registrado en la base de datos segun su Id        
        Vacuna IRepositorioVacuna.GetVacuna(int vacunaId)
        {
            return this.appContext.Vacunas.FirstOrDefault(v => v.Id == vacunaId);
        }
        //Borrar un registro de la tabla Vacunas en la base de datos        
        void IRepositorioVacuna.DeleteVacuna(int vacunaId)
        {
            var vacunaEncontrada = this.appContext.Vacunas.FirstOrDefault(v => v.Id == vacunaId);
            if(vacunaEncontrada == null)
            {
                return;
            }
            this.appContext.Vacunas.Remove(vacunaEncontrada);
            this.appContext.SaveChanges();
        }
    }
}
