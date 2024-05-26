using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace coreapplication.Migrations
{
    /// <inheritdoc />
    public partial class dbentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "difficulities",
                keyColumn: "Id",
                keyValue: new Guid("e976a513-58fd-4baf-8add-8f239685dc5e"));

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
        }
    }
}
