using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedbackFinal.Migrations
{
    public partial class AddedSubjectDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubjectDetails",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectDetails", x => x.SubjectId);
                });

            migrationBuilder.InsertData(
                table: "SubjectDetails",
                columns: new[] { "SubjectId", "SubjectCode", "SubjectName", "TeacherId", "Year" },
                values: new object[,]
                {
                    { new Guid("6d372407-b0fc-4433-8301-b1163def62c6"), "MCA-223", "Cloud Computing", "Parul", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b8eca3c-071b-4289-bfad-2138fe66aec8"), "MCA-103", "Computer Networks", "Manish", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b615028b-5c92-4c10-95e3-f4c3166b9cbe"), "MCA-233", "Multimedia", "Sunil", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7d7cea4-dcad-45e7-8114-ed79de4c85be"), "MCA-105", "Operating System With Linux", "Sunil", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e06e01cb-27a6-4c90-bf78-715d3951c093"), "MCA-101", "Data Structures", "Parul", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectDetails");
        }
    }
}
