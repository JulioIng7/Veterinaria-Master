using System;
using System.Collections.Generic;
using System.Linq;
using VeterinaryG02.App.Dominio;

namespace VeterinaryG02.App.Persistencia
{
    public interface IRepositorioVacuna
    {
        IEnumerable<Vacuna> GetAllVacunas();
        Vacuna AddVacuna(Vacuna nuevaVacuna);
        Vacuna UpdateVacuna(Vacuna actVacuna);
        Vacuna GetVacuna(int idVacuna);
        void DeleteVacuna(int idVacuna);
    }
}