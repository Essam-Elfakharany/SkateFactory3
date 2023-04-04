using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkateFactory3.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMyProperty1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty1",
                table: "Skateboards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty1",
                table: "Skateboards");
        }
    }
}
