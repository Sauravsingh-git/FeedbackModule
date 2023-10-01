using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedbackFinal.Migrations
{
    public partial class migrationupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ResponseEntry",
                table: "ResponseEntry");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "ResponseEntry");

            migrationBuilder.AlterColumn<Guid>(
                name: "FeedbackId",
                table: "ResponseEntry",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResponseEntry",
                table: "ResponseEntry",
                column: "FeedbackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ResponseEntry",
                table: "ResponseEntry");

            migrationBuilder.AlterColumn<Guid>(
                name: "FeedbackId",
                table: "ResponseEntry",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<string>(
                name: "QuestionId",
                table: "ResponseEntry",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResponseEntry",
                table: "ResponseEntry",
                columns: new[] { "FeedbackId", "QuestionId" });
        }
    }
}
