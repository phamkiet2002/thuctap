using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhanDienKhuonMat.Migrations
{
    /// <inheritdoc />
    public partial class themmoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaceData_Employee",
                table: "FaceData");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeKeeping_Employee",
                table: "TimeKeeping");

            migrationBuilder.DropColumn(
                name: "Department1",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_FaceData_Employee_EmployeeId",
                table: "FaceData",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeKeeping_Employee_EmployeeId",
                table: "TimeKeeping",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaceData_Employee_EmployeeId",
                table: "FaceData");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeKeeping_Employee_EmployeeId",
                table: "TimeKeeping");

            migrationBuilder.AddColumn<string>(
                name: "Department1",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_FaceData_Employee",
                table: "FaceData",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeKeeping_Employee",
                table: "TimeKeeping",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
