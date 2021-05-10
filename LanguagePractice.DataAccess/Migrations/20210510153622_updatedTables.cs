using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguagePractice.DataAccess.Migrations
{
    public partial class updatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Word",
                table: "TurDictionary",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Word",
                table: "EngDictionary",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TurDictionary",
                newName: "Word");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EngDictionary",
                newName: "Word");
        }
    }
}
