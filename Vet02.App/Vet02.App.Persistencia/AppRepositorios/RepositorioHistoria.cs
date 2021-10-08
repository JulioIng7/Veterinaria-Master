using System;
using System.Linq;
using System.Collections.Generic;
using VeterinaryG02.App.Dominio;

namespace VeterinaryG02.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly AppContext appContext;
        public RepositorioHistoria(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        IEnumerable<HistoriaClinica> IRepositorioHistoria.GetAllHistorias()
        {
            return this.appContext.TblHistoriaClinica;
        }
        HistoriaClinica IRepositorioHistoria.AddHistoria(HistoriaClinica nuevaHistoria)
        {
            var historiaAdicionada = this.appContext.TblHistoriaClinica.Add(nuevaHistoria);
            this.appContext.SaveChanges();
            return historiaAdicionada.Entity;
        }
        HistoriaClinica IRepositorioHistoria.UpdateHistoria(HistoriaClinica actHistoria)
        {
            var historiaEncontrada = this.appContext.TblHistoriaClinica.FirstOrDefault(hc => hc.Id == actHistoria.Id);
            if(historiaEncontrada != null)
            {
                historiaEncontrada.Fecha = actHistoria.Fecha;
                //historiaEncontrada.MascotaId = actHistoria.MascotaId;
                historiaEncontrada.EstadoMascota = actHistoria.EstadoMascota;
                historiaEncontrada.Observaciones = actHistoria.Observaciones;

                this.appContext.SaveChanges();
            }
            return historiaEncontrada;
        }
        HistoriaClinica IRepositorioHistoria.GetHistoriaClinica(int idHistoria)
        {
            return this.appContext.TblHistoriaClinica.FirstOrDefault(hc => hc.Id == idHistoria);
        }
        void IRepositorioHistoria.DeleteHistoria(int idHistoria)
        {
            var historiaEncontrada = this.appContext.TblHistoriaClinica.FirstOrDefault(hc => hc.Id == idHistoria);
            if(historiaEncontrada == null)
            {
                return;
            }
            this.appContext.TblHistoriaClinica.Remove(historiaEncontrada);
            this.appContext.SaveChanges();
        }
    }
}