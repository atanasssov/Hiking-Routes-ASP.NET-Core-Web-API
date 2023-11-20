using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HikingRoutes.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("777c4644-a5f7-42a5-a086-44ecd5ece1ce"), "Hard" },
                    { new Guid("b26b0570-cf97-49a6-a74e-acf6ed6c58d0"), "Medium" },
                    { new Guid("cfdb74d0-8ef8-43ba-81a5-cc6d5fe36270"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("5e3e72dc-d097-478e-91e2-fd075b3b882c"), "BUR", "Burgas", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Burgas_in_Bulgaria.svg/1024px-Burgas_in_Bulgaria.svg.png" },
                    { new Guid("6ed072ff-7d65-4288-851b-0d7669060ce9"), "SOF", "Sofia", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Sofia_%28province%29_in_Bulgaria.svg/1024px-Sofia_%28province%29_in_Bulgaria.svg.png" },
                    { new Guid("81ad011c-60f0-4969-90db-219e3e2a5728"), "SLI", "Sliven", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Sliven_in_Bulgaria.svg/1024px-Sliven_in_Bulgaria.svg.png" },
                    { new Guid("8b5ada31-046f-477a-92d2-e82fbffa5825"), "YAM", "Yambol", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png" },
                    { new Guid("95962c9b-61b4-4094-97bc-259125fbc1c0"), "SIL", "Silistra", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Silistra_in_Bulgaria.svg/1024px-Silistra_in_Bulgaria.svg.png" },
                    { new Guid("a85890ab-bfc7-41b4-b59c-aaab8cb61169"), "VAR", "Varna", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Varna_in_Bulgaria.svg/1024px-Varna_in_Bulgaria.svg.png" },
                    { new Guid("c94159c3-715c-4ed1-8649-6a28130d5563"), "PLE", "Pleven", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Pleven_in_Bulgaria.svg/1024px-Pleven_in_Bulgaria.svg.png" },
                    { new Guid("cdd626be-d005-4a66-b647-6b985c0976dd"), "VID", "Vidin", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png" },
                    { new Guid("da1d1365-ee7e-43f5-95f4-90b4eebaf65c"), "PLO", "Plovdiv", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Plovdiv_in_Bulgaria.svg/250px-Plovdiv_in_Bulgaria.svg.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("777c4644-a5f7-42a5-a086-44ecd5ece1ce"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("b26b0570-cf97-49a6-a74e-acf6ed6c58d0"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("cfdb74d0-8ef8-43ba-81a5-cc6d5fe36270"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5e3e72dc-d097-478e-91e2-fd075b3b882c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6ed072ff-7d65-4288-851b-0d7669060ce9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("81ad011c-60f0-4969-90db-219e3e2a5728"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8b5ada31-046f-477a-92d2-e82fbffa5825"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("95962c9b-61b4-4094-97bc-259125fbc1c0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a85890ab-bfc7-41b4-b59c-aaab8cb61169"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c94159c3-715c-4ed1-8649-6a28130d5563"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cdd626be-d005-4a66-b647-6b985c0976dd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("da1d1365-ee7e-43f5-95f4-90b4eebaf65c"));

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
    }
}
