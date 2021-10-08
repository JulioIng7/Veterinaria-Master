using System;
using System.Linq;
using System.Collections.Generic;
using VeterinaryG02.App.Dominio;

namespace VeterinaryG02.App.Persistencia
{
    public class RepositorioVacuna : IRepositorioVacuna
    {
        private readonly AppContext appContext;
        public RepositorioVacuna(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        IEnumerable<Vacuna> IRepositorioVacuna.GetAllVacunas()
        {
            return this.appContext.TblVacuna;
        }
        Vacuna IRepositorioVacuna.AddVacuna(Vacuna nuevaVacuna)
        {
            var vacunaAdicionada = this.appContext.TblVacuna.Add(nuevaVacuna);
            this.appContext.SaveChanges();
            return vacunaAdicionada.Entity;
        }
        Vacuna IRepositorioVacuna.UpdateVacuna(Vacuna actVacuna)
        {
            var vacunaEncontrada = this.appContext.TblVacuna.FirstOrDefault(v => v.Id == actVacuna.Id);
            if(vacunaEncontrada != null)
            {
                //vacunaEncontrada.MascotaId = actVacuna.MascotaId;
                vacunaEncontrada.Laboratorio = actVacuna.Laboratorio;
                vacunaEncontrada.Lote = actVacuna.Lote;
                vacunaEncontrada.Serie = actVacuna.Serie;
                vacunaEncontrada.FechaProduccion = actVacuna.FechaProduccion;
                vacunaEncontrada.FechaVencimiento = actVacuna.FechaVencimiento;
                vacunaEncontrada.FechaAplicacion = actVacuna.FechaAplicacion;
                this.appContext.SaveChanges();
            }
            return vacunaEncontrada;
        }
        Vacuna IRepositorioVacuna.GetVacuna(int idVacuna)
        {
            return this.appContext.TblVacuna.FirstOrDefault(v => v.Id == idVacuna);
        }
        void IRepositorioVacuna.DeleteVacuna(int idVacuna)
        {
            var vacunaEncontrada = this.appContext.TblVacuna.FirstOrDefault(v => v.Id == idVacuna);
            if(vacunaEncontrada == null)
            {
                return;
            }
            this.appContext.TblVacuna.Remove(vacunaEncontrada);
            this.appContext.SaveChanges();
        }
    }
}