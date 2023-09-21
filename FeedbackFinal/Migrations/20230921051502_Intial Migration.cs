using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedbackFinal.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackEntry",
                columns: table => new
                {
                    FeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnrollmentRollNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubmissionTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackEntry", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_FeedbackEntry_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponseEntry",
                columns: table => new
                {
                    FeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ResponseText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashKey = table.Column<string>(type: "nvarchar(max)", nullable: false, computedColumnSql: "CONCAT(FeedbackId, QuestionId)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseEntry", x => new { x.FeedbackId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_ResponseEntry_FeedbackEntry_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "FeedbackEntry",
                        principalColumn: "FeedbackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponseEntry_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackEntry_SubjectId",
                table: "FeedbackEntry",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseEntry_QuestionId",
                table: "ResponseEntry",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponseEntry");

            migrationBuilder.DropTable(
                name: "FeedbackEntry");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
