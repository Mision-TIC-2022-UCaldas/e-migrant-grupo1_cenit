using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace Persistencia.AppRepositorios
{
    public class RepositorioLogin : IRepositorioLoginClave
    {
        List<ListaLogin> listado3 = new List<ListaLogin>()
            {
                new ListaLogin{User=" ", Pass=" "},
                
            };     
     
        public bool GetLogin(string user, string pass)
        {
          foreach (ListaLogin adress in listado3)
          {

              if (adress.User == user){
                  if (adress.Pass == pass){
                      return true;
                  }
              }              
          }
          return false;
        }
    }
}