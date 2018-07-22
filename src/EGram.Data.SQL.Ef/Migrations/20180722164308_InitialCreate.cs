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
                    Group = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroups", x => x.BloodGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EducationLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    HouseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HouseNumber = table.Column<string>(type: "varchar(200)", nullable: false),
                    AddressLine = table.Column<string>(type: "varchar(200)", nullable: false),
                    StreetAddress = table.Column<string>(type: "varchar(200)", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: false),
                    PostOffice = table.Column<string>(type: "varchar(200)", nullable: false),
                    PostCode = table.Column<string>(type: "varchar(10)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(10, 6)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(10, 6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.HouseId);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    OccupationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "varchar(50)", nullable: true),
                    Info = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.OccupationId);
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
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<int>(nullable: false),
                    Lastname = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    EducationId = table.Column<int>(nullable: false),
                    OccupationId = table.Column<int>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RecieveNotification = table.Column<bool>(nullable: false),
                    BloodGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_BloodGroups_BloodGroupId",
                        column: x => x.BloodGroupId,
                        principalTable: "BloodGroups",
                        principalColumn: "BloodGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "OccupationId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "EducationLevel" },
                values: new object[,]
                {
                    { 6, "Doctorate or Higher" },
                    { 4, "Graduate" },
                    { 5, "Post Graduate" },
                    { 2, "High School" },
                    { 1, "Basic School" },
                    { 3, "Predegree/Diploma" }
                });

            migrationBuilder.InsertData(
                table: "House",
                columns: new[] { "HouseId", "AddressLine", "City", "HouseNumber", "Latitude", "Longitude", "PostCode", "PostOffice", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "47 Bharat Bhawan", "Mumbai", "B4134", null, null, "987789", "Mumbai", "Kalbadevi Road, Kalbadevi" },
                    { 2, "Lake Town", "Kolata", "P-173", null, null, "700089", "Kolkaata", "Kolkata" },
                    { 3, "Sec12, Opp.lakme Beauty Center, Vashi, Navi Mumbai", "Mumbai", "Plot No 190 A", null, null, "400703", "Mumbai", "Mumbai" }
                });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "OccupationId", "Info", "Type" },
                values: new object[,]
                {
                    { 7, "Electical, Civil, Software, Mechanical", "Engineer" },
                    { 1, "Primary School Teacher", "Teacher" },
                    { 2, "Carpenter", "Daily wage" },
                    { 3, "Bus Driver, Truck Driver", "Driver" },
                    { 4, "Business with less than 10 employes", "Small scale Business" },
                    { 5, "Business with 10-100 employees", "Medium scale Busiess" },
                    { 6, "Business with morethan 100 employees", "Large Scale Business" },
                    { 8, "Medical Doctors, Vetinary Doctors etc", "Doctor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_BloodGroupId",
                table: "Person",
                column: "BloodGroupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_EducationId",
                table: "Person",
                column: "EducationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_OccupationId",
                table: "Person",
                column: "OccupationId",
                unique: true);

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
                name: "House");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "BloodGroups");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropTable(
                name: "SurveyType");
        }
    }
}
