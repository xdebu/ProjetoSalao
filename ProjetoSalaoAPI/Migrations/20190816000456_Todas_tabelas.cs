using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoSalaoAPI.Migrations
{
    public partial class Todas_tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdServ_Usuario_UsuCadIdUsuar",
                table: "ProdServ");

            migrationBuilder.RenameColumn(
                name: "UsuCadIdUsuar",
                table: "ProdServ",
                newName: "UsuAtuIdUsuar");

            migrationBuilder.RenameIndex(
                name: "IX_ProdServ_UsuCadIdUsuar",
                table: "ProdServ",
                newName: "IX_ProdServ_UsuAtuIdUsuar");

            migrationBuilder.AddColumn<int>(
                name: "TipoUsuario",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtu",
                table: "ProdServ",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtu",
                table: "Pessoas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UsuAtuIdUsuar",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCad",
                table: "Agenda",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_UsuAtuIdUsuar",
                table: "Pessoas",
                column: "UsuAtuIdUsuar");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Usuario_UsuAtuIdUsuar",
                table: "Pessoas",
                column: "UsuAtuIdUsuar",
                principalTable: "Usuario",
                principalColumn: "IdUsuar",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdServ_Usuario_UsuAtuIdUsuar",
                table: "ProdServ",
                column: "UsuAtuIdUsuar",
                principalTable: "Usuario",
                principalColumn: "IdUsuar",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Usuario_UsuAtuIdUsuar",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdServ_Usuario_UsuAtuIdUsuar",
                table: "ProdServ");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_UsuAtuIdUsuar",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "TipoUsuario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DataAtu",
                table: "ProdServ");

            migrationBuilder.DropColumn(
                name: "DataAtu",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "UsuAtuIdUsuar",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DataCad",
                table: "Agenda");

            migrationBuilder.RenameColumn(
                name: "UsuAtuIdUsuar",
                table: "ProdServ",
                newName: "UsuCadIdUsuar");

            migrationBuilder.RenameIndex(
                name: "IX_ProdServ_UsuAtuIdUsuar",
                table: "ProdServ",
                newName: "IX_ProdServ_UsuCadIdUsuar");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdServ_Usuario_UsuCadIdUsuar",
                table: "ProdServ",
                column: "UsuCadIdUsuar",
                principalTable: "Usuario",
                principalColumn: "IdUsuar",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
