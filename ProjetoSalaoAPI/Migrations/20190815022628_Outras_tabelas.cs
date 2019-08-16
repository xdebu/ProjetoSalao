using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoSalaoAPI.Migrations
{
    public partial class Outras_tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataNasc = table.Column<DateTime>(nullable: false),
                    Cpf = table.Column<int>(nullable: false),
                    DataCad = table.Column<DateTime>(nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdServ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    ValorUnit = table.Column<double>(nullable: false),
                    QtdeEstoque = table.Column<double>(nullable: false),
                    UsuCadIdUsuar = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdServ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdServ_Usuario_UsuCadIdUsuar",
                        column: x => x.UsuCadIdUsuar,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PessoasId = table.Column<int>(nullable: true),
                    DataReserva = table.Column<DateTime>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: true),
                    UsuCadIdUsuar = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_Pessoas_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agenda_Pessoas_PessoasId",
                        column: x => x.PessoasId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agenda_Usuario_UsuCadIdUsuar",
                        column: x => x.UsuCadIdUsuar,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgendaItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AgendaId = table.Column<int>(nullable: true),
                    ProdServId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgendaItem_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgendaItem_ProdServ_ProdServId",
                        column: x => x.ProdServId,
                        principalTable: "ProdServ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_FuncionarioId",
                table: "Agenda",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_PessoasId",
                table: "Agenda",
                column: "PessoasId");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_UsuCadIdUsuar",
                table: "Agenda",
                column: "UsuCadIdUsuar");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaItem_AgendaId",
                table: "AgendaItem",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaItem_ProdServId",
                table: "AgendaItem",
                column: "ProdServId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdServ_UsuCadIdUsuar",
                table: "ProdServ",
                column: "UsuCadIdUsuar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaItem");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "ProdServ");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
