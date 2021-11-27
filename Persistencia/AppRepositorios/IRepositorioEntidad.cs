using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioEntidad
    {

       IEnumerable<Entidad> GetAllEntidad();

        Entidad AddEntidad(Entidad entidad);

        Entidad UpdateEntidad(Entidad entidad);

        void DeleteEntidad(int idEntidad);

        Entidad GetEntidad(int  idEntidad); 
    }
}