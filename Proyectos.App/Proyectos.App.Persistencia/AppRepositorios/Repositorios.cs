using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public class Repositorios : IRepositorios
    {
       private readonly AppContext _appContext;
       public IEnumerable<Formador> formadores {get; set;} 
       public IEnumerable<Tutor> tutores {get; set;} 
       public IEnumerable<Estudiante> estudiantes {get; set;} 
       public IEnumerable<Equipo> equipos {get; set;} 
       public IEnumerable<EstadoProyecto> estadoProyectos {get; set;} 
       public IEnumerable<EstadoTarea> estadoTareas {get; set;} 
       public IEnumerable<Rol> roles {get; set;} 

       public Repositorios(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        //AQUÍ CADA UNO DE LOS MÉTODOS DEL CRUD, REFERENCIADOS EN LA INTERFACE
        //SIGUIENTE DIAPOSITIVA

        Formador IRepositorios.AddFormador(Formador formador)
        {
        try
         {
            var FormadorAdicionado = _appContext.formador.Add( formador );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return FormadorAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Formador> IRepositorios.GetAllFormadores(string? searchString)
        {
            if (searchString == null)
                formadores = _appContext.formador;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                formadores = _appContext.formador.Where(s => s.identificacion.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                //formadores = _appContext.formador.Where(s => s.identificacion.Equals(searchString));    
            }
            return formadores;
        }

       Formador IRepositorios.GetFormador(int? idFormador)
       {
            return _appContext.formador.FirstOrDefault(p => p.id == idFormador);
       }

       Formador IRepositorios.UpdateFormador(Formador formador)
        {    
            var FormadorEncontrado = _appContext.formador.FirstOrDefault(p => p.id == formador.id);
            if (FormadorEncontrado != null)
            {
                FormadorEncontrado.identificacion  = formador.identificacion;
                FormadorEncontrado.nombre          = formador.nombre;
                FormadorEncontrado.mail            = formador.mail;
                FormadorEncontrado.movil           = formador.movil;
                FormadorEncontrado.vigente         = formador.vigente;
                _appContext.SaveChanges();
            }
            return FormadorEncontrado;
        }

        void IRepositorios.DeleteFormador(int idFormador)
        {   
            var FormadorEncontrado = _appContext.formador.FirstOrDefault(p => p.id == idFormador);
            if (FormadorEncontrado != null){                
                _appContext.formador.Remove(FormadorEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

        //repositorio para tutores
        Tutor IRepositorios.AddTutor(Tutor tutor)
        {
        try
         {
            var TutorAdicionado = _appContext.tutor.Add( tutor );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return TutorAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Tutor> IRepositorios.GetAllTutores(string? searchString)
        {
            if (searchString == null)
                tutores = _appContext.tutor;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                //tutores = _appContext.tutor.Where(s => s.identificacion.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                tutores = _appContext.tutor.Where(s => s.identificacion.Equals(searchString));    
            }
            return tutores;
        }

       Tutor IRepositorios.GetTutor(int? idTutor)
       {
            return _appContext.tutor.FirstOrDefault(p => p.id == idTutor);
       }

       Tutor IRepositorios.UpdateTutor(Tutor tutor)
        {    
            var TutorEncontrado = _appContext.tutor.FirstOrDefault(p => p.id == tutor.id);
            if (TutorEncontrado != null)
            {
                TutorEncontrado.identificacion  = tutor.identificacion;
                TutorEncontrado.nombre          = tutor.nombre;
                TutorEncontrado.mail            = tutor.mail;
                TutorEncontrado.movil           = tutor.movil;
                TutorEncontrado.vigente         = tutor.vigente;
                _appContext.SaveChanges();
            }
            return TutorEncontrado;
        }

        void IRepositorios.DeleteTutor(int idTutor)
        {   
            var TutorEncontrado = _appContext.tutor.FirstOrDefault(p => p.id == idTutor);
            if (TutorEncontrado != null){                
                _appContext.tutor.Remove(TutorEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

        //repositorio para estudiantes
        Estudiante IRepositorios.AddEstudiante(Estudiante estudiante)
        {
        try
         {
            var EstudianteAdicionado = _appContext.estudiante.Add( estudiante );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return EstudianteAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Estudiante> IRepositorios.GetAllEstudiantes(string? searchString)
        {
            if (searchString == null)
                estudiantes = _appContext.estudiante;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                //estudiantes = _appContext.estudiante.Where(s => s.identificacion.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                estudiantes = _appContext.estudiante.Where(s => s.identificacion.Equals(searchString));    
            }
            return estudiantes;
        }

       Estudiante IRepositorios.GetEstudiante(int? idEstudiante)
       {
            return _appContext.estudiante.FirstOrDefault(p => p.id == idEstudiante);
       }

       Estudiante IRepositorios.UpdateEstudiante(Estudiante estudiante)
        {    
            var EstudianteEncontrado = _appContext.estudiante.FirstOrDefault(p => p.id == estudiante.id);
            if (EstudianteEncontrado != null)
            {
                EstudianteEncontrado.identificacion  = estudiante.identificacion;
                EstudianteEncontrado.nombre          = estudiante.nombre;
                EstudianteEncontrado.mail            = estudiante.mail;
                EstudianteEncontrado.movil           = estudiante.movil;
                EstudianteEncontrado.vigente         = estudiante.vigente;
                _appContext.SaveChanges();
            }
            return EstudianteEncontrado;
        }

        void IRepositorios.DeleteEstudiante(int idEstudiante)
        {   
            var EstudianteEncontrado = _appContext.estudiante.FirstOrDefault(p => p.id == idEstudiante);
            if (EstudianteEncontrado != null){                
                _appContext.estudiante.Remove(EstudianteEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

        //repositorio para equipos
        Equipo IRepositorios.AddEquipo(Equipo equipo)
        {
        try
         {
            var EquipoAdicionado = _appContext.equipo.Add( equipo );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return EquipoAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Equipo> IRepositorios.GetAllEquipos(string? searchString)
        {
            if (searchString == null)
                equipos = _appContext.equipo;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                //equipos = _appContext.equipo.Where(s => s.identificacion.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                equipos = _appContext.equipo.Where(s => s.codigo.Equals(searchString));    
            }
            return equipos;
        }

       Equipo IRepositorios.GetEquipo(int? idEquipo)
       {
            return _appContext.equipo.FirstOrDefault(p => p.id == idEquipo);
       }

       Equipo IRepositorios.UpdateEquipo(Equipo equipo)
        {    
            var EquipoEncontrado = _appContext.equipo.FirstOrDefault(p => p.id == equipo.id);
            if (EquipoEncontrado != null)
            {
                EquipoEncontrado.codigo  = equipo.codigo;
                EquipoEncontrado.nombre          = equipo.nombre;
                EquipoEncontrado.meet            = equipo.meet;
                EquipoEncontrado.whatsapp        = equipo.whatsapp;
                EquipoEncontrado.formador        = equipo.formador;
                EquipoEncontrado.tutor           = equipo.tutor;
                EquipoEncontrado.estadoProyecto  = equipo.estadoProyecto;
                EquipoEncontrado.vigente         = equipo.vigente;
                _appContext.SaveChanges();
            }
            return EquipoEncontrado;
        }

        void IRepositorios.DeleteEquipo(int idEquipo)
        {   
            var EquipoEncontrado = _appContext.equipo.FirstOrDefault(p => p.id == idEquipo);
            if (EquipoEncontrado != null){                
                _appContext.equipo.Remove(EquipoEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

         //repositorio para estadoProyectos
        EstadoProyecto IRepositorios.AddEstadoProyecto(EstadoProyecto estadoProyecto)
        {
        try
         {
            var EstadoProyectoAdicionado = _appContext.estadoProyecto.Add( estadoProyecto );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return EstadoProyectoAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<EstadoProyecto> IRepositorios.GetAllEstadoProyectos(string? searchString)
        {
            if (searchString == null)
                estadoProyectos = _appContext.estadoProyecto;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                estadoProyectos = _appContext.estadoProyecto.Where(s => s.nombre.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                //estadoProyectos = _appContext.estadoProyecto.Where(s => s.nombre.Equals(searchString));    
            }
            return estadoProyectos;
        }

       EstadoProyecto IRepositorios.GetEstadoProyecto(int? idEstadoProyecto)
       {
            return _appContext.estadoProyecto.FirstOrDefault(p => p.id == idEstadoProyecto);
       }

       EstadoProyecto IRepositorios.UpdateEstadoProyecto(EstadoProyecto estadoProyecto)
        {    
            var EstadoProyectoEncontrado = _appContext.estadoProyecto.FirstOrDefault(p => p.id == estadoProyecto.id);
            if (EstadoProyectoEncontrado != null)
            {                
                EstadoProyectoEncontrado.nombre = estadoProyecto.nombre;
                _appContext.SaveChanges();
            }
            return EstadoProyectoEncontrado;
        }

        void IRepositorios.DeleteEstadoProyecto(int idEstadoProyecto)
        {   
            var EstadoProyectoEncontrado = _appContext.estadoProyecto.FirstOrDefault(p => p.id == idEstadoProyecto);
            if (EstadoProyectoEncontrado != null){                
                _appContext.estadoProyecto.Remove(EstadoProyectoEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

        //repositorios de Estados tarea
        EstadoTarea IRepositorios.AddEstadoTarea(EstadoTarea estadoTarea)
        {
        try
         {
            var EstadoTareaAdicionado = _appContext.estadoTarea.Add( estadoTarea );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return EstadoTareaAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<EstadoTarea> IRepositorios.GetAllEstadoTareas(string? searchString)
        {
            if (searchString == null)
                estadoTareas = _appContext.estadoTarea;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                estadoTareas = _appContext.estadoTarea.Where(s => s.nombre.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                //estadoTareas = _appContext.estadoTarea.Where(s => s.nombre.Equals(searchString));    
            }
            return estadoTareas;
        }

       EstadoTarea IRepositorios.GetEstadoTarea(int? idEstadoTarea)
       {
            return _appContext.estadoTarea.FirstOrDefault(p => p.id == idEstadoTarea);
       }

       EstadoTarea IRepositorios.UpdateEstadoTarea(EstadoTarea estadoTarea)
        {    
            var EstadoTareaEncontrado = _appContext.estadoTarea.FirstOrDefault(p => p.id == estadoTarea.id);
            if (EstadoTareaEncontrado != null)
            {
                EstadoTareaEncontrado.nombre = estadoTarea.nombre;
                _appContext.SaveChanges();
            }
            return EstadoTareaEncontrado;
        }

        void IRepositorios.DeleteEstadoTarea(int idEstadoTarea)
        {   
            var EstadoTareaEncontrado = _appContext.estadoTarea.FirstOrDefault(p => p.id == idEstadoTarea);
            if (EstadoTareaEncontrado != null){                
                _appContext.estadoTarea.Remove(EstadoTareaEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

        //REPOSITORIOS PARA EL CRUD DEL ROL
        Rol IRepositorios.AddRol(Rol rol)
        {
        try
         {
            var RolAdicionado = _appContext.rol.Add( rol );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return RolAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Rol> IRepositorios.GetAllRoles(string? searchString)
        {
            if (searchString == null)
                roles = _appContext.rol;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                roles = _appContext.rol.Where(s => s.nombre.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                //roles = _appContext.rol.Where(s => s.identificacion.Equals(searchString));    
            }
            return roles;
        }

       Rol IRepositorios.GetRol(int? idRol)
       {
            return _appContext.rol.FirstOrDefault(p => p.id == idRol);
       }

       Rol IRepositorios.UpdateRol(Rol rol)
        {    
            var RolEncontrado = _appContext.rol.FirstOrDefault(p => p.id == rol.id);
            if (RolEncontrado != null)
            {
                RolEncontrado.nombre          = rol.nombre;
                RolEncontrado.descripcion     = rol.descripcion;
                RolEncontrado.vigente         = rol.vigente;
                _appContext.SaveChanges();
            }
            return RolEncontrado;
        }

        void IRepositorios.DeleteRol(int idRol)
        {   
            var RolEncontrado = _appContext.rol.FirstOrDefault(p => p.id == idRol);
            if (RolEncontrado != null){                
                _appContext.rol.Remove(RolEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

    } //fin repositorios
}

