using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MP.Migrations
{
    /// <inheritdoc />
    public partial class Azure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonID);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "GameLink", "GameName", "Thumbnail" },
                values: new object[] { 1, "https://play.unity.com/en/games/bd29b7bb-5721-4838-b924-f3f413c7a5bd/mp", "Math Space Race", "[\"/Images/GameThumbnail1.png\"]" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonID", "LessonLink", "LessonName", "Thumbnail" },
                values: new object[] { 1, "https://play.unity.com/en/games/cb9c9d93-d188-45d0-9c0d-ff33257c0d08/learning-number-recognition", "Learning Number Recognition", "[\"/Images/LessonThumbnail1.png\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
