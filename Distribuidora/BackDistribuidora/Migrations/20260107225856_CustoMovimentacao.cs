using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackDistribuidora.Migrations
{
    /// <inheritdoc />
    public partial class CustoMovimentacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoCusto",
                table: "MovimentacoesEstoque",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoCusto",
                table: "MovimentacoesEstoque");
        }
    }
}
