using Vet02.App.Dominio;
using System.Collections.Generic;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioCuidador
    {
        IEnumerable<Cuidador> GetAllCuidadores();
        Cuidador AddCuidador(Cuidador cuidador);
        Cuidador UpdateCuidador(Cuidador nuevoCuidador);
        Cuidador GetCuidador(int cuidadorId);
        void DeleteCuidador(int cuidadorId);
    }
}
