using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguagePractice.DataAccess.Migrations
{
    public partial class AddedRepeatCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RepeatedCount",
                table: "UserWordList",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalRepeatCount",
                table: "UserWordList",
                type: "integer",
                nullable: false,
                defaultValue: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RepeatedCount",
                table: "UserWordList");

            migrationBuilder.DropColumn(
                name: "TotalRepeatCount",
                table: "UserWordList");
        }
    }
}
