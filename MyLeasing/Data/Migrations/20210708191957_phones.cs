using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLeasing.Data.Migrations
{
    public partial class phones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "Owners",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FixedPhone",
                table: "Owners",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "Lessees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FixedPhone",
                table: "Lessees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "FixedPhone",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "Lessees");

            migrationBuilder.DropColumn(
                name: "FixedPhone",
                table: "Lessees");
        }
    }
}
