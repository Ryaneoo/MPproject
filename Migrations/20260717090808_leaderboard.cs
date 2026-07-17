using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MP.Migrations
{
    /// <inheritdoc />
    public partial class leaderboard : Migration
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

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "LeaderboardID", "FirebaseUrl", "LeaderboardName" },
                values: new object[,]
                {
                    { 1, "https://spacegame-745af-default-rtdb.asia-southeast1.firebasedatabase.app/", "Math Space Game Leaderboard" },
                    { 2, "https://mpproject-ccebf-default-rtdb.asia-southeast1.firebasedatabase.app/", "Counting Animals Leaderboard" },
                    { 3, "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/", "Skip Counting Leaderboard" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boards");
        }
    }
}
