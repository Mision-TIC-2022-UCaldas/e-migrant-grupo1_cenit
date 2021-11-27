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
    public class EntidadModel : PageModel
    {
       private readonly IRepositorioEntidad repositorioEntidad;

        public IEnumerable<Entidad> Entidad {get; set;}
        public EntidadModel()
        {
            this.repositorioEntidad = new RepositorioEntidad(new Persistencia.AppContext());            
        }

        public void OnGet(string filtroBusqueda)     
        {
            Entidad = repositorioEntidad.GetAllEntidad();
        } 
    }
}
