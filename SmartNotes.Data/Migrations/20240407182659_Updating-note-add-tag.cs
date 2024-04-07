using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartNotes.Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatingnoteaddtag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Note",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Note");
        }
    }
}
