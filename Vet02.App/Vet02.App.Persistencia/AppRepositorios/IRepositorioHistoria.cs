using System;
using System.Collections.Generic;
using System.Linq;
using VeterinaryG02.App.Dominio;

namespace VeterinaryG02.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<HistoriaClinica> GetAllHistorias();
        HistoriaClinica AddHistoria(HistoriaClinica nuevaHistoria);
        HistoriaClinica UpdateHistoria(HistoriaClinica actHistoria);
        HistoriaClinica GetHistoriaClinica(int idHistoria);
        void DeleteHistoria(int idHistoria);
    }
}