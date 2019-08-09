﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoSalaoAPI.Models;

namespace ProjetoSalaoAPI.Migrations
{
    [DbContext(typeof(ProjetoSalaoAPIContext))]
    [Migration("20190809023448_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoSalaoAPI.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuar")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Senha");

                    b.HasKey("IdUsuar");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
