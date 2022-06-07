using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProject.Migrations
{
    public partial class addedidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("6b6cb417-e1ec-4b3b-ab87-4d660456b696"), new Guid("9ee65d68-80f5-4945-819d-b74029aba764") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("7a33a7d4-3967-418b-b593-ba4e89fa26c9"), new Guid("173221c4-7d98-400f-8ef3-e0c5977abd4c") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("7a33a7d4-3967-418b-b593-ba4e89fa26c9"), new Guid("9ee65d68-80f5-4945-819d-b74029aba764") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("93856c53-5513-4a6c-8a77-7c961bfab4bb"), new Guid("173221c4-7d98-400f-8ef3-e0c5977abd4c") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("173221c4-7d98-400f-8ef3-e0c5977abd4c") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("30161aef-c5c4-4bb2-94b3-4a0a1a88441b") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("44e00435-f865-4162-ba90-167446fe49a8") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("800ee376-e910-45d4-9441-b87d031f4aa1") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"), new Guid("b5a2fb0c-054a-4366-87b4-cc462b0b4ff8") });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("6b6cb417-e1ec-4b3b-ab87-4d660456b696"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("7a33a7d4-3967-418b-b593-ba4e89fa26c9"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("93856c53-5513-4a6c-8a77-7c961bfab4bb"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("e91c6fbb-472e-4776-a47b-3d3683cc2320"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("173221c4-7d98-400f-8ef3-e0c5977abd4c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("30161aef-c5c4-4bb2-94b3-4a0a1a88441b"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("44e00435-f865-4162-ba90-167446fe49a8"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("800ee376-e910-45d4-9441-b87d031f4aa1"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("9ee65d68-80f5-4945-819d-b74029aba764"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("b5a2fb0c-054a-4366-87b4-cc462b0b4ff8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("0f3d34f5-0f4c-4561-8488-9cb025083f19"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("25cb535d-bbe1-4277-a826-402ea33b6602"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("437fca0c-324f-41d3-853c-ab143a7d9c14"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("544b6d6c-9a82-4b8c-9e82-db46606fb06a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("96abf55e-3257-4a13-920a-dcf6e0d90cd5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("c796d9df-09f5-4788-8724-e97c0006cff9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("1977b703-ada7-4c6b-9402-d6f05d9f2c12"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("808a370a-9de2-41b7-83d7-57ad76b26719"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("d91e0afc-5d81-4a7a-9230-ea07f9acf45a"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("302373eb-5d98-4965-a5ea-ec7d2d30265f"), "Sweden" },
                    { new Guid("84c8c820-520b-47f6-a200-10c1a4a514ab"), "Germany" },
                    { new Guid("9bbe248d-577b-4ba7-ad38-f10a110a5e5b"), "USA" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), "English" },
                    { new Guid("92ed3a0a-f30f-40fb-ac84-96f776f2b223"), "Swedish" },
                    { new Guid("97eeb315-d320-41e5-ad5c-86261e56f944"), "German" },
                    { new Guid("fbf73f92-08ac-4655-8947-b92ab9381a1c"), "C#" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CountryID", "Name" },
                values: new object[,]
                {
                    { new Guid("b11cfbec-0cde-4242-bc1b-b3040c4d008c"), new Guid("302373eb-5d98-4965-a5ea-ec7d2d30265f"), "Borås" },
                    { new Guid("248a564d-1e7a-4e80-89bd-473436a1de1b"), new Guid("84c8c820-520b-47f6-a200-10c1a4a514ab"), "Dreamland" },
                    { new Guid("c0934d01-eb93-4d07-af96-972526b3733d"), new Guid("9bbe248d-577b-4ba7-ad38-f10a110a5e5b"), "Los Angeles" },
                    { new Guid("1065337c-9786-493a-af84-665504b4188e"), new Guid("9bbe248d-577b-4ba7-ad38-f10a110a5e5b"), "Chicago" },
                    { new Guid("2e00bcb5-2ef0-4285-a566-61f6d6e00248"), new Guid("9bbe248d-577b-4ba7-ad38-f10a110a5e5b"), "Springfield" },
                    { new Guid("49b0612d-af88-49e6-9d28-6076fee4351c"), new Guid("9bbe248d-577b-4ba7-ad38-f10a110a5e5b"), "Albuquerque" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "CityID", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("cd7c5767-8cc0-4d9b-a7fe-363cd6095580"), new Guid("b11cfbec-0cde-4242-bc1b-b3040c4d008c"), "Anthony Hopkins", "555-6162" },
                    { new Guid("6e91f2e2-36ec-4147-8a9d-d36dcdd851f0"), new Guid("248a564d-1e7a-4e80-89bd-473436a1de1b"), "Somna Sculpt", "1-555-766728578" },
                    { new Guid("e23d003b-c015-4fc8-bf6d-519b8225d7d8"), new Guid("c0934d01-eb93-4d07-af96-972526b3733d"), "Jane Doe", "555-123 45" },
                    { new Guid("5fae0c20-903a-4280-8e02-a2ff7597a60d"), new Guid("1065337c-9786-493a-af84-665504b4188e"), "John Doe", "555-123 45" },
                    { new Guid("4c6fe5a1-9b29-4c5a-935a-68c49b1c9b99"), new Guid("2e00bcb5-2ef0-4285-a566-61f6d6e00248"), "Marge Simpson", "939-555-0113" },
                    { new Guid("cb60f98e-2c8d-4b63-8d55-1c3162108f13"), new Guid("49b0612d-af88-49e6-9d28-6076fee4351c"), "Saul Goodman", "505-842-5662" }
                });

            migrationBuilder.InsertData(
                table: "LanguageSpeakers",
                columns: new[] { "LanguageID", "PersonID" },
                values: new object[,]
                {
                    { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("cd7c5767-8cc0-4d9b-a7fe-363cd6095580") },
                    { new Guid("97eeb315-d320-41e5-ad5c-86261e56f944"), new Guid("cd7c5767-8cc0-4d9b-a7fe-363cd6095580") },
                    { new Guid("92ed3a0a-f30f-40fb-ac84-96f776f2b223"), new Guid("cd7c5767-8cc0-4d9b-a7fe-363cd6095580") },
                    { new Guid("97eeb315-d320-41e5-ad5c-86261e56f944"), new Guid("6e91f2e2-36ec-4147-8a9d-d36dcdd851f0") },
                    { new Guid("fbf73f92-08ac-4655-8947-b92ab9381a1c"), new Guid("6e91f2e2-36ec-4147-8a9d-d36dcdd851f0") },
                    { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("e23d003b-c015-4fc8-bf6d-519b8225d7d8") },
                    { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("5fae0c20-903a-4280-8e02-a2ff7597a60d") },
                    { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("4c6fe5a1-9b29-4c5a-935a-68c49b1c9b99") },
                    { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("cb60f98e-2c8d-4b63-8d55-1c3162108f13") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("92ed3a0a-f30f-40fb-ac84-96f776f2b223"), new Guid("cd7c5767-8cc0-4d9b-a7fe-363cd6095580") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("97eeb315-d320-41e5-ad5c-86261e56f944"), new Guid("6e91f2e2-36ec-4147-8a9d-d36dcdd851f0") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("97eeb315-d320-41e5-ad5c-86261e56f944"), new Guid("cd7c5767-8cc0-4d9b-a7fe-363cd6095580") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("4c6fe5a1-9b29-4c5a-935a-68c49b1c9b99") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("5fae0c20-903a-4280-8e02-a2ff7597a60d") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("cb60f98e-2c8d-4b63-8d55-1c3162108f13") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("cd7c5767-8cc0-4d9b-a7fe-363cd6095580") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"), new Guid("e23d003b-c015-4fc8-bf6d-519b8225d7d8") });

            migrationBuilder.DeleteData(
                table: "LanguageSpeakers",
                keyColumns: new[] { "LanguageID", "PersonID" },
                keyValues: new object[] { new Guid("fbf73f92-08ac-4655-8947-b92ab9381a1c"), new Guid("6e91f2e2-36ec-4147-8a9d-d36dcdd851f0") });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("92ed3a0a-f30f-40fb-ac84-96f776f2b223"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("97eeb315-d320-41e5-ad5c-86261e56f944"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("db9ced18-bee1-4c66-87d7-2d3ad54160c9"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("fbf73f92-08ac-4655-8947-b92ab9381a1c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("4c6fe5a1-9b29-4c5a-935a-68c49b1c9b99"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("5fae0c20-903a-4280-8e02-a2ff7597a60d"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("6e91f2e2-36ec-4147-8a9d-d36dcdd851f0"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("cb60f98e-2c8d-4b63-8d55-1c3162108f13"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("cd7c5767-8cc0-4d9b-a7fe-363cd6095580"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "ID",
                keyValue: new Guid("e23d003b-c015-4fc8-bf6d-519b8225d7d8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("1065337c-9786-493a-af84-665504b4188e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("248a564d-1e7a-4e80-89bd-473436a1de1b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("2e00bcb5-2ef0-4285-a566-61f6d6e00248"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("49b0612d-af88-49e6-9d28-6076fee4351c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("b11cfbec-0cde-4242-bc1b-b3040c4d008c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: new Guid("c0934d01-eb93-4d07-af96-972526b3733d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("302373eb-5d98-4965-a5ea-ec7d2d30265f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("84c8c820-520b-47f6-a200-10c1a4a514ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9bbe248d-577b-4ba7-ad38-f10a110a5e5b"));

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
        }
    }
}
