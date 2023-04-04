using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkateFactory3.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinishSkateboardColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty3",
                table: "Skateboards",
                newName: "SkateType");

            migrationBuilder.RenameColumn(
                name: "MyProperty2",
                table: "Skateboards",
                newName: "ShapeType");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skateboards",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "BrakeType",
                table: "Skateboards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "Skateboards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Skateboards",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrakeType",
                table: "Skateboards");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Skateboards");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Skateboards");

            migrationBuilder.RenameColumn(
                name: "SkateType",
                table: "Skateboards",
                newName: "MyProperty3");

            migrationBuilder.RenameColumn(
                name: "ShapeType",
                table: "Skateboards",
                newName: "MyProperty2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skateboards",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);
        }
    }
}
