using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05fe6198-1ced-443a-ad2c-5d9477df7449", "04ac35fc-94ad-4960-8e7d-b422610f7567", "Admin", "ADMIN" },
                    { "c6810e1a-b13a-433a-bf92-b04ee782ece9", "b7af16e5-0678-4ed2-ab80-69315f98f99a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62650392-e3a3-4208-9df5-10ff008cf831", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b4e6cb0c-ed43-4aff-a71a-5772968767d7", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENtu7BTQ/SacZMMKEwhax71NoYSD7HCxsY6dq7FBec+5lsBV5zxZ2IEt0+pjf+AyHw==", null, false, "8b20eacd-9bfc-48d3-850a-41529925cac2", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("022c8a26-b1e3-4d0b-af94-8569d47e61fe"), "Sweden" },
                    { new Guid("93044ce3-77d4-453f-95ad-648ba9a4a44a"), "Germany" },
                    { new Guid("45452a84-d7cc-48de-8dfb-2818b9471bce"), "USA" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("4468e7d0-30b0-4eb8-acee-f85f2070e892"), "English" },
                    { new Guid("8c659377-b25f-41d1-b355-f1f2dc08bd59"), "Swedish" },
                    { new Guid("ce71eef1-0fe8-495d-a8ff-e6e10713e6de"), "German" },
                    { new Guid("5ee2ca5a-f2f5-40e5-9544-7bcca5519709"), "C#" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "62650392-e3a3-4208-9df5-10ff008cf831", "05fe6198-1ced-443a-ad2c-5d9477df7449" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CountryID", "Name" },
                values: new object[,]
                {
                    { new Guid("7ad71a68-8329-4e80-aae0-2724aa09df11"), new Guid("022c8a26-b1e3-4d0b-af94-8569d47e61fe"), "Borås" },
                    { new Guid("3f8b480c-3913-4508-96ad-4967133cb3b7"), new Guid("93044ce3-77d4-453f-95ad-648ba9a4a44a"), "Dreamland" },
                    { new Guid("adc5c322-8f30-41f0-a472-a2fc6a7b56cb"), new Guid("45452a84-d7cc-48de-8dfb-2818b9471bce"), "Los Angeles" },
                    { new Guid("8f9cee4e-79f5-46aa-ad01-8d922479f497"), new Guid("45452a84-d7cc-48de-8dfb-2818b9471bce"), "Chicago" },
                    { new Guid("529b7340-0ded-4d89-ace3-17bf1a275181"), new Guid("45452a84-d7cc-48de-8dfb-2818b9471bce"), "Springfield" },
                    { new Guid("00a0c2df-0487-46a5-ac57-37b2807bf600"), new Guid("45452a84-d7cc-48de-8dfb-2818b9471bce"), "Albuquerque" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "CityID", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("f918763a-2e4a-45a8-8693-c16a6f343d8d"), new Guid("7ad71a68-8329-4e80-aae0-2724aa09df11"), "Anthony Hopkins", "555-6162" },
                    { new Guid("8678839a-dbfe-49ba-bfa3-93e71b5d2945"), new Guid("3f8b480c-3913-4508-96ad-4967133cb3b7"), "Somna Sculpt", "1-555-766728578" },
                    { new Guid("60462428-59e4-43e3-8f97-b4debedcc340"), new Guid("adc5c322-8f30-41f0-a472-a2fc6a7b56cb"), "Jane Doe", "555-123 45" },
                    { new Guid("b89407ba-c4fd-4354-948b-1838e1b3be77"), new Guid("8f9cee4e-79f5-46aa-ad01-8d922479f497"), "John Doe", "555-123 45" },
                    { new Guid("d967ea5a-0ab0-4e21-b6a4-9be6f5e921f5"), new Guid("529b7340-0ded-4d89-ace3-17bf1a275181"), "Marge Simpson", "939-555-0113" },
                    { new Guid("6785893f-9f6a-4560-90e9-5928c0543821"), new Guid("00a0c2df-0487-46a5-ac57-37b2807bf600"), "Saul Goodman", "505-842-5662" }
                });

            migrationBuilder.InsertData(
                table: "LanguageSpeakers",
                columns: new[] { "LanguageID", "PersonID" },
                values: new object[,]
                {
                    { new Guid("4468e7d0-30b0-4eb8-acee-f85f2070e892"), new Guid("f918763a-2e4a-45a8-8693-c16a6f343d8d") },
                    { new Guid("ce71eef1-0fe8-495d-a8ff-e6e10713e6de"), new Guid("f918763a-2e4a-45a8-8693-c16a6f343d8d") },
                    { new Guid("8c659377-b25f-41d1-b355-f1f2dc08bd59"), new Guid("f918763a-2e4a-45a8-8693-c16a6f343d8d") },
                    { new Guid("ce71eef1-0fe8-495d-a8ff-e6e10713e6de"), new Guid("8678839a-dbfe-49ba-bfa3-93e71b5d2945") },
                    { new Guid("5ee2ca5a-f2f5-40e5-9544-7bcca5519709"), new Guid("8678839a-dbfe-49ba-bfa3-93e71b5d2945") },
                    { new Guid("4468e7d0-30b0-4eb8-acee-f85f2070e892"), new Guid("60462428-59e4-43e3-8f97-b4debedcc340") },
                    { new Guid("4468e7d0-30b0-4eb8-acee-f85f2070e892"), new Guid("b89407ba-c4fd-4354-948b-1838e1b3be77") },
                    { new Guid("4468e7d0-30b0-4eb8-acee-f85f2070e892"), new Guid("d967ea5a-0ab0-4e21-b6a4-9be6f5e921f5") },
                    { new Guid("4468e7d0-30b0-4eb8-acee-f85f2070e892"), new Guid("6785893f-9f6a-4560-90e9-5928c0543821") }
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
                name: "LanguageSpeakers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
