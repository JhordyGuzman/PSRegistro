﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PSRegistro;

namespace PSRegistro.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("PSRegistro.MainWindow+Actores", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salario")
                        .HasColumnType("TEXT");

                    b.HasKey("ActorID");

                    b.ToTable("Actores");
                });
#pragma warning restore 612, 618
        }
    }
}
