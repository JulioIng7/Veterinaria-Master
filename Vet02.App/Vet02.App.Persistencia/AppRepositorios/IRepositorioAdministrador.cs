using Vet02.App.Dominio;
using System.Collections.Generic;

namespace Vet02.App.Persistencia
{
    public interface IRepositorioAdministrador
    {
        IEnumerable<Administrador> GetAllAdministradores();
        Administrador AddAdministrador(Administrador admin);
        Administrador UpdateAdministrador(Administrador admin);
        void DeleteAdministrador(int numDocAdm);
        void DeleteAdministradorById(int idAdm);
        Administrador GetAdministrador(int numDocAdm);
    }
}