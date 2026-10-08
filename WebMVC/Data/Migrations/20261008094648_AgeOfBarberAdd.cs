using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgeOfBarberAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Age",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Age",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Age",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Age",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Age",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Age",
                value: 30);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Age",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Age",
                value: 0);
        }
    }
}
