﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyectos.App.Dominio.Entidades.Equipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estadoProyecto")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("formador")
                        .HasColumnType("int");

                    b.Property<string>("meet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tutor")
                        .HasColumnType("int");

                    b.Property<bool>("vigente")
                        .HasColumnType("bit");

                    b.Property<string>("whatsapp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("equipo");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Entidades.EstadoProyecto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("estadoProyecto");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Entidades.EstadoTarea", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("estadoTarea");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Entidades.Estudiante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("vigente")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("estudiante");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Entidades.Formador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("vigente")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("formador");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Entidades.Rol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("vigente")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("rol");
                });

            modelBuilder.Entity("Proyectos.App.Dominio.Entidades.Tutor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("vigente")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("tutor");
                });
#pragma warning restore 612, 618
        }
    }
}