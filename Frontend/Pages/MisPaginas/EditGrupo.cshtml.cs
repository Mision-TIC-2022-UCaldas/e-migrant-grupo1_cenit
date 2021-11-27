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
    public class EditGrupoModel : PageModel
    {
 private readonly IRepositorioGrupo repositorioGrupo;
        [BindProperty]

        public Grupo Grupo {set; get;}

        public EditGrupoModel ()
        {
            this.repositorioGrupo = new RepositorioGrupo(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? grupoId)
        {
            if (grupoId.HasValue)
            {
                Grupo = repositorioGrupo.GetGrupo(grupoId.Value);
            }
            else 
            {
                Grupo = new Grupo();
            }
            if (Grupo == null)
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
            if (Grupo.Id>0)
            {
                Grupo= repositorioGrupo.UpdateGrupo(Grupo);
            }
            else
            {
                repositorioGrupo.AddGrupo(Grupo);
            }
            return Page();
        }        
        
    }
}
