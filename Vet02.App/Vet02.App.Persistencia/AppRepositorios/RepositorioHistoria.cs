using System;
using System.Linq;
using System.Collections.Generic;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly AppContext appContext;
        public RepositorioHistoria(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        //Obtener una coleccion de datos de tipo HistoriaMedica de la tabla Historias en la base de datos        
        IEnumerable<HistoriaClinica> IRepositorioHistoria.GetAllHistorias()
        {
            return this.appContext.Historias;
        }
        //Adicionar registro a tabla Historias de un objeto historia      
        HistoriaClinica IRepositorioHistoria.AddHistoria(HistoriaMedica historia)
        {
            var historiaAdicionada = this.appContext.Historias.Add(historia);
            this.appContext.SaveChanges();
            return historiaAdicionada.Entity;
        }
        //Actualizar un registro de la tabla Historias con los datos del objeto nuevaHistoria        
        HistoriaClinica IRepositorioHistoria.UpdateHistoria(HistoriaMedica nuevaHistoria)
        {
            var historiaEncontrada = this.appContext.Historias.FirstOrDefault(hc => hc.Id == nuevaHistoria.Id);
            if(historiaEncontrada != null)
            {
                historiaEncontrada.EstadoMascota = nuevaHistoria.EstadoMascota;
                historiaEncontrada.Observaciones = nuevaHistoria.Observaciones;
                historiaEncontrada.MascotaId = nuevaHistoria.MascotaId;
                this.appContext.SaveChanges();
            }
            return historiaEncontrada;
        }
        //Obtener un objeto de la clase HistoriaMedica registrado en la base de datos segun su Id        
        HistoriaClinica IRepositorioHistoria.GetHistoriaMedica(int historiaId)
        {
            return this.appContext.Historias.FirstOrDefault(hc => hc.Id == historiaId);
        }
        //Borrar un registro de la tabla Historias en la base de datos        
        void IRepositorioHistoria.DeleteHistoria(int historiaId)
        {
            var historiaEncontrada = this.appContext.Historias.FirstOrDefault(hc => hc.Id == historiaId);
            if(historiaEncontrada == null)
            {
                return;
            }
            this.appContext.Historias.Remove(historiaEncontrada);
            this.appContext.SaveChanges();
        }
    }
}
