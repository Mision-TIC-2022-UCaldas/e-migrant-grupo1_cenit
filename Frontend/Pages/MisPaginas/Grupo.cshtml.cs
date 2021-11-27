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
    public class GrupoModel : PageModel
    {
        
        private readonly IRepositorioGrupo repositorioGrupo;

        public IEnumerable<Grupo> Grupo {get; set;}
        public GrupoModel()
        {
            this.repositorioGrupo = new RepositorioGrupo(new Persistencia.AppContext());            
        }

        public void OnGet(string filtroBusqueda)     
        {
            Grupo = repositorioGrupo.GetAllGrupo();
        }  
    }
}
