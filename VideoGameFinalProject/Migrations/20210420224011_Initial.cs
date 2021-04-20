using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoGameFinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameRelease = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameProducer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "GameName", "GameProducer", "GameRelease" },
                values: new object[] { 3, "Minecraft", "Mojang Studios", "2011" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "GameName", "GameProducer", "GameRelease" },
                values: new object[] { 2, "Tom Clancy's Rainbow Six Siege", "Ubisoft Montreal", "2015" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "GameName", "GameProducer", "GameRelease" },
                values: new object[] { 1, "Super Mario Bros.", "Nintendo", "1985" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
