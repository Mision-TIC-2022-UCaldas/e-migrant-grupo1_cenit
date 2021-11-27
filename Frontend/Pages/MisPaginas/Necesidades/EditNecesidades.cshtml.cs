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
    public class EditNecesidadesModel : PageModel
    {
    private readonly IRepositorioNecesidades repositorioNecesidades;
        [BindProperty]

        public Necesidades Necesidades {set; get;}

        public EditNecesidadesModel ()
        {
            this.repositorioNecesidades = new RepositorioNecesidades(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? necesidadesId)
        {
            if (necesidadesId.HasValue)
            {
                Necesidades = repositorioNecesidades.GetNecesidades(necesidadesId.Value);
            }
            else 
            {
                Necesidades = new Necesidades();
            }
            if (Necesidades == null)
            {
                return RedirectToPage("./Notfound");                
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
            if (Necesidades.Id>0)
            {
                Necesidades= repositorioNecesidades.UpdateNecesidades(Necesidades);
            }
            else
            {
                repositorioNecesidades.AddNecesidades(Necesidades);
            }
            return Page();
        }        
        
    }
}
