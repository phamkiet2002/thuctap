using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhanDienKhuonMat.Migrations
{
    /// <inheritdoc />
    public partial class them : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department1",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department1",
                table: "Employee");
        }
    }
}
