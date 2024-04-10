using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhanDienKhuonMat.Migrations
{
    /// <inheritdoc />
    public partial class themmoi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FaceData_Employee_EmployeeId",
                table: "FaceData");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeKeeping_Employee_EmployeeId",
                table: "TimeKeeping");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "TimeKeeping",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "FaceData",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FaceData_Employee_EmployeeId",
                table: "FaceData",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeKeeping_Employee_EmployeeId",
                table: "TimeKeeping",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
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

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "TimeKeeping",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "FaceData",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
