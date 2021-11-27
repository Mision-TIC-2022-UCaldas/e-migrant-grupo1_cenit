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
    public class EditEntidadModel : PageModel
    {
private readonly IRepositorioEntidad repositorioEntidad;
        [BindProperty]

        public Entidad Entidad {set; get;}

        public EditEntidadModel ()
        {
            this.repositorioEntidad = new RepositorioEntidad(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? entidadId)
        {
            if (entidadId.HasValue)
            {
                Entidad = repositorioEntidad.GetEntidad(entidadId.Value);
            }
            else 
            {
                Entidad = new Entidad();
            }
            if (Entidad == null)
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
            if (Entidad.Id>0)
            {
                Entidad= repositorioEntidad.UpdateEntidad(Entidad);
            }
            else
            {
                repositorioEntidad.AddEntidad(Entidad);
            }
            return Page();
        }  
    }
}
