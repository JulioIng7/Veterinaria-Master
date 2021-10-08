using System;
using System.Linq;
using System.Collections.Generic;
using VeterinaryG02.App.Dominio;

namespace VeterinaryG02.App.Persistencia
{
    public interface IRepositorioMascota
    {
         IEnumerable<Mascota> GetAllMascotas();
         Mascota AddMascota(Mascota nuevaMascota);
         Mascota UpdateMascota(Mascota actMascota);
         Mascota GetMascota(int idMascota);
         void DeleteMascota(int idMascota);
    }
}