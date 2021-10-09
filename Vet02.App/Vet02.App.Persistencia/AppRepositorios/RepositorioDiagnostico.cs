using System;
using System.Collections.Generic;
using System.Linq;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public class RepositorioDiagnostico : IRepositorioDiagnostico
    {
        private readonly AppContext appContext;
        public RepositorioDiagnostico(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        //Obtener una coleccion de datos de tipo Diagnostico de la tabla Diagnosticos en la base de datos
        IEnumerable<Diagnostico> IRepositorioDiagnostico.GetAllDiagnosticos()
        {
            return this.appContext.Diagnosticos;
        }
        //Adicionar registro a tabla Diagnosticos de un objeto diagnostico
        Diagnostico IRepositorioDiagnostico.AddDiagnostico(Diagnostico diagnostico)
        {
            var diagnosticoAdicionado = this.appContext.Diagnosticos.Add(diagnostico);
            this.appContext.SaveChanges();
            return diagnosticoAdicionado.Entity;
        }
        //Actualizar un registro de la tabla Diagnostico con los datos del objeto nuevoDiagnostico        
        Diagnostico IRepositorioDiagnostico.UpdateDiagnostico(Diagnostico nuevoDiagnostico)
        {
            var diagnosticoEncontrado = this.appContext.Diagnosticos.FirstOrDefault(d => d.Id == nuevoDiagnostico.Id);
            if(diagnosticoEncontrado != null)
            {
                diagnosticoEncontrado.DiagnosticoMascota = nuevoDiagnostico.DiagnosticoMascota;
                diagnosticoEncontrado.Recomendaciones = nuevoDiagnostico.Recomendaciones;
                diagnosticoEncontrado.HistoriaMedicaId = nuevoDiagnostico.HistoriaMedicaId;
            }
            return diagnosticoEncontrado;
        }
        //Obtener un objeto de la clase Diagnostico registrado en la base de datos segun su Id        
        Diagnostico IRepositorioDiagnostico.GetDiagnostico(int diagnosticoId)
        {
            return this.appContext.Diagnosticos.FirstOrDefault(d => d.Id == diagnosticoId);
        }
        //Borrar un registro de la tabla Diagnosticos en la base de datos        
        void IRepositorioDiagnostico.DeleteDiagnostico(int diagnosticoId)
        {
            var diagnosticoEncontrado = this.appContext.Diagnosticos.FirstOrDefault(d => d.Id == diagnosticoId);
            if(diagnosticoEncontrado == null)
            {
                return;
            }
            this.appContext.Diagnosticos.Remove(diagnosticoEncontrado);
            this.appContext.SaveChanges();
        }
    }
}
