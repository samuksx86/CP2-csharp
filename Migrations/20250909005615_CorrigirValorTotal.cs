using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheckPoint.Migrations
{
    /// <inheritdoc />
    public partial class CorrigirValorTotal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "RM99134_Pedido",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ValorTotal",
                table: "RM99134_Pedido",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }
    }
}
