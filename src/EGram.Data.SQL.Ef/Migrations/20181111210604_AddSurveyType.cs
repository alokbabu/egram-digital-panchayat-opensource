using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EGram.Data.SQL.Ef.Migrations
{
    public partial class AddSurveyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_SurveyType_SurveyTypeId",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_YearId",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyType",
                table: "SurveyType");

            migrationBuilder.RenameTable(
                name: "SurveyType",
                newName: "SurveyTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyTypes",
                table: "SurveyTypes",
                column: "SurveyTypeId");

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    YearId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    YearString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.YearId);
                });

            migrationBuilder.InsertData(
                table: "SurveyTypes",
                columns: new[] { "SurveyTypeId", "Type" },
                values: new object[,]
                {
                    { 1, "House" },
                    { 2, "Person" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "YearId", "YearString" },
                values: new object[,]
                {
                    { 1, "2018" },
                    { 2, "2019" }
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyId", "CreatedOn", "Info", "ModifiedOn", "Name", "SurveyTypeId", "YearId" },
                values: new object[] { 1, new DateTime(2018, 11, 11, 21, 6, 4, 48, DateTimeKind.Local), "Yearly Survey", new DateTime(2018, 11, 11, 21, 6, 4, 48, DateTimeKind.Local), "Yearly end survey 2018", 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_SurveyId",
                table: "Surveys",
                column: "SurveyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SurveyTypes_SurveyTypeId",
                table: "SurveyTypes",
                column: "SurveyTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Years_YearId",
                table: "Years",
                column: "YearId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_SurveyTypes_SurveyTypeId",
                table: "Surveys",
                column: "SurveyTypeId",
                principalTable: "SurveyTypes",
                principalColumn: "SurveyTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_SurveyTypes_SurveyTypeId",
                table: "Surveys");

            migrationBuilder.DropTable(
                name: "Years");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_SurveyId",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyTypes",
                table: "SurveyTypes");

            migrationBuilder.DropIndex(
                name: "IX_SurveyTypes_SurveyTypeId",
                table: "SurveyTypes");

            migrationBuilder.DeleteData(
                table: "SurveyTypes",
                keyColumn: "SurveyTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "SurveyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SurveyTypes",
                keyColumn: "SurveyTypeId",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "SurveyTypes",
                newName: "SurveyType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyType",
                table: "SurveyType",
                column: "SurveyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_YearId",
                table: "Surveys",
                column: "YearId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_SurveyType_SurveyTypeId",
                table: "Surveys",
                column: "SurveyTypeId",
                principalTable: "SurveyType",
                principalColumn: "SurveyTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
