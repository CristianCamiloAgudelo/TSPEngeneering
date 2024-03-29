﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftMan_TSPEnginner.Data;

namespace SoftMan_TSPEnginner.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191119185952_MigracionPlanGrupalActualizacion6")]
    partial class MigracionPlanGrupalActualizacion6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SoftMan_TSPEnginner.Models.PlanGrupal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("PlanGrupal");
                });

            modelBuilder.Entity("SoftMan_TSPEnginner.Models.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPlanGrupalId");

                    b.Property<string>("MinutosLiderCalidad")
                        .IsRequired();

                    b.Property<string>("MinutosLiderDesarrollo")
                        .IsRequired();

                    b.Property<string>("MinutosLiderPlaneacion")
                        .IsRequired();

                    b.Property<string>("MinutosLiderProyecto")
                        .IsRequired();

                    b.Property<string>("MinutosLiderSoporte")
                        .IsRequired();

                    b.Property<string>("MinutosTotales");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int?>("planGrupalId");

                    b.HasKey("Id");

                    b.HasIndex("planGrupalId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("SoftMan_TSPEnginner.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Codigo")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Rol")
                        .IsRequired();

                    b.Property<string>("Universidad")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SoftMan_TSPEnginner.Models.Tarea", b =>
                {
                    b.HasOne("SoftMan_TSPEnginner.Models.PlanGrupal", "planGrupal")
                        .WithMany("tareas")
                        .HasForeignKey("planGrupalId");
                });
#pragma warning restore 612, 618
        }
    }
}
