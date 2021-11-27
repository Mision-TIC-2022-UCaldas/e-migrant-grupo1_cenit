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
    public class EditMigrantesModel : PageModel
    {
    private readonly IRepositorioMigracion repositorioMigracion;
        [BindProperty]

        public Migrantes Migrantes {set; get;}

        public EditMigrantesModel ()
        {
            this.repositorioMigracion = new RepositorioMigracion(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? migrantesId)
        {
            if (migrantesId.HasValue)
            {
                Migrantes = repositorioMigracion.GetMigrantes(migrantesId.Value);
            }
            else 
            {
                Migrantes = new Migrantes();
            }
            if (Migrantes == null)
            {
                return RedirectToPage("./Index");                
            }
            else
            {
                return Page();
            }

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Migrantes.Id>0)
            {
                Migrantes= repositorioMigracion.UpdateMigrantes(Migrantes);
            }
            else
            {
                repositorioMigracion.AddMigrantes(Migrantes);
            }
            return Page();
        }        
        
    }
}
