using System;
using System.Collections.Generic;
using System.Linq;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<HistoriaClinica> GetAllHistorias();
        HistoriaClinica AddHistoria(HistoriaClinica historia);
        HistoriaClinica UpdateHistoria(HistoriaClinica nuevaHistoria);
        HistoriaClinica GetHistoriaClinica(int historiaId);
        void DeleteHistoria(int historiaId);
    }
}
