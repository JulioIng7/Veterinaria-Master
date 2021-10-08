using System;
using System.Collections.Generic;
using System.Linq;
using Vet02.App.Dominio;

namespace Vet02.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext appContext;
        public RepositorioMascota(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }
        //Obtener una coleccion de datos de tipo Mascota de la tabla Mascotas en la base de datos
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return this.appContext.Mascotas;
        }
        //Adicionar registro a tabla Mascotas de un objeto mascota        
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionada = this.appContext.Mascotas.Add(mascota);
            this.appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }
        //Actualizar un registro de la tabla Mascotas con los datos del objeto nuevaMascota        
        Mascota IRepositorioMascota.UpdateMascota(Mascota nuevaMascota)
        {
            var mascotaEncontrada = this.appContext.Mascotas.FirstOrDefault(m => m.Id == nuevaMascota.Id);
            if(mascotaEncontrada != null)
            {
                mascotaEncontrada.Nombre = nuevaMascota.Nombre;
                mascotaEncontrada.Edad = nuevaMascota.Edad;
                mascotaEncontrada.TipoAnimal = nuevaMascota.TipoAnimal;
                mascotaEncontrada.Raza = nuevaMascota.Raza;
                mascotaEncontrada.Genero = nuevaMascota.Genero;
                this.appContext.SaveChanges();
            }
            return mascotaEncontrada;
        }
        //Obtener un objeto de la clase Mascota registrado en la base de datos segun su Id        
        Mascota IRepositorioMascota.GetMascota(int mascotaId)
        {
            return this.appContext.Mascotas.FirstOrDefault(m => m.Id == mascotaId);
        }
        //Borrar un registro de la tabla Mascotas en la base de datos
        void IRepositorioMascota.DeleteMascota(int mascotaId)
        {
            var mascotaEncontrada = this.appContext.Mascotas.FirstOrDefault(m => m.Id == mascotaId);
            if(mascotaEncontrada == null)
            {
                return;
            }
            this.appContext.Mascotas.Remove(mascotaEncontrada);
            this.appContext.SaveChanges();
        }
    }
}
