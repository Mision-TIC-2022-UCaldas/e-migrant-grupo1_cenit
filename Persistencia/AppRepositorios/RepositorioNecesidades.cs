using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;
 
namespace  Persistencia.AppRepositorios
{
    public class RepositorioNecesidades : IRepositorioNecesidades
    {
        private readonly AppContext _appContext;
 
        //Constructor de necesidades
        public RepositorioNecesidades(AppContext appContext)
        {
            _appContext = appContext;
        }  
 
 
        //Agrego necesidades
        Necesidades IRepositorioNecesidades.AddNecesidades(Necesidades necesidades)
        {
            var necesidadAdicionada = _appContext.Necesidades.Add(necesidades);
            _appContext.SaveChanges();
            return necesidadAdicionada.Entity;
        }
 
        //Actualizo necesidades
        Necesidades IRepositorioNecesidades.UpdateNecesidades(Necesidades necesidades)
        {
            var necesidadAdicionada = _appContext.Necesidades.FirstOrDefault(c => c.Id == necesidades.Id);
            if (necesidadAdicionada!= null)
            {
                necesidadAdicionada.Salud = necesidades.Salud;
                necesidadAdicionada.Clasificacion_Salud = necesidades.Clasificacion_Salud;

                necesidadAdicionada.Alimentacion = necesidades.Alimentacion;
                necesidadAdicionada.Clasificacion_Alimentacion = necesidades.Clasificacion_Alimentacion;

                necesidadAdicionada.Empleo = necesidades.Empleo;
                necesidadAdicionada.Clasificacion_Empleo = necesidades.Clasificacion_Empleo;

                necesidadAdicionada.Alojamiento_temporal = necesidades.Alojamiento_temporal;
                necesidadAdicionada.Clasificacion_Alojamiento_temporal = necesidades.Clasificacion_Alojamiento_temporal;

                necesidadAdicionada.Alojamiento_permanente = necesidades.Alojamiento_permanente;
                necesidadAdicionada.Clasificacion_Alojamiento_permanente = necesidades.Clasificacion_Alojamiento_permanente;

                necesidadAdicionada.Educacion = necesidades.Educacion;
                necesidadAdicionada.Clasificacion_Educacion = necesidades.Clasificacion_Educacion;

                necesidadAdicionada.Ayuda_legal = necesidades.Ayuda_legal;
                necesidadAdicionada.Clasificacion_Ayuda_legal = necesidades.Clasificacion_Ayuda_legal;

 
                //Guardo actualizaciones
                _appContext.SaveChanges();                                        
            }
            return necesidadAdicionada;
                   
        }
 
        //Elimino necesidades
        void IRepositorioNecesidades.DeleteNecesidades(int idMigrantes)
        {
            var necesidadesEncontradas = _appContext.Necesidades.FirstOrDefault(c => c.Id == idMigrantes);
            if (necesidadesEncontradas == null)
            return;
            _appContext.Necesidades.Remove(necesidadesEncontradas);
            _appContext.SaveChanges();  
        }
 
 
         Necesidades IRepositorioNecesidades.GetNecesidades(int idMigrantes)
        {
            return _appContext.Necesidades.FirstOrDefault(c => c.Id == idMigrantes);  
        }
 
        IEnumerable<Necesidades> IRepositorioNecesidades.GetAllNecesidades()
        {
            return _appContext.Necesidades;
        }
 
 
    }
}
