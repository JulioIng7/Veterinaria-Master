using Vet02.App.Dominio;
using System.Collections.Generic;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario AddVeterinario(Veterinario vet);
        Veterinario UpdateVeterinario(Veterinario vet);
        void DeleteVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
    }
}