﻿// <auto-generated />
using LocadoraApp2.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraApp2.Migrations
{
    [DbContext(typeof(LocadoraAppDbContext))]
    [Migration("20241011004820_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocadoraApp2.Classes.Midia", b =>
                {
                    b.Property<int>("MidiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClassificacaoIndicativa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MidiaId");

                    b.ToTable("Midias");
                });
#pragma warning restore 612, 618
        }
    }
}
