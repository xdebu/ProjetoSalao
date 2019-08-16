using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoSalaoAPI.Migrations
{
    public partial class Todas_tabelas_Correto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boleto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodBarra = table.Column<int>(nullable: false),
                    NrDocum = table.Column<int>(nullable: false),
                    Alerta = table.Column<bool>(nullable: false),
                    ValorTotal = table.Column<double>(nullable: false),
                    UsuCadIdUsuar = table.Column<int>(nullable: true),
                    DataCad = table.Column<DateTime>(nullable: false),
                    DataPagto = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boleto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boleto_Usuario_UsuCadIdUsuar",
                        column: x => x.UsuCadIdUsuar,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Saldo = table.Column<double>(nullable: false),
                    ValorCred = table.Column<double>(nullable: false),
                    ValorDeb = table.Column<double>(nullable: false),
                    UsuAberturaIdUsuar = table.Column<int>(nullable: true),
                    DataAbertura = table.Column<DateTime>(nullable: false),
                    UsuFechamentoIdUsuar = table.Column<int>(nullable: true),
                    DataFechamento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caixa_Usuario_UsuAberturaIdUsuar",
                        column: x => x.UsuAberturaIdUsuar,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuar",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Caixa_Usuario_UsuFechamentoIdUsuar",
                        column: x => x.UsuFechamentoIdUsuar,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comissao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FuncionarioId = table.Column<int>(nullable: true),
                    TxComissao = table.Column<double>(nullable: false),
                    DataIni = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    UsuCadIdUsuar = table.Column<int>(nullable: true),
                    DataCad = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comissao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comissao_Pessoas_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comissao_Usuario_UsuCadIdUsuar",
                        column: x => x.UsuCadIdUsuar,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Telefone = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lancamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FuncionarioId = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    ValorTotal = table.Column<double>(nullable: false),
                    UsuCadIdUsuar = table.Column<int>(nullable: true),
                    DataLanc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lancamento_Pessoas_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lancamento_Pessoas_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lancamento_Usuario_UsuCadIdUsuar",
                        column: x => x.UsuCadIdUsuar,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BoletoVenc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NrParcela = table.Column<int>(nullable: false),
                    DataVencto = table.Column<DateTime>(nullable: false),
                    ValorParcela = table.Column<double>(nullable: false),
                    BoletoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoletoVenc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoletoVenc_Boleto_BoletoId",
                        column: x => x.BoletoId,
                        principalTable: "Boleto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemLanc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdServId = table.Column<int>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    Quantidade = table.Column<double>(nullable: false),
                    LancamentoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemLanc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemLanc_Lancamento_LancamentoId",
                        column: x => x.LancamentoId,
                        principalTable: "Lancamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemLanc_ProdServ_ProdServId",
                        column: x => x.ProdServId,
                        principalTable: "ProdServ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemLancId = table.Column<int>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    DataMovim = table.Column<DateTime>(nullable: false),
                    UsuMovimIdUsuar = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentacao_ItemLanc_ItemLancId",
                        column: x => x.ItemLancId,
                        principalTable: "ItemLanc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movimentacao_Usuario_UsuMovimIdUsuar",
                        column: x => x.UsuMovimIdUsuar,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boleto_UsuCadIdUsuar",
                table: "Boleto",
                column: "UsuCadIdUsuar");

            migrationBuilder.CreateIndex(
                name: "IX_BoletoVenc_BoletoId",
                table: "BoletoVenc",
                column: "BoletoId");

            migrationBuilder.CreateIndex(
                name: "IX_Caixa_UsuAberturaIdUsuar",
                table: "Caixa",
                column: "UsuAberturaIdUsuar");

            migrationBuilder.CreateIndex(
                name: "IX_Caixa_UsuFechamentoIdUsuar",
                table: "Caixa",
                column: "UsuFechamentoIdUsuar");

            migrationBuilder.CreateIndex(
                name: "IX_Comissao_FuncionarioId",
                table: "Comissao",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comissao_UsuCadIdUsuar",
                table: "Comissao",
                column: "UsuCadIdUsuar");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_PessoaId",
                table: "Contato",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLanc_LancamentoId",
                table: "ItemLanc",
                column: "LancamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLanc_ProdServId",
                table: "ItemLanc",
                column: "ProdServId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_ClienteId",
                table: "Lancamento",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_FuncionarioId",
                table: "Lancamento",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_UsuCadIdUsuar",
                table: "Lancamento",
                column: "UsuCadIdUsuar");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_ItemLancId",
                table: "Movimentacao",
                column: "ItemLancId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_UsuMovimIdUsuar",
                table: "Movimentacao",
                column: "UsuMovimIdUsuar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoletoVenc");

            migrationBuilder.DropTable(
                name: "Caixa");

            migrationBuilder.DropTable(
                name: "Comissao");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Movimentacao");

            migrationBuilder.DropTable(
                name: "Boleto");

            migrationBuilder.DropTable(
                name: "ItemLanc");

            migrationBuilder.DropTable(
                name: "Lancamento");
        }
    }
}
