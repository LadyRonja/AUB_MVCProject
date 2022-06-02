using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CountryID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CityID = table.Column<Guid>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                    table.ForeignKey(
                        name: "FK_People_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageSpeakers",
                columns: table => new
                {
                    LanguageID = table.Column<Guid>(nullable: false),
                    PersonID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageSpeakers", x => new { x.LanguageID, x.PersonID });
                    table.ForeignKey(
                        name: "FK_LanguageSpeakers_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageSpeakers_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("808a370a-9de2-41b7-83d7-57ad76b26719"), "Sweden" },
                    { new Guid("d91e0afc-5d81-4a7a-9230-ea07f9acf45a"), "Germany" },
                    { new Guid("1977b703-ada7-4c6b-9402-d6f05d9f2c12"), "USA" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), "English" },
                    { new Guid("93856c53-5513-4a6c-8a77-7c961bfab4bb"), "Swedish" },
                    { new Guid("7a33a7d4-3967-418b-b593-ba4e89fa26c9"), "German" },
                    { new Guid("6b6cb417-e1ec-4b3b-ab87-4d660456b696"), "C#" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CountryID", "Name" },
                values: new object[,]
                {
                    { new Guid("96abf55e-3257-4a13-920a-dcf6e0d90cd5"), new Guid("808a370a-9de2-41b7-83d7-57ad76b26719"), "Borås" },
                    { new Guid("437fca0c-324f-41d3-853c-ab143a7d9c14"), new Guid("d91e0afc-5d81-4a7a-9230-ea07f9acf45a"), "Dreamland" },
                    { new Guid("0f3d34f5-0f4c-4561-8488-9cb025083f19"), new Guid("1977b703-ada7-4c6b-9402-d6f05d9f2c12"), "Los Angeles" },
                    { new Guid("544b6d6c-9a82-4b8c-9e82-db46606fb06a"), new Guid("1977b703-ada7-4c6b-9402-d6f05d9f2c12"), "Chicago" },
                    { new Guid("25cb535d-bbe1-4277-a826-402ea33b6602"), new Guid("1977b703-ada7-4c6b-9402-d6f05d9f2c12"), "Springfield" },
                    { new Guid("c796d9df-09f5-4788-8724-e97c0006cff9"), new Guid("1977b703-ada7-4c6b-9402-d6f05d9f2c12"), "Albuquerque" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "CityID", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("173221c4-7d98-400f-8ef3-e0c5977abd4c"), new Guid("96abf55e-3257-4a13-920a-dcf6e0d90cd5"), "Anthony Hopkins", "555-6162" },
                    { new Guid("9ee65d68-80f5-4945-819d-b74029aba764"), new Guid("437fca0c-324f-41d3-853c-ab143a7d9c14"), "Somna Sculpt", "1-555-766728578" },
                    { new Guid("44e00435-f865-4162-ba90-167446fe49a8"), new Guid("0f3d34f5-0f4c-4561-8488-9cb025083f19"), "Jane Doe", "555-123 45" },
                    { new Guid("800ee376-e910-45d4-9441-b87d031f4aa1"), new Guid("544b6d6c-9a82-4b8c-9e82-db46606fb06a"), "John Doe", "555-123 45" },
                    { new Guid("b5a2fb0c-054a-4366-87b4-cc462b0b4ff8"), new Guid("25cb535d-bbe1-4277-a826-402ea33b6602"), "Marge Simpson", "939-555-0113" },
                    { new Guid("30161aef-c5c4-4bb2-94b3-4a0a1a88441b"), new Guid("c796d9df-09f5-4788-8724-e97c0006cff9"), "Saul Goodman", "505-842-5662" }
                });

            migrationBuilder.InsertData(
                table: "LanguageSpeakers",
                columns: new[] { "LanguageID", "PersonID" },
                values: new object[,]
                {
                    { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("173221c4-7d98-400f-8ef3-e0c5977abd4c") },
                    { new Guid("7a33a7d4-3967-418b-b593-ba4e89fa26c9"), new Guid("173221c4-7d98-400f-8ef3-e0c5977abd4c") },
                    { new Guid("93856c53-5513-4a6c-8a77-7c961bfab4bb"), new Guid("173221c4-7d98-400f-8ef3-e0c5977abd4c") },
                    { new Guid("7a33a7d4-3967-418b-b593-ba4e89fa26c9"), new Guid("9ee65d68-80f5-4945-819d-b74029aba764") },
                    { new Guid("6b6cb417-e1ec-4b3b-ab87-4d660456b696"), new Guid("9ee65d68-80f5-4945-819d-b74029aba764") },
                    { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("44e00435-f865-4162-ba90-167446fe49a8") },
                    { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("800ee376-e910-45d4-9441-b87d031f4aa1") },
                    { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("b5a2fb0c-054a-4366-87b4-cc462b0b4ff8") },
                    { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("30161aef-c5c4-4bb2-94b3-4a0a1a88441b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageSpeakers_PersonID",
                table: "LanguageSpeakers",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_People_CityID",
                table: "People",
                column: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageSpeakers");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
