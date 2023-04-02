using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Troshka.Blazor.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CategoryInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Troshka");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "Troshka",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "0Uun56AGjKNM2f07qMBS", new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(3995), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cars", "577532f1-4438-4a2d-a226-ea751f91fe5a" },
                    { "AhHuT41lRddLH1wachlm", new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Buses", "38ada8a6-a5f3-42e4-8b97-e88e0b6756f3" },
                    { "DARdvjHJcTyGCYGekfIn", new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4018), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Motorcycles", "6ddfbf40-cf4a-4566-a2af-9a722dcd3070" },
                    { "ExCL3LNxUqXNC8LFF8rL", new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trucks", "015b0d13-186d-4971-9fad-4572ac08bff2" },
                    { "GFF7R0xsM4muSxEG8k0J", new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caravans", "b7ae5262-cd7b-49db-828a-523bb7c8a811" },
                    { "lnm5mTuNV56JTQQYWPRe", new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4101), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Boats", "3574dd5c-354f-430f-bf0a-5240a2ebdd0f" },
                    { "NUSX1N5R2xUS9WfTo3lp", new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4118), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Construction", "cd80e9ba-b7a2-4b70-80e9-e7d9d4784b96" },
                    { "poo2JeVEhMn8wJz0KJdR", new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Agriciltural", "ffe20117-1803-44e2-a2da-08995c1372f9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories",
                schema: "Troshka");
        }
    }
}
