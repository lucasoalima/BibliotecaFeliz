﻿// <auto-generated />
using BibliotecaFeliz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotecaFeliz.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220930134745_Biblioteca")]
    partial class Biblioteca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("BibliotecaFeliz.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCategoria")
                        .HasColumnType("TEXT");

                    b.Property<int>("QtdEstoqueCategoria")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("BibliotecaFeliz.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Categorias_ID")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Categoria");

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeLivro")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Categorias_ID");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("BibliotecaFeliz.Models.Livro", b =>
                {
                    b.HasOne("BibliotecaFeliz.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("Categorias_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}