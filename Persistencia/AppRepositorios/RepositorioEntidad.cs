using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;



namespace Persistencia.AppRepositorios
{
    public class RepositorioEntidad:IRepositorioEntidad
    {
        
        private readonly AppContext _appContext; 

        public RepositorioEntidad(AppContext appContext) 
        {
            _appContext = appContext;
        }   

        Entidad IRepositorioEntidad.AddEntidad(Entidad entidad)
        {
            var entidadAdicionado = _appContext.Entidad.Add(entidad);
            _appContext.SaveChanges();
            return entidadAdicionado.Entity;
        }

        Entidad IRepositorioEntidad.UpdateEntidad(Entidad entidad)
        {
            var entidadAdicionado = _appContext.Entidad.FirstOrDefault(c => c.Id == entidad.Id);
            if (entidadAdicionado!= null)
            {
                entidadAdicionado.nombre = entidad.nombre;
                entidadAdicionado.nit = entidad.nit;
                entidadAdicionado.ciudad= entidad.ciudad;
                entidadAdicionado.telefono= entidad.telefono;
                entidadAdicionado.correo = entidad.correo;
                entidadAdicionado.sector = entidad.sector;
                entidadAdicionado.tipo_servicio = entidad.tipo_servicio;
                
                _appContext.SaveChanges();                                        
            }
            return entidadAdicionado;
                    
        }

        void IRepositorioEntidad.DeleteEntidad(int idEntidad)
        {
            var entidadEncontrada = _appContext.Entidad.FirstOrDefault(c => c.Id == idEntidad);
            if (entidadEncontrada == null)
            return;
            _appContext.Entidad.Remove(entidadEncontrada);
            _appContext.SaveChanges();   
        }

         Entidad IRepositorioEntidad.GetEntidad(int  idEntidad)
        {
            return _appContext.Entidad.FirstOrDefault(c => c.Id == idEntidad);   
        }

        IEnumerable<Entidad> IRepositorioEntidad.GetAllEntidad()
        {
            return _appContext.Entidad;
        }
    }
}