//Directivas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Entidades;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public interface IRepositorios
    {
        //contratos o firmas para los metodos Formador        
        Formador AddFormador(Formador formador);
        IEnumerable<Formador> GetAllFormadores(string? searchString);         
        Formador GetFormador(int? idFormador);
        Formador UpdateFormador(Formador formador);
        void DeleteFormador(int idFormador); 

        //contratos o firmas para los metodos Tutor        
        Tutor AddTutor(Tutor tutor);
        IEnumerable<Tutor> GetAllTutores(string? searchString);         
        Tutor GetTutor(int? idTutor);
        Tutor UpdateTutor(Tutor tutor);
        void DeleteTutor(int idTutor); 

        //contratos o firmas para los metodos Estudiante        
        Estudiante AddEstudiante(Estudiante estudiante);
        IEnumerable<Estudiante> GetAllEstudiantes(string? searchString);         
        Estudiante GetEstudiante(int? idEstudiante);
        Estudiante UpdateEstudiante(Estudiante estudiante);
        void DeleteEstudiante(int idEstudiante); 

        //contratos o firmas para los metodos Equipo        
        Equipo AddEquipo(Equipo equipo);
        IEnumerable<Equipo> GetAllEquipos(string? searchString);         
        Equipo GetEquipo(int? idEquipo);
        Equipo UpdateEquipo(Equipo equipo);
        void DeleteEquipo(int idEquipo); 

        //contratos o firmas para los metodos Estado Proyectos        
        EstadoProyecto AddEstadoProyecto(EstadoProyecto estadoProyecto);  //INSERT EN DB
        IEnumerable<EstadoProyecto> GetAllEstadoProyectos(string? searchString);  //SELECT    
        EstadoProyecto GetEstadoProyecto(int? idEstadoProyecto);  //SELECT
        EstadoProyecto UpdateEstadoProyecto(EstadoProyecto estadoProyecto);  //UPDATE 
        void DeleteEstadoProyecto(int idEstadoProyecto);   //DELETE EN LA BD

         //contratos o firmas para los metodos Estado Proyectos        
        EstadoTarea AddEstadoTarea(EstadoTarea estadoTarea);  //INSERT EN DB
        IEnumerable<EstadoTarea> GetAllEstadoTareas(string? searchString);  //SELECT    
        EstadoTarea GetEstadoTarea(int? idEstadoTarea);  //SELECT
        EstadoTarea UpdateEstadoTarea(EstadoTarea estadoTarea);  //UPDATE 
        void DeleteEstadoTarea(int idEstadoTarea);   //DELETE EN LA BD

         //contratos o firmas para los metodos Estado Proyectos        
        Rol AddRol(Rol rol);  //INSERT EN DB
        IEnumerable<Rol> GetAllRoles(string? searchString);  //SELECT    
        Rol GetRol(int? idRol);  //SELECT
        Rol UpdateRol(Rol rol);  //UPDATE 
        void DeleteRol(int idRol);   //DELETE EN LA BD

    } //fin IRepositorios
}



