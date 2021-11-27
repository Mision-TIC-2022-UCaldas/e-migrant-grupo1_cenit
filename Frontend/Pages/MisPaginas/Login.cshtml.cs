using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia.AppRepositorios;
namespace Frontend.Pages
{
    public class LoginModel : PageModel
    {
         private readonly IRepositorioLoginClave ObjetoRepositorio;

        public LoginModel(IRepositorioLoginClave Repositorio)
        {
            ObjetoRepositorio = Repositorio;
        }

        public IActionResult OnPost(string numero_documento, string contraseña)
        {
            //User = user;
            //Pass = pass;

            if (ObjetoRepositorio.GetLogin(numero_documento, contraseña))
            {
                return Redirect("./Cuatro");
            }
            else
            {
                //MessageBox.Show("Contraseña Invalidad");
                return Page();
            }


        }
    }
}
