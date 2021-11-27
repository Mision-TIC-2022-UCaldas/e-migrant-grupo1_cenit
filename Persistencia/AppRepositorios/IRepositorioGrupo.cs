using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioGrupo
    {
        IEnumerable<Grupo> GetAllGrupo();

        Grupo AddGrupo(Grupo grupo);

        Grupo UpdateGrupo(Grupo grupo);

        void DeleteGrupo(int idGrupo);

        Grupo GetGrupo(int  idGrupo);
    }
}