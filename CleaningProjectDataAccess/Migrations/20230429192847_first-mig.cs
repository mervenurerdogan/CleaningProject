using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleaningProjectDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class firstmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Hizmets",
                columns: table => new
                {
                    HizmetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmets", x => x.HizmetID);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    IlceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.IlceID);
                });

            migrationBuilder.CreateTable(
                name: "IsBasvurus",
                columns: table => new
                {
                    IsBasvuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastEmployedCompany = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    StartEmployed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishEmployed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsBasvurus", x => x.IsBasvuruID);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    PersonnelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.PersonnelID);
                });

            migrationBuilder.CreateTable(
                name: "TeklifAls",
                columns: table => new
                {
                    TeklifID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TeklifDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HizmetID = table.Column<int>(type: "int", nullable: false),
                    IlceID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeklifAls", x => x.TeklifID);
                    table.ForeignKey(
                        name: "FK_TeklifAls_Hizmets_HizmetID",
                        column: x => x.HizmetID,
                        principalTable: "Hizmets",
                        principalColumn: "HizmetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeklifAls_Ilces_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilces",
                        principalColumn: "IlceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelHizmets",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false),
                    HizmetID = table.Column<int>(type: "int", nullable: false),
                    TeklifID = table.Column<int>(type: "int", nullable: false),
                    WorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelHizmets", x => new { x.HizmetID, x.TeklifID, x.PersonelID });
                    table.ForeignKey(
                        name: "FK_PersonnelHizmets_Hizmets_HizmetID",
                        column: x => x.HizmetID,
                        principalTable: "Hizmets",
                        principalColumn: "HizmetID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PersonnelHizmets_Personnels_PersonelID",
                        column: x => x.PersonelID,
                        principalTable: "Personnels",
                        principalColumn: "PersonnelID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PersonnelHizmets_TeklifAls_TeklifID",
                        column: x => x.TeklifID,
                        principalTable: "TeklifAls",
                        principalColumn: "TeklifID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminID", "CreatedDate", "IsActive", "IsDeleted", "Name", "Password", "Surname", "UserName" },
                values: new object[] { 1, new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(4204), true, false, "Ramazan", "E68r68.", "Erdoğan", "Erdogan68" });

            migrationBuilder.InsertData(
                table: "Hizmets",
                columns: new[] { "HizmetID", "CreatedDate", "Desciption", "IsActive", "IsDeleted", "Name" },
                values: new object[] { 1, new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(4682), "Açıklama hizmet detayları ", true, false, "Ev Temziliği" });

            migrationBuilder.InsertData(
                table: "Ilces",
                columns: new[] { "IlceID", "CreatedDate", "IsActive", "IsDeleted", "Name" },
                values: new object[] { 1, new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(5293), true, false, "Merkez" });

            migrationBuilder.InsertData(
                table: "IsBasvurus",
                columns: new[] { "IsBasvuruID", "Address", "CV", "CreatedDate", "FinishEmployed", "IsActive", "IsDeleted", "LastEmployedCompany", "Mail", "Name", "PhoneNumber", "StartEmployed", "Surname" },
                values: new object[] { 1, "Aksaray/Merkez", "blala bala blaaa", new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(5810), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "", "ayse@gmail.com", "Ayşe", "05966665214", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dumankaya" });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "PersonnelID", "Address", "CreatedDate", "Email", "IdentityNumber", "IsActive", "IsDeleted", "Name", "PhoneNumber", "SurName" },
                values: new object[] { 1, "Aksaray", new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(6916), "anakiz@gmail.com", "99966655599", true, false, "Anakız", "99966633322", "Soyad" });

            migrationBuilder.InsertData(
                table: "TeklifAls",
                columns: new[] { "TeklifID", "Address", "CreatedDate", "HizmetID", "IlceID", "IsActive", "IsDeleted", "Mail", "Name", "Note", "PhoneNumber", "Surname", "TeklifDate" },
                values: new object[] { 1, "adress", new DateTime(2023, 4, 29, 22, 28, 47, 101, DateTimeKind.Local).AddTicks(7082), 1, 1, true, false, "nur@gmail.com", "Nur", "istenilen hizmet detayları örn m^2 vs vs yazılır", "33322211144", "Al", new DateTime(2023, 6, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "PersonnelHizmets",
                columns: new[] { "HizmetID", "PersonelID", "TeklifID", "CreatedDate", "IsActive", "IsDeleted", "Price", "WorkDate" },
                values: new object[] { 1, 1, 1, new DateTime(2023, 4, 29, 22, 28, 47, 101, DateTimeKind.Local).AddTicks(3823), true, false, 5, new DateTime(2022, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelHizmets_PersonelID",
                table: "PersonnelHizmets",
                column: "PersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelHizmets_TeklifID",
                table: "PersonnelHizmets",
                column: "TeklifID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_IdentityNumber",
                table: "Personnels",
                column: "IdentityNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_PhoneNumber",
                table: "Personnels",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeklifAls_HizmetID",
                table: "TeklifAls",
                column: "HizmetID");

            migrationBuilder.CreateIndex(
                name: "IX_TeklifAls_IlceID",
                table: "TeklifAls",
                column: "IlceID");

            migrationBuilder.CreateIndex(
                name: "IX_TeklifAls_PhoneNumber",
                table: "TeklifAls",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "IsBasvurus");

            migrationBuilder.DropTable(
                name: "PersonnelHizmets");

            migrationBuilder.DropTable(
                name: "Personnels");

            migrationBuilder.DropTable(
                name: "TeklifAls");

            migrationBuilder.DropTable(
                name: "Hizmets");

            migrationBuilder.DropTable(
                name: "Ilces");
        }
    }
}
