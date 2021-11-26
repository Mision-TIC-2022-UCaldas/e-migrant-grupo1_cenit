using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace  Persistencia.AppRepositorios
{
    public interface IRepositorioMigracion
    {
        IEnumerable<Migrantes> GetAllMigrantes();

        Migrantes AddMigrantes(Migrantes migrantes);

        Migrantes UpdateMigrantes(Migrantes migrantes);

        void DeleteMigrantes(int idMigrantes);

        Migrantes GetMigrantes(int  idMigrantes);
    }
}