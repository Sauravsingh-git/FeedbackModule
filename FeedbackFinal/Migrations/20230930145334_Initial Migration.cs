using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedbackFinal.Migrations
{
    public partial class InitialMigration : Migration
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
                    ResponseTextA1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextA2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextA3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextB1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextB2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextB3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextB4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextB5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextB6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextC1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextC2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextC3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextC4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextC5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextD10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextE1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextF1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextG1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextH1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextI1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextI2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextI3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextI4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextI5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextJ1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextJ2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextJ3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextJ4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTextJ5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsetextK1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackEntry_SubjectId",
                table: "FeedbackEntry",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "ResponseEntry");

            migrationBuilder.DropTable(
                name: "FeedbackEntry");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
