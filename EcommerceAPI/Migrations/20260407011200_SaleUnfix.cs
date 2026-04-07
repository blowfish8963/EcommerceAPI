using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class SaleUnfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleProductQty",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "ProductQty",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductQty",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "SaleProductQty",
                table: "Sales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
