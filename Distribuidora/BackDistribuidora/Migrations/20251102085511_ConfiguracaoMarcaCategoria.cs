using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackDistribuidora.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguracaoMarcaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantidadeUnitario",
                table: "Produtos",
                newName: "QuantidadeEstoque");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantidadeEstoque",
                table: "Produtos",
                newName: "QuantidadeUnitario");
        }
    }
}
