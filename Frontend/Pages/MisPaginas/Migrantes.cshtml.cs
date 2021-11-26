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
    public class MigrantesModel : PageModel
    {

        private readonly IRepositorioMigracion repositorioMigracion;

        public IEnumerable<Migrantes> Migrantes {get; set;}
        public MigrantesModel()
        {
            this.repositorioMigracion = new RepositorioMigracion(new Persistencia.AppContext());            
        }

        public void OnGet(string filtroBusqueda)     
        {
            Migrantes = repositorioMigracion.GetAllMigrantes();
        }  
    }
}
