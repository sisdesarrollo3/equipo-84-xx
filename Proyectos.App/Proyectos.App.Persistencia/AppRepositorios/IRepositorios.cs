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

        //contratos o firmas para los metodos Equipo        
        EstadoProyecto AddEstadoProyecto(EstadoProyecto estadoProyecto);
        IEnumerable<EstadoProyecto> GetAllEstadoProyectos(string? searchString);         
        EstadoProyecto GetEstadoProyecto(int? idEstadoProyecto);
        EstadoProyecto UpdateEstadoProyecto(EstadoProyecto estadoProyecto);
        void DeleteEstadoProyecto(int idEstadoProyecto); 

    } //fin IRepositorios
}



