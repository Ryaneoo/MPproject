using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MP.Migrations
{
    /// <inheritdoc />
    public partial class Ready : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    LeaderboardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaderboardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirebaseUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.LeaderboardID);
                });

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
                table: "Boards",
                columns: new[] { "LeaderboardID", "FirebaseUrl", "LeaderboardName" },
                values: new object[,]
                {
                    { 1, "https://spacegame-745af-default-rtdb.asia-southeast1.firebasedatabase.app/", "Math Space Game Leaderboard" },
                    { 2, "https://mpproject-ccebf-default-rtdb.asia-southeast1.firebasedatabase.app/", "Counting Animals Leaderboard" },
                    { 3, "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_2s.json", "Skip Counting - 2s" },
                    { 4, "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_5s.json", "Skip Counting - 5s" },
                    { 5, "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_10s.json", "Skip Counting - 10s" },
                    { 6, "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_random.json", "Skip Counting - Everything" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "GameLink", "GameName", "Thumbnail" },
                values: new object[,]
                {
                    { 1, "https://play.unity.com/en/games/bd29b7bb-5721-4838-b924-f3f413c7a5bd/mp", "Math Space Race", "[\"/Images/GameThumbnail1.png\"]" },
                    { 2, "https://play.unity.com/en/games/916d7430-f1a1-4bb7-924b-234c12bf7f95/count-the-animals", "Counting Animals", "[\"/Images/GameThumbnail2.png\"]" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonID", "LessonLink", "LessonName", "Thumbnail" },
                values: new object[] { 1, "https://play.unity.com/en/games/cb9c9d93-d188-45d0-9c0d-ff33257c0d08/learning-number-recognition", "Learning Number Recognition", "[\"/Images/LessonThumbnail1.png\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Lessons");
        }
    }
}
