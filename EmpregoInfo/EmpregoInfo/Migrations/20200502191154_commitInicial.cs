using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpregoInfo.Migrations
{
    public partial class commitInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Morada = table.Column<string>(nullable: true),
                    NIF = table.Column<string>(nullable: true),
                    Atividade = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Formacao = table.Column<string>(nullable: true),
                    Experiencia = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true),
                    Data_criacao_conta = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Anuncios",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    ExperienciaNecessaria = table.Column<string>(nullable: true),
                    NomeEmpresa = table.Column<string>(nullable: true),
                    Salario = table.Column<float>(nullable: false),
                    DataCriacaoAnuncio = table.Column<DateTime>(nullable: false),
                    EmpresaFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Anuncios_Empresas_EmpresaFK",
                        column: x => x.EmpresaFK,
                        principalTable: "Empresas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidaturas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCandidatura = table.Column<DateTime>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    AnuncioFK = table.Column<int>(nullable: false),
                    UtilizadorFK = table.Column<int>(nullable: false),
                    EmpresaFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidaturas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Candidaturas_Anuncios_AnuncioFK",
                        column: x => x.AnuncioFK,
                        principalTable: "Anuncios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidaturas_Empresas_EmpresaFK",
                        column: x => x.EmpresaFK,
                        principalTable: "Empresas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidaturas_Utilizadores_UtilizadorFK",
                        column: x => x.UtilizadorFK,
                        principalTable: "Utilizadores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_EmpresaFK",
                table: "Anuncios",
                column: "EmpresaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Candidaturas_AnuncioFK",
                table: "Candidaturas",
                column: "AnuncioFK");

            migrationBuilder.CreateIndex(
                name: "IX_Candidaturas_EmpresaFK",
                table: "Candidaturas",
                column: "EmpresaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Candidaturas_UtilizadorFK",
                table: "Candidaturas",
                column: "UtilizadorFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidaturas");

            migrationBuilder.DropTable(
                name: "Anuncios");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
