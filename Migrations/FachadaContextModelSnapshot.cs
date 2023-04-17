﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoSemana5.Context;

#nullable disable

namespace ProyectoSemana5.Migrations
{
    [DbContext(typeof(FachadaContext))]
    partial class FachadaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoSemana5.Models.Cita", b =>
                {
                    b.Property<long>("citaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("citaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("citaId"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("DateTime")
                        .HasColumnName("fecha");

                    b.Property<long>("medicoId")
                        .HasColumnType("bigint")
                        .HasColumnName("medicoId");

                    b.Property<long>("usuarioId")
                        .HasColumnType("bigint")
                        .HasColumnName("usuarioId");

                    b.HasKey("citaId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("ProyectoSemana5.Models.Medico", b =>
                {
                    b.Property<long>("medicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("medicoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("medicoId"));

                    b.Property<DateTime>("fechaContrato")
                        .HasColumnType("DateTime")
                        .HasColumnName("fechaContrato");

                    b.Property<long>("personaId")
                        .HasColumnType("bigint")
                        .HasColumnName("personaId");

                    b.Property<int>("tipoMedicoId")
                        .HasColumnType("int")
                        .HasColumnName("tipoMedicoId");

                    b.HasKey("medicoId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("ProyectoSemana5.Models.Persona", b =>
                {
                    b.Property<long>("personaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("personaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("personaId"));

                    b.Property<long>("cedula")
                        .HasColumnType("bigint")
                        .HasColumnName("cedula");

                    b.Property<string>("celular")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("celular");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("direccion");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombreintegrado");

                    b.HasKey("personaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("ProyectoSemana5.Models.TipoMedico", b =>
                {
                    b.Property<int>("tipoMedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tipoMedicoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tipoMedicoId"));

                    b.Property<string>("cargo")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("cargo");

                    b.HasKey("tipoMedicoId");

                    b.ToTable("TipoMedicos");
                });

            modelBuilder.Entity("ProyectoSemana5.Models.TipoServicio", b =>
                {
                    b.Property<int>("TipoServicioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoServicioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoServicioId"));

                    b.Property<string>("descripcionPlan")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descripcionPlan");

                    b.HasKey("TipoServicioId");

                    b.ToTable("TipoServicios");
                });

            modelBuilder.Entity("ProyectoSemana5.Models.Usuario", b =>
                {
                    b.Property<long>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("usuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("usuarioId"));

                    b.Property<int>("TipoServicioId")
                        .HasColumnType("int")
                        .HasColumnName("TipoServicioId");

                    b.Property<DateTime>("fechaIngreso")
                        .HasColumnType("DateTime")
                        .HasColumnName("fechaIngreso");

                    b.Property<long>("personaId")
                        .HasColumnType("bigint")
                        .HasColumnName("personaId");

                    b.HasKey("usuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
