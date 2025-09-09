using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheckPoint.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RM99134_Fornecedor",
                columns: table => new
                {
                    idFornecedor = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nrCep = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    dsEndereco = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Estado = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM99134_Fornecedor", x => x.idFornecedor);
                });

            migrationBuilder.CreateTable(
                name: "RM99134_Pedido",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DtPedido = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM99134_Pedido", x => x.idPedido);
                });

            migrationBuilder.CreateTable(
                name: "RM99134_Produto",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NmProduto = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Preco = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM99134_Produto", x => x.idProduto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RM99134_Fornecedor");

            migrationBuilder.DropTable(
                name: "RM99134_Pedido");

            migrationBuilder.DropTable(
                name: "RM99134_Produto");
        }
    }
}
