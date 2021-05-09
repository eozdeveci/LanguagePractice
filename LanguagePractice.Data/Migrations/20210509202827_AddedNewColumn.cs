using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguagePractice.Data.Migrations
{
    public partial class AddedNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RepeatCount",
                table: "EngTur",
                newName: "TotalRepeatCount");

            migrationBuilder.AddColumn<byte>(
                name: "RepeatedCount",
                table: "EngTur",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RepeatedCount",
                table: "EngTur");

            migrationBuilder.RenameColumn(
                name: "TotalRepeatCount",
                table: "EngTur",
                newName: "RepeatCount");
        }
    }
}
