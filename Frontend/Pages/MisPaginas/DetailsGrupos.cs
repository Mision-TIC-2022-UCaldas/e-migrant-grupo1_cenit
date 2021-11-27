using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace Frontend.Pages
{
    public class DetailsGrupoModel : PageModel
    {
    private readonly IRepositorioGrupo RepositorioGrupo;
        
        public Grupo Grupo {set; get;}

        public DetailsGrupoModel()
        {
            this.RepositorioGrupo = new RepositorioGrupo(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int grupoId)
        {
            Grupo = RepositorioGrupo.GetGrupo(grupoId);
            if(Grupo==null)
            {
                return RedirectToPage("./Login");
            }
            else
            {
                return Page();
            }
        }
        
    }
}
