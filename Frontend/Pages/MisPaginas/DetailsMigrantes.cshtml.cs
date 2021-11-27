using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Dominio.Entidades;
using Persistencia.AppRepositorios;

namespace Frontend.Pages
{
    public class DetailsMigrantesModel : PageModel
    {
        private readonly IRepositorioMigracion RepositorioMigracion;
        
        public Migrantes Migrantes {set; get;}

        public DetailsMigrantesModel()
        {
            this.RepositorioMigracion = new RepositorioMigracion(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int migrantesId)
        {
            Migrantes = RepositorioMigracion.GetMigrantes(migrantesId);
            if(Migrantes==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
        
    }
}
