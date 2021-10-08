using System;
using System.Collections.Generic;
using System.Linq;
using VeterinaryG02.App.Dominio;

namespace VeterinaryG02.App.Persistencia
{
    public class RepositorioDiagnostico : IRepositorioDiagnostico
    {
        private readonly AppContext appContext;
        public RepositorioDiagnostico(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        IEnumerable<Diagnostico> IRepositorioDiagnostico.GetAllDiagnosticos()
        {
            return this.appContext.TblDiagnostico;
        }
        Diagnostico IRepositorioDiagnostico.AddDiagnostico(Diagnostico nuevoDiagnostico)
        {
            var diagnosticoAdicionado = this.appContext.TblDiagnostico.Add(nuevoDiagnostico);
            this.appContext.SaveChanges();
            return diagnosticoAdicionado.Entity;
        }
        Diagnostico IRepositorioDiagnostico.UpdateDiagnostico(Diagnostico actDiagnostico)
        {
            var diagnosticoEncontrado = this.appContext.TblDiagnostico.FirstOrDefault(d => d.Id == actDiagnostico.Id);
            if(diagnosticoEncontrado != null)
            {
                diagnosticoEncontrado.DiagnosticoMascota = actDiagnostico.DiagnosticoMascota;
                diagnosticoEncontrado.SugerenciaCuidado = actDiagnostico.SugerenciaCuidado;
                diagnosticoEncontrado.HistoriaClinicaId = actDiagnostico.HistoriaClinicaId;
            }
            return diagnosticoEncontrado;
        }
        Diagnostico IRepositorioDiagnostico.GetDiagnostico(int idDiagnostico)
        {
            return this.appContext.TblDiagnostico.FirstOrDefault(d => d.Id == idDiagnostico);
        }
        void IRepositorioDiagnostico.DeleteDiagnostico(int idDiagnostico)
        {
            var diagnosticoEncontrado = this.appContext.TblDiagnostico.FirstOrDefault(d => d.Id == idDiagnostico);
            if(diagnosticoEncontrado == null)
            {
                return;
            }
            this.appContext.TblDiagnostico.Remove(diagnosticoEncontrado);
            this.appContext.SaveChanges();
        }
    }
}