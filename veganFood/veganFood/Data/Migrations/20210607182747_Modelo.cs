using Microsoft.EntityFrameworkCore.Migrations;

namespace veganFood.Data.Migrations
{
    public partial class Modelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fotografia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    IDutilizador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNameId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.IDutilizador);
                });

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    IDreceita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModoPreparo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutorFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.IDreceita);
                    table.ForeignKey(
                        name: "FK_Receitas_Utilizadores_AutorFK",
                        column: x => x.AutorFK,
                        principalTable: "Utilizadores",
                        principalColumn: "IDutilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasReceitas",
                columns: table => new
                {
                    CategoriasIdCategoria = table.Column<int>(type: "int", nullable: false),
                    ReceitasIDreceita = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasReceitas", x => new { x.CategoriasIdCategoria, x.ReceitasIDreceita });
                    table.ForeignKey(
                        name: "FK_CategoriasReceitas_Categorias_CategoriasIdCategoria",
                        column: x => x.CategoriasIdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriasReceitas_Receitas_ReceitasIDreceita",
                        column: x => x.ReceitasIDreceita,
                        principalTable: "Receitas",
                        principalColumn: "IDreceita",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotografias",
                columns: table => new
                {
                    IDfotografia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fotografia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceitaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotografias", x => x.IDfotografia);
                    table.ForeignKey(
                        name: "FK_Fotografias_Receitas_ReceitaFK",
                        column: x => x.ReceitaFK,
                        principalTable: "Receitas",
                        principalColumn: "IDreceita",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasReceitas_ReceitasIDreceita",
                table: "CategoriasReceitas",
                column: "ReceitasIDreceita");

            migrationBuilder.CreateIndex(
                name: "IX_Fotografias_ReceitaFK",
                table: "Fotografias",
                column: "ReceitaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_AutorFK",
                table: "Receitas",
                column: "AutorFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriasReceitas");

            migrationBuilder.DropTable(
                name: "Fotografias");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Receitas");

            migrationBuilder.DropTable(
                name: "Utilizadores");
        }
    }
}
