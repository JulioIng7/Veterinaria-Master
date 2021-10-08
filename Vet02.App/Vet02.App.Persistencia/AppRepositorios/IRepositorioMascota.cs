using System;
using System.Linq;
using System.Collections.Generic;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioMascota
    {
         IEnumerable<Mascota> GetAllMascotas();
         Mascota AddMascota(Mascota mascota);
         Mascota UpdateMascota(Mascota nuevaMascota);
         Mascota GetMascota(int mascotaId);
         void DeleteMascota(int mascotaId);
    }
}
