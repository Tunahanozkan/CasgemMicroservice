using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cargoStates",
                columns: table => new
                {
                    CargoStateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargoStateID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargoStates", x => x.CargoStateID);
                    table.ForeignKey(
                        name: "FK_cargoStates_cargoStates_CargoStateID1",
                        column: x => x.CargoStateID1,
                        principalTable: "cargoStates",
                        principalColumn: "CargoStateID");
                });

            migrationBuilder.CreateTable(
                name: "cargoDetails",
                columns: table => new
                {
                    CargoDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderingID = table.Column<int>(type: "int", nullable: false),
                    CargoStateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargoDetails", x => x.CargoDetailID);
                    table.ForeignKey(
                        name: "FK_cargoDetails_cargoStates_CargoStateID",
                        column: x => x.CargoStateID,
                        principalTable: "cargoStates",
                        principalColumn: "CargoStateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cargoDetails_CargoStateID",
                table: "cargoDetails",
                column: "CargoStateID");

            migrationBuilder.CreateIndex(
                name: "IX_cargoStates_CargoStateID1",
                table: "cargoStates",
                column: "CargoStateID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cargoDetails");

            migrationBuilder.DropTable(
                name: "cargoStates");
        }
    }
}
