using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkateFactory3.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMyProperty1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty1",
                table: "Skateboards");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty1",
                table: "Skateboards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
