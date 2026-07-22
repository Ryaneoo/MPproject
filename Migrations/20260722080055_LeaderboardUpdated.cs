using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MP.Migrations
{
    /// <inheritdoc />
    public partial class LeaderboardUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "LeaderboardID",
                keyValue: 3,
                columns: new[] { "FirebaseUrl", "LeaderboardName" },
                values: new object[] { "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_2s.json", "Skip Counting - 2s" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "LeaderboardID", "FirebaseUrl", "LeaderboardName" },
                values: new object[,]
                {
                    { 4, "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_5s.json", "Skip Counting - 5s" },
                    { 5, "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_10s.json", "Skip Counting - 10s" },
                    { 6, "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/leaderboard_random.json", "Skip Counting - Everything" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "LeaderboardID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "LeaderboardID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "LeaderboardID",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "LeaderboardID",
                keyValue: 3,
                columns: new[] { "FirebaseUrl", "LeaderboardName" },
                values: new object[] { "https://skipcounting-a54ba-default-rtdb.asia-southeast1.firebasedatabase.app/", "Skip Counting Leaderboard" });
        }
    }
}
