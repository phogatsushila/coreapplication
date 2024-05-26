using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace coreapplication.Migrations
{
    /// <inheritdoc />
    public partial class entitybased : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "difficulities",
                keyColumn: "Id",
                keyValue: new Guid("71ded2f0-bfef-456e-bcf9-dc946b4249da"));

            migrationBuilder.DeleteData(
                table: "difficulities",
                keyColumn: "Id",
                keyValue: new Guid("eca63935-cee2-4219-924d-9786d4357956"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Id",
                keyValue: new Guid("7662e6da-e2d8-4922-be8e-ee2f9229a433"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Id",
                keyValue: new Guid("b15305fb-dded-4261-9530-a3dd6f2f5d43"));

            migrationBuilder.InsertData(
                table: "difficulities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("007c0611-5674-4f33-b145-41c5d20a2737"), "Easy" },
                    { new Guid("599388f1-86ef-4427-acef-03e3be6d6b14"), "difficult" }
                });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Id", "Code", "Name", "Regionimageurl" },
                values: new object[,]
                {
                    { new Guid("4d3a7665-da45-4466-9033-230b2156f592"), "ghi", "difficult", "images/u.gif" },
                    { new Guid("566cbe50-640a-4fe7-8200-d567a16fe723"), "def", "Easy", "image/s.gif" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "difficulities",
                keyColumn: "Id",
                keyValue: new Guid("007c0611-5674-4f33-b145-41c5d20a2737"));

            migrationBuilder.DeleteData(
                table: "difficulities",
                keyColumn: "Id",
                keyValue: new Guid("599388f1-86ef-4427-acef-03e3be6d6b14"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Id",
                keyValue: new Guid("4d3a7665-da45-4466-9033-230b2156f592"));

            migrationBuilder.DeleteData(
                table: "regions",
                keyColumn: "Id",
                keyValue: new Guid("566cbe50-640a-4fe7-8200-d567a16fe723"));

            migrationBuilder.InsertData(
                table: "difficulities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e976a513-58fd-4baf-8add-8f239685dc5e"), "Easy" },
                    { new Guid("eca63935-cee2-4219-924d-9786d4357956"), "difficult" }
                });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "Id", "Code", "Name", "Regionimageurl" },
                values: new object[,]
                {
                    { new Guid("7662e6da-e2d8-4922-be8e-ee2f9229a433"), "ghi", "difficult", "images/u.gif" },
                    { new Guid("b15305fb-dded-4261-9530-a3dd6f2f5d43"), "def", "Easy", "image/s.gif" }
                });
        }
    }
}
