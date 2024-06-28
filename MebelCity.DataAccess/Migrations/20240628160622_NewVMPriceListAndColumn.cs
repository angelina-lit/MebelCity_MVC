using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MebelCity.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewVMPriceListAndColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Columns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.CreateTable(
                name: "ColumnPriceList",
                columns: table => new
                {
                    ColumnsId = table.Column<int>(type: "int", nullable: false),
                    PriceListsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColumnPriceList", x => new { x.ColumnsId, x.PriceListsId });
                    table.ForeignKey(
                        name: "FK_ColumnPriceList_Columns_ColumnsId",
                        column: x => x.ColumnsId,
                        principalTable: "Columns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColumnPriceList_PriceLists_PriceListsId",
                        column: x => x.PriceListsId,
                        principalTable: "PriceLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColumnPriceList_PriceListsId",
                table: "ColumnPriceList",
                column: "PriceListsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColumnPriceList");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Columns",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
