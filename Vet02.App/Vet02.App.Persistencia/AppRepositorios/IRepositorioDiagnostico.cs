using System;
using System.Linq;
using System.Collections.Generic;
using VeterinaryG02.App.Dominio;

namespace VeterinaryG02.App.Persistencia
{
    public interface IRepositorioDiagnostico
    {
        IEnumerable<Diagnostico> GetAllDiagnosticos();
        Diagnostico AddDiagnostico(Diagnostico nuevoDiagnostico);
        Diagnostico UpdateDiagnostico(Diagnostico actDiagnostico);
        Diagnostico GetDiagnostico(int idDiagnostico);
        void DeleteDiagnostico(int idDiagnostico);
    }
}