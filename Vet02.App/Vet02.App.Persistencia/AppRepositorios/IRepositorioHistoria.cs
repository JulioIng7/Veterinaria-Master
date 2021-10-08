using System;
using System.Collections.Generic;
using System.Linq;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<HistoriaMedica> GetAllHistorias();
        HistoriaMedica AddHistoria(HistoriaMedica historia);
        HistoriaMedica UpdateHistoria(HistoriaMedica nuevaHistoria);
        HistoriaMedica GetHistoriaMedica(int historiaId);
        void DeleteHistoria(int historiaId);
    }
}
