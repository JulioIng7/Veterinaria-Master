using Vet02.App.Dominio;
using System.Collections.Generic;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioAdministrador
    {
        IEnumerable<Administrador> GetAllAdministradores();
        Administrador AddAdministrador(Administrador admin);
        Administrador UpdateAdministrador(Administrador admin);
        Administrador GetAdministrador(int numDocAdm);
        void DeleteAdministrador(int numDocAdm);
    }
}
