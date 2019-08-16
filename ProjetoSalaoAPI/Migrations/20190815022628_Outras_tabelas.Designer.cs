﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoSalaoAPI.Models;

namespace ProjetoSalaoAPI.Migrations
{
    [DbContext(typeof(ProjetoSalaoAPIContext))]
    [Migration("20190815022628_Outras_tabelas")]
    partial class Outras_tabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoSalaoAPI.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataReserva");

                    b.Property<int?>("FuncionarioId");

                    b.Property<int?>("PessoasId");

                    b.Property<int?>("UsuCadIdUsuar");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("PessoasId");

                    b.HasIndex("UsuCadIdUsuar");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("ProjetoSalaoAPI.Models.AgendaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AgendaId");

                    b.Property<int?>("ProdServId");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("ProdServId");

                    b.ToTable("AgendaItem");
                });

            modelBuilder.Entity("ProjetoSalaoAPI.Models.Pessoas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cpf");

                    b.Property<DateTime>("DataCad");

                    b.Property<DateTime>("DataNasc");

                    b.Property<string>("Nome");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("ProjetoSalaoAPI.Models.ProdServ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<double>("QtdeEstoque");

                    b.Property<int>("Tipo");

                    b.Property<int?>("UsuCadIdUsuar");

                    b.Property<double>("ValorUnit");

                    b.HasKey("Id");

                    b.HasIndex("UsuCadIdUsuar");

                    b.ToTable("ProdServ");
                });

            modelBuilder.Entity("ProjetoSalaoAPI.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuar")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Senha");

                    b.HasKey("IdUsuar");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoSalaoAPI.Models.Agenda", b =>
                {
                    b.HasOne("ProjetoSalaoAPI.Models.Pessoas", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("ProjetoSalaoAPI.Models.Pessoas", "Pessoas")
                        .WithMany()
                        .HasForeignKey("PessoasId");

                    b.HasOne("ProjetoSalaoAPI.Models.Usuario", "UsuCad")
                        .WithMany()
                        .HasForeignKey("UsuCadIdUsuar");
                });

            modelBuilder.Entity("ProjetoSalaoAPI.Models.AgendaItem", b =>
                {
                    b.HasOne("ProjetoSalaoAPI.Models.Agenda", "Agenda")
                        .WithMany("AgendaItem")
                        .HasForeignKey("AgendaId");

                    b.HasOne("ProjetoSalaoAPI.Models.ProdServ", "ProdServ")
                        .WithMany()
                        .HasForeignKey("ProdServId");
                });

            modelBuilder.Entity("ProjetoSalaoAPI.Models.ProdServ", b =>
                {
                    b.HasOne("ProjetoSalaoAPI.Models.Usuario", "UsuCad")
                        .WithMany()
                        .HasForeignKey("UsuCadIdUsuar");
                });
#pragma warning restore 612, 618
        }
    }
}
