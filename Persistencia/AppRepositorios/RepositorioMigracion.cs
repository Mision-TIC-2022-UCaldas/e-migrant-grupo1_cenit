using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace  Persistencia.AppRepositorios
{
    public class RepositorioMigracion : IRepositorioMigracion
    {
        private readonly AppContext _appContext; 

        public RepositorioMigracion(AppContext appContext) 
        {
            _appContext = appContext;
        }   

        Migrantes IRepositorioMigracion.AddMigrantes(Migrantes migrantes)
        {
            var migrantesAdicionado = _appContext.Migrantes.Add(migrantes);
            _appContext.SaveChanges();
            return migrantesAdicionado.Entity;
        }

        Migrantes IRepositorioMigracion.UpdateMigrantes(Migrantes migrantes)
        {
            var migrantesAdicionado = _appContext.Migrantes.FirstOrDefault(c => c.Id == migrantes.Id);
            if (migrantesAdicionado!= null)
            {
                migrantesAdicionado.nombre = migrantes.nombre;
                migrantesAdicionado.apellidos = migrantes.apellidos;
                migrantesAdicionado.tipo_documento = migrantes.tipo_documento;
                migrantesAdicionado.numero_documento = migrantes.numero_documento;
                migrantesAdicionado.pais = migrantes.pais;
                migrantesAdicionado.fecha_nacimiento = migrantes.fecha_nacimiento;
                migrantesAdicionado.correo = migrantes.correo;
                migrantesAdicionado.telefono = migrantes.telefono;
                migrantesAdicionado.direccion = migrantes.direccion;
                migrantesAdicionado.ciudad = migrantes.ciudad;
                migrantesAdicionado.situacion_laboral = migrantes.situacion_laboral;
                migrantesAdicionado.contraseña=migrantes.contraseña;

                _appContext.SaveChanges();                                        
            }
            return migrantesAdicionado;
                    
        }

        void IRepositorioMigracion.DeleteMigrantes(int idMigrantes)
        {
            var migrantesEncontrada = _appContext.Migrantes.FirstOrDefault(c => c.Id == idMigrantes);
            if (migrantesEncontrada == null)
            return;
            _appContext.Migrantes.Remove(migrantesEncontrada);
            _appContext.SaveChanges();   
        }

         Migrantes IRepositorioMigracion.GetMigrantes(int  idMigrantes)
        {
            return _appContext.Migrantes.FirstOrDefault(c => c.Id == idMigrantes);   
        }

        IEnumerable<Migrantes> IRepositorioMigracion.GetAllMigrantes()
        {
            return _appContext.Migrantes;
        }




    }
}