using System;

namespace Dominio.Entidades
{
    public class ListaLogin:Migrantes
    {
        public int Id {get; set;}       
        public string User {get; set;}
        public string Pass {get; set;}        
    }
}