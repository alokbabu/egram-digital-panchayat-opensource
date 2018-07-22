using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EGram.Data.SQL.Ef.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodGroups",
                columns: table => new
                {
                    BloodGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Group = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroups", x => x.BloodGroupId);
                });

            migrationBuilder.CreateTable(
                name: "SurveyType",
                columns: table => new
                {
                    SurveyTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyType", x => x.SurveyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    SurveyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurveyTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.SurveyId);
                    table.ForeignKey(
                        name: "FK_Surveys_SurveyType_SurveyTypeId",
                        column: x => x.SurveyTypeId,
                        principalTable: "SurveyType",
                        principalColumn: "SurveyTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BloodGroups",
                columns: new[] { "BloodGroupId", "Group" },
                values: new object[,]
                {
                    { 1, "A +" },
                    { 2, "A -" },
                    { 3, "B +" },
                    { 4, "B -" },
                    { 5, "O +" },
                    { 6, "O -" },
                    { 7, "AB +" },
                    { 8, "AB -" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_SurveyTypeId",
                table: "Surveys",
                column: "SurveyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_YearId",
                table: "Surveys",
                column: "YearId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodGroups");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "SurveyType");
        }
    }
}
