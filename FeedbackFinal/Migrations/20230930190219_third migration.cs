using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedbackFinal.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HashKey",
                table: "ResponseEntry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HashKey",
                table: "ResponseEntry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
