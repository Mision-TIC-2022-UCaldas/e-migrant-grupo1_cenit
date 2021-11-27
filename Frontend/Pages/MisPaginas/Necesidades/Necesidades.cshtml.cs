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
    public class NecesidadesModel : PageModel
    {
 
        private readonly IRepositorioNecesidades repositorioNecesidades;
 
        public IEnumerable<Necesidades> Necesidades {get; set;}
        public NecesidadesModel()
        {
            this.repositorioNecesidades = new RepositorioNecesidades(new Persistencia.AppContext());            
        }
 
        public void OnGet(string filtroBusqueda)    
        {
            Necesidades = repositorioNecesidades.GetAllNecesidades();
        }  
    }
}

