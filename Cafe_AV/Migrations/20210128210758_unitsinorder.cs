using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafe_AV.Migrations
{
    public partial class unitsinorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<short>(
                name: "UnitsInOrder",
                table: "Items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitsInOrder",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Items",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
