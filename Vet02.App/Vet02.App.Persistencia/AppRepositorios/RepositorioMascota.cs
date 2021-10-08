using System;
using System.Collections.Generic;
using System.Linq;
using VeterinaryG02.App.Dominio;

namespace VeterinaryG02.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext appContext;
        public RepositorioMascota(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return this.appContext.TblMascota;
        }
        Mascota IRepositorioMascota.AddMascota(Mascota nuevaMascota)
        {
            var mascotaAdicionada = this.appContext.TblMascota.Add(nuevaMascota);
            this.appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }
        Mascota IRepositorioMascota.UpdateMascota(Mascota actMascota)
        {
            var mascotaEncontrada = this.appContext.TblMascota.FirstOrDefault(m => m.Id == actMascota.Id);
            if(mascotaEncontrada != null)
            {
                //mascotaEncontrada.CuidadorId = actMascota.CuidadorId;
                mascotaEncontrada.Nombre = actMascota.Nombre;
                mascotaEncontrada.Edad = actMascota.Edad;
                mascotaEncontrada.TipoAnimal = actMascota.TipoAnimal;
                mascotaEncontrada.Raza = actMascota.Raza;
                mascotaEncontrada.Genero = actMascota.Genero;
                this.appContext.SaveChanges();
            }
            return mascotaEncontrada;
        }
        Mascota IRepositorioMascota.GetMascota(int idMascota)
        {
            return this.appContext.TblMascota.FirstOrDefault(m => m.Id == idMascota);
        }
        void IRepositorioMascota.DeleteMascota(int idMascota)
        {
            var mascotaEncontrada = this.appContext.TblMascota.FirstOrDefault(m => m.Id == idMascota);
            if(mascotaEncontrada == null)
            {
                return;
            }
            this.appContext.TblMascota.Remove(mascotaEncontrada);
            this.appContext.SaveChanges();
        }
    }
}