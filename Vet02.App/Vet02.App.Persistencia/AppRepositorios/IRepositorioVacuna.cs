using System;
using System.Collections.Generic;
using System.Linq;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioVacuna
    {
        IEnumerable<Vacuna> GetAllVacunas();
        Vacuna AddVacuna(Vacuna vacuna);
        Vacuna UpdateVacuna(Vacuna nuevaVacuna);
        Vacuna GetVacuna(int vacunaId);
        void DeleteVacuna(int vacunaId);
    }
}
