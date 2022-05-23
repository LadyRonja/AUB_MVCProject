using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProject.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("ca92bb42-3f87-4cc9-9c0c-2efe3b6a0046"), "Los Angeles", "Jane Doe", "555-123 45" },
                    { new Guid("c88b0434-a202-4e35-a85c-3a6aad549098"), "Chicago", "John Doe", "555-123 45" },
                    { new Guid("903f249d-1976-4f9e-a048-be14c72a74d2"), "Kansas", "Janelle Monáe", "555-5555" },
                    { new Guid("39c5a1c9-0fd2-431d-bea6-57d99c7c7e3d"), "Springfield", "Marge Simpson", "939-555-0113" },
                    { new Guid("5f018729-3ae0-494c-8514-29f5a8f11160"), "Dreamland", "Somna Sculpt", "1-555-766728578" },
                    { new Guid("83779862-0eea-4f50-9ed9-8655a56e7265"), "Pittsburgh", "Anthony Hopkins", "555-6162" },
                    { new Guid("edda6d7e-0f99-4cf3-a1d5-35de1d10bec0"), "Albuquerque", "Saul Goodman", "505-842-5662" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
