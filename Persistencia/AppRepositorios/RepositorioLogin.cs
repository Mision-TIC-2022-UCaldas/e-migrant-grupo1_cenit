using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace Persistencia.AppRepositorios
{
    public class RepositorioLogin : IRepositorioLoginClave
    {
        List<ListaLogin> Migrantes = new List<ListaLogin>()
            {
                new ListaLogin{numero_documento=" ", contraseña=" "},
                
            };     
     
        public bool GetLogin(string numero_documento, string contraseña)
        {
          foreach (ListaLogin adress in Migrantes)
          {

              if (adress.numero_documento == numero_documento){
                  if (adress.contraseña == contraseña){
                      return true;
                  }
              }              
          }
          return false;
        }
    }
}