using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace  Persistencia.AppRepositorios
{
    public interface IRepositorioServicios
    {
        IEnumerable<Servicios> GetAllServicios();

        Servicios AddServicios(Servicios servicios);

        Servicios UpdateServicios(Servicios servicios);

        void DeleteServicios(int idServicios);

        Servicios GetServicios(int  idServicios);
    }
}