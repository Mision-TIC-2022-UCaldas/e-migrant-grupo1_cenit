using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;
 
namespace  Persistencia.AppRepositorios
{
    public interface IRepositorioNecesidades
    {
        IEnumerable<Necesidades> GetAllNecesidades();
 
        //Agregar necesidades
        Necesidades AddNecesidades(Necesidades necesidades);
 
        //Actualizar necesidades
        Necesidades UpdateNecesidades(Necesidades necesidades);
 
        //Eliminar necesidades
        void DeleteNecesidades(int idNecesidades);
 
        //Mostrar necesidades
        Necesidades GetNecesidades(int  idNecesidades);
    }
}
