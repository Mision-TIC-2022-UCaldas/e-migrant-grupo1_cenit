using System;

namespace Dominio.Entidades
{
    public class Migrantes
    {
        public int Id {get; set;}
        public string nombre {get; set;}
        public string apellidos {get; set;}
        public string tipo_documento  {get; set;}
        public string numero_documento  {get; set;}
        public string pais {get; set;}
        public string fecha_nacimiento {get; set;}
        public string correo {get; set;}
        public string telefono {get; set;}
        public string direccion {get; set;}
        public string ciudad {get; set;}
        public string situacion_laboral {get; set;}

        public string contraseña {get; set;}
        
    }
}