using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkateFactory3.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMyProperty2and3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty2",
                table: "Skateboards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty3",
                table: "Skateboards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty2",
                table: "Skateboards");

            migrationBuilder.DropColumn(
                name: "MyProperty3",
                table: "Skateboards");
        }
    }
}
