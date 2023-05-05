using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleaningProjectDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mighizmetimg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "img_path",
                table: "Hizmets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 440, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Hakkimzdas",
                keyColumn: "HakkimizdaID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 442, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "HizmetID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "img_path" },
                values: new object[] { new DateTime(2023, 5, 5, 11, 41, 7, 441, DateTimeKind.Local).AddTicks(693), "img.png" });

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "IlceID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 441, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Iletisims",
                keyColumn: "IletisimID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 442, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "IsBasvurus",
                keyColumn: "IsBasvuruID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 441, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "PersonnelHizmets",
                keyColumns: new[] { "HizmetID", "PersonelID", "TeklifID" },
                keyValues: new object[] { 1, 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 442, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 441, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "SosyalMedyas",
                keyColumn: "SocialID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 442, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "TeklifAls",
                keyColumn: "TeklifID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 5, 11, 41, 7, 442, DateTimeKind.Local).AddTicks(7421));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img_path",
                table: "Hizmets");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 49, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Hakkimzdas",
                keyColumn: "HakkimizdaID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 50, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "HizmetID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 49, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Ilces",
                keyColumn: "IlceID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 49, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Iletisims",
                keyColumn: "IletisimID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 50, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "IsBasvurus",
                keyColumn: "IsBasvuruID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 49, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "PersonnelHizmets",
                keyColumns: new[] { "HizmetID", "PersonelID", "TeklifID" },
                keyValues: new object[] { 1, 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 49, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "PersonnelID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 49, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "SosyalMedyas",
                keyColumn: "SocialID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 50, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "TeklifAls",
                keyColumn: "TeklifID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 30, 18, 11, 4, 50, DateTimeKind.Local).AddTicks(5123));
        }
    }
}
