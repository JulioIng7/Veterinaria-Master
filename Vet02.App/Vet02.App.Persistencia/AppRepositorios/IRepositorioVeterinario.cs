using Vet02.App.Dominio;
using System.Collections.Generic;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario AddVeterinario(Veterinario vet);
        Veterinario UpdateVeterinario(Veterinario nuevoVet);
        void DeleteVeterinario(int veterinarioId);
        Veterinario GetVeterinario(int veterinarioId);
    }
}
