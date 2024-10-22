using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CentalFile.managment.api.Migrations
{
    /// <inheritdoc />
    public partial class addseedcompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Identificaction", "IdentificationType", "Name" },
                values: new object[,]
                {
                    { new Guid("6ba5217d-a12d-4d70-a42c-8a64c3f509eb"), "123456789", "NIT", "centralfile" },
                    { new Guid("9f97249c-be60-4d4d-b31b-ede77f24db4d"), "987654321", "NIT", "Company 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6ba5217d-a12d-4d70-a42c-8a64c3f509eb"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("9f97249c-be60-4d4d-b31b-ede77f24db4d"));
        }
    }
}
