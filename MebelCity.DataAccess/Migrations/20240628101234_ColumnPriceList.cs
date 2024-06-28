using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MebelCity.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ColumnPriceList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceListId",
                table: "Columns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Columns_PriceListId",
                table: "Columns",
                column: "PriceListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Columns_PriceLists_PriceListId",
                table: "Columns",
                column: "PriceListId",
                principalTable: "PriceLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Columns_PriceLists_PriceListId",
                table: "Columns");

            migrationBuilder.DropIndex(
                name: "IX_Columns_PriceListId",
                table: "Columns");

            migrationBuilder.DropColumn(
                name: "PriceListId",
                table: "Columns");
        }
    }
}
