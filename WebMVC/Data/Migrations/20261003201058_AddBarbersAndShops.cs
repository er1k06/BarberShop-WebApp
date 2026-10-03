using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBarbersAndShops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Barbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ShopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barbers_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Sofia", "BarberShop Sofia" },
                    { 2, "Plovdiv", "HeadHunters Plovdiv" },
                    { 3, "Varna", "BarberShop Varna" },
                    { 4, "Sofia", "BestBarbers" },
                    { 5, "Plovdiv", "BlendHouse Plovdiv" },
                    { 6, "Kalofer", "KaloferBarbs" },
                    { 7, "Vidin", "BlendHouse Vidin" },
                    { 8, "Smolqn", "HouseOFBarbers" }
                });

            migrationBuilder.InsertData(
                table: "Barbers",
                columns: new[] { "Id", "Age", "Experience", "FirstName", "LastName", "ShopId" },
                values: new object[,]
                {
                    { 1, 0, 5, "John", "Doe", 1 },
                    { 2, 0, 3, "Jane", "Smith", 8 },
                    { 3, 0, 7, "Mike", "Johnson", 3 },
                    { 4, 0, 4, "Emily", "Davis", 4 },
                    { 5, 0, 6, "David", "Wilson", 5 },
                    { 6, 0, 5, "Stoyan", "Stanislavov", 1 },
                    { 7, 0, 3, "Anna", "Boneva", 2 },
                    { 8, 0, 7, "Ivan", "Petrov", 3 },
                    { 9, 0, 4, "Lyubomir", "Savov", 4 },
                    { 10, 0, 3, "Denis", "Stoilov", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barbers_ShopId",
                table: "Barbers",
                column: "ShopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barbers");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
