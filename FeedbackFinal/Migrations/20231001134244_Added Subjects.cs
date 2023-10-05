using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedbackFinal.Migrations
{
    public partial class AddedSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("6d372407-b0fc-4433-8301-b1163def62c6"));

            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("7b8eca3c-071b-4289-bfad-2138fe66aec8"));

            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("b615028b-5c92-4c10-95e3-f4c3166b9cbe"));

            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("d7d7cea4-dcad-45e7-8114-ed79de4c85be"));

            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("e06e01cb-27a6-4c90-bf78-715d3951c093"));

            migrationBuilder.InsertData(
                table: "SubjectDetails",
                columns: new[] { "SubjectId", "SubjectCode", "SubjectName", "TeacherId", "Year" },
                values: new object[,]
                {
                    { new Guid("0a2ea97a-9ab6-4aee-88fa-a110c4def2f0"), "MCA-223", "Cloud Computing", "Parul", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("209a2540-5837-4268-b2de-05755c0c9f70"), "MCA-105", "Operating System With Linux", "Sunil", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b77919c-52d8-4a79-be2b-8b3777da6025"), "MCA-103", "Computer Networks", "Manish", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54d25c13-bffb-48a1-a188-bdef592b24bc"), "MCA-101", "Data Structures", "Parul", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a129aaa4-ab88-4298-a2a5-e04924463426"), "MCA-233", "Multimedia", "Sunil", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("0a2ea97a-9ab6-4aee-88fa-a110c4def2f0"));

            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("209a2540-5837-4268-b2de-05755c0c9f70"));

            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("2b77919c-52d8-4a79-be2b-8b3777da6025"));

            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("54d25c13-bffb-48a1-a188-bdef592b24bc"));

            migrationBuilder.DeleteData(
                table: "SubjectDetails",
                keyColumn: "SubjectId",
                keyValue: new Guid("a129aaa4-ab88-4298-a2a5-e04924463426"));

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
    }
}
