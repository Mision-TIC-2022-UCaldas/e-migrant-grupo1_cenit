using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace Persistencia.AppRepositorios
{
    public interface IRepositorioLoginClave
    {
        bool GetLogin(string numero_documento, string Pass);
        //ListaLogin AddListaLogin(ListaLogin listalogin);
        //ListaLogin list22 ();        
    }
}