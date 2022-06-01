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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name" },
                values: new object[] { new Guid("fe47740f-b727-4605-89ab-cc9ff71f9a03"), "Sweden" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name" },
                values: new object[] { new Guid("a0f82d3f-6543-448c-bbb3-d5e5b5ffaea9"), "Germany" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name" },
                values: new object[] { new Guid("14b0821e-fd60-4817-bab6-75be489848bd"), "USA" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CountryID", "Name" },
                values: new object[,]
                {
                    { new Guid("a8e2737b-bec9-4d54-af91-fc77cb71a932"), new Guid("fe47740f-b727-4605-89ab-cc9ff71f9a03"), "Borås" },
                    { new Guid("b9a8b919-c7af-4e23-bf20-4ca5ccf6258e"), new Guid("a0f82d3f-6543-448c-bbb3-d5e5b5ffaea9"), "Dreamland" },
                    { new Guid("c6dd1263-f7cb-4f24-9a4c-86f4009674c1"), new Guid("14b0821e-fd60-4817-bab6-75be489848bd"), "Los Angeles" },
                    { new Guid("efbb7f0e-ade1-4458-bfb5-b179298d8fcf"), new Guid("14b0821e-fd60-4817-bab6-75be489848bd"), "Chicago" },
                    { new Guid("3f0271fb-1675-40e0-b7a3-50f97e06f45e"), new Guid("14b0821e-fd60-4817-bab6-75be489848bd"), "Springfield" },
                    { new Guid("49daa98f-768e-44d7-8c72-00341d6ecddf"), new Guid("14b0821e-fd60-4817-bab6-75be489848bd"), "Albuquerque" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "CityID", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("03b39f07-6712-42b9-a004-40db45cbed73"), new Guid("a8e2737b-bec9-4d54-af91-fc77cb71a932"), "Anthony Hopkins", "555-6162" },
                    { new Guid("9490db50-9448-477e-acc4-b9a095cdec56"), new Guid("b9a8b919-c7af-4e23-bf20-4ca5ccf6258e"), "Somna Sculpt", "1-555-766728578" },
                    { new Guid("e27c4995-5430-4bb4-8489-74eff4d69761"), new Guid("c6dd1263-f7cb-4f24-9a4c-86f4009674c1"), "Jane Doe", "555-123 45" },
                    { new Guid("160aabb1-5799-43b9-9774-3249992441c9"), new Guid("efbb7f0e-ade1-4458-bfb5-b179298d8fcf"), "John Doe", "555-123 45" },
                    { new Guid("e846f52c-ac1e-42c2-9900-f5b37f0b2c3f"), new Guid("3f0271fb-1675-40e0-b7a3-50f97e06f45e"), "Marge Simpson", "939-555-0113" },
                    { new Guid("c0c9982d-b27a-4118-80c2-b69d6367f277"), new Guid("49daa98f-768e-44d7-8c72-00341d6ecddf"), "Saul Goodman", "505-842-5662" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_People_CityID",
                table: "People",
                column: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
