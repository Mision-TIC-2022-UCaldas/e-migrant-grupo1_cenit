using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;



namespace Persistencia.AppRepositorios
{
    public class RepositorioGrupo:IRepositorioGrupo
    {
        private readonly AppContext _appContext; 

        public RepositorioGrupo(AppContext appContext) 
        {
            _appContext = appContext;
        }   

        Grupo IRepositorioGrupo.AddGrupo(Grupo grupo)
        {
            var grupoAdicionado = _appContext.Grupo.Add(grupo);
            _appContext.SaveChanges();
            return grupoAdicionado.Entity;
        }

        Grupo IRepositorioGrupo.UpdateGrupo(Grupo grupo)
        {
            var grupoAdicionado = _appContext.Grupo.FirstOrDefault(c => c.Id == grupo.Id);
            if (grupoAdicionado!= null)
            {
                grupoAdicionado.tipo_documento = grupo.tipo_documento;
                grupoAdicionado.numero_documento = grupo.numero_documento;
                grupoAdicionado.nombre= grupo.nombre;
                grupoAdicionado.apellidos= grupo.apellidos;
                grupoAdicionado.telefono = grupo.telefono;
                grupoAdicionado.correo = grupo.correo;
                grupoAdicionado.cercania = grupo.cercania;
                
                _appContext.SaveChanges();                                        
            }
            return grupoAdicionado;
                    
        }

        void IRepositorioGrupo.DeleteGrupo(int idMigrantes)
        {
            var grupoEncontrada = _appContext.Grupo.FirstOrDefault(c => c.Id == idMigrantes);
            if (grupoEncontrada == null)
            return;
            _appContext.Grupo.Remove(grupoEncontrada);
            _appContext.SaveChanges();   
        }

         Grupo IRepositorioGrupo.GetGrupo(int  idMigrantes)
        {
            return _appContext.Grupo.FirstOrDefault(c => c.Id == idMigrantes);   
        }

        IEnumerable<Grupo> IRepositorioGrupo.GetAllGrupo()
        {
            return _appContext.Grupo;
        }

    }
}