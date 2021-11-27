using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace Persistencia.AppRepositorios
{
    public class RepositorioLogin : IRepositorioLoginClave
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> acc5bf4c0f0bf9323b381faf1620d392f9019842
                      return true;
                  }
              }              
          }
          return false;
        }
    }
}