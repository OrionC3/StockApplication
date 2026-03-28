using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockApplication.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardwareSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cpu = table.Column<string>(type: "TEXT", nullable: true),
                    Ram = table.Column<string>(type: "TEXT", nullable: true),
                    Storage = table.Column<string>(type: "TEXT", nullable: true),
                    GraphicCard = table.Column<string>(type: "TEXT", nullable: true),
                    Allimentation = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareSpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareSpecs_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NetworkSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    IpAddress = table.Column<string>(type: "TEXT", nullable: true),
                    IpMask = table.Column<string>(type: "TEXT", nullable: true),
                    IpGateway = table.Column<string>(type: "TEXT", nullable: true),
                    MacAddress = table.Column<string>(type: "TEXT", nullable: true),
                    VlanId = table.Column<string>(type: "TEXT", nullable: true),
                    IsStatic = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkSpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NetworkSpecs_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSpecs_ItemId",
                table: "HardwareSpecs",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NetworkSpecs_ItemId",
                table: "NetworkSpecs",
                column: "ItemId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HardwareSpecs");

            migrationBuilder.DropTable(
                name: "NetworkSpecs");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
