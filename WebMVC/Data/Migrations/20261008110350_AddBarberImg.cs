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
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/barbers/Denis-Stoilov.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/barbers/Demis-Stoilov.png");
        }
    }
}
