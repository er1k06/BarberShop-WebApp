using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBarberImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/barbers/John-Doe.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/barbers/Jane-Smith.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/barbers/Mike-Johnson.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/barbers/Emily-Davis.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/barbers/David-Wilson.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/barbers/Stoyan-Stanislavov.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/barbers/Anna-Boneva.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/barbers/Ivan-Petrov.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/barbers/Lyubomir-Savov.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/barbers/Demis-Stoilov.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/barbers/john_doe.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/barbers/jane_smith.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/barbers/mike_johnson.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/barbers/emily_davis.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/barbers/david_wilson.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/barbers/stoyan_stanislavov.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/barbers/anna_boneva.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/barbers/ivan_petrov.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/barbers/lyubomir_savov.png");

            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/barbers/denis_stoilov.png");
        }
    }
}
