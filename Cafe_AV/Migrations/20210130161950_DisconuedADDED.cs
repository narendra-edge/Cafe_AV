using Microsoft.EntityFrameworkCore.Migrations;

namespace Cafe_AV.Migrations
{
    public partial class DisconuedADDED : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Discount",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<short>(
                name: "Quantity",
                table: "OrderDetails",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<bool>(
                name: "Customise",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CustomisedOption",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomisedType",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Discontinued",
                table: "Items",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Discontinued",
                table: "Categories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Customise",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CustomisedOption",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CustomisedType",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Discontinued",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Discontinued",
                table: "Categories");
        }
    }
}
