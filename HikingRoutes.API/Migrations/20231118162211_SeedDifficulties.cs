using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HikingRoutes.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDifficulties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7bcaea57-3e5f-4225-a59a-2f33c06b3fd8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b46a351c-3324-43ef-94f8-f2cbb6a64182"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d1185b46-f00b-412f-99d1-76dd4e666211"));

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9ebee7a6-5859-4f23-81f1-ab569ba8065a"), "Easy" },
                    { new Guid("cb3428c7-b8f9-4dc3-8144-63a628b46cf4"), "Hard" },
                    { new Guid("e7fbb735-8cbe-4b6e-8141-39858a54640d"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("4f805307-4978-46f3-9193-27dc66e89b87"), "BUR", "Burgas", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Burgas_in_Bulgaria.svg/1024px-Burgas_in_Bulgaria.svg.png" },
                    { new Guid("68476d26-3dc1-424f-8bc0-57b317c5b3af"), "VAR", "Varna", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Varna_in_Bulgaria.svg/1024px-Varna_in_Bulgaria.svg.png" },
                    { new Guid("7d4da82a-0725-464d-9688-c090fa4bc822"), "PLO", "Plovdiv", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Plovdiv_in_Bulgaria.svg/250px-Plovdiv_in_Bulgaria.svg.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("9ebee7a6-5859-4f23-81f1-ab569ba8065a"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("cb3428c7-b8f9-4dc3-8144-63a628b46cf4"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("e7fbb735-8cbe-4b6e-8141-39858a54640d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4f805307-4978-46f3-9193-27dc66e89b87"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("68476d26-3dc1-424f-8bc0-57b317c5b3af"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7d4da82a-0725-464d-9688-c090fa4bc822"));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("7bcaea57-3e5f-4225-a59a-2f33c06b3fd8"), "BUR", "Burgas", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Burgas_in_Bulgaria.svg/1024px-Burgas_in_Bulgaria.svg.png" },
                    { new Guid("b46a351c-3324-43ef-94f8-f2cbb6a64182"), "VAR", "Varna", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Varna_in_Bulgaria.svg/1024px-Varna_in_Bulgaria.svg.png" },
                    { new Guid("d1185b46-f00b-412f-99d1-76dd4e666211"), "PLO", "Plovdiv", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Plovdiv_in_Bulgaria.svg/250px-Plovdiv_in_Bulgaria.svg.png" }
                });
        }
    }
}
