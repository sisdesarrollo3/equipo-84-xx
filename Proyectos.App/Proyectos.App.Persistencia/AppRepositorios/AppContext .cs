using System;
using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio.Entidades;

namespace Proyectos.App.Persistencia
{    
    public class AppContext : DbContext
    {
       /* public AppContext  (DbContextOptions<AppContext> options) : base(options)
        { 

        }*/

        //poner aqui los modelos
        public DbSet<Formador> formador{get; set;}
        public DbSet<Tutor> tutor{get; set;}
        public DbSet<Estudiante> estudiante{get; set;}
        public DbSet<Equipo> equipo{get; set;}
        public DbSet<EstadoProyecto> estadoProyecto{get; set;}


        //crear el deContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder
           .UseSqlServer("Server=localhost; user id=sa; password=12345; Initial Catalog=BDFinalProyectos27;");            
            }
        }      

    }
}