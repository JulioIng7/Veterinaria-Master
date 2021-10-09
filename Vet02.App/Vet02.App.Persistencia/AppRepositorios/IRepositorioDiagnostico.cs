using System;
using System.Linq;
using System.Collections.Generic;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioDiagnostico
    {
        IEnumerable<Diagnostico> GetAllDiagnosticos();
        Diagnostico AddDiagnostico(Diagnostico nuevoDiagnostico);
        Diagnostico UpdateDiagnostico(Diagnostico actDiagnostico);
        Diagnostico GetDiagnostico(int diagnosticoId);
        void DeleteDiagnostico(int diagnosticoId);
    }
}
