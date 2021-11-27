using System;

namespace Dominio.Entidades
{
    public class Servicios : Necesidades
    {
        public int Id {get;set;}
        
        public string Todos_los_servicios {get;set;}

        public string Disponiblidad {get;set;}

        public string Solicitud {get;set;}


        /*El ejercicio dice que va relacionado con las necesidades de los
        migrantes, creo que se refiere a la herencia*/

        
    }
}