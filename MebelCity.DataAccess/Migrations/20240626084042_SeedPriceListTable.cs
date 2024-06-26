using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MebelCity.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedPriceListTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PriceLists",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 1, 1, "Прайс-лист от 25.06.2024" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PriceLists",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
