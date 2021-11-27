﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211127020911_aaaaa")]
    partial class aaaaa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dominio.Entidades.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cercania")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero_documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefono")
                        .HasColumnType("int");

                    b.Property<string>("tipo_documento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("Dominio.Entidades.Migrantes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha_nacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numero_documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("situacion_laboral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_documento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Migrantes");
                });

            modelBuilder.Entity("Dominio.Entidades.Necesidades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alimentacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alojamiento_permanente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alojamiento_temporal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ayuda_legal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion_Alimentacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion_Alojamiento_permanente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion_Alojamiento_temporal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion_Ayuda_legal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion_Educacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion_Empleo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion_Salud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Educacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empleo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salud")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Necesidades");
                });
#pragma warning restore 612, 618
        }
    }
}
