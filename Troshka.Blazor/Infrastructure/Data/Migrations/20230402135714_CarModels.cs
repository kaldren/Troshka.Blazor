using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Troshka.Blazor.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CarModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Models",
                schema: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBrandId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalSchema: "Cars",
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "06MxFkB3ArFfVraVWN1u",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5676), new TimeSpan(0, 0, 0, 0, 0)), "b0326d3a-e9e2-4927-a057-922aeba786ec" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "0SlIJFKD3VdaMAEnxfTT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 0, 0, 0, 0)), "35153f2a-a052-4f8f-967e-27495e43e239" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2FEzeyYHYe3zlhjMeaEF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 0, 0, 0, 0)), "d96dda25-2f16-4e60-b498-b32ea26e1ba2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2SBENlnqR76XRNAjbAs3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 0, 0, 0, 0)), "cc08e4b1-a4dd-45b5-be3e-75db9f9df35d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2VS5yLgAuj7VmYeRVxTD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5725), new TimeSpan(0, 0, 0, 0, 0)), "e864c61a-297a-45ae-add5-c5bec36f266e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2xSRLgR4QgzYhDLjfgAM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 0, 0, 0, 0)), "75fb7dba-e565-4757-a2e1-d2b364a1a24c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "3qGrKAnyJ2rmHlevXb8c",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5740), new TimeSpan(0, 0, 0, 0, 0)), "a88d8af2-1dfa-4f8f-99b1-bb73fc341013" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "3yTpJND7nxjtqoDcuc5M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5747), new TimeSpan(0, 0, 0, 0, 0)), "df673e4f-cb76-4f31-8a61-c7c6d4565d0f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "470SJrcKER8YaPHSS0br",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 0, 0, 0, 0)), "7574cf06-6117-4ed7-9ce3-81503c740de5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "48xSUCHrRIfABkLmGHxD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 0, 0, 0, 0)), "9e87e704-59b5-4d83-ad71-d581fc5d05f7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5aFWwvagmpfBWQlHxU5M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 0, 0, 0, 0)), "84884c1a-c28a-4a27-a71e-86b042d0b103" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5kDhCqXf6JTAIvz61oEz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 0, 0, 0, 0)), "7367e240-f68a-4d41-af40-c2fb83a5afed" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5TgVdpBPF4SsQWVFP08j",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 0, 0, 0, 0)), "36580ced-7187-4a18-9030-67967ae83d30" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "65B72rCez5bGWR7Po3Ny",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5877), new TimeSpan(0, 0, 0, 0, 0)), "b72641be-0b40-412f-8a1b-3a11c020e03c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "6mI4J3fGUdG5KvEHYjqL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5885), new TimeSpan(0, 0, 0, 0, 0)), "f577e792-972a-4a2b-be4d-5368d025adf8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "7ReFhJXxyx7pAkvlW1eS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5891), new TimeSpan(0, 0, 0, 0, 0)), "480a960b-7c4b-4423-a629-d1d4f9ed2f4a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "8mIlNn2498yIC72vgKBK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5897), new TimeSpan(0, 0, 0, 0, 0)), "3aa51b0a-00f2-4aac-a26b-8542fa046a1c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "9NRn3UNnrPnf2yJoGIBH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5903), new TimeSpan(0, 0, 0, 0, 0)), "53a537d1-8b9e-4b63-a8b9-e9ee1ffa6a25" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "aPIB6410rSAP3jxueo2Y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 0, 0, 0, 0)), "4b1c348a-ad97-41b7-94dd-a5a8be3c2fc6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ATbb9NezfDxSdpBXdqd6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 0, 0, 0, 0)), "d48edfa0-6112-4ca7-8e58-3e1789d483b1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "axxx6410rzzz3jxueox5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5916), new TimeSpan(0, 0, 0, 0, 0)), "9cd7da85-9b86-47ae-bba5-d49d012d19a5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "B42TXsELwNJNBewRvcu5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5927), new TimeSpan(0, 0, 0, 0, 0)), "6cc82d15-ce93-4b39-b960-636bf4c9b130" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "BESQA89ghmpmxnMv6lb4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5934), new TimeSpan(0, 0, 0, 0, 0)), "1ff4a4f5-71ed-46bd-8c29-80888f0a7118" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bshsdfzU1lNaPe58k9Io",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5961), new TimeSpan(0, 0, 0, 0, 0)), "960faf2f-d19e-4766-b1cb-3d046ea02aa2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bXGDbcoVlUUFaUAeuBhU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5967), new TimeSpan(0, 0, 0, 0, 0)), "157b0357-dbc1-4471-9e7a-4fb888de7d5d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bymbQs0TabKzPsrN3TlL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5973), new TimeSpan(0, 0, 0, 0, 0)), "0c9f6d89-f9f4-4538-b80b-5a7bc5fb66a4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "CDKhu32A8uPkeWM4eblC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5979), new TimeSpan(0, 0, 0, 0, 0)), "e3864895-8101-437d-bd07-63ab2f53a2b1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cjnwEk8Wle037jtonYsj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5985), new TimeSpan(0, 0, 0, 0, 0)), "7f58f046-5ba5-4b4f-b638-c20a5ce38c4f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cYgoBzV1QqkgGALBMqxE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 0, 0, 0, 0)), "8ad299ea-fc14-44ca-a878-b1701fe6641c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cYlq5o6z4W9RcnLLB6zq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5997), new TimeSpan(0, 0, 0, 0, 0)), "b6a91daa-d135-4eff-91f6-b0c72a8d4c95" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "D67BxpjC6stcD4YYGmdn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6004), new TimeSpan(0, 0, 0, 0, 0)), "e8dc75e2-9c21-4744-8759-db968cf71e9e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "D6a4Vo3VE2WzDdgA5AFo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6010), new TimeSpan(0, 0, 0, 0, 0)), "5efd51bf-4d36-45e5-9ef4-e843a18dbcb7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "d6V8Py7xGhHTTVvS02QR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6072), new TimeSpan(0, 0, 0, 0, 0)), "f5acbd98-e89b-4702-9783-3b71b016561b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Dfej8VedBqRvW5SVCeo3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6079), new TimeSpan(0, 0, 0, 0, 0)), "dc1ad363-dc52-4a4c-b50f-fe8db77e71eb" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "dksqVUhgDuHJ9KJ2uqyP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6085), new TimeSpan(0, 0, 0, 0, 0)), "d4f9bcb7-09ca-4b9e-bbdd-a28a50805290" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DsQDYqGhCx8KL7zF4UFK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6091), new TimeSpan(0, 0, 0, 0, 0)), "c1c9e0ac-5bc8-497f-acce-ceb6b29766e2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DumA309cvKSKLalqcW6h",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6096), new TimeSpan(0, 0, 0, 0, 0)), "d4df7dce-b5b1-4cf7-8986-ab224a83a193" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DV94kh1MyMbGW3P4aac5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6102), new TimeSpan(0, 0, 0, 0, 0)), "ed60e7b4-b180-4bc3-9237-6358dfd1f449" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "e7NrNKeWFc73uCAkz1Ar",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6109), new TimeSpan(0, 0, 0, 0, 0)), "1427cfa6-0cc9-48f6-a74f-238b09145927" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eF1lrB1EP63Y0DablBJF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6115), new TimeSpan(0, 0, 0, 0, 0)), "6d89458e-821a-4959-b6ab-ecc5f0aafdbe" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "EMczl7VAvCRwT3kAz4In",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6122), new TimeSpan(0, 0, 0, 0, 0)), "5fc70f39-40f7-49f4-8658-e9a419929f64" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "emn3h8NrhdSz7ojPBV2H",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6127), new TimeSpan(0, 0, 0, 0, 0)), "0eb55122-a2f0-422c-8030-8b0c2a489715" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "etMtb4JLm7eB90mlnd72",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6155), new TimeSpan(0, 0, 0, 0, 0)), "157c558f-38ad-402f-8f3a-c2bba9a7d219" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eUMYrz00U0nQH5KTc7uR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6161), new TimeSpan(0, 0, 0, 0, 0)), "14894f5f-be9e-4cbe-98ac-4cf5137fc40a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "fAVrUUNVKFbMuNlP7oUW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6166), new TimeSpan(0, 0, 0, 0, 0)), "fd2d1830-f1ef-48d3-a7a1-9c5abdf1228e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FcCNt3RVlzMFl9Jtw38m",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6172), new TimeSpan(0, 0, 0, 0, 0)), "a43e4fdd-5688-45e1-a83b-7674f2586644" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Fjw2xBL9BqCaQBzxcxDI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 0, 0, 0, 0)), "11bd0159-2b75-41d9-867d-c9624ae279b6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FtX2HosXUQDnvSScsyP8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6186), new TimeSpan(0, 0, 0, 0, 0)), "cc0e23cc-e718-4192-9c71-f11477c3ed11" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FXHe5SU6zyIfYHPGygNC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6191), new TimeSpan(0, 0, 0, 0, 0)), "d338ba27-132b-4b88-b2c2-34f046487810" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "GBnMMAvdjskIFpKTYLb1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6197), new TimeSpan(0, 0, 0, 0, 0)), "6f066ea4-f966-4397-938f-82c82f4a8f05" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ghyFhm7jzcjYDrjMVLs1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6202), new TimeSpan(0, 0, 0, 0, 0)), "1b5828f3-308c-48a6-afa9-7b51fa1da363" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "gXuBjVjveGKf3R9Kc9vE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6229), new TimeSpan(0, 0, 0, 0, 0)), "39079e78-1f30-4cc9-a66f-fa622df80b09" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "h6Bfvk5LdFwXv9QzKLxU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6235), new TimeSpan(0, 0, 0, 0, 0)), "454b13a8-5378-484c-a116-4bd32929af2f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hajLAGmn9WWXQco4CXw1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 0, 0, 0, 0)), "86f9d974-77a9-401f-9946-99d160aa88f1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Hc1zhgoBCF1639Rp1PkY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 0, 0, 0, 0)), "d4afea0b-1f81-4931-a38d-2f6ee87f3ee6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HhvYG9GBNEg7RhQBIjtY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6254), new TimeSpan(0, 0, 0, 0, 0)), "d3e6a6fe-f790-4547-84f1-5917e8f25e6a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HKjqbIm3EQ96YdfpakFI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6259), new TimeSpan(0, 0, 0, 0, 0)), "5676c0df-5cec-4070-ba80-dd1de5b709f7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HrERVHUdBMrdUrgLsvuT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6265), new TimeSpan(0, 0, 0, 0, 0)), "6c1ea6f5-e21b-413a-a0fc-fca9a520d8c3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hy7DsFSFE0ugKvGj8Hfk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6271), new TimeSpan(0, 0, 0, 0, 0)), "de43c9e9-c543-41d1-a751-2a601d30057c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IIqtbBpQcKHy7TVA10Nl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 0, 0, 0, 0)), "977340d7-2725-48b6-931b-e2e1d1cdc63b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IR6qs66ukTVnB4w0NIFq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6283), new TimeSpan(0, 0, 0, 0, 0)), "2d0d6f24-89e9-4054-8745-5abf74faf474" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "j0N3jEL5HfQ9Ve0KVNUl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, 0, 0, 0, 0)), "7c588a40-8c0f-46f8-b966-a22d671ed2ef" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "J3wnurM4CgKVkRFfRvHs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 0, 0, 0, 0)), "d0209d20-53fb-476d-bb54-70bf8485a111" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "JqgJmqpSsWvQ7b60GLvq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6321), new TimeSpan(0, 0, 0, 0, 0)), "e3af4576-1062-4706-9ff6-c35c3c32bf9b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "jyCumAseWnFjQjPzn3kQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6327), new TimeSpan(0, 0, 0, 0, 0)), "3ebc3121-7bb4-4c11-b01d-8189cf0c5daf" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "k4Lylg5nrM6Vt1MrWfxS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6333), new TimeSpan(0, 0, 0, 0, 0)), "bf23eae7-426b-4bb0-8c90-87b8dc09d39d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KCEkkBQL72L0jmEutbgl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6340), new TimeSpan(0, 0, 0, 0, 0)), "fcbfe550-68d1-44b9-8bb5-d4f8b787e93b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kF0x9WcUJs7aHYtoKzWY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6345), new TimeSpan(0, 0, 0, 0, 0)), "58e47d0d-689d-499e-af82-47ecce4941e3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KQMma7dRwtXlcym9oSWC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6351), new TimeSpan(0, 0, 0, 0, 0)), "c5b0f69b-2611-44bf-8c06-baa91b1e4d4b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KRmmVEwPAtzSzJQgD6HY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6357), new TimeSpan(0, 0, 0, 0, 0)), "e9976f67-0321-4a7b-b6e2-9c4f50bd8404" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KvyHwQN3QMrXmgbsvne9",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6385), new TimeSpan(0, 0, 0, 0, 0)), "69c5ab28-79ff-4e15-b68b-3da3dc37b669" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kXULxNaVDJWKs2ACmH5C",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 0, 0, 0, 0)), "fb222394-b272-4f3d-9500-d0efa2523d06" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "l5Xv7WgEwDFBEEnFG9uC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6397), new TimeSpan(0, 0, 0, 0, 0)), "81dfdd7e-3ffb-4b6c-b273-0d605d968ff4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "laJM8lrsRY8D0eRYypqk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 0, 0, 0, 0)), "411e5437-0333-424b-b353-7f6d91da6c32" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "LcuKvSewzBSW3KEJdLIa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6409), new TimeSpan(0, 0, 0, 0, 0)), "f86a4023-a67f-48f1-8ea5-562231ac8256" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "lEVEcrE9FIVtGbtFarHV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6415), new TimeSpan(0, 0, 0, 0, 0)), "891156e0-1e75-41bd-b915-97e37097f29e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "lgRSEHsdarS0gC4osQWQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6420), new TimeSpan(0, 0, 0, 0, 0)), "84906d2c-f5d8-4b0a-8808-dcdbd70b7d50" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Lxge9Bn07u7pWE0RqbwJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6426), new TimeSpan(0, 0, 0, 0, 0)), "4fa2f078-62d0-4d6e-b4c8-d05ed726ea63" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "m5L90Q8l2fTcbPyeA3GF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6433), new TimeSpan(0, 0, 0, 0, 0)), "e0c0ddcf-0a66-444a-a95c-bb0b11d3d426" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "mEjXfYc5wzIHYnGGpCbE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6439), new TimeSpan(0, 0, 0, 0, 0)), "ad855c5d-cf13-4ed2-bb8c-a5501f21c7b7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MlFe1uw8xqqhdAUnqcHd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6479), new TimeSpan(0, 0, 0, 0, 0)), "b8570dd1-b377-47de-89e0-1d2d1ee68a60" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MvMqrrJaUbAAVIvJHQcu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6485), new TimeSpan(0, 0, 0, 0, 0)), "75feea6f-d84a-416a-a24c-f68f64778b61" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MX3aL9JN6gD0F4KRl0Nq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6491), new TimeSpan(0, 0, 0, 0, 0)), "d82f3486-c8a6-4f1a-bab6-bf609a60fab6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "n1jg2wtcteSRvhvMGm4n",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6496), new TimeSpan(0, 0, 0, 0, 0)), "0996888d-860c-48cc-ac3f-e99125be42c3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nDxKpo5IAKk62ekEBbNS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6502), new TimeSpan(0, 0, 0, 0, 0)), "c7dafd8f-36fd-4c16-8bf7-065309886582" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nm2AJSoa0dWnayDNBRnh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6508), new TimeSpan(0, 0, 0, 0, 0)), "d369ad2d-cfd4-4a9a-8781-5a851d4014cd" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nsITvMBs2Ujtv8rQ0KJM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6515), new TimeSpan(0, 0, 0, 0, 0)), "10aa34f8-5765-41c1-b513-1eef9a048b40" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nul5YjFdxToWeg1GrlCX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6522), new TimeSpan(0, 0, 0, 0, 0)), "6046c6b8-8609-4571-bea9-8ffe283a45e7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nWD6UJdXnV7cjq8tP6R8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6527), new TimeSpan(0, 0, 0, 0, 0)), "bf682a51-3d69-441f-b538-69e1f15dd846" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "oyETMjvBlpVLEDFlVADI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6553), new TimeSpan(0, 0, 0, 0, 0)), "462b123b-1018-498b-b817-d5aa249a5ce2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "p4hD4RsKIPD68JMtt4N2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6559), new TimeSpan(0, 0, 0, 0, 0)), "fe4b366f-e64b-41d8-a707-243cc84bd621" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "p6Wbw5sW2Fj67lvp482v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6565), new TimeSpan(0, 0, 0, 0, 0)), "09b19e74-729e-40ba-a2e1-4825f25cc3a7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pjQ5tv7x5L1UYaKzhokc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6576), new TimeSpan(0, 0, 0, 0, 0)), "7b34c31b-8f20-4b7d-aad6-e8fdae7ddb72" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "PpQFVF4cAQlfX3BppjFB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 0, 0, 0, 0)), "3b8192cd-568b-40e2-b3b0-cbd3b1ec0e42" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "PsbTIAKWHCVgruG7IgRE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 0, 0, 0, 0)), "8a6c66d3-9daa-4df0-b82d-54a6894fa8ed" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pTCUtnhqCmkJALgYU8NY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6596), new TimeSpan(0, 0, 0, 0, 0)), "2635eaf8-2ad3-478c-b6e1-3bac35593140" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Q6kJ5uDgBmklCCBwofrx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6602), new TimeSpan(0, 0, 0, 0, 0)), "9a9b74c7-c09d-4ffc-b3b7-1390fca468b4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QExc6n8HRxp39gGTKXSt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6607), new TimeSpan(0, 0, 0, 0, 0)), "3972e33b-e576-43dc-8ca8-3faa7509d199" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "qnkV2dT7G6arP780Dwxs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 0, 0, 0, 0)), "cccb7be4-fed7-4d59-bdf1-9d65ea5d26df" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QojugShL0F4QRXbwv1r3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 0, 0, 0, 0)), "8714b632-af44-4860-977a-44f58f457095" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QS0jwSg5owyS3XS5xnbY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6647), new TimeSpan(0, 0, 0, 0, 0)), "482491eb-a3d7-45ac-9919-d6fd2d7b515e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "R0e7DzoQBFL5UIyTpqDP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6654), new TimeSpan(0, 0, 0, 0, 0)), "cac15d6b-4830-48f2-adf4-27598b5ffbe5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "R9BIHlzCwb67GPT89e7F",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6659), new TimeSpan(0, 0, 0, 0, 0)), "18ad17c6-11ff-481a-a32a-9fa7f18f589e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RgqbbBCJaJLWTlu87M9R",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6665), new TimeSpan(0, 0, 0, 0, 0)), "3260c314-5120-4332-844e-7881b6dfff94" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RRr4RDrnqyqmT3ehdy6Q",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 0, 0, 0, 0)), "1f1f9045-fd31-4a56-b4f5-d528f477a424" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RuSMmRIATbwWRYSkgIrH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 0, 0, 0, 0)), "354b74bb-e384-4f8f-936a-09735b86ef27" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "rYJp3Jg61wKdUqFGSAp3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6682), new TimeSpan(0, 0, 0, 0, 0)), "8e4ca3cf-0cd1-4cc3-bc89-56d7467bb23b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sAKTDDgl9EDeyYnG77R8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6689), new TimeSpan(0, 0, 0, 0, 0)), "163836dd-edd0-4b02-8327-5b24643730b6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "SGKURGhEbYHIdqkxpDJh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 0, 0, 0, 0)), "81699a20-db23-40e5-abf2-430a0accca9e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Sn4CRrl6hfVTTra5B0pd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, 0, 0, 0, 0)), "8d29959a-1f68-468e-9c5f-d69a68fcd66c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sQ5C4f7H60rzJLhMA0T5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 0, 0, 0, 0)), "b5c87ca8-cdd9-4dc2-a752-486af90fb954" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sSh78RpjbHGvjL43TzMl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6741), new TimeSpan(0, 0, 0, 0, 0)), "7f59dea1-918c-4b1d-ab21-0b5f94598f00" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Sw3e46nyzgd7zmMPVG4r",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 0, 0, 0, 0)), "64239fb4-e31e-4f17-b7ee-02854563bd12" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sx9Vqv3yxRnX4SGwQa4y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6754), new TimeSpan(0, 0, 0, 0, 0)), "6eafc002-b313-41c8-8a6b-75c90c608614" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "T8karRTfSTcM29oupBnt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 0, 0, 0, 0)), "f1f25eb4-0d2c-40c3-a91b-2630563919cd" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "t9gPoXWQAlKYkzxc7EaK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6765), new TimeSpan(0, 0, 0, 0, 0)), "b5f751fc-7cc0-4669-aad2-43e7bc691cdb" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TjjXJlSeru5Ccm3G2Vet",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6771), new TimeSpan(0, 0, 0, 0, 0)), "a66f5b41-6093-493f-ab7c-c6a3f22bffe9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TJTAqICS7fjRu8I4afxm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6799), new TimeSpan(0, 0, 0, 0, 0)), "a8d3ffa1-b36f-4673-b29a-14ef1139f0fa" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Tuaz0kuNQvU5jsy459u2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6805), new TimeSpan(0, 0, 0, 0, 0)), "85065efd-e8cc-456b-8ae4-1efcb6a5dcdf" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TXVRNj5SbqClTvNfEI8c",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 0, 0, 0, 0)), "76302c94-3975-4f2e-a235-962cfbbad485" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "u3lzgWdKo9KaByo34lmN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 0, 0, 0, 0)), "a40e9c77-5405-45d9-b5cd-752abb06c694" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UG6N8tBL4hpBPkjX12Bh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 0, 0, 0, 0)), "60eaaaf0-e764-4ac7-a5eb-5f4d8d5bd7f0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ulCdKx22IbD50hbfYtIE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6828), new TimeSpan(0, 0, 0, 0, 0)), "ca102d28-7f71-4920-8b24-3b2b42dbe2b4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UpE1pLHfAgAQDHEVWdAb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6834), new TimeSpan(0, 0, 0, 0, 0)), "5bd2c100-2344-45f1-b295-c7fc8a19d816" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UpsGGKBQ2fXfNQBgABoF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 0, 0, 0, 0)), "b29f53f4-413c-4d51-8e85-d664f5f804ed" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "v1Q2gNvx2B1YX6h2w0TR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6847), new TimeSpan(0, 0, 0, 0, 0)), "c4ecc9e8-53fc-4350-9a2c-c3850ed68dd2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "v4vruTNk6WkdcxN3fFA0",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6853), new TimeSpan(0, 0, 0, 0, 0)), "88a4688c-ccf7-4fc2-a533-49250e951a9b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "V9HWmNFfpUS2Y5eLqrct",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6878), new TimeSpan(0, 0, 0, 0, 0)), "5c58d13a-acf5-4fea-b0b2-4bb4bf6aeabe" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vMFor3Ks1QECjDpWHUqW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6883), new TimeSpan(0, 0, 0, 0, 0)), "5c2c3ec5-a0d0-4f14-887c-b87c4fd59fe9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vYf86TFDqUkh9RcEN9VN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6890), new TimeSpan(0, 0, 0, 0, 0)), "eeeae40a-cbe9-4de6-951c-2e575b5d7cff" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "W5TnArCA9xCEodsTpDHG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6896), new TimeSpan(0, 0, 0, 0, 0)), "19868d31-deb3-4827-bbc2-9200ba61ee40" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wC0Q8eUqQLkE6cpVwHgu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6903), new TimeSpan(0, 0, 0, 0, 0)), "4393a61f-5e2b-4515-a350-dbe6f485f549" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wDseIgWSpqkLesX2ftwn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6909), new TimeSpan(0, 0, 0, 0, 0)), "a272b261-01b3-4e20-80c2-0dcc3f8df666" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "whPfE6p1LaKgaGTWoNqj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 0, 0, 0, 0)), "efeecca4-766b-4401-aa8c-949ba3b1c755" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wMQSzkfJzJhYwfV22Ew6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6922), new TimeSpan(0, 0, 0, 0, 0)), "12ab8c74-272c-4932-b4d2-4778d4cda7c7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wwSqJWvMPuau2LBxW24w",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6927), new TimeSpan(0, 0, 0, 0, 0)), "162dd2fc-0e5c-4ec2-9cd9-1418a0f4c0c3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XECbl6phGcsYXQWHwrT7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6952), new TimeSpan(0, 0, 0, 0, 0)), "821281ac-9717-4864-9904-f1dd3231616c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "xHqKd4nN6cMLEAaL4zdp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6959), new TimeSpan(0, 0, 0, 0, 0)), "96462c06-b04f-4eee-bf60-c89ba08eacc6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XQ0Nk2N0zDYDydY9CEpC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6964), new TimeSpan(0, 0, 0, 0, 0)), "17b1c939-22ae-43ed-89bd-fd011c0852d1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "xqP1xuan2MoXnMkwolM7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6970), new TimeSpan(0, 0, 0, 0, 0)), "b2d02f55-203e-4114-9114-7a99da4a78b9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Xsx7AcUNguMUYwC2eInr",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 0, 0, 0, 0)), "64201653-d26c-417e-b629-b17c2c34c5a6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XW7Xpw80z3VgX82egcWN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6982), new TimeSpan(0, 0, 0, 0, 0)), "3405bb6d-0b53-49b3-8b6b-b67c2fbefaae" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Xz43eo1VM5H41uNJ9x28",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6988), new TimeSpan(0, 0, 0, 0, 0)), "7e7dff72-b878-4e03-953c-b4c4ff96ef02" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yjnmBGS0tfeUY6wppqlL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6994), new TimeSpan(0, 0, 0, 0, 0)), "e043fbdc-595b-4f43-ad60-765f8e10b6cb" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YK3JYVEmHcskgB4f1s9M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 0, 0, 0, 0)), "9524c147-d29a-42e1-a25f-1252499fc787" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YK3zzVEmH55kg41f1s2M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 0, 0, 0, 0)), "90b94b84-9dcd-403e-9db2-423c8281afd3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yL0kvEf81nf8Sd7CGQys",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 0, 0, 0, 0)), "6182fdc9-0b95-416a-b758-d677d9048bb4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YSHfWTR5rJ8vCR2S95xp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7035), new TimeSpan(0, 0, 0, 0, 0)), "b257e44e-ba71-4f1d-8805-b9c11cf5c355" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YUWNuWGy76j0cK9LWTP8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, 0, 0, 0, 0)), "edd4dc77-ae20-4d57-89db-05c0d38ecef2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zlaX6newWoQPagELHC4J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7049), new TimeSpan(0, 0, 0, 0, 0)), "4e873277-86d0-4fc1-8f3d-66361033b208" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zmtbQwqcCyHjrSKk77Se",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7055), new TimeSpan(0, 0, 0, 0, 0)), "cbb9d830-f8d9-40e8-be2c-3ef232228462" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zpPwsvLWKJ4CmjHmU1ES",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7061), new TimeSpan(0, 0, 0, 0, 0)), "ac3e58af-4d94-4a48-b1c8-8b07321cf4d4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zvQcGcl1nR7SpAfIMvxF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7067), new TimeSpan(0, 0, 0, 0, 0)), "75f7e20f-2b1a-4ed4-960b-9f0de6853276" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zzzbw5sz2hj27fvp4x2v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 0, 0, 0, 0)), "3416834b-6e77-42f1-876e-22e598c2cd5e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0Uun56AGjKNM2f07qMBS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5387), new TimeSpan(0, 0, 0, 0, 0)), "a556f4b0-c06f-456a-a3e9-a3ed7fa8f1ee" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "AhHuT41lRddLH1wachlm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5395), new TimeSpan(0, 0, 0, 0, 0)), "8b1b1967-f523-4fdb-aa69-687fe94bb54f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "DARdvjHJcTyGCYGekfIn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, 0, 0, 0, 0)), "c547ca13-e3d3-421b-883f-ff5f391fc10b" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ExCL3LNxUqXNC8LFF8rL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5408), new TimeSpan(0, 0, 0, 0, 0)), "0f349798-dced-4442-bae9-f8b9c5ef56f9" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "GFF7R0xsM4muSxEG8k0J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5414), new TimeSpan(0, 0, 0, 0, 0)), "009dda8d-fc2e-41f3-aa8b-c5aa6ab9da8c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "lnm5mTuNV56JTQQYWPRe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5420), new TimeSpan(0, 0, 0, 0, 0)), "e6f9d258-2fb9-496b-8ac6-b58ba186a7c3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "NUSX1N5R2xUS9WfTo3lp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5436), new TimeSpan(0, 0, 0, 0, 0)), "92024d34-159e-4f2a-bb14-637bb33b9a2e" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "poo2JeVEhMn8wJz0KJdR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(5466), new TimeSpan(0, 0, 0, 0, 0)), "cdc23866-9623-4b7a-9e03-286e0a01f983" });

            migrationBuilder.InsertData(
                schema: "Cars",
                table: "Models",
                columns: new[] { "Id", "CarBrandId", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "03K0czqfwqFQlxQ8GXQm", "FcCNt3RVlzMFl9Jtw38m", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GV70", "c469eacb-d1b2-4fa4-8677-12337ca9b609" },
                    { "0400GAEAlYg0T0znexRv", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21412", "aa2d26bc-ba49-4489-8c8d-298141bda467" },
                    { "053I2jUnjV4wsKrnn3Mv", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6961), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gallardo", "5cc25ac3-c3ba-4c5f-bae3-3ea7a3b99807" },
                    { "0A0KXo5l7x4uFE3VdUaT", "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1872), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2", "e442b18a-4b95-4f40-968f-c23465e86eec" },
                    { "0b5tM0DT1xxU1y4lFRjP", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(822), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 53 AMG", "aaf68551-5023-4c60-82cd-aae6e97ef7b7" },
                    { "0C5NA9ebjT7cvTL1Y0LD", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9046), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "528", "c9332704-d17e-4651-ac92-f3bc05922623" },
                    { "0cQccNzsrrMQGBaNS9zW", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Haval H2", "bb15590c-7546-4067-b70c-0e12c1f7e35d" },
                    { "0Fk1jsosCpJYSWmk3aK6", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1510), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hijet", "3caac7cb-0208-4658-8384-e0fdd2ab25c2" },
                    { "0gbK809hdtSGgHoU1kDd", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3897), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hover Cuv", "3f7f17da-19e4-49f2-83d4-aa96b4018c30" },
                    { "0GTfrxaUkLQqgc47T7ht", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4813), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scala", "d87daced-31e4-4f7a-abac-2d65eb457e00" },
                    { "0HTrnyr8MkTz64x1q0Jt", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1290), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pajero sport", "49a49dc2-1a1b-489d-b792-bb69ddb1bf2e" },
                    { "0Hxb3TIG5vE4kp78Io9y", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z3", "81ec904b-31b4-4d84-bb24-55fbf54bfca1" },
                    { "0JEfXCuFM9S9fINYGClg", "CDKhu32A8uPkeWM4eblC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1031), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Formentor", "41dc5eb2-c3ba-4ed3-9d4e-788fe2656f32" },
                    { "0jhICzvFsTMEqWSyImz9", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2765), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Traveler", "1c3adbfb-e475-407e-a799-1b516bb96141" },
                    { "0L6vb31wN8gQd6omFF3K", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9815), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Riviera", "8d015852-98a2-4dc4-9713-14c4b309697a" },
                    { "0Nb9bf96INz0gbd66Hhs", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(561), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vision", "fe7d4f3b-708a-4187-8647-975b4e6b69ff" },
                    { "0oe7Tkp47Ekw2gTLTJ9P", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 43 AMG", "b71cfbc1-81da-434f-a4fb-218c5d391d3b" },
                    { "0pxyJdLx92env5E5jmBw", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Harrier", "c3d966e5-ec1d-4969-b5da-fab79ad6d7b5" },
                    { "0qhnXR9p84Wx3dE2XNhz", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(900), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SLR", "59047dfd-1751-40f3-b51f-23d03aa95940" },
                    { "0qYbM2UtsW05EbqrEKo8", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EQV", "aca2e765-3a91-459b-b87b-95d02a3ab1f0" },
                    { "0SlXYBQol4EWo2UNbcEf", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8391), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "P1", "6bc47e2f-bc6a-42bb-a8ce-45f54e402e1e" },
                    { "0SqCXygVUplprVQNlh61", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3878), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Silver Spur", "87c0f4e4-ac71-40df-aad7-42f0fb4c1f20" },
                    { "0SWR7HNI8aSJDSpeG0SF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9282), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLC", "fe6bbda9-8cd1-471a-8d96-87f687e11203" },
                    { "0sx0RPzC9KJ0xFUr5FsM", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F550", "881684a5-7ec4-4197-b39c-364de4090e7a" },
                    { "0ThWa2zcAkuALade3c1F", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Unior", "3f4a1b73-096d-44f5-b3be-a4a1015959ab" },
                    { "0TNQ75DSINze179n5AAS", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9140), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "650", "04124c51-97c1-4a2b-9df8-595bd1085324" },
                    { "0TRmsWrVDbzIwlVMbD11", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1439), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21417", "3e7c3a83-d4db-49a0-b8f1-15917df8ce5b" },
                    { "0v645gBH5tuC0MMTXnGt", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ecoline", "0dd1d6ec-e5f1-493e-a606-ec7ea681e4f7" },
                    { "0W7YF7MgYoKM37W6KNNm", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2485), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "204", "ac9121e8-0165-4575-ba7d-70931e28340a" },
                    { "0Wbg07fgNasPHHq3EzU1", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9138), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL", "33ee80fe-7fc1-4709-b45e-6b2a22e9fbd9" },
                    { "0WIJ1h6gIRGtH6MwlhHg", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(66), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bolt", "2a68b139-0996-4046-9dc3-c66e28dfe462" },
                    { "0x21g8QkqmWEDNz3rp4L", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(41), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLC", "9d3e04bd-61c1-436a-ae8a-e97bdb4b8b0d" },
                    { "0XKQ4xeXBC3DWmrNjMfm", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4377), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cordoba", "846abedb-4bac-42fa-aff0-a580e34e1555" },
                    { "0XRe8FcHEhsca04q6rN5", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "K9", "2f5bacc7-a3c8-4e7c-89c5-7d591a83ab01" },
                    { "10pSzTuzYW6Vgntej2l5", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1205), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Galant", "a17e274b-75ba-4e12-8ca5-744d801e8ae6" },
                    { "15TdMFbFqLqFmk3BxwTE", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GranCabrio", "c06406be-6f0b-4350-8d82-0e5466d0e1a5" },
                    { "18rNdhBHRq6hbHCJ8HeU", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Juke", "89b7c7a9-41c4-4979-b830-3a677b040031" },
                    { "19deMa7S8TWQdfR4vrty", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6861), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "480", "ed99f45c-8fbf-4737-b3dd-13e998118ea6" },
                    { "1BCMb18BfgQjJYffuA6F", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5052), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XV", "f70aa8d7-e14f-46ef-9c6a-82aa946c397d" },
                    { "1CnMULzthcN5YVfB1qSu", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1373), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Matiz", "87f012ee-7233-42c9-ace8-ad3182e54860" },
                    { "1EImSc2uLRPEbC8WLrVl", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9447), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X6 M", "4e02f31f-b88d-4313-93f3-1ef849cd68f7" },
                    { "1f6NkvMPl2PfvTX4w1ff", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9143), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL 230", "8ae81dfa-7d4e-4901-a8a4-7372093f2f01" },
                    { "1fwyLkUJR25A1Y0ujSbU", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1488), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Copen", "7262d7fe-495d-45f8-b9c6-26a205323abe" },
                    { "1fXAnSAWFaN9rFvWQD0b", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5801), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trooper", "6091bbb3-9d96-4d10-ae1e-f15c89fdc804" },
                    { "1GjRP9d40CcU6yzGQWEe", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Horizon", "bf9c2b92-da42-42a3-9245-dc54ced4898c" },
                    { "1I84LqPbusmuvMbFKRJq", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "QX56", "fbc2ec55-472c-4bad-a1e2-04a214541044" },
                    { "1IkC1YWLLyDIFmW7MyRw", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5860), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sienna", "0c03887e-54b9-4ae5-9a2c-2a6cd0faffcd" },
                    { "1ItduNW46ddP7J4dhMXH", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6997), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S60", "5df5ffbe-d4fa-46c5-b641-ac62590b32eb" },
                    { "1jcQXvCyr2D5zFaKsD53", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6988), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Veneno", "69dd9862-4f5c-45de-9c18-d19620ff214e" },
                    { "1lAKUtRsJzUzp3phttrT", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2661), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "504", "4d00399e-8474-43d5-ba3f-60b3b06f661d" },
                    { "1oIuvyN6TjCo8dklNsmD", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2491), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "205", "ef21c3f1-f8be-4bd8-855a-d6cb4f28729a" },
                    { "1Q2t4jQnudhxgNQVmECA", "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4272), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wizard", "411e99d1-c9cb-4f18-8da7-f4fc5cba14ba" },
                    { "1Qq0r4VUTaYcjXrvJguf", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand espace", "cf660110-1183-41e4-990c-0720b7ded5a9" },
                    { "1qV5wDuGK8BUYdISMjvp", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9125), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 55 AMG", "749edf31-9b9a-40b9-aeef-da1adf4f1148" },
                    { "1R2RDsmB5HntjHBm9VDo", "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6163), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand cherokee", "23398e11-8aff-4fc5-96b3-1bd368b377f6" },
                    { "1R46EKrv7rVCFkase3Qt", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TLX", "43e8e764-508e-4b6a-8941-802d1a9749d7" },
                    { "1rguP9wDYdXCvJPvpIcs", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9660), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BS6", "1206540f-b823-4216-b07a-c15febf67cf0" },
                    { "1rJKnAvy6Tdm62jVMhrp", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3257), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Orion", "2543b116-1683-457b-831c-e15c73b9551e" },
                    { "1RW8ttDa9Ec9q1BuBcWG", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(632), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 400", "eb52a87d-7c9b-4047-b124-003dc0ccc36d" },
                    { "1s8cSCIpVbfLyQuKNCY4", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Boxster", "162b2213-4a10-4a3b-9d92-ab4f6dc5631c" },
                    { "1sFgrd7RzE45rtGoxdJf", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z4", "ca6bf8bc-a7f2-451e-a2d0-c739b8dfffc8" },
                    { "1sUAkoWkdG37MRd44Fdc", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(815), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 500", "45e44427-e0a8-4cbc-8f5b-c84cc174656d" },
                    { "1tYt6EHYIVdjPnFmbKHB", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Brera", "5f83c31d-c0aa-40d2-bc8b-227da4f6f20b" },
                    { "1v2bfSwoEkagdkdyJvJr", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mondial 8", "ceda8a1c-2d51-4881-91c9-655d021773d3" },
                    { "1VFGtEE0QEFGMP2rsQwL", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5564), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G", "3303a6be-accf-4411-9efb-7bb445c21b5d" },
                    { "1xnHb9I3V0JW13DrSc5w", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(320), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLS580", "d1e0439f-b412-4772-8973-f5889c83d68a" },
                    { "1xyfqt6uudgFs5SNlJ5Y", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9459), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X1", "360765e1-d5c4-4112-9e03-3c5c41e5afbc" },
                    { "1yaBqTUY5SFyQhEPbdbS", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3923), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "220", "f7dab70c-8dc4-48f6-a40a-f3b1c79798c3" },
                    { "1yu6AECe2WxKvXVzs1JD", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4395), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crx", "193e0f55-213d-4fc5-a450-d4ccf2cdbb8f" },
                    { "21UTnlLPnWkHlptNxcyT", "IR6qs66ukTVnB4w0NIFq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5813), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Massive", "bc935676-bed5-46e8-a8f4-daeb947c57eb" },
                    { "22xbG70oHRAupGpVN5EG", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Streetwise", "95eba2f9-bcc1-48bb-9f96-1919a0317c2a" },
                    { "23F1916ymnAaNwSvqnXI", "yjnmBGS0tfeUY6wppqlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7228), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2021d", "0f01073b-9ca1-4c8a-ad93-de677377f2e7" },
                    { "27kUjxGCYTkjduIfFb31", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(115), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cobalt", "c56e2121-1d8d-4288-b0f4-fcfc9edc1c98" },
                    { "29hzBk7B719nMIVzU9Xl", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7463), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tl", "11db90a9-70b7-4140-afbd-1437cc75bf82" },
                    { "2a0eU6vKqm63l4bYXfH4", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6182), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hunter", "667c1686-fb0e-42e1-8a7b-4ddf97a3f3d5" },
                    { "2AqULPCNcTIhmnjsPeAD", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Beta", "96af4373-b3ac-4e71-aea5-1b9e1046f7b1" },
                    { "2bAIP1hgTDYnvRlWzqb8", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6330), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "K5", "e48aa2e4-f7b2-454a-8c55-38f704233a47" },
                    { "2bjl0kDqTmwXfz8o13ry", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2708), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tipo", "a0120aa3-18b5-4c4e-bc51-a92dfcc4472f" },
                    { "2C4fVP4EgI1gtkca1Wnl", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3043), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F450", "b3c2b28e-85fd-4ff8-97e2-5fe8981ace97" },
                    { "2Ck3Wa3LpyRvSc7DUVD1", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2344), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "650", "b095bb7b-754f-4445-960a-541ffe9ca2b1" },
                    { "2Df2v7Pt3oALKfN6blNr", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9312), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLC 230", "1712c784-12fd-42c2-b3b2-ef3a9f097edb" },
                    { "2df4LYVcHIBQzwWtSQDF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(326), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GT", "be67949d-23da-475f-8aac-b95ca49269c1" },
                    { "2e0YToGpxGlHSs4dyTTv", "J3wnurM4CgKVkRFfRvHs", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5880), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-S2", "2f506776-04df-4ec9-aeb1-49fc3320e747" },
                    { "2eETWjQDuR3kxEo7gzlQ", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6808), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21099", "c84abcf2-2d15-433f-a50c-33df8cbbf6d2" },
                    { "2ewRRbCscJWbyyprkGqF", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9301), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i8", "e679eea3-ee4d-4259-bed5-49d4153fc2e2" },
                    { "2H63bN3X1kMKXU0UxKMu", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Toledo", "60a092f6-ff2e-4849-b45d-a018a36113be" },
                    { "2hcY0Pyz9LNtDIRFsjrJ", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9810), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 280", "6dd3d6e4-64c9-4cbe-8254-6c49cb9bb6b3" },
                    { "2IWyS7VzMITKcuTcJCo3", "Dfej8VedBqRvW5SVCeo3", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cherry", "5ac0f67a-257c-446c-8d95-64617cda2cfb" },
                    { "2JSqQksxVHsWQFTb0CuA", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3889), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Haval H6", "9fb4bdf1-f6b6-4daa-a513-e7d6de9f869e" },
                    { "2K2NYm4mqeuvECpjrVlf", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Estate", "2dbd6f92-ddb0-45f5-86b7-e2de0529f012" },
                    { "2KHp9mcpfBsTQaX3j9ve", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Probe", "c47315bd-00ac-450b-97b7-9852cac27ad5" },
                    { "2KPyeLz0KsMeg2FKULPV", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6971), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Murcielago", "57e9e6c8-2d0f-4bc4-a083-384265bb5c4b" },
                    { "2Lwl0ND5bNTUANhhcpfK", "u3lzgWdKo9KaByo34lmN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4836), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fortwo", "fc476dbc-e0b9-489e-836e-e1ed70676e30" },
                    { "2mXByyWJd5PgI1QSWUke", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4547), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "9", "7af2afcd-0c66-42ab-a8d1-cefe089e6738" },
                    { "2NcftRwStj9SJUkkxkBW", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "22", "c792f67b-2510-4b4d-ae96-68d5331ec122" },
                    { "2nMsIwW2CqdP9DzHLIka", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2534), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Freemont", "a8b0bceb-8f30-47de-a6f0-2423a9b95553" },
                    { "2oBP4u55wBSCHrsRhvWj", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9079), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 6-series", "f93692b3-f977-4ab2-a5cd-a91d2a3abcb2" },
                    { "2oYvjUVjMbFNDWQ0nXwv", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1338), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kalos", "d69a346b-0c41-4d60-97db-ed2ec2f52b9f" },
                    { "2PWaWJVV11Tg3Am3BPy1", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2615), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Qubo", "ed92d14d-06c1-4fb7-9b0d-11623e398ef6" },
                    { "2QYv1mzttCqM5Ysn7SsC", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q50", "47d22395-93cc-4f63-8ce9-49d4b346b749" },
                    { "2rff9YqUbvuB96aPmn24", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Delta", "ff6c8bfe-4e35-48f2-bbfa-fe22fea47ce9" },
                    { "2RHwlJkvkezYHpqEJUYd", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1500", "ce0cc890-1f92-467d-9f5f-0d08dce14ddd" },
                    { "2S0uocGCAwDnu82oI8dK", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5768), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rodeo", "b1d72ab5-93cc-44ab-8718-8bcd3412c126" },
                    { "2srpAWo16VM2l8H5PLl5", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4525), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1307", "eaa1cb67-b1a1-4ee3-aca2-a1661004b342" },
                    { "2t3LgKg9pyV4rWRvlbFF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9198), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL 600", "5ec19dea-2661-4604-a2d0-1907cbf95a3a" },
                    { "2uu5uEcnwhuvSQuQCeNI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "220", "bb8731e8-bfd7-4e46-8898-9bd625421c19" },
                    { "2VB4DQG3WnzJbvvH4fHz", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4992), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Levorg", "492d3401-7e8b-41d6-b34e-9671750e64bf" },
                    { "2VBpoTMIdMpXvfkJdduQ", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "200 sx", "2d819e54-7851-452e-ab64-5f470486fde3" },
                    { "2wHjLFMuwEADKFI1EF3E", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1047), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cooper", "fe272431-b176-49b9-ae1b-23062484da95" },
                    { "2wTEBhY4I7SVmmIWpU4P", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9044), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 270", "d6f2d77e-0518-425b-843d-84e0b36bd854" },
                    { "31NAcmQzSNTTId28Ir0d", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9307), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLC 220", "139accd1-7d73-4f3c-ae4f-fe6522991485" },
                    { "32FRCxoHYKwXUbLf2NuK", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4076), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "825", "a451bdbd-3746-4cf6-a2dd-809235d20571" },
                    { "36C4nLVm4YVY0WsoFx7N", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Corrado", "6af709f5-78bc-41d1-8c6c-1f02cf38bd20" },
                    { "36QmSn71184d7yy6Wpf2", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9276), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLA 45 AMG", "c14cd5cc-eecc-4318-afdb-56d1d5edeccc" },
                    { "370bYwnUdanPD1gFHmx1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "628", "c734f6fc-7efb-42e8-9620-c63cc0c6fc88" },
                    { "39lhX7EqzoFm4u2koncI", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Escort", "bdadfce3-2709-4728-abfa-e6e9055db587" },
                    { "39Mf2p0XSehW2lKjzWbu", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3765), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Savana", "75d0ea4a-a4f8-471f-bb55-06d546efcf38" },
                    { "39u9BJvCKIkqoC08mLhr", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(939), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Visa", "a2d7df6b-7309-4894-875c-f7e71fe5555b" },
                    { "3aAFNMg7E4PD4GTY2fHs", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Continental GT", "2754f74d-63f5-4d8f-bf4e-da4736d87570" },
                    { "3Apuhl2koxfVW9uqFjDF", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xm", "9da62e9a-e8db-4219-8138-2f8c27e68650" },
                    { "3b531sPFQn9MIUsb4yqj", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2107), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "FF", "7e4e0807-dc91-4a41-a2d6-204d1ac1f29d" },
                    { "3CtnT255wHrIC4XdpbtG", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3164), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "993", "91cfd3ae-7bc6-48fd-9119-9b764014b0f2" },
                    { "3dGVkFk2gbd6KsHwKTM8", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1698), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Charger", "9e684581-09e5-4b15-96eb-ba15c820ae05" },
                    { "3dkGEmIGXA6ufUl0XnRe", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SLC", "c170712f-ed32-47ca-8c06-0d0c83f8c8ad" },
                    { "3F41aCEV1HKnvPsger7X", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "156", "3c8ff37e-f42a-4b3e-8ff0-fdcd5ab220fb" },
                    { "3gmH1TXyjXgSrxH00lrt", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2567), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Palio", "74ab2387-f5ac-40d2-846d-99aea2c1b9a4" },
                    { "3JRvWPb2Wq9PhS0qYs0W", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(337), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tahoe", "ebd89ef7-84cd-47e6-a64f-af93015f6c74" },
                    { "3krMAgceX94YQmJbbRQq", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3813), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ghost", "1c9d5081-0032-4028-b4c5-c9e60441b3ab" },
                    { "3lVsmFPwFNzC5h5PyNFj", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3849), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tracker", "576f013c-6c29-4264-b4d5-5e2be441e27f" },
                    { "3p2DV1j7I1BL3P4HLd6p", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2142), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Campo", "a9e4bd58-a804-4d08-bbb7-8c5adc60fa00" },
                    { "3QK43RVH30C9lUukLLgf", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8527), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "126-260", "abb2bd6f-dcf2-400d-b037-6493196c8fb3" },
                    { "3rDbY3br9jyqJB5zd9jU", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "I40", "03cf473d-dafe-4ed9-8f72-7f648fd5eceb" },
                    { "3rI0RPMVxa2YjMdKpvIN", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Flex", "29fa88ae-f61c-40dc-a33b-e6b8c148de1d" },
                    { "3stn1DJ9sPTaP8KKnEBK", "W5TnArCA9xCEodsTpDHG", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roadster Sport", "2b0e8ae3-83e4-4f4d-8a37-485668f35445" },
                    { "3TwES3RybJ17xUMzoI0U", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1600), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "370Z", "1e4a5b63-5df8-4573-bc35-8e77637b402a" },
                    { "3TXuMLmXjBApqYanW6T1", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8547), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "170", "d8cfa9c3-212d-499f-b213-87839c4c89a9" },
                    { "3uGleL7AXlB6Yp1wpUtx", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3707), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scenic rx4", "d64c6b6b-8434-4d90-8f1b-ebb304e6784d" },
                    { "3V6dkwErGGruJSC8N56U", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8871), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "AMG GT", "b59068d5-0931-4ee4-8539-e7c891031d49" },
                    { "3Vnl6CR83SRVrD3WFv4t", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A1 Sportback", "f4edd222-9efd-4322-ae86-4af8da1053e1" },
                    { "3vpqTGl6LTC8nrgn42ey", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 550", "a9747ac5-dde3-4383-a203-11eae95dc4a0" },
                    { "3wApjIDUlhRwyY8DwkzH", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6795), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2109", "45529cd0-f453-451f-b092-277cde35a056" },
                    { "3wtb6CXr2Q3cxeXfUFFN", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "123", "96c703d3-23cb-46f8-b4b5-50165d05e149" },
                    { "3x2eSnpo3JS21M5wqXBD", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2282), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mokka", "c6429f64-ca8c-4c64-a10d-91915ddd318c" },
                    { "3XFpqhkBRcd5toArwv3t", "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1087), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 3 Crossback", "01b76071-6f5f-4f0c-a519-bb9715fb42db" },
                    { "40s5RQMBLgddveClAk14", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crown", "10a4f80d-c42d-4a68-beda-eccc2b1f1fec" },
                    { "41UD61mBCgaoPx27ckfz", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5693), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "QX80", "c09ba01b-9ba1-4c26-92e1-0522a9e62f97" },
                    { "42busspFj8g6Kqfp6et0", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9441), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X5 M", "86699104-7682-4279-ac6f-c5924cd71019" },
                    { "42Ht9LMKsRkUEwvf0Sm2", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2041), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cutlass", "ed5e0e10-ac8a-47e2-b7cd-7b5cb5205c86" },
                    { "43koASIcLSpL8oYN7D0l", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8119), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Demio", "ebee2e6e-c7cf-4ad8-8e13-a2cfe98deb04" },
                    { "43LDnMNACXREethu80Cy", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2519), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "301", "43bff3e2-736a-4e0a-b103-f38edff5ad84" },
                    { "44jKbDxSBk8hSBj4TVd4", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Civic", "fedbfce0-45c7-4468-bfb5-f13a7327e5ec" },
                    { "45j3Q7U8smqpRKccyJcF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(882), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SLK", "aa371bca-6007-46b6-9e75-e17cee26fec9" },
                    { "47HvbmSvtqz6tzuI6qG7", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "800", "2d08186a-f15a-4497-a232-0c1805ca1e1f" },
                    { "48gwd9Lh625X64XfGDuR", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2269), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Manta", "6cca1fb7-8f74-4a04-85c1-27f71c176d08" },
                    { "4AHHXKyheFW3M4AcIQoY", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9312), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iX3", "9f3223a5-40ef-4da7-937e-d4a001b91ad6" },
                    { "4BcBIsDq0b9xCnhGtmuJ", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2459), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Campagnola", "ba0cdc2f-df18-4b3c-96f2-c4d3605e21d2" },
                    { "4DWw5oXPk2X05AezcI2g", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1973), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "348", "795a9986-b6a8-4df0-9e60-f43933d86683" },
                    { "4EDJlLczqdlESNRwMcdF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(954), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Viano", "92c9f0e8-81bd-43d6-8d92-71f6887353d5" },
                    { "4Es6hEQWNRfqW3HwYP7m", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4137), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Montego", "061d8d65-6666-4c95-8453-b28158e9f0e1" },
                    { "4Gh0K8s1Y7JFaNk99Lfb", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1481), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Charmant", "ae4ff42b-fbfe-48f9-85ae-ad4d4cdb4216" },
                    { "4gIpF2PxuLhJKlK1FQ6h", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(960), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X-Klasse", "e19068d7-0bdf-49b4-9012-a8960fcb9f8f" },
                    { "4gjYGceQYoEUxE1aqvlm", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5947), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Yaris verso", "e5cab15e-213a-4905-abc5-891bc4ab83b4" },
                    { "4grHe6P1cGNzN354puMI", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 500", "34e3f022-4ee1-48e9-94cb-4963e2c32cb5" },
                    { "4GVaVeg8KtJPBBW8xyVQ", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6589), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "T-Roc", "6b8e7d4c-56a0-4499-9f70-7295763ca473" },
                    { "4Gwy8Vw7wsuauLGQYAEJ", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4668), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "125", "c68ba38f-483f-45b6-8748-c82c26924fca" },
                    { "4gXHezNfHrzRkFCvPcVg", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Proace City Verso", "6df8b46f-0f98-4670-b996-b799096e5fe7" },
                    { "4GYD9EMetYM9tKNFfYgq", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rx400h", "74fbc25a-eaf3-4a60-b47b-b871672f1cdf" },
                    { "4jP6UgyGq1BgLUQey9bW", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(53), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLC 250", "ec39147a-bc05-47d4-a5c6-75d395b33f8e" },
                    { "4JxXQuoRH8gXa0qKpY24", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9793), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Invicta", "b2d49606-5419-4197-951e-8fd7d835020f" },
                    { "4lallNTrouoGHdPP4b9U", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2208), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grandland X", "02ab5914-a2aa-4804-92b7-6ec83030b4a8" },
                    { "4MBGmnorzrElpQJklYdP", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4528), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hr-v", "0ea1d750-e2d3-44ef-b54a-fe722a268046" },
                    { "4moIYoeXhBssohHt11tQ", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RVR", "710d92fd-0457-416a-87b1-600a04e4225a" },
                    { "4n05c4PGgU6Qg5qRwB1S", "XW7Xpw80z3VgX82egcWN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7142), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1.3", "896f5952-e235-402a-96d5-797a309c7841" },
                    { "4nj9IRIwBCS3hDG9j5Wk", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2881), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Prowler", "a2be4941-3847-4e6d-b449-b3c8ab8d60db" },
                    { "4NwPKSN6X9Uz3yyzx9sx", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Courier", "f4638f8e-1934-4c30-84c5-3946e26fb8e9" },
                    { "4pyQ55WLvURakoer4SDK", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(121), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Colorado", "046e98d5-8ca8-4da8-89be-d4373855201c" },
                    { "4qdwoL96m3KBpHhj2nNM", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2830), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cortina", "639baacc-cfc1-432c-86c2-3a12e4725406" },
                    { "4QNc5kFcXqetIN3tgX7C", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "416", "48672488-ebd5-4599-93b7-e8ec0ea9c86e" },
                    { "4rgjlCe6PkVJMMttgola", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2443), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "107", "2c790a80-107e-4f1b-be9f-043672f937b5" },
                    { "4rnhoNI3T4DGXq69fdzm", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cayenne", "0f5bf50c-58b6-4649-9f90-d2fc48e0ec6a" },
                    { "4SKj3mfrjjnpJ6BNJtFp", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Priora", "27861657-c29b-47ab-b4e0-0ca3421a0cf7" },
                    { "4u7Dc6bPAB2mloGmoN3g", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1958), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tiida", "ded620ff-94e6-4c7c-b335-2426e3eb2a16" },
                    { "4vckPwdHrwb3RdYIF9E2", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3981), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Safe", "0f70d433-a11d-4add-a363-8090919a995f" },
                    { "4voVwGqIB3rkav67nubD", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(795), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 4 Crossback", "4ecf536b-38ce-4f5d-8595-3665d795836b" },
                    { "4XF9KTxjSA9s5psRUKF1", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5388), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Veracruz", "9522788c-120a-4571-80bf-f3087fa7be60" },
                    { "4YaWKEmFdm91nCvPBnmP", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5009), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Svx", "29600d2b-3e13-4762-b51c-db9135d71f95" },
                    { "4YgaHawvkrujeI22n7a1", "W5TnArCA9xCEodsTpDHG", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Model X", "f93e9ba9-4202-4d94-a710-12253ec28736" },
                    { "507ffnMLXtcYr9fENmyh", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C4", "dd710177-d853-4387-86c6-c03715572590" },
                    { "50ypCGqTAJllvQCyxV57", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6623), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1500", "b86fd39e-fa63-4c6b-8deb-daa99eefeb2e" },
                    { "52MTArBkjxjprkKTkcWc", "ghyFhm7jzcjYDrjMVLs1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H2", "b2dccbdb-abb2-4658-8925-2936a2db809c" },
                    { "54dbgFsqLyfJBHcLoxg0", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1362), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Leganza", "ab8e6b2e-c629-400b-a1ac-a7a98dbb74ba" },
                    { "54J0Adw1Dy3VJnluyDtw", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4998), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Libero", "c1e44a1e-d8fb-4e86-931b-5a019702f63a" },
                    { "56PTNkt5tjt8GxuA5y4Q", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8376), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS5", "73a0903f-8a6d-4d08-bef4-5e3a75656bba" },
                    { "5c1XwWsbd9mxR3QAtdsx", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sandero", "178e8ece-84b3-442d-a9fa-287e59342b0e" },
                    { "5cdvpPhHuptjGxgl9F9P", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9073), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "550", "a0bcc84d-b73d-4195-b337-9fd56f954e96" },
                    { "5cHHFcNNThSD8Bhbmb30", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3871), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Silver Seraph", "070895d5-9f7a-47d9-b568-ad75c423f2bd" },
                    { "5CSERx1Qzq3IohKLNFYu", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fso", "7c7d0a05-d850-4384-82fd-fd03babead7d" },
                    { "5em0tjTI6gRPb232lrMV", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "df3d22c1-529b-4edc-9cbc-25b29acebda0" },
                    { "5fGrV732TMwo68WwRtao", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9736), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B5", "e527df6c-68d0-4b33-b8d0-457a0e113920" },
                    { "5fmcA9FITfhtR5U310Sn", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1115), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "John Cooper Works", "567002c3-998f-4faf-b2d2-e3fe86cfa9fc" },
                    { "5gppDIdjCK3xtduHlLGd", "sQ5C4f7H60rzJLhMA0T5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "9000", "18ba9c47-1c0a-4e9d-9f6a-56efb0236d1a" },
                    { "5hBpXjoKuJgfCzbfu97m", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6266), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1300", "061d6bc1-5ca3-41f8-87a3-6f61e2edef57" },
                    { "5Hd4mtM7gzHaWyD07sd3", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7447), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rsx", "a497c7cc-9d61-4472-86e5-a2df31cab743" },
                    { "5hMb0MDAMNwE4KvbvMkX", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6642), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21011", "2a1ce219-e96e-42f2-9b41-9eabf0e2c6dc" },
                    { "5Hp9qGzFok2DFKWBmkGd", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7996), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "5", "260d9ea5-da4f-4803-8501-d7d08912016f" },
                    { "5IG9PuMSxv7NDJ9pXVLo", "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7315), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1102", "5d0054b8-bf9c-425c-9087-d716a6bf9df7" },
                    { "5kDDUNaAveAjndaVrG6g", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7405), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rx450", "b2822208-ab28-407b-bf07-425b0455e9d8" },
                    { "5keYURU1rD2KdHoSQWcV", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Verso S", "8e7e2817-9686-4cd5-9aae-a0780142119d" },
                    { "5KTzHvT2gbGBXQfgeNwJ", "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DR4", "41c1c737-518c-4426-afb5-3424a113cef4" },
                    { "5LEvAaQwdhsLgc1PWQnB", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C-HR", "5d05b031-8fc4-4f76-9133-20bf1cbee2cc" },
                    { "5LlMDn7xE8YsVpv0cEDY", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allroad", "5f80d456-e60f-4de9-ae4b-d8810707f007" },
                    { "5lVRVzC5uWXfIlkj1VoS", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6734), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "142", "b4aa758d-35bf-4828-ac18-fbd2439e3c13" },
                    { "5N5eEv3BDLebeGdtIlnp", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1188), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cordia", "578dca0a-e614-4174-86c4-9a94b22b408b" },
                    { "5naSE4RS4JXfYoqG7c3g", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "730", "65f188d5-153d-4682-bda8-468e83079aec" },
                    { "5peftbUW1f8XPo4TsgbC", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Enzo", "6246e293-0bad-4b43-bf87-5b4bdd0065fe" },
                    { "5q8W7tJmsugQE0wglRwp", "whPfE6p1LaKgaGTWoNqj", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5991), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Combi", "acf295b1-3cff-41d2-8fb3-d5ce6e1703d9" },
                    { "5qR1scs3keEGMkBhEWYp", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9761), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G", "38770b89-d2e6-41ee-8ffd-b43c60a78581" },
                    { "5QRGoQWF4BQxXq5cmF19", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7922), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C1", "ab22e246-6fcd-4701-b1d0-50316b27e8aa" },
                    { "5RKf9s1u7qN9y43lUMFp", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLS 450", "67c77366-0b97-4a41-a020-4e6b19b19a70" },
                    { "5tqjUKY10soBYGB5bkDG", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2991), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Excursion", "a43ba379-134a-425f-a1b1-01fc81bd58e7" },
                    { "5tx0wcXSaq4vgjFk7gKt", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6733), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21061", "152e4f56-acb9-43ce-a4e3-e503c715b153" },
                    { "5tzg1dd3tvY2Dh1Irw3t", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "127", "c281b800-f5bc-470e-91f9-31dfb8c8b5e7" },
                    { "5ud8Ad0zTYttInlJJb0m", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Capri", "33975e7c-c255-43b8-b7fa-a26848f063e0" },
                    { "5xdFdvQsc9Aex91jcGkb", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6474), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rio", "f522c6c4-35a1-45a7-a669-01689a4cf7c6" },
                    { "5ykzKVRhhNToskRQm38W", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6260), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1200", "68ff1501-8017-43c3-8aca-d98f8d6c25a7" },
                    { "5zKW4vrouppUnMAzQbDf", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4545), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Integra", "5a94945e-5da6-4f8b-8147-50f7f7c6e15a" },
                    { "5zzKxYmh2YTf2pP8IJng", "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 5", "6d9bb783-c085-4bdf-a2c7-2ae9063291de" },
                    { "602snAq0u6FNs3DV9pEF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 170", "a241201f-30f8-4785-b8f4-d9f8ad056c01" },
                    { "60jWf49CNhPMmIppuSEI", "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6010), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dolomite", "6198d1c7-2a9d-4045-b4e8-5b85f5d6a3c2" },
                    { "62BHpkLw2RFXDfx73TxL", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6844), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "360", "c08c3c3b-2914-432d-9046-3e442db81e7b" },
                    { "635DoSaovFp6GSXLTeDr", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Logo", "116c4b5d-14f1-463e-a7fc-515a3fa50879" },
                    { "63U43qUoGs4r9N09zW3P", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6487), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Seltos", "a7818171-1b4c-4570-a206-cb2e02db3b10" },
                    { "67rHKzJBGQ4SeLWmy415", "etMtb4JLm7eB90mlnd72", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3495), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GEM E6", "c1a3ea6d-2461-4cab-8d4a-95f22bdf4b5a" },
                    { "69lDY4MLWvaWp0xRwaek", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rekord", "aef85cb6-a279-4390-acb5-b4c8d78051f4" },
                    { "6bfUuIoUl6vs8qfSgrQN", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8029), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V8 Vantage", "264f57e3-c991-4a7f-8a81-df1af986f37e" },
                    { "6BYQJcThRR7AYWgKTqAS", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(971), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zx", "fcae7f6b-dde6-44ba-bde6-241128e8273f" },
                    { "6e6cl9dqrVdrgx8S59va", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4519), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fr-v", "d84b24b8-3aef-4f8b-8255-c30dc5cc8889" },
                    { "6e85IIFhorvIHRDVMDwu", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(529), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stratus", "44b1ad94-aeb3-4ee9-a8e5-652e91522a9b" },
                    { "6eeCrqTQU0hfwVW11wPm", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9669), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 53 AMG", "5dd8a6df-b30f-4fcc-9b79-5f5daafd094e" },
                    { "6Erbk45RdmqDyGEnGjs8", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8943), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B 180", "3e457a87-08b1-4760-bff8-8b2643f21f90" },
                    { "6EUwYGxD04DmUsR50EEk", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7020), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V40", "bb05143b-c53d-47b3-947c-c203d5056e21" },
                    { "6FkbxSF6cY3PNFXV2Qdy", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(175), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Equinox", "8fcc98b1-9ca1-4595-a291-b824f6c751ad" },
                    { "6g6wvy5tpXG71A0MCs3d", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4693), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S2000", "3da838a9-af39-4608-9fe4-5d7b06178eb1" },
                    { "6gYFGIWAEaB4Qq3rfz5X", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2738), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "15m", "f579571d-3a0c-4a51-93fc-81e06bb984a3" },
                    { "6hQ7LYoop3NVjTxV9vsp", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9895), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GL", "297dbd7b-88d1-41b3-ac19-3a506b45845d" },
                    { "6JC01t9XImPy4nw3GfaH", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand vitara", "21d83311-057c-444b-a339-f88023f02931" },
                    { "6kueI6DdRY9Epe31U4HY", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6765), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "240", "f9740d5f-44bf-433f-99e9-5b429d74baa2" },
                    { "6LleVuVQCMKFWP2VHdc9", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9221), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLA 180", "69f11479-dd07-437d-ab04-bde4c8939d95" },
                    { "6LSmYBvtARp1PgXN5SDg", "Hc1zhgoBCF1639Rp1PkY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4781), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H2", "0c36647a-9cd1-4cef-aa7b-e1dde3c14f11" },
                    { "6MDB9KbLcvTTkScWL9ba", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1589), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "300 zx", "53966b39-0c22-447e-b8f2-06881b6154c7" },
                    { "6MLtI8w9oGDdLldXwmoq", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1693), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Figaro", "8ed93fe3-264c-4e33-973f-4981b5f04653" },
                    { "6MpKJs2sgy6PaobAUNa8", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(126), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Corvette", "ff583dc7-9bc0-4d34-9f09-cd390032a769" },
                    { "6n0PLXBL04I08NLhQ2of", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GL 63 AMG", "fa1cef53-d2c0-447e-ad10-79aeb5a098bf" },
                    { "6nMKUv372Lb6HkpcHIK8", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3388), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Taunus", "1b9200c9-9c95-4184-ae2a-83a94d02d4ba" },
                    { "6npmwQEY3Rz7as93D3Qh", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3210), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Taycan", "9fa8208d-32fc-43b3-812e-e34036608bd1" },
                    { "6nrRIq7mEJo6HkdDyr1z", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7758), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "KUV 100", "03a726e4-b8f3-4201-9df3-ebf4362f1144" },
                    { "6o20w0pBehW5SsN6UcmC", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3389), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "5", "25ecf665-b68d-416f-a509-19a67463f53e" },
                    { "6PBWAweIbWBI2ntJ4qBz", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2cv", "4d66124a-3b45-428d-81b6-1152084462c8" },
                    { "6qp2fpdU01IxvVuFEdBl", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9943), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Seville", "b42d864d-56ca-4aee-abe2-01c75b9cba1f" },
                    { "6s7A62WScv3y9tpQKtKR", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8727), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "450", "c379b269-4e38-4e6e-b8c7-7c3bf8715514" },
                    { "6sVCkfFLaHqBkNcgLceP", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9187), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL 500", "2a0c50d5-5f9d-446d-ae7f-2be38943ab6d" },
                    { "6th619RlN2jtLyN7udDT", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GL 320", "28bd27b9-d287-49c8-bb64-ffc4515c308e" },
                    { "6UB5nmDETuvwMELDr5TR", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(544), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R 320", "e9637c69-0f2f-4a44-82be-180b95663393" },
                    { "6V7jz09MmjQeP2y9uNex", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M2", "5c51d811-7cd7-4cd3-b192-d07515b7fb2e" },
                    { "6w44LkNCsLb5FygrIteo", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8666), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "290", "7ef2a186-21e3-4866-b1de-2c785b65f03b" },
                    { "6wcxbnRs7MRQy1s3z4ux", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 63 AMG", "b44d722c-d7d2-4ce9-afe3-01b70e74770c" },
                    { "6xFBasMVuohFf1xJHFbN", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4928), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E12", "e8f22049-7508-4044-bb0d-aee2890a6400" },
                    { "6xQVy4lH3JNraR0fLLMn", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9265), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLA 220", "f5b4ba5a-fe1b-4674-b6aa-6d96861ee2a1" },
                    { "6yr9yellGlLXl9A8A9FE", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Malaga", "3c6c37b3-35fd-4671-8432-dadfad9805b7" },
                    { "6YVSB7FWzAydJxbyFoA0", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(355), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 270", "af28e548-f54b-429b-87a2-25312d71b602" },
                    { "6zlU7zDMReP0yovGxNIl", "sQ5C4f7H60rzJLhMA0T5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "9-3", "a6194bca-958f-4439-8cf0-abb2420e54e3" },
                    { "71sVVkrUAxnK3gGI31xG", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1564), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Taft", "9eb14167-d26e-4e00-b3aa-74c0086d29fe" },
                    { "71yYxrmMVQ3r7w6GoPBk", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4500), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vario", "85607e58-c5f2-40ff-b5c7-5e92ffef6afe" },
                    { "72CK6IKkwgBRWxrSYKvK", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1521), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "427", "b99950ea-4732-4d6c-aff4-e8646e433618" },
                    { "74DsSMFAn3W0Q6duLQHB", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Swace", "512218b2-35cf-4d89-a2dd-688ef7876a8f" },
                    { "74SunEV1uLktX59FsWmX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9296), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i7", "759e99e1-4d64-4be2-bbe3-179718adec54" },
                    { "75aKVjE0WT0f4UW0yXjq", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "6", "67614bb1-a05a-4ce0-8cf2-8067e23aff3b" },
                    { "76UcHoqLeIckAN3WqLhI", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5406), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sumo", "a9f811d5-fe58-4b3e-8b47-6d7f7fc75467" },
                    { "78wIR9gvuSKKcyXkhggf", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9295), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLC 180", "de9da9b5-9f85-4bdc-83e9-e52af6085e21" },
                    { "79MpXwskCI03bNrookxP", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9340), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLC 250", "4417a105-4512-4470-954e-c1b72e6f3887" },
                    { "7cJErmPTxbbFvqGTuko0", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6618), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Touran", "83ca05e0-bb0d-4793-bcb9-de1c44360890" },
                    { "7CKRyF50oSB3wTxk6Bth", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1839), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Primera", "e16615ea-adc7-47e3-b530-91d49a08d6d2" },
                    { "7EgSY0jNEERooaPUU4Qj", "Fjw2xBL9BqCaQBzxcxDI", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3648), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Metro", "c72a9629-4751-4d76-8c4b-77fbaedc1dc9" },
                    { "7FgDFR07S9SzoSnb6bqj", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(275), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Orlando", "a81d0064-4dd2-4466-abfc-90f86f6409b6" },
                    { "7FRQkDQt8dJP1qNFe7k2", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(429), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 350", "83a1b412-7fe7-4770-86f8-3e02bc0796ca" },
                    { "7fYwjFAaUcGKg08dRT0T", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5750), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gemini", "6d12a746-3e16-4e7d-a977-7b0873e523ec" },
                    { "7hbzfeX5DSU4gx1hCrGj", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6303), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Amarok", "5490f246-fd27-46d3-a404-58663078c371" },
                    { "7J0w5MgQjXWUVr03dpYm", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3342), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "18", "fd490ba4-e0b4-48a7-afd7-eabca7d5a648" },
                    { "7LCdcbA9ntodlo80hqTM", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7946), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D5", "b368b8e3-7a57-4297-a048-0c7139266ace" },
                    { "7lPqu9HzKGCI35reM5nE", "9NRn3UNnrPnf2yJoGIBH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9748), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Veyron", "0deba4da-f631-4730-8356-0e9d81ceabfc" },
                    { "7N3pRjIHqHEK6xMQx0Xo", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1149), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Attrage", "92a84c0b-f157-4bb1-b45d-a32f85dfaac5" },
                    { "7NYQTMzYodL6j9bJPrdg", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sportsvan", "b0182768-644f-4049-b9b8-56921d58e8e0" },
                    { "7ory0r1aB5JxwJW5hSCQ", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(902), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Oltcit", "ce44ffd8-7d7e-4173-9e4c-53b522e3e3da" },
                    { "7oU0qCMMFYbSFXWC9RWH", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9584), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 320", "2bdf9f38-a406-4dd4-8e24-b2f8b6d22c02" },
                    { "7pGskh7qIhuBlCS8n40j", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(171), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 53 4MATIC", "9515436b-b56a-45fb-8f6f-51417676eabe" },
                    { "7pTK5QYSETtePuKyfF3K", "ghyFhm7jzcjYDrjMVLs1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4129), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jolion", "d1b06b42-4a0e-495f-8c9c-b3d8efa1de6e" },
                    { "7qDqhhAQxsANqsmTWRAY", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3723), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Twingo", "34c0f380-0575-41d3-94c0-4af3a9b961cc" },
                    { "7QUFySujYzuYUGUS7yoP", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trezia", "46aad7ec-d400-4cd6-920d-4b5498a9cafe" },
                    { "7SjxE05DYfg6PsVxc0qV", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9767), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 230", "a74e87e7-7095-4151-a320-1b9e70f75fec" },
                    { "7Sl1YIWJ9wwnocoSsCVM", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1798), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RAM 2500", "e315970f-8a4d-482e-9596-d7c6013b15c0" },
                    { "7sop7BVTwvBc26chDxwh", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4281), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Accord", "c583d1f0-756b-45af-85ba-77bb51fb6eb1" },
                    { "7Trg9Sg7MPt1MVH3G54T", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2678), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "604", "2d015b21-cbd8-45b8-bcb5-f944c540d8d2" },
                    { "7U6j5JbbhMFssQRRD1MI", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2725), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "807", "389ab770-af3a-42d5-abf0-1458fbdad115" },
                    { "7uce4mTXN3YdP4yFx8RP", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "8", "5d0bec7d-e772-4c5a-8c3a-49064b72b044" },
                    { "7vR6S74dJYKKhugFJ48u", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9888), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DTS", "ad6c17f0-2032-4254-9a4b-8532d99ddac6" },
                    { "7WfUFpN8w7dXPfPNofwl", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3479), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chamade", "1a27c4c9-c113-4b5a-b7e8-4a94a7722da4" },
                    { "7yjk1KNjWcEFgMrpv7ID", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2106", "9306f8c4-8759-43fe-913b-115897fab25b" },
                    { "80MjKYdgoS66lzgaFYun", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R 350", "fc414941-5456-43a5-8fca-479d6e12f7d6" },
                    { "80zV7owAujusNIIp9Wer", "whPfE6p1LaKgaGTWoNqj", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "be68a488-2600-4de7-87d9-4c3b30324a57" },
                    { "811tQz3vzEeD8GvfQdPe", "MvMqrrJaUbAAVIvJHQcu", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S560", "cc4c4e12-1d99-4cdf-badc-1fa1f9e3b5d3" },
                    { "81ANounUMpkXNV1HtPmF", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9707), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H230", "d8b47566-6963-43ef-b731-f1968ac64598" },
                    { "81VfV5HsrdzcIj6d1djX", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8711), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "380", "82b7d6ac-0d16-4306-9003-35139151112f" },
                    { "82hTPhoBxLGBnQ46CRQQ", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ZDX", "3b5e6ea4-55dd-4644-b389-24caebf7d68e" },
                    { "82LqLzL3pBNQUGLNM7Ks", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1657), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ariya", "c90e1bb0-c55f-49d6-9e60-09c48d92791f" },
                    { "84QX3y3JDrQHS9d8qaHf", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(187), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gmc", "db4fb7e3-7f1f-422d-b087-feb0c7adb74f" },
                    { "86HM3HKW4MuACgeU3bjI", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arosa", "13f3f32b-eb45-4100-a9f0-70b02d1489c6" },
                    { "8BFwLnpjP2qMl4Gx16TN", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 250", "a3a76538-0a32-4f6e-9a06-8750b075fb3f" },
                    { "8BrIGTuPCoSzgCQUfrnd", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(182), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 63 AMG", "efd7fad8-e199-4167-9dab-ace3c68ed18a" },
                    { "8CDvyudQlRD6DgMEcdMN", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8649), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "250", "da629756-70e4-417d-a933-1a3c0dbe6be7" },
                    { "8CewpPFdCc3658rxXl3s", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5063), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alto", "b52b31ed-1566-44a2-9173-93abb9106805" },
                    { "8DeDprUuK8qLe71aWWkq", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(719), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C4 AIRCROSS", "77367263-e69b-4e7d-9ab3-17a162c24538" },
                    { "8f1Qye7JHl1ufDR2AvVQ", "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4254), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Imp", "42855afe-0b40-48c9-a2df-7b1e95b0a791" },
                    { "8f2vuvRUeHXEmN10lpVx", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6355), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Magentis", "70f2d7d6-7d73-42d1-ab2b-c125d4f2fae0" },
                    { "8f6EoeHeQC6931TJNceF", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7075), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V90", "922c5d3e-d6be-447c-a21e-bf947232fad8" },
                    { "8gdtXGX30axsssVjx9kI", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3100), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "918 Spyder", "b2b3fb29-978e-46f7-8582-f1fab06299c0" },
                    { "8Gm4y0VRX1kSN06mlUM8", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 55 AMG", "a1dcfbbe-21e4-413d-bc69-6dee05ac8c3d" },
                    { "8hq1UKfHRa20uAm2fyjV", "axxx6410rzzz3jxueox5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7461), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Han", "3c2620a0-993e-4af6-8edd-b755711bbb86" },
                    { "8jGAYzSAM0z35CFb2m5u", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1077), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Coupe", "5d28a68e-49cb-4ba3-9984-d1b047494249" },
                    { "8JuTNkLyrkHfczvQVB3c", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6361), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mohave", "4a8acddb-cbf4-4d6a-99bb-c820808da2a3" },
                    { "8KEAqPHHqnNUmzsQXHdA", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9844), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 400", "c12a30de-5bd8-4ddb-bbf2-2438d3279b3d" },
                    { "8KQSqco9jIhBxIbmYr1w", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(807), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS3", "e3507df3-51ac-4259-acb5-0766eb9fbea9" },
                    { "8Lo3ECc7PYoU0RH7qWLK", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8179), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6", "b0d6dc78-3676-4d60-9560-a022c663a4f2" },
                    { "8lxI1twyLCEXoM6TCSXw", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "635", "85ffb3e5-08aa-4763-9e6d-0ac1c5f7ae3c" },
                    { "8MbI2QHuUvcqC9oFeBqI", "XW7Xpw80z3VgX82egcWN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "353", "0c66ec25-d1a7-4f82-adca-41ebf58e1eaf" },
                    { "8ozP05vGhooIjYEx4dRL", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(293), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spark", "f7d2d98e-06b6-4352-839e-230784c299c3" },
                    { "8PNylYw639tvIAJY7GVP", "u3lzgWdKo9KaByo34lmN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4848), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roadster", "e6683b81-22a0-42b6-b3e5-f05e1fdf46d6" },
                    { "8py8deu9WES1ppbEpMVY", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5887), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daimler", "eed14bf1-d1ee-4a39-8c0f-a90152379ab5" },
                    { "8Q4S4HxNyBM1UuKRfJIs", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3348), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "19", "5b057e7b-cef7-49d5-87b7-db9b3349c9f9" },
                    { "8QFlJBSE4MEm98XjToNQ", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Eldorado", "ff407e43-5077-4d8a-a857-3417cfcb88b1" },
                    { "8QQWzcIPvYXfemIXfjb0", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "4", "79d04699-b3fd-4d20-8867-3aeb488e2885" },
                    { "8qr5DIaJJCcHscavQXa5", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8629), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maestro", "d37cded6-7fb6-49ff-ba4d-f46f9c3a562a" },
                    { "8qUWBpfwMlIMzH9gRgSL", "W5TnArCA9xCEodsTpDHG", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5522), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Model S", "e527980a-32fb-42c1-8f12-a262e0bf08d0" },
                    { "8rVsU8GVUaRn5mtemWlu", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(361), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 280", "3f92064e-d959-46dd-8032-872324faaff3" },
                    { "8rYFYYsYnfI8NCfDAcLb", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6531), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rabbit", "2e818d36-d8c8-4fa7-a4c9-e61ff214465f" },
                    { "8WPDbLbwwKDGV5GLxEGL", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S90", "72a1ceb9-05e3-4515-bd51-45b040bd8e8b" },
                    { "8wRoyLTQ7hLguDR6asUD", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4959), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grandeur", "01cb52f6-4b97-44a8-ab01-45da12494df0" },
                    { "8x2fBz9AMDAUWnI4zlge", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1300), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sapporo", "164cfb85-5885-454d-b193-e27567b0fbfe" },
                    { "90qVY8ojehgnM4hqIJrB", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Veloster ", "a9d3bb65-f19a-4df5-b4e1-39fa17158c86" },
                    { "91gDgW45eWtvDdIT4Iae", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1975), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Versa", "4f25fbdb-471a-4c56-bdf2-828c9855805c" },
                    { "93cI2oR5T7zeVuF3ezoo", "CDKhu32A8uPkeWM4eblC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1020), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ateca", "531462d0-d3ee-473e-bb39-b4a587be8bbc" },
                    { "95FgeUUacSuzDzUuq4QT", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "402", "27e60ca2-c6fb-4120-ba29-c944a2cd9bbc" },
                    { "98sq7ge7Ja8F8mKvMb3X", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1760), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Micra", "966b1c2a-64a0-4eb4-953a-8e737c1a9c73" },
                    { "9abPUQxv9KBQcof1j6os", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9608), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 420", "ebe45cac-e294-4cf6-a88b-19f776ba3745" },
                    { "9AX6UJFHPW8FlQXC9r2q", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1422), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2140", "b79049bd-15a2-427b-b744-1498b1c20fe5" },
                    { "9BJpVfgLL58mFElwhxpY", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Joyce", "09ed2c68-07a6-4048-a1bd-abde68895890" },
                    { "9desJ9e7TFwkAM5offdr", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(661), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 55 AMG", "449ab510-39ba-4835-b85c-64e94d98890f" },
                    { "9dV0nKokWKVM66QEG084", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6393), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Golf", "e4c47f85-e6be-4cc5-8241-76a3d75d9ba4" },
                    { "9ExhuW2cN3JfuDKynS2j", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Firebird", "9df8c838-f5d3-4341-be03-1752f7576edb" },
                    { "9gptWtgbftVLmTmIWL9f", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8661), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "280", "1966b772-38b8-41fe-8f4a-882ec311b5c9" },
                    { "9hv8pzARafKQhonlRh83", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7588), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zephyr", "963be257-1790-4889-a1ab-865f5af2d603" },
                    { "9j0npcfMoPYyeEQ8fBMC", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Es", "f3a92eed-fde4-4bb2-a39d-dc5982ffcc1e" },
                    { "9lmFCj1wNYUHpcDAMqPH", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1194), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Eclipse", "405cb5ff-905f-4e45-aa52-e22714021478" },
                    { "9n4RntFPRnDJ4SVn6Lqf", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5798), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Previa", "f60dde58-7161-416b-9405-311305d43e63" },
                    { "9n8snvrQfwtYDh14Rwff", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Suburban", "6d900d69-ca86-42ba-aa97-be7ad61cdc84" },
                    { "9nIVsywR2VPHapB2lYWa", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1672), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Challenger", "0cbb5f6b-0a5e-433a-9162-f5c995f75194" },
                    { "9nmc0oYpWnVE2h9vLHR9", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL 65 AMG", "c1f36aad-a411-4bad-8896-1044f42406a5" },
                    { "9oXaW0Vklgcb5tzMkS7P", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1612), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Almera", "6572f91f-101d-40f7-8437-5f3ebafa0adf" },
                    { "9Pqld23K2JYp0MWMeS8P", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maverick", "6d4b3d42-f590-4e96-8f3e-bd0b18c79039" },
                    { "9QHS4lkWyfBB6o1Sakgk", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3070), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "356 Speedster", "0c4dce6b-6d43-42cc-b842-69d3e020c070" },
                    { "9qtgMpblN8BubU2HAvWc", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2697), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Strada", "b7c30966-a19b-4495-8a00-3017534f766e" },
                    { "9ReeDeovbPWyKTfog1bb", "zmtbQwqcCyHjrSKk77Se", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7389), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "531bdb2d-5da3-4262-9442-0e814b402fdd" },
                    { "9Slf1M7dy0g2mCnvI7g5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "324", "d3c0ab68-482e-4f9f-a0bc-76c5c0933181" },
                    { "9tCjNEoJvjSARlanDgcb", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8889), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "AMG GT S", "50be19bb-2b4d-499a-89df-475347d7a422" },
                    { "9Tm0zsBQaToaxgPDyQa2", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "340", "eda7403f-938a-4865-84e9-ce0d84192bb0" },
                    { "9TU3rNSGLE9tWwuEedn5", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7280), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gx470", "7c6e2386-5637-465c-8e61-73fd59326779" },
                    { "9UAlgeqIX4yx7z94pNHc", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5496), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fx 45", "95f6fa8f-c829-45cb-b1f7-aa5df69846a8" },
                    { "9uDJgUpBrCrgN8mbF8Vd", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Camaro", "dc46e572-c450-4e0b-b802-f8b76dad0535" },
                    { "9X95AMwXcLFwhcrJN9yg", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D-max", "b8982d3c-57d3-4a1d-a33b-e0a0b6305638" },
                    { "9XAoe6AujAbhUhap0kCq", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3756), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Saturn", "e3f7c0ab-2339-407a-80b1-22087423f91a" },
                    { "9XocdlHsI39HC8BvbjzI", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8267), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "СХ-3", "be715804-ca2d-4fb5-8878-8da2f8dd8573" },
                    { "9Y3wgvxBxWn5hmUjl2eu", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6982), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Urus", "915df3a7-f173-4835-ae45-789708632390" },
                    { "9Yy2oSdh1dGl3jqGJ9PA", "T8karRTfSTcM29oupBnt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4311), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tc", "044a165c-4341-4309-b3dd-2c1dff520ba5" },
                    { "a0NNJT8xnkFsPdlePlsA", "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7320), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1103", "b75a4ea2-bae7-4175-99ad-cfd64c553a08" },
                    { "a0sUm3Y4EBgW1GMLBLw9", "etMtb4JLm7eB90mlnd72", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3487), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GEM E4", "33894a53-e4d3-4726-a462-d8089efd3ad1" },
                    { "A1cfGUdEKdc4b8r8rdEn", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2299), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Omega", "ce681b04-0d8c-467f-bc3d-31ab75274231" },
                    { "A1sRul7h18fIBAYmw2Sg", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "524", "feb75df9-dcd6-40ae-a6b4-a57d51718c78" },
                    { "A3eprqbIJX0tl5RzDQa0", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8079), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A1", "fdcb5a2a-a046-470f-a822-66c10d235035" },
                    { "A56cscUMhzKX5cLCpz2x", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "460", "c36c023e-fc6e-48d3-9272-f85bf22bbca3" },
                    { "A6cFCU8jQp2BSCJ4ymhm", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XT5", "3c46524a-f041-482b-88d9-c4ac488ddce9" },
                    { "a8Vb8F71Kj0eP1dmkWdj", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arona", "64443c3e-dbc4-4367-a41b-25172c6ec4e7" },
                    { "A9vxp57V0zlC7WMtmRKB", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cooper s", "78c756cb-0d6f-48a4-998c-be3b98728a16" },
                    { "aA4JP01ww410LBrCXd13", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3403), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Thunderbird", "e89245b6-cef9-4eb5-8da5-7468a0b05c3e" },
                    { "aamf5aRgHks75SloLWlb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9068), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "545", "5f3a0f7e-cfaa-4c3d-a630-e70b0376bc32" },
                    { "aAtfVYTPv7KMTtXS006k", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9827), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Skyline", "d64dbba6-0d94-4959-a779-232dba87cdaf" },
                    { "ab3MLIXkBsMLnBInm5N9", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9818), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 290", "02395dbf-d84e-444c-a554-b6dd163ba9da" },
                    { "AbaJ0HbdpXDsKoNXyRSD", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grace", "864d0615-af5f-4593-af26-a52c1a042d0a" },
                    { "AbcDLbkmRMxtQLGrrfgh", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 65 AMG", "728f9e40-da17-4fb5-ad26-0ab7dafb5ce7" },
                    { "ACtDfe6WVtA1QPWanNW9", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9175), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL 320", "e59e54e7-586c-431e-af27-e31b13acae7d" },
                    { "aDmmEcNla8lxV91Q6RrI", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kubistar", "be5af9d6-a77f-4fd6-ab95-308b649a3aa1" },
                    { "aDs9L0vWam49VqexLzfr", "bymbQs0TabKzPsrN3TlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C06 Coupe", "d2b77554-356e-487b-b9fa-9ba47d750a0b" },
                    { "Aeh8kzaFH1EhAGbaUt0E", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9951), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GL 55 AMG", "9457d47a-cb9d-4edc-83a1-567fc01a0410" },
                    { "AeHJUMgL9rlMe2LFJUKn", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7330), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lx", "8f9e4d75-67f2-442b-94ea-48b1c445a885" },
                    { "AGH7IG2jG2hMxkWAgW6V", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5807), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vehi cross", "dcb81762-9bfb-44b7-8427-0f9825885b92" },
                    { "Agv4pktzVoAYcEwguMYy", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cerato", "e3dacd59-c898-4e70-bbbf-238fb49c51b2" },
                    { "AHDTfhvy0YE2VFXkdl82", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4739), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Forman", "5bf86fbf-1abf-45b9-a9d5-fa506273a60e" },
                    { "ajsDM4GqJzMsXjx4AMMv", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4829), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Coupe", "12573bbd-fbbf-4b9f-b1ca-b879d7f0e4ba" },
                    { "akdRJwjpr8nuhtf1o0v6", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1980), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X-trail", "05a00d21-e0d5-45ed-8d95-331960c516a1" },
                    { "aKG00qfoMKDdYYEFQd9m", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8067), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "80", "f0c47a88-9fe7-434d-90ac-eab79969390e" },
                    { "AKVJopo6wHno6SdSdwDl", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 300", "ace62faf-0c9e-4a55-abfc-557e3bfc5745" },
                    { "akWDQKG4JExRQjmcIU7F", "eUMYrz00U0nQH5KTc7uR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "469", "8db0e9df-f099-406b-b8a8-5afaf1cbf7fe" },
                    { "AKxeIADBMTRqtLdykMf1", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6923), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "770", "7e82c35a-af7c-444d-8c3d-e7a3b577cd22" },
                    { "alDA2AW02BJkhEPWwL8X", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Agila", "a5d33557-159f-4433-864e-93bb26ce07d9" },
                    { "AMnTxNwkTnQf8pp4fWol", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9493), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Citan", "443c0b9f-387d-4f3b-bae7-6e62faeb1957" },
                    { "An8D9asT7jjmtG2TCeFt", "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7365), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "966", "d00d61c9-c846-4c84-860b-f0641a0f483c" },
                    { "Ana0NLf9U4Gw3rpz1ncx", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zagato", "40bc4a47-7810-4814-a26a-821c9d4cfa41" },
                    { "ANcU7XJbP8XomV5RmxqF", "CDKhu32A8uPkeWM4eblC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1026), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Born", "4efae7e1-3d8a-4fc9-8479-2005cf04a050" },
                    { "ANMw4VPC75ULgTPaNMsn", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(436), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 400", "7e1d6565-def2-40dc-a651-331c44811c0e" },
                    { "AnPeSbeFrhgqYUnmSlky", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5664), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "QX30", "c54602b7-e689-4e20-a641-07ab1401e274" },
                    { "aNYCYYdzWz15rk9m0WHI", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2911), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EcoSport", "a6acf0a3-9e1e-41a1-a4d2-ca476b16cc7c" },
                    { "ao78MAYXD8hlhXbueICQ", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Corolla Matrix", "1488f6ad-61c2-4d20-a4a6-8c19123a0022" },
                    { "AohTPqgtUac1ETwd7hWW", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3601), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kadjar", "2e8ea11a-f504-4a43-9c00-6b1d4f84015b" },
                    { "ap5wgNnJJuttdN7QLbCk", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S70", "1f9b9497-c550-4c42-ae17-616295cf3e0b" },
                    { "Apr2RuvX29MHsepLeSG3", "sx9Vqv3yxRnX4SGwQa4y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Outlook", "f1b47add-2b1f-4089-8deb-3d11b5763b81" },
                    { "Aq5hzxnlJIY2yjIlxAou", "T8karRTfSTcM29oupBnt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xa", "0cbda856-1c7c-4ccb-ba82-3ee014d9cdc1" },
                    { "aQaIrXC6P0lg6v0IlfPP", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4008), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "618", "704f5acb-219b-413b-b1f8-4c496db09b7e" },
                    { "AQAwLa791zFuV6s5hetK", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1270), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Outlander", "5cdb2120-59cf-4b72-9ec9-c9428b15edc0" },
                    { "aQV7HYzcMDR58U8MLEQv", "PsbTIAKWHCVgruG7IgRE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2377), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kelisa", "64927a62-7709-4c27-9dba-5b7f7ca43a1a" },
                    { "AR03wGBBXKUj8qlKfKjx", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4808), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Atos", "ac946062-2ecc-4e9a-a84c-c18def369a14" },
                    { "argLujelYks6mKQX5D6o", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2123), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ascona", "7fcd5d53-f11b-47d4-b1bb-fbc48bcc4516" },
                    { "AsPyj7K91auM97btQ0AT", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sovereign", "6ad69a85-6e8c-4f59-bde2-f094b161e77e" },
                    { "AUgdnLTgfdCMU6HYAjp7", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9532), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 260", "8db89a31-02f8-4582-ac14-b27920637f8d" },
                    { "AuMA0kLdVpb2V9A6yVMb", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(137), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Diamante", "09c7747b-c049-4667-a982-d86a88c03d08" },
                    { "Auxrb19GEhSJQyAEs3Er", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "90", "920f24db-ee32-4f19-8309-a4b0478170cc" },
                    { "avaWrLgmFBKVue4y9Spp", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8543), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S7 Sportback", "e63bbcf6-ec2e-4797-9e79-312d59f190b0" },
                    { "AwBmCwF60UsooINljBR9", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2806), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C-max", "e0b2ae15-5dc4-4663-b408-1fe5c958ddd0" },
                    { "AX3CKWR88JXskUE7GGvT", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3723), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Acadia", "9b2e8b23-4c44-435e-b136-c8f35b143e27" },
                    { "axIquLwhtKoAxLe23tVt", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2892), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Road runner", "35176876-6014-4e86-8822-697115064c02" },
                    { "axVLVVTPPDBsxSlY0rqm", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5131), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Liana", "e21225c5-56d5-481c-9304-a79121206d19" },
                    { "Ay00Q9DpULeUs7gb0zTJ", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2655), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "5008", "86915bfa-7327-4809-b5da-59e63e4d5955" },
                    { "AyjJR5BVBrPWs9yfhXn4", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Niva", "979b10ba-a765-4539-9bf7-f98dfedad233" },
                    { "azJ1Eu5BufRAC1caXbhV", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5866), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Starlet", "83b078e8-362f-4a76-957a-9febdf466fe2" },
                    { "b19cNWAD9DW45cPJaNkd", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Brava", "4a094931-7e32-451c-a107-670879f95c17" },
                    { "B1sYdC9J68vYrmtbQ9Nq", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(464), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 55 AMG", "b32e1b38-ddf2-40aa-90d3-fa249fcdae06" },
                    { "b1T2HfJtJI0s26olPYjI", "v4vruTNk6WkdcxN3fFA0", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5461), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Slavuta", "d522b3c4-b80f-4daa-98f8-25a832f7268c" },
                    { "b2m6yNJwl0RGGTyQpH67", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3864), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Yukon", "adfc8cb1-fcbe-4451-83cf-52bd3542139f" },
                    { "b2rm6NesesNld3eTqXQU", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1142), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ASX", "9857e0c3-4861-4adc-99ed-ba0c7f661c8e" },
                    { "b4xVHGTqJHktfCmVAQ2C", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ulysse", "54559a0c-5e39-4feb-bce7-40e8d82d69fb" },
                    { "B5fQtquNNHzouBFAj9dd", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7585), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "159 SW", "a39b58b0-2e80-4f9f-878d-c449029dc214" },
                    { "B5o0IFSMb5EkArdRrHfr", "cjnwEk8Wle037jtonYsj", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1038), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "580", "6efdc8c3-222c-4ea3-88df-43a4351f3479" },
                    { "B5r5e3T0hVhDCj32Uxm7", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8667), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mg", "954432d0-d388-4fdf-8f71-70c1c9849a10" },
                    { "B66CG8m0p9lpUGSuaubJ", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6309), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arteon", "abebaa63-edf3-4653-895d-8379d330f1ae" },
                    { "B7EDm4XCz3a1TYqnAPEj", "vMFor3Ks1QECjDpWHUqW", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gurkha", "891dbb6a-f8ca-46bc-9150-612c829be75e" },
                    { "b84kvJY3Ap0S8yAmo298", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5847), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scion", "aa4c1645-5842-4551-83e1-6a9326ff7f45" },
                    { "baLfPc5r7TdY7noXdhNf", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1109), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D one", "bf9dcf17-7b08-48b0-a833-bc82f9c649e9" },
                    { "Batzf4oP8gwMb6kBCq2G", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "940", "0bf423e1-bfc9-439f-8750-2c8cc1692914" },
                    { "BaYbWeSMBscgg4e0jfQN", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tf", "f3401d89-971b-42a2-bd2e-9e9e97ff0b89" },
                    { "BAzQqo7VGCglHExVwVpq", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6704), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "VS", "5e9f3a4c-554a-454a-904c-aa60f3e8210c" },
                    { "bb9E79z84VdxpTUIYGEB", "nm2AJSoa0dWnayDNBRnh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mountaineer", "9ebbf6b6-48bb-41e1-8523-bfe523ac287a" },
                    { "BBgMNVPMkKWGJKM2CRId", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 220", "5502c703-489d-4d22-9cae-8b74af589cf9" },
                    { "Bct3HyAerIgKjpT5twuI", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1312), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Space gear", "2ea4f40c-ceca-4115-8b0e-20e3a47662d3" },
                    { "bE7NuVH6t6ktnt5sS35I", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(59), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLC 300", "e93cd37e-2fe6-442c-9580-11571562b6bd" },
                    { "BebNuWadPnsysleAkutz", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4354), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Altea", "8da8936f-36bc-4aeb-bd86-8cf35b126906" },
                    { "bEfJIrztut1vGtxgwrWL", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7361), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rx200t", "d7fe81e0-cec3-46ee-9ca7-1d18af3eb365" },
                    { "BEkNqRklwyzn7Wcmgd7w", "sx9Vqv3yxRnX4SGwQa4y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aura", "c8d388f7-a370-4dd8-ab45-565812d72a6c" },
                    { "bEMBxNkdQoDTqA0G86e9", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2362), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Albea", "c286df7e-041a-4fef-86a3-efe4c3b1ed35" },
                    { "BeUl4cNtwCda4lDuHooV", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9725), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H530", "e95d98dc-767a-47a2-84fc-e340149369ab" },
                    { "BffEGasK2StsgeGeAnGv", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3739), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wind", "f9e3f6b6-b0b9-4d71-b195-b15671fcacbc" },
                    { "BFPvRHuGksEzxATQol7c", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8264), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q3", "b6e582b0-b748-4343-b6de-1253711de08f" },
                    { "BH5xkr2lMhKr1Mltj26J", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3449), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Avantime", "f7f26fdb-aed4-4f07-89d7-e519d694110e" },
                    { "bHK9JEJGQeouowqbbudG", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8083), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CX-7", "d8f67c5f-9ac4-463c-92a3-173d26f2d798" },
                    { "bhmCXXGTob6b1bRrWnGj", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3215), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kuga", "39edf814-dee7-41ac-b0d2-18e40765e750" },
                    { "BhuyTxrEVNGSucIpSS0h", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6512), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Passat", "ea90b48f-972a-4e5c-a3a5-0a1010e0eedf" },
                    { "BISxLGvoLS5VxIP36kgo", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1675), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cedric", "e5d98a92-e23c-446b-a309-db2dae71580c" },
                    { "BKIlmSD9NJSvzRwhrnmc", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4387), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crosstour", "a4da8e9d-5df6-4bef-a645-a6aff8ad50f2" },
                    { "bLp90mbCKDgagagwNxne", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G sedan", "b1c8ea25-7c67-4334-abfb-bb8443a6c29a" },
                    { "bLrl8EYEAERmoMEsdzrG", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1427), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rezzo", "8d4e4024-8b3f-4694-aafc-d2b36412b864" },
                    { "BLy7c8aGknhPLAP68EAr", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5064), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ioniq", "1a46e1ab-ba2f-48fe-927d-532fce86c18d" },
                    { "bm9vv3fzIg2dF4Gzswjw", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "145", "e1dba8b4-7899-4299-b7aa-e6896d88c2a6" },
                    { "bMBGR2H7UTsoWyhPt8lD", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aurelia", "dab077dc-f4db-45cf-971d-06a25a0ab386" },
                    { "BMd6bzleL7XDMWcV1toG", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "190", "e6d00e80-a30b-45ae-b5fd-335b5ecd2c3b" },
                    { "BMRG57TTY9HG3QN3oLJp", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8945), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "430", "42339c5a-5b0e-42e7-9ac7-17b155daeddb" },
                    { "BmUfSSnr008Iq49BXJQC", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9601), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 400", "6cfbc2a0-1eb2-47ec-aaf5-bba0a2dfa1d7" },
                    { "bNHUxnNGPfjTToWR2LG8", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5757), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hilux", "14f7f574-cde0-4947-9fd1-56e2facacfdd" },
                    { "bo7P4I2J1XEaIGYS5WYX", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5763), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "IQ", "82010192-33f6-4394-872f-2dd63838455c" },
                    { "boD7yaAGeEldsttNCAUb", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(708), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C3 pluriel", "b1d290d6-e02a-4ca5-8959-4b4154fe5d8a" },
                    { "bok1FfuWnTFgb22js5TV", "zzzbw5sz2hj27fvp4x2v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EC6", "2ea5d6ad-0a31-488e-beab-babd67128eb9" },
                    { "BozVH42EVnG06PEg39e8", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5929), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Verso", "732705aa-80cc-4ab9-b42c-94179c61d931" },
                    { "BpNEvPpqPYN48v0JuaQT", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8672), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "300", "3cdba7a6-f355-40b0-9b75-5b8b5cd6f3f4" },
                    { "Bpq34Ls5gbjR4Be2RDuK", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3360), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21", "6503d946-dfbd-47e9-9d4f-5ea172025fff" },
                    { "brhl8llectLPAWAzGrEN", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(281), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rezzo", "fbc20a17-c129-420e-86a7-543fc5cc3f64" },
                    { "BRmeMUtGuasjCH7JygYv", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7417), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "UX", "54138dbb-d6c2-4a19-aae0-f51afd37eb29" },
                    { "BRqWcUwLHj6WHmRggQkt", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Avalanche", "b3f9d2ea-26bb-4668-9dbf-15859246f3ae" },
                    { "bRULwTxAXow31vyH00x8", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9643), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BC3", "cde604ff-ce43-4f26-bd23-789371c6553c" },
                    { "BSDXd8vCVKBF1agaUXjR", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2575), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "309", "fbb7bbf1-2b98-45c2-bef3-ab8dba57a251" },
                    { "bSqI2ePpx2d1TrBCnA5c", "PsbTIAKWHCVgruG7IgRE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kancil", "77631e78-f26d-447b-b9d4-8f69456b2494" },
                    { "Bsrxh2NPb1E0Mbun3JGm", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8787), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 160", "ffb2bc84-6a6d-463f-b77e-73e505cbddbc" },
                    { "bTqYfzA5jocAnWUgyMw7", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4614), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Versail", "4ccb06bd-0a92-4a23-adb3-2ad28c173b64" },
                    { "bu7u6ep1bLYfVzYct3db", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5143), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Reno", "27843650-9561-4c89-99bc-b4da61acc06a" },
                    { "bUh6AG5CYo0aPIAnNVMz", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3856), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Typhoon", "89040d40-4efd-4088-b978-6764b1cefddc" },
                    { "buJIIrGCpzJBYPoLaJqr", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(526), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R", "2a64e7e1-ff6e-453a-aacf-2f8ac75fa705" },
                    { "bUX2ELoItmHydQ6KWCY0", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1137), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3000 gt", "ae85bf87-9845-4bee-88e2-119dca211327" },
                    { "bvEU9HbyAe7sU9ek10bd", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sierra", "97211864-b2ac-4feb-ba62-d055dbe442ca" },
                    { "bvMmg5pFFkFelCAYJaFl", "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stag", "1c6e071f-cb22-4e2b-8f7f-8bdfcc27eff5" },
                    { "bvql8DKUeugGqj635Dp9", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(348), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trailblazer", "fb8b4648-760e-4fe5-886d-b79d9a51cc0c" },
                    { "bvUM9h48T0MUY7hkCJya", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5193), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pony", "4c5f3308-2e55-4be3-9ae7-6ae80ea9ced5" },
                    { "Bvy3IdPHwwKwduSAxw7R", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3641), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Modus", "993aff3b-6292-4c62-8273-1f024bcadee6" },
                    { "bwIeBtnQ1QLYzIV4vF4X", "eUMYrz00U0nQH5KTc7uR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3515), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "69", "7a4865a6-907d-4a93-b31f-6b3bcf8b848a" },
                    { "BwjKFH1osHeq5Hopf6qV", "ghyFhm7jzcjYDrjMVLs1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H6", "c98dfdc0-2ffe-4990-b6ca-8969c5fb0307" },
                    { "bxh9SQvhrddRK2tn6FGG", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4464), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tarraco", "048dc055-d133-4364-a628-ef698d825845" },
                    { "C1p8F2cqc3lPmtpoBvGN", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7972), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "121", "981150b7-33b4-4483-b316-054e6429456e" },
                    { "c2EaN1xSCTjE6WjBcYuj", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BRZ", "245e189a-8d19-4c22-841b-f90821236fcb" },
                    { "c2z2dkRgozb1Qa78akgW", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7048), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Flaminia", "8d82b871-94ef-4d72-b23b-6741a9c4fbcf" },
                    { "c3jwTLMwEWkoTtpcUu1a", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5774), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Matrix", "b0e3c8d1-67db-4445-b7f9-775bf09cfbee" },
                    { "C3N6j3fGJVUBb1VbQ2DF", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Titan king", "fb4bbe88-bdff-4b4c-80a8-b4512d6863aa" },
                    { "C4KcIKvKMbkh2QM9Mpjk", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R 63 AMG", "bba339a6-c48b-4388-8954-6270607287de" },
                    { "c5Fe73DKCGTEbjrYjw3u", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9119), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "630", "023f4f3b-3e1d-48f5-9946-6aa65b54a9f8" },
                    { "c5lNzJRASNBqSEU3dyVh", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6436), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Quoris", "01b38ddb-5299-404f-8ccd-362e7b32b130" },
                    { "C7vvt3KPIGAEQ78slg6F", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6864), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nova", "bc97ef6c-f7b1-4178-afd1-db60885addd7" },
                    { "Caf5EzITISBhLamWm1e2", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1979), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "360 modena", "3daf5082-2941-4ca9-996a-1ece1aa7f9b4" },
                    { "cAm738m9YHfhf7J3MUxC", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9436), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 53 AMG", "527595fb-2710-4520-b1b3-f54a7286460f" },
                    { "CbAqQN1tdJ629KaEKd5I", "lgRSEHsdarS0gC4osQWQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Exige", "22f89bab-2c79-4bf1-8300-cc8573d91f49" },
                    { "cBIrCQNDIQBwxYpWVsmg", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C70", "f0329eb5-337a-437e-a0c4-be17d8447efa" },
                    { "CBjbAFVPUcE3l1HfFj4W", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9501), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X5", "24733029-7e45-49f1-b7ce-99be763fddee" },
                    { "Ccds1wIYwew6hGLlvLQQ", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Shuma", "60cb7474-e172-444b-9251-6d2aea48b91a" },
                    { "cCgwoaIbuknaGobcFqyX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8934), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "420", "e9ba9293-d064-4943-9569-cd4f12cf5c9d" },
                    { "CdA68QmDCr2p5cnSo9yF", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mkz", "e4cde3fb-6257-459b-9a4a-09b9e170d316" },
                    { "cdCUmpP7SXlgaNp9aWLn", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6991), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S40", "23db77d0-dee5-442c-912a-98b255f5bb77" },
                    { "CDTF14r2YK8gF7H6LI5N", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "116", "6eebd42b-b5e3-432a-9f65-411621fbc311" },
                    { "cDTFzenV5udC6YEpvBun", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2844), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Laser", "9ebd9613-e6bd-4703-85a5-dd70689230e6" },
                    { "cdu8YmnDt0TuJavDX8de", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RX330", "bca1d19e-9244-4dbd-ac0c-3407c23e0d61" },
                    { "ceNNdRmrhpluEt60ojQX", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1765), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Murano", "85f0a31f-9b95-40f0-b254-3a0b32150c29" },
                    { "CetelHzzacQfL4gdydpP", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1781), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Neon", "a3fc20ee-293f-406e-9de4-c7d086a4f737" },
                    { "cEUyCrwqDdkPEJgzvqMx", "yjnmBGS0tfeUY6wppqlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7221), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1021s", "99e2671d-6beb-4362-82df-3548b60e731e" },
                    { "CFoxoEBxBXkPj5C3gWYe", "whPfE6p1LaKgaGTWoNqj", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5998), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "T 1.1", "7ed6bd6e-0bdf-45be-89a1-8d75ad3f7330" },
                    { "cG88J4DDX2ylR9dhaqcN", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8756), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 140", "657f8f08-feb5-4c27-947a-ea70f1d59f55" },
                    { "cGC9vQaqblQlHterukh6", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2861), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cosworth", "6b899ded-60eb-4676-976d-fa4551ac72ea" },
                    { "cGQ7sWYPaQF2zjmb35fA", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 250", "7569f3f5-9139-4b47-8764-f2965bd258a3" },
                    { "chfvw5fWqGojBtcauhfy", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4905), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B10 Tribeka", "b41b3d57-75bf-4f25-a8cb-6947157db9e5" },
                    { "CHL0W1uvoFtXr5WRJxYx", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3962), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "25", "e829e8ad-c41b-4df3-a4fa-7a0ea28456f2" },
                    { "chQ6n0uFflmf45DYVRjH", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4941), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Getz", "e0c70439-bd77-4c41-bd28-542c86ba0a2f" },
                    { "cHuUN7ercPoI2Rtv8Qw2", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8448), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "116", "20cf5586-d8ae-4a7a-a6dc-76ca57f010b2" },
                    { "cHwcA5kSwY3yWWug4PLp", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9230), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "840", "0d2c6868-5707-461c-a327-816efab0e17e" },
                    { "cjA4V7rmgfDxXXCC7CCC", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "P 1800", "5e4b51cb-b082-4a18-9e67-dc2276bd025f" },
                    { "cjIjoJG18GfmbQGnSkUs", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1558), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sirion", "d63718d6-c184-419d-a16e-86c8da1102a6" },
                    { "CJITM2JNjM72UUl8tIMX", "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 7 Crossback", "16df0b83-e4af-4c25-94c0-7284754dc2b4" },
                    { "CjMjEXphGBty8qrCuTPe", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1748), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Leaf ", "3b3b41ae-9231-4116-854b-52b28889c0a1" },
                    { "ckDTtyU5js3qYzmomScn", "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6033), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tr6", "af2e113c-0de4-404d-820a-f9275e490b48" },
                    { "CKHM8xoR3dPScXl04EjK", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8799), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 180", "e6a08766-cab3-4937-a3bc-00952d7d4a4a" },
                    { "CKqKzH1Mt2rbWXMsygnn", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(205), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kalos", "b61ac77d-adc5-4e9d-a665-564a17935ca7" },
                    { "CLCWP3xzplfMFaywTono", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(609), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 280", "30827d0e-2995-4ffe-8bfd-e41a0954f931" },
                    { "CLfax9UHUxAdAma76U7T", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(812), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS4", "e8d7adb1-1576-46ca-985e-c536e74efd32" },
                    { "cLjHHHJcrsI2CXAufwh4", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3790), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Century", "e9771e78-5b18-408b-83c9-e9f7756298a1" },
                    { "cLtXG1gvxMEMe97UL09d", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9866), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BLS", "f47fe46e-2317-4068-ac5c-97d6ddd43fb9" },
                    { "cm0lMMyByXaNQM28WnBJ", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2448), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "108", "a3b0988f-ce95-443c-a4b4-a952ded82aa9" },
                    { "CMge72oT9qQNFAcLvqpj", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5289), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XL-7", "71b5ec3b-5dc7-4300-9cbd-54bba83ac603" },
                    { "cMWg2u5crXynWutFH404", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(800), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 7 Crossback", "2a22b9a3-3605-49f0-b308-649e2a4f1352" },
                    { "CMwGNYclNeEKNaybt5N0", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9192), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL 55 AMG", "192de95e-a59b-4cb1-9896-f67c13627ad0" },
                    { "Cmy0UuLXoNJoyhyGWfp7", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8190), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6 Avant", "83a15f04-f917-4204-8fbf-f5273c60d9a0" },
                    { "CouGbB4BKRSfc75w4GkM", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 560", "c8fc5f6c-e84c-46b5-a6a8-30b8e3066bcd" },
                    { "coUPSfaHbKl8Io11AkjL", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3158), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ka", "5335e440-df39-49a9-bb29-d85aeb51656b" },
                    { "cp5QMgVrbQCpXE0yeYzX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8706), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "118", "eabe18ab-7157-4aaf-af3f-b84fae031927" },
                    { "CqWJaI1hmQYCV3Fu7HR8", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bx", "91bdbd00-2a81-4c7f-a95d-e11724c27236" },
                    { "CqWqrumkkzwDWfKCj8bw", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Touareg", "286397c4-ae5e-4b53-8525-8198228cfb18" },
                    { "crzJ7UtMSv3YKb9j4Skn", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4780), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roomster", "6aceb156-22eb-4ee7-9138-db3482b0a881" },
                    { "csaQerY2DwhF7VQJVIyd", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLS 600", "f4c50479-d420-4083-874a-091fb97ce00e" },
                    { "cSEmoY7csRxdbfnutWE7", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4989), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "I30", "2dff5200-7da0-4399-b010-89bdf20b7769" },
                    { "cSyk1XGtaseMNmxudRAT", "Hc1zhgoBCF1639Rp1PkY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4791), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H3", "7403e627-229c-4deb-b559-1b66d242e56c" },
                    { "cTJPvG1A70z8sr5kB804", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Samurai", "a32d0599-ec02-4292-8f7f-718460818ff8" },
                    { "cuHm4Nb7r83hha3E6L1a", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "725", "b577d4ec-9839-4894-b501-b57412f7b21e" },
                    { "CUMYSUsKt4o2pm0jCCEF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLS 500", "b614f273-f3ab-438e-a86e-48a862ee231c" },
                    { "CUQJqq5YErF4DdFqyI9U", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8519), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S5", "c13b4e8b-be1d-45c0-879a-aaf33159bd21" },
                    { "CVNwSeyHrbSDRtYSquEN", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9158), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "728", "b139a488-9e6f-4fca-89b9-353f86f039c4" },
                    { "CvpIoQP39lXbLnzX0JQb", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "c96fb4be-54a3-4e6b-8a16-9d0b114ab85c" },
                    { "CXk4Dxj0vnsv7gI1Puu1", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2181), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "124", "a643b5a9-69b3-47e9-934d-931ae7f0361d" },
                    { "CXQucmceBHuxjsu2LlSn", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5210), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sidekick", "b3a3c7d3-8a0a-40b7-86c0-a556e8e811f8" },
                    { "cXtx2mz5FnPhLjXWXg9p", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9084), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "620d", "5da82cc8-468a-4b33-b911-03605171782a" },
                    { "D1AxtJm6PCTdXqJn3gqe", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4653), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pilot", "22e4197c-b718-4bec-9279-1fb136ed43c2" },
                    { "D1oTraGSxvnxyxnPk1q2", "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 4", "0f8f5546-1af3-45b4-ae18-bcfbe96d186a" },
                    { "d2gmNhSIdrRfdTcACl1Y", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5682), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "QX60", "274f1338-c4b7-4dac-961f-bb82a91bbb7d" },
                    { "d4xhQqpmByRGahKAgyFt", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5473), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ex37", "39afa77a-7dc1-4a4e-8186-1475e88cf144" },
                    { "d5f3Y8dzaguvAds5EYfu", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5411), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Telcoline", "3db30a78-4824-4242-bb60-d6c846728116" },
                    { "d689hRvYxCsQYbJ2JKf4", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6855), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "460", "09155316-f723-4287-b7fe-ecf2beee62b6" },
                    { "d6Rdp0Ub58HoTU1D2rLq", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "820", "2d6c6c18-f199-4156-9c39-b8f2d00e8741" },
                    { "d6vhqj0qRSuKqqAeY9ek", "B42TXsELwNJNBewRvcu5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(17), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tigo 8 Pro", "ffe972da-98d4-4dbd-8d9e-aa8b8d30eec5" },
                    { "D7zzjkSkzrIb2koSoxna", "MvMqrrJaUbAAVIvJHQcu", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7925), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "62", "3d34fc3c-019d-47cc-86d2-f19d84d39959" },
                    { "d9bn9lYzw5X8JXMfxPaq", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE Coupe", "d9f3cf30-6cee-4a55-9c54-efc0e08ea166" },
                    { "d9HmmEoWpfzVhgNEGV8J", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5786), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Paseo", "68680470-1f27-4ad0-928d-c37fa72f99c9" },
                    { "da5B8CxJ2DrLDQwutK1v", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5326), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stelar", "0e697e17-71b7-49fa-8fc0-70d93f491b00" },
                    { "dA7h8GntY8KDzzchHU9u", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8001), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DBX", "1343da6d-a80a-4cf1-a0c0-ce5d60c15289" },
                    { "dAdbWWAH8X6wSHGUF9Ej", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5233), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Santamo", "1105a556-51bc-403a-897e-b98b4b0057bd" },
                    { "DAnSduQYRQCPCUvqgP3j", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "10", "e58eeee0-5b23-4ecb-8737-beb2e594de43" },
                    { "db41zeF4fJxRG1RzmkXt", "hy7DsFSFE0ugKvGj8Hfk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "e9e5fe0b-57c8-4812-8735-284fee899845" },
                    { "dBAl6zxFfTX1BXg5H3lN", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trax", "d9ac6094-e8ef-48ae-8f18-c43b19a2e3bc" },
                    { "DbB6v11noXxgACs0sLCu", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aurora", "a9070877-b0ea-4c8d-9bec-5c53f3cef8b1" },
                    { "dBoc8cFw2w8sBUpP4dDr", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Terrain", "1553faf0-c685-4dd0-be32-218c8b80e4d9" },
                    { "dC2RbM3PcVb8KA7g6WQb", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9541), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Azure", "1856e31b-c268-4ab3-ab6e-979694a3bbd0" },
                    { "dC6YE7vDmSPVudS9shw5", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6583), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XCeed", "47bea0d9-5cb9-41b5-8823-682d71489a9a" },
                    { "Dc7DRvVt5R3GIPT87JRl", "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4261), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Minx", "4de6a45d-9631-46c8-afac-78746bed47e7" },
                    { "DcBn95ggD81cyPe7lqf3", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6866), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "66", "1e9d5edb-6b74-441d-9f19-14ee441e2b82" },
                    { "DCmn7U6CD4QJb70qbRl2", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4 Allroad", "e4bb0f68-14ca-4324-b4da-f2287b50e41a" },
                    { "dD8vDrBos2GQcbVbP1pz", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3098), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F750", "70b6d821-4954-4411-a755-cccce9a6ab49" },
                    { "DDUeuLNtUteANEs3nWyI", "nm2AJSoa0dWnayDNBRnh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(966), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Marauder", "215b11d3-85a9-4bae-9e91-ff12a2ec0806" },
                    { "dDUpzgk7EFw3GcuhbjHw", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1336), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Space runner", "d8bb4b5b-153f-4a10-bda7-c6c792470e34" },
                    { "DeECUEu8l4DaPxTjSsKD", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S5 Sportback", "ac6d6e89-c63b-4f61-b44b-2cfa80588c0b" },
                    { "DeT1YUdvBGREWA6VNRW1", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2438), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "106", "e74df575-1acf-466e-8293-3c124946eb8b" },
                    { "dFCy8oeSE9v8QQS1IgpH", "UG6N8tBL4hpBPkjX12Bh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4854), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chairman", "09e60b5a-c25b-4855-b21c-b738c5d7b32d" },
                    { "dGaNPRG249s4M7zplbuN", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1834), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Viper", "106ce859-74c4-4266-a4c0-0fd4173a79dd" },
                    { "DGLIbj4qXpkNWRkjsouT", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4673), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Quintet", "0ce93a9a-93d1-4925-99c1-bb86c78f8a9c" },
                    { "DGndQcEG4wcGfXpQehut", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Expert", "b7752b6f-1a2a-49b1-bf17-01918701c046" },
                    { "DGYdj2WEdwkX6pXMlsDU", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "145", "92a43a8f-deba-43b3-991b-3fe9d3a14f16" },
                    { "DhmNFrabMaA6rcHuxYLP", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8446), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RSQ8", "5e70f1aa-b818-499a-83fb-5f0df205800b" },
                    { "dK2HtCqpKYQuXVcffMwc", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rdx", "ce09fe4b-a5df-47df-a8d8-0bb8dc3ccca9" },
                    { "Dl0nUVWIwtfFJmFhDTSq", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Venza", "a725beee-995f-406a-8db9-3544abcd7369" },
                    { "DL15HEcaVB1QIanJWuIm", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9097), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 350", "5425965e-a278-4d05-a14b-e7f51cb5e8a6" },
                    { "dlIDbf9AbEnjMb8RnlTq", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8346), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q8", "e55846d2-f217-4b67-b72c-b8b438967d7f" },
                    { "DLoULPeS5eAGhpphWjaG", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F-PACE", "babedc40-8d91-4baa-b2b0-0b6dcb8b913c" },
                    { "DLpYXAq6prCmHeFxJMNX", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6381), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Eos", "3fe67f74-307a-4f34-b635-b31eed89d81f" },
                    { "dmA679I7ntN6kqxGHQT6", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1185), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1350", "890aef57-fbc3-40c5-a1d0-e0076b9ec652" },
                    { "DMhnCDfRlUnVwMzYFUg6", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "132", "19e25ba9-f5a9-4c76-9c03-939da8c4bc6b" },
                    { "DNhDjfSEyI0HMeU8KXgu", "sQ5C4f7H60rzJLhMA0T5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4226), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "9-5", "3c509aa7-43ce-426b-840f-b87dfc2dc610" },
                    { "dNtydP2TcQJwr6JYSANd", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9207), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "745", "12293c81-654d-420b-affd-15c90aa28618" },
                    { "Do2KC3pfTRWb5b07rFKY", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1167), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1304", "97b376c9-8217-485e-a86c-8fdf8f59390f" },
                    { "DRfU3nkla1m8CK7S6qgG", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(240), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLS", "ea93dcd6-be47-48c3-a806-ba1948aea7f7" },
                    { "DrGF7crdbHC1HtXfXk3R", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(833), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 60 AMG", "e5a87f51-11e7-429f-8062-2f4e50d93210" },
                    { "Dse55vr5kC8uIFlrC04F", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "960", "77f327a9-d055-4d3e-b1f1-b4be7e8c0211" },
                    { "dsQRRVYeecTn0sDUAJ9l", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5479), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fx 30", "7cd0865c-5b0a-4e55-9568-b3fc918f695a" },
                    { "DSUFawu61KblhgM6RKHD", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6233), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cadenza", "1cc1ce3d-2b62-4d9c-a4ee-e6663f30a001" },
                    { "DsuGMnEvagVARw4Gwxxr", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4081), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "827", "4d870c1f-36a1-46bc-9498-8f495b4128c1" },
                    { "dSUu8QW45bA8V14312mI", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(447), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 430", "abc911cd-a773-4944-b96d-9b2fbc843d2e" },
                    { "DSy92qq0AAa3AWvFKvUd", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8977), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 180", "ba638d04-7734-40c5-b067-ee50ec44434b" },
                    { "DTdvd0U4sW3vMlRFAIvz", "cjnwEk8Wle037jtonYsj", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1050), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "IX5", "e60f677e-49a4-4a2b-a428-4aad28780a26" },
                    { "DTeENl3EUxF9Cbxpuj5F", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2777), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "17m", "908551f5-d202-4a05-b531-33eda429af4b" },
                    { "DTQ7oa8pTeLl7dQ4eluk", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(318), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ssr", "3f430371-d505-458a-94c4-01b8349ba695" },
                    { "dtRyCvIccNetyrSbBENY", "Xz43eo1VM5H41uNJ9x28", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7197), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mf4", "027a66bc-d30c-4c5e-a5b8-4c68b3ab6d06" },
                    { "duBA6rTBzCyjkcJyKuug", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5204), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sg", "97170ece-94db-4f5b-9cbe-8a6a7f58c0ad" },
                    { "duTcoVbsDA9fvQzM1YgR", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6903), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "745", "0d9f1adf-e14b-474a-b8a3-93a6686c0a7b" },
                    { "DV2WMwoT2Nh3NjvQldgT", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Talisman", "b56a8a08-080a-4604-bf8f-2e78fd9aaf05" },
                    { "DvlI0UrQNIUCy94zaefh", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1306), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sigma", "41ea4f3f-abf6-4793-8b56-4258dcc27669" },
                    { "dWsbK9934lwt4AUKpozu", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2081), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Admiral", "0f2a18f7-9397-4535-9bf7-a8e5d66a52d0" },
                    { "DxBAjRGKAnWJk79cEDyU", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(476), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gts", "4059e3d1-172c-4c14-b5e1-7b3f6888074e" },
                    { "dxm3REW6sIyUUFenJTLr", "PsbTIAKWHCVgruG7IgRE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2382), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kembara", "be9e525a-8ef4-4848-a2c8-a8aa52045eff" },
                    { "dxoTC7wdUKxJWRCaq9vu", "MvMqrrJaUbAAVIvJHQcu", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7953), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "650", "c3d22c26-9d15-4755-97d5-07d542b69a4e" },
                    { "dY0npQnRI4NP7nClWhD4", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4369), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Concerto", "36e48fb0-b58c-4b36-b6c9-757a9309c464" },
                    { "dY7TFvM5YwwxAQ2s7hfz", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7509), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MKS", "69e70c6b-71ab-4fe4-b411-c116e8aabef0" },
                    { "DYxspl0CV7edtpNrvgv9", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8282), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q5", "017d6f78-e25c-4aa8-bdd9-70c444f6e822" },
                    { "DzbFXz9RtWs75EuJMe12", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4696), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Enyaq", "9759839e-69e0-4963-81c0-0efa1bd1c26f" },
                    { "DzCtYHnrv9at654wq5Lq", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GT", "7c1ef501-de7f-4176-9898-91d1f748fbf4" },
                    { "e4WPdgHuM6JYgGP2FjPQ", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "944", "e3fd9bdc-cf71-4ef2-83b1-6fc647384b1a" },
                    { "e53eU71egnSYtUD2S4CM", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7885), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B7", "19a2a22c-3288-4c09-b479-ad49d508f3b7" },
                    { "E5o288ltE4NsQbHUNMvL", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aria", "ce1abc6b-dcb8-46fd-a86e-aef79bda50b5" },
                    { "E6rLczfFRS8pQ6wYg2hz", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3991), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "420", "f15bea9e-81d3-41b7-93e7-b20effefa7c2" },
                    { "E6UayT1KRE19oQPnm5S3", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nevada", "65c37f90-a911-4a9b-9da3-1df63d3bece1" },
                    { "E7qblMNzje9gl9qQTKB1", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8603), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TT", "821faeee-2b75-4a92-8823-4ff70eddc810" },
                    { "E8uCFYtKIYrfC2Vh943L", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4987), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Leone", "5f4665cb-0ba0-4587-ac37-802027530347" },
                    { "eaDzsBS9HnIuTwTGAPFR", "R9BIHlzCwb67GPT89e7F", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Satria", "e9843242-ea81-4d41-9f95-3e0d06d5dc7d" },
                    { "Eb0rJVlL9uIFDJNtSjc7", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Escalade", "ce006881-6825-416a-aed3-0388e69d4585" },
                    { "EBcv0ubnrJ1hvwtSGV1Y", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9073), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 320", "2ff4dd38-8f80-407b-ba55-63c6fbda15cf" },
                    { "ebnBPl1mFxxpNjgYejGb", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8508), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "124", "514c1b6d-5bb6-41f1-9610-4f7f4ac1ef98" },
                    { "ebTHexGY5AEgeCR5aBgg", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1428), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2141", "42c810d5-d5ec-436b-aa72-e8332c709731" },
                    { "EbuFAvQPx11Lkd0KoCp6", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q30", "751c9b16-2c37-46e7-bc77-1a2d8711f070" },
                    { "eBvpC2MCNbwDIc5tys2z", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RSQ3", "26bdbcf9-6034-4717-89b3-f68d9cf16141" },
                    { "Ec7bC7A6qXUCY4uUDmC6", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3462), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bulgar", "c0da93d1-f422-40c7-b3fc-d33af9a9c69f" },
                    { "ECA9k7hf228keGWTJVjG", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9278), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gran Coupe", "ca98d017-00b8-445d-ad5b-90d844c1b891" },
                    { "ECaXuGNkslSQ80AH1FnF", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Huracan", "2469b424-2d53-444a-bc4e-6b9c510d3735" },
                    { "EcpkH4T5dEogzN9JJFXo", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(866), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand C4 Picasso", "215d490f-4a2d-44aa-83de-a38e294b1da1" },
                    { "EDj8CWStR65nNAkx5QPG", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4679), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "135", "ee066cf3-5b9a-4c9c-aa26-726a2c1b1564" },
                    { "eEdDCFpAmnsUktBnAygc", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLS 400", "89f91ebc-beb0-4e5c-b72e-52c45aa18c62" },
                    { "eEhznokkdwmAMHoUDNGQ", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Amigo", "f9fb9f68-9292-4564-884d-ce3cf9e75a3e" },
                    { "eEjy2vB3QbV0M5wnDjIY", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Forenza", "0ce757dc-93f2-4a77-8031-d887db733d63" },
                    { "eF58h2np8VwxJUBg6Jcr", "wC0Q8eUqQLkE6cpVwHgu", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kartal", "15c4fa60-c001-4b65-bd21-76049338a6fd" },
                    { "EF7AKK5yJGEQ3o0YyqMf", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "City", "33b8a901-0088-461c-ab7d-211f8d909927" },
                    { "EFXjY4fVJBEm0cutxIa0", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F350", "69f5f188-1558-476f-8a8a-7d10ba3d4d00" },
                    { "EhkTVksNg9NJfbH092FH", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "318", "f3c8279f-b240-43db-a1db-32b82325e4fd" },
                    { "Ehsg425zfeQE99tnsIND", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1220), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Logan", "eee7d0d2-8b1c-4b22-ad2a-2b8b733c3a57" },
                    { "eI7BfXe4s2SmA8M2hf1Y", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8271), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q3 Sportback", "9b69ec64-b7b4-4a8b-8908-0071d8958a43" },
                    { "eIpPy6JXqSyFj2eep6c9", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 240", "53e83d76-4473-4fdd-816b-119f01634e84" },
                    { "eIWLpWtJtuojEnw3XnCq", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7325), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LS", "62d6d8b9-b430-4406-83e8-be1e810d65b7" },
                    { "eJT2Qf1FUWAmnTxuDQqM", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9890), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 65 AMG", "638b33cd-5c35-40c4-93f4-e7445ad27794" },
                    { "ekLyvRv86Mrmr0j2JM1w", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3194), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cayman", "5a977bb6-909e-4697-adef-9ed5c7e4410f" },
                    { "EkQe4CKmkJKzGpScb20G", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1716), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dart", "48d0958b-4553-4e91-b8b4-e8d1837b6d99" },
                    { "ekQKL6aF5EMVJozWVBqK", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9810), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rendezvous", "f138cee4-5d18-492e-8a46-ac304ad41f86" },
                    { "ekSAaPx9THeIUCvF4UlW", "zvQcGcl1nR7SpAfIMvxF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M", "d9f66abd-c84c-46c9-8930-6460864467b1" },
                    { "elISrktD4eswQFKHaKdd", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1583), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "280 z", "c5905c39-8a1d-45ca-87f3-4f17aacb713f" },
                    { "EM3tvR5d3E3aFAFdC1FR", "vMFor3Ks1QECjDpWHUqW", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5480), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Judo", "9375d70c-7aba-4994-b2df-786c14b2ae9a" },
                    { "eMgh6vVgPTB31AxHXhbc", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zs", "e12a88e1-99e7-4895-ae2b-13bdf567c395" },
                    { "emnoQ5NoyAl1KmqNR91g", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9972), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLA 180", "4676ba6b-a7f8-4b31-a106-299dc16ffe5a" },
                    { "emQXAomd4vFmS9X4r1Ad", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2185), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Corsa", "344a73ed-b8b3-45e6-a318-a05d4226b1bf" },
                    { "emry197PRPRHw8gu7GNS", "0SlIJFKD3VdaMAEnxfTT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7384), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "d81ab149-517b-45f2-9b86-63f6ba8f67f2" },
                    { "ENFXzk6R2TymJu9VoPSe", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3354), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "20", "2dbe7cdc-7a16-498e-ab89-0867e2fb445e" },
                    { "eNP9IIKWkUzQpQe4D97y", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cougar", "345bafa1-b693-4b64-a1c7-4404cdb0f23f" },
                    { "enTGG74B4k4mkxtlwQac", "Q6kJ5uDgBmklCCBwofrx", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Speedster", "54e1d511-443e-4d5b-b75f-001f4bb22878" },
                    { "ENtjHj9X6yuKnf0AI10h", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8024), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V12 Vantage", "14d35ed1-c0ae-4bf4-b403-c0abaad18daa" },
                    { "eoag7kFpK25fA4IptMs3", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1415), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2138", "aec30ae1-cab5-4117-a6a1-030aafd9fc6a" },
                    { "eoyEdhTl37Jk5sMGBvSS", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7890), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B8", "83380282-b82e-465e-8a71-2450ab96a31d" },
                    { "epSfTLo55ob1gC29TCpQ", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rieju", "b466d9df-0deb-4ce0-b512-6410a4ee0bc0" },
                    { "Eqctud6jT4aTvSW0vqTq", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1787), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nitro", "933159c8-5091-412c-9a67-ca71a5bd8d42" },
                    { "EQF2xHc1NzRHg3JsgDT3", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2733), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "12m", "f9c18fe0-ace9-4cc9-a03a-26377a03d535" },
                    { "EQflVr44Doe7QsSxbPoD", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(176), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 580", "f8ec2efe-e60e-4a2e-8845-15b5805c0267" },
                    { "eqRkTW0ULAAlxcFlKjbB", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1368), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Magnus", "fc7b986b-bf5e-4bb0-a003-5973d6f888c6" },
                    { "ERBgdCnc6EYEgDMHc0rM", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(482), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Interpid", "65460cef-bc50-406e-8513-1845a6195a83" },
                    { "erenm61r32enkqnzuXj0", "zlaX6newWoQPagELHC4J", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "4708c289-727f-44db-971b-c6eb05ec7383" },
                    { "ESf2MVuMgPfjnYlvDWxR", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "123", "9be6491a-5fe1-44f2-81f2-927bf5ad00e9" },
                    { "EstVrdzsN0zvltwnQx8z", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8352), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R8", "ffbe0e2d-34af-45cb-963c-f9eed162cccb" },
                    { "etfQQQbo1SoW3BFSF2Cz", "d6V8Py7xGhHTTVvS02QR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1599), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Six", "1d318570-7361-4e53-9410-5dbc1f7a0e59" },
                    { "eTJe3y96h3F2uJHPMxcQ", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLC 43 AMG", "60de7d93-bb20-426f-be30-e4ca5ffea944" },
                    { "eTLQRk6wTqNYRQ8F1gJq", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4296), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cbx", "7651b4a1-e5ce-4235-bb3c-daf6ab64959f" },
                    { "ETQRWY0mXxBrT5veUG5M", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1383), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1500", "1d0489b9-94ab-41a4-954f-752956481734" },
                    { "ETv1zMEkaBqE0vC8gE6n", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2217), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "128", "86b3543d-c66c-43dc-8638-644ceb2499f1" },
                    { "EuelA36NuWDa65bngwgY", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6837), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "345", "ffbda3e9-24f6-4c38-92d5-129d1f1278c6" },
                    { "eus6aQ8mpm9uFl3nSzrJ", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3606), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kangoo", "d8361b40-0047-49b0-a6f3-a504b4d870a4" },
                    { "ev0EDgfgqXm2u7dvn0G9", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "164", "4715881d-609f-4785-b66a-8e74657c2f50" },
                    { "EvSxarpTQfN11ufD18d5", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1191), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dokker", "aca933b0-383a-4243-9503-5721e1e449ba" },
                    { "EwqVBPVPb7hR5Dtn1Hzc", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(416), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cherokee", "24754e1c-d842-4632-88b9-c856366865ff" },
                    { "EYAHejGyE9DqrH6KhoxB", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(819), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS5", "d5c0d616-0ecb-42cd-825b-f64c02b49f27" },
                    { "EyNjpMyrkN5Fe60Eomsh", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1202), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jogger", "615c8cf9-6740-48a7-9ef0-04399edd6432" },
                    { "Ez6wJfya5pGLRclCfshs", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9655), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BS4", "57488039-59b8-4e3d-8a04-68c33029354b" },
                    { "Ezc4unH4C45NkT4IIc2z", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9955), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XT4", "d06b69a3-69c2-4b71-95b8-7810634a9417" },
                    { "F0JyW6bxgRf5z1urIXvQ", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2821), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Breeze", "7f452bdb-ed1a-4d4a-8c40-ee27e6739fb2" },
                    { "f0yh8GrMnY37ddAzQuyD", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7694), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zt-t", "c0992f14-1280-4fc3-851c-a56887efcb87" },
                    { "f1lmxNvg5JyanuAJfIWy", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5417), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xenon", "1ae20b81-7b9f-4a65-99db-df3c26b790ca" },
                    { "F2jnmk4snNoB9AUJDErY", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Unimog", "98c0102b-b1e8-4934-b2ae-e810e5736365" },
                    { "f3fEJNQlfwL0Bh60PHa9", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "330", "f4f0d0de-0316-4d7f-a14c-6b2e284de141" },
                    { "f3YwoXQjkB01Nb8LTltl", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3433), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "9", "2737bdd8-5c5d-4dd3-8152-e4036aee7467" },
                    { "f444kwXWsY0Pp9dhsDJb", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Staria", "af7b658c-3bce-43e8-b73e-2c4b113e3ee1" },
                    { "f698BexqF6jlQlYLRMCY", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3087), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F650", "6ada443d-b423-45a4-98e6-1e9346d6ffd0" },
                    { "f79bGgykQodA2Tmf3Anu", "fAVrUUNVKFbMuNlP7oUW", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Atlas Pro", "37d020c1-442c-4f35-bf2f-c5a3d41e741f" },
                    { "F7FzcyNwvNYXPnqBjT0L", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C4 Picasso", "6367b639-19f8-4583-9a15-a81ef4e2d2a7" },
                    { "f7noIyuvA0oWR3F9I3NR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8695), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "114", "9f963d49-4516-458c-9e26-be04f9c2f7c1" },
                    { "F88T8V4yycayw1SPsssK", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q40", "302d5127-6383-48a9-bf2a-cc2d7dbd365f" },
                    { "F8V5jyxrd3vg92RnTWS8", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6904), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XRAY", "7ae89932-941d-45c3-ac60-e2e14e1778e0" },
                    { "f92L5AVW5mce2pcfSej4", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1545), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rocky", "c60e6574-6c89-452a-b0e9-8611fc49d690" },
                    { "fAYd6PdljzhL51X75wAR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8987), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "5 Gran Turismo", "b25b5636-d595-47eb-a933-634c0ebdc07a" },
                    { "FBpx6wXDXIToQMUKNIN4", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2958), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bonneville", "b0e18eb8-ac00-4a3a-b044-72b50af8b1d3" },
                    { "fc9eYSXcsPW4JfKmB9qN", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3140), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Galaxy", "1df5d01e-62b2-4d92-b867-fc973f0f605e" },
                    { "fC9Hq64hvRh6654EWKmN", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8090), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A2", "d4f4953d-ef0f-4ec2-9d0a-fc10cfbe3e43" },
                    { "fClLzNsCeJUwvh3lTdTw", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3889), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "111", "873d501c-6aec-44eb-aeab-e0e6a0c86f82" },
                    { "fdSupdzpjX1npl5Cro1e", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 65 AMG", "957f32e6-d286-4bc1-8aaa-82caa098e702" },
                    { "FDUkDI8KNtrRqIdTj2Io", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4674), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "130", "17f1ed72-168b-48c8-b830-e469fbb320cb" },
                    { "FEqGSsGn0fafyeprFzAn", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M5", "91be35ca-1826-4f8b-a317-ba9447e44916" },
                    { "Ff2tPk0APK11uL9fMvzt", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ampera", "8e5ff930-2ccb-47e5-8bf3-39ca1c1c9505" },
                    { "FF5troME3Dorb9rwvomx", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1372), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1360", "fe2fbcf7-1f3e-4bb1-8926-6adf562aad1c" },
                    { "FFQkNXQGc1qTjsY7XT3D", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7529), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "147", "9bd4e8d2-284d-4bef-b0d1-8edbebe75e9b" },
                    { "fG0AJqS7zBqFSbRfMcEy", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9181), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL 420", "cbb7e303-afcb-4ec5-8fbb-e762abafad42" },
                    { "FHaoJWV3b7SNkA1DcH0R", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4015), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Steed 7", "4821f9c4-3300-4f80-9528-6c9ed234b0b5" },
                    { "FHJw27jtRKpy491frECt", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1378), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1361", "e7540c5b-fe97-4e48-af8e-7cc5c4f9777c" },
                    { "fhvas8R677WyF1nezoQD", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Countur", "a63e89bb-f88d-43de-bdff-d84249b7bea6" },
                    { "FhxabFEwSTLmRgS8pKl4", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9459), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 63", "6fb96719-8acd-41dc-9c6e-194aca525d4f" },
                    { "fInsco5v34eqg9vR4Gaq", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6351), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bora", "47270eed-15f2-44e6-aa0e-c392462ccde0" },
                    { "FIqTopFhY6ld0jY83JLF", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8155), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mx-5", "e3ab495b-67ed-4119-ba4f-214dd4957b21" },
                    { "fJoto1uySzgkw3vHdu1r", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6095), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "390945", "4434a420-c651-4428-8fa0-60afe6beeaba" },
                    { "Fjv7kJkHr1qQIlTFjpye", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9465), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X2", "a3dce5e5-e52e-4aac-8ca5-b13fbb44690d" },
                    { "FJWT9jY2N0usQF7BbwGo", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kapitaen", "ae949f08-81fe-4793-97f1-938745d45930" },
                    { "fK2DaYv6I9zjg7XBk1Is", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9966), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLA", "0ad8540e-b2d0-4ed5-a17b-a755c2d0a4a9" },
                    { "fkU45R5FAbCvesC8TXv7", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9418), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M4", "46028b54-48af-48e8-abca-f66505c2664b" },
                    { "FKWX7rbKxQdo2XnFcPwo", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "996", "2c756ecc-7e57-41be-8139-cfdfcfa00d62" },
                    { "fm7A18mr93h5pWx1W2tz", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5628), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Avensis verso", "aea0723a-1356-473e-b624-9e33ed20f163" },
                    { "FM8BDLcSyEUKVACDtd95", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CT200h", "1eabee77-e4ec-4e8b-9e0c-469e9e64fe38" },
                    { "fNatT1Qch9w9bfeN7VB7", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Expedition", "4250e46d-3ae0-45b2-bbac-b1d4224099b6" },
                    { "FnfDvLcLkrr3eG2GUCbq", "Xsx7AcUNguMUYwC2eInr", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7136), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "232", "22922e66-5ca8-41f9-b726-4c1ca56e5814" },
                    { "fNlk0mx1xV5HJC2PHEvc", "nm2AJSoa0dWnayDNBRnh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Monarch", "b2372036-a3e6-477f-83cc-5fbd2dc803b4" },
                    { "FoKbwXQlwfNgTTC2huKa", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9823), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 300", "c1b83876-514a-4eb4-8585-c290c3e60394" },
                    { "FoMrhCubxRyw8sxMjtLP", "bymbQs0TabKzPsrN3TlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1013), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z06", "76753d09-e741-483b-aad0-50746c0667e5" },
                    { "fpde8cHnkSA9HFXlER0g", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLC 200", "f97bc8a5-e505-45ad-b920-74caaf6bf519" },
                    { "FpdEfwXl6fkHWndkHzgR", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7536), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "155", "bac4056f-faf2-441c-8a67-f49acf03ef81" },
                    { "FpTMmAKC7edKKICX5wKj", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8469), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S3 Sportback", "7452036d-e2b2-44c4-a2d0-8c185a553b84" },
                    { "FPWh1YfacdDssGnaDtEY", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2824), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Consul", "d776c0a7-3779-4d07-8d8e-add16ae4437e" },
                    { "FPYbUo8es811G5cEVUHX", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8684), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Princess", "bf2100c7-f915-473e-a303-238dd3f49077" },
                    { "FQ0cu0AqTrVXHPxpdmwT", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2827), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Colt", "dc3d03aa-58a1-4f34-a71e-f8340c8a211a" },
                    { "fQCGV1DKIHrWLsxLNWWj", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bentayga", "2a3ae05f-d255-4ab2-9f31-3e8f99f745fa" },
                    { "FR2uYUmFwfHyKE54jVEz", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9130), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "640", "ab2959de-183e-4825-b09f-ddd76f5c266c" },
                    { "FteY8jKxdxXgL0r8Uy5f", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4088), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Voleex C30", "d7b6694e-43eb-45e8-9c78-8b9e21fdcbb7" },
                    { "fTF8AF5AvlRFf7SUS6UH", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1704), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Coronet", "41db5de9-3b61-4188-ba3c-df254c19616d" },
                    { "FtNdbLLGNfBVAWPucVYX", "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4237), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hunter", "f68d83f5-47fb-4524-87be-7d91211f8ba9" },
                    { "FTQuBDab3ImWzaYwfVuU", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Retona", "26d0cb7b-e5f4-4813-8752-477621cbfb7d" },
                    { "FTWQhA8crWQvG1IPgKnD", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Qx4", "4e195e82-739b-4cd9-a490-606a6424edae" },
                    { "fu70f4a84V3aNMg1bHY6", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1510), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "412", "2ff6fba5-0eca-41a5-906a-efc8d598cfc3" },
                    { "fUz3pbewsMRwhhPb9RSo", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9361), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All M-series", "400c4ddd-af09-484f-9946-5d38117f8091" },
                    { "fV6zwWdjTkp6MMJIzezk", "DV94kh1MyMbGW3P4aac5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1942), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Talon", "196fdeb4-0084-4b6e-856e-91e2c271e21f" },
                    { "fv75TNuXmrRvqzKGs10W", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3555), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fuego", "a52367a8-2944-40f0-b685-4a53e7d8fa09" },
                    { "fvPzFHpVR2et47EyxoB0", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5780), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mr2", "e2f720c6-4417-4fc3-97cc-9460d68a4c19" },
                    { "FVUH7UQCj3RG1r7RwHP7", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GX 460", "18cc3ee5-2397-4b2f-9b39-1289af0523e1" },
                    { "fWH338ncwGIahkzS6mjv", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1985), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xterra", "f6dad459-b1e1-4f8e-a39a-a6e783989d13" },
                    { "FwmH9enQJPuyFUzRfsaM", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4922), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Galloper", "4ed481be-c19f-428d-b1d5-aa579905ab56" },
                    { "fWqNqpBIxEu4EWHm0VLS", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9062), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "540", "3182f2e5-65d7-4788-8af3-348bec0a181a" },
                    { "FWr6K018lo3lw0JjFaWg", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8955), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B 220", "c64ba8e7-2760-471a-bcbe-0f333a7e0a09" },
                    { "FXeIem39b7YG19YxEpad", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1053), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cooper cabrio", "31885901-adef-4da6-b21c-82212850b72d" },
                    { "fXkMoRuJv10VIbacgAfC", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "469", "b74059cc-3a6b-49fa-b5d8-0f7f73759b5e" },
                    { "FXYWubWrd3YCnNo7QQ19", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8883), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "AMG GT R", "0b979a54-c9af-4adb-a86d-5f1f883bc442" },
                    { "FyfmB8SXBbLKXSenzmwy", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1967), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "308", "f22c4afc-05b4-4b8e-97ad-42f95adedc41" },
                    { "Fytb3C2zyu60n9qgYnUw", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8761), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 150", "d9f6d773-2d99-4842-b314-b1b5ae5cb8fc" },
                    { "G0tJg4zBgrbWLehKXya0", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand am", "9384b624-3d3a-4fc3-8482-08bc41557bd2" },
                    { "g1LnyGdywqCpHTJ3b9Tg", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Qx", "40a217da-ed5e-422e-b2f6-0494977f7fe1" },
                    { "G1plYrEqVYcGtyqzIo8D", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6425), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Golf Variant", "09f5812c-7a4d-48f5-8e4b-38e4c49be6ea" },
                    { "G2Dmc1FGl2dv7tnKtNDB", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1475), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Charade", "ae2e45c3-b5a6-4b03-b28b-5e7372fb37f0" },
                    { "G2vtqFgsdeaKxvUntsPz", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1303", "865ec502-c80c-42a7-add7-f29065809666" },
                    { "g343UzFwgfx20VKh1mkJ", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2225), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kadett", "47cd3437-a46a-4d87-ac83-370d11a0f342" },
                    { "G3l4RhXGQ4TCF0cdy35x", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6510), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Soul", "c91b2514-f2e4-45ae-aea7-0ecea267b7f2" },
                    { "g56s1K3eXVaUNHpG1X9l", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3818), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Phantom", "6c4bea85-d7a9-446b-a154-22ddf4e8e669" },
                    { "g6Ga2Ibp5zzyqYXHnRQT", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2898), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sundance", "5dc26de4-76e8-42d6-a2a9-f9cf2aba68bd" },
                    { "G6JGlk9GowAITAQdHsSr", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4025), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Voleex C10", "d2bce30c-e241-4dbe-a7d4-c681b32ad029" },
                    { "G6TPvarPMSdQG8NbPmpG", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3884), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wraith", "2fdcb8b5-29fb-4de3-81d0-3963ff1fb1d6" },
                    { "G9QnSHxam1aP3uTKmAkF", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1804), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RAM 3500", "c0746b8e-1cf8-4288-a5a1-d2b7e802b4b5" },
                    { "gA5MQM6UvmHd2vYG9se4", "axxx6410rzzz3jxueox5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7456), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tang", "954fdf62-afaf-4adb-8ae2-486c59594f4d" },
                    { "Ga8jjH1ea6bwV7Kzb8Wu", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2293), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Monza", "9bd1f135-6c03-40ed-b316-31a9724c87fe" },
                    { "GasUkAR3BjRAyShFDuHt", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Toronado", "cbe71160-44c4-4ed7-b965-f2a59bc581f0" },
                    { "GavkjR3y2jBzjBJXWS0X", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2426), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bertone", "f42cbb5f-3861-4f00-b381-006600d6398d" },
                    { "GbdtAwAF2GVWdnobIAyo", "FcCNt3RVlzMFl9Jtw38m", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3608), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G80", "da91c4f5-9682-418b-9c1c-492648236c12" },
                    { "GbgYEQ0Lg7PU5ejmDToF", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Musso", "d688d0cc-9870-4ed0-b7c6-1cd507e297a2" },
                    { "gbQ2gLCTtmmYMDqArclj", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6521), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sportage", "23fb3f61-9b5e-4a35-bf28-2bbea237368a" },
                    { "gCSYyaHxLWbK2sTAHuIn", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8174), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A5 Sportback", "76225558-8e73-4702-8424-535e17a7f6eb" },
                    { "GDRuUvbbIzg3UDxUQGdb", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F250", "cd3aa16e-6ebf-451d-9084-2041af9392be" },
                    { "GeC4QRv1XIQBAQQHn2lt", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2644), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "406", "5e87ee98-fe4d-4b65-8436-1b8abe01e95d" },
                    { "gEd2ppzo1zGyJ0E9lXxS", "YK3zzVEmH55kg41f1s2M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7504), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G3", "33168243-4fec-49d5-bda7-25c538c4cf83" },
                    { "gEsktuRAGH58wamK0AtJ", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C", "f0ce0450-0afb-4f13-8ebb-4fe5c71bd04b" },
                    { "GEvxmWVySMnh9dBrw3aT", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2276), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Meriva", "8f87627d-d4b6-4222-aeab-c964976f1388" },
                    { "gExXtojDvoLSnQobvWBM", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SLK 55 AMG", "196ecc07-2079-42ab-91bd-24b7c9013849" },
                    { "GF261o5yLUopy6achpCl", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3023), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Solstice", "f8dfafef-a240-4109-baf2-f74792a515be" },
                    { "gfce787DL0Kaj2D4XK1K", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4854), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Equus", "9e9c1dd9-1cb5-4137-aa80-3dcb09415852" },
                    { "gFhmSjxNBcB1TEba7kd5", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(568), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Voyager", "8351e4ef-ae1d-45fc-ba3c-0d61232bc561" },
                    { "gFQDvgysV34X5IhqNchU", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6753), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "164", "9f9788e0-27b2-4c61-8702-4f1ee9592c77" },
                    { "Gfvd6jKtJU2qUlKn6EuF", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5045), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XT", "495d6213-a89e-4c3b-8b97-7a8315e1cfb7" },
                    { "Gfy4wKYKkgefuYFwQCeq", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6100), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "390995", "94a6f2c9-f5d1-489f-8f52-e05507228722" },
                    { "ggIfD8vMNMjaImddTA8s", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2288), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Monterey", "0a776d91-a171-4535-8cd2-84fdac2051b4" },
                    { "Ggp4kLPgcbUefKoMzVo7", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6084), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3303", "85b1acac-e5af-4c63-acfc-e878d5655607" },
                    { "ggukLU8GVK4JgBVfLlIP", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9201), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "740", "81cdc8a2-1ebb-4122-83d2-0c508f5718e3" },
                    { "gGXf1QyfHpfDb4NcRwmQ", "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5336), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Solara", "dbb1881e-ec5a-49a3-ab67-89fb7798ec9f" },
                    { "Gh7zfv5vbo1mJgcN8tt5", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8623), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "220", "25452d89-094d-4d77-9c93-af4ee3fa6b79" },
                    { "GhMDQ0WsV4fu2N2BdSku", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7503), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MKC", "ab86f1e0-7296-46a0-91eb-362d05ad42a9" },
                    { "GhrNGpTM69ahmbSmlE5B", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3009), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Explorer", "cb5f79af-533a-44c5-8a7f-343ec50d22d5" },
                    { "GIHI59YkzBsvt7jXrCLW", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(647), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C-Elysee", "289fc2a2-0815-4869-ad25-5959f5029f20" },
                    { "gJnGj1X4AJb7uA3Gy6PW", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7727), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Armada", "c76fe9d5-1a9b-4be6-9dd0-2cd85ad8276a" },
                    { "GJXUfA58JcNzloaYL8CR", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EQA", "bc1e710d-3167-4f34-ae9a-83a9bc2277b6" },
                    { "GjyFR2gjFUtoytFxEwMt", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7291), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LC", "7bb5af24-6309-4a74-8dee-c270a07a6c2b" },
                    { "GKbjybGGK7WNeJpG99z8", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2461), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "202", "6cf2ef15-b466-446f-9e3d-95c5fe33e2b0" },
                    { "gLMxC8wjnv0uyfaMqxN2", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6691), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M 21", "7d53249a-532f-461b-893b-926b8e115e21" },
                    { "gLUa8nM5HSBY3q0eCMyV", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "765", "089dd053-9acc-49f9-8864-5fef3c37914e" },
                    { "gMMKwejVvrMdeRKBFa7R", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8453), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S1", "c3daf0ff-9e88-48f7-a47a-73db81584e15" },
                    { "GMNuM3yeyF22s0fHYpQo", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4923), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Baja", "bfbe6ea0-def9-4ff9-9116-c2b6b3f55c35" },
                    { "GmUvygnlMhzL9wBUhQRE", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1705), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gt-r", "4f53f5b9-56ad-46ff-8ae9-6e8abc23135a" },
                    { "GNHH0sm7rutzp84hJlDK", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cressida", "511594e3-f45a-4f16-ab9c-5bdd262cfa2e" },
                    { "gnsK32k8UBtkhvWRGQNk", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ardea", "95f2adec-7b53-466b-9e43-6e382e7242ca" },
                    { "go6hvlFK7atfF0S7mV9l", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4608), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Special", "da7a2ffb-cdbb-4982-b120-05e3535c4959" },
                    { "goBB891qs0f3rJg2XC0H", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6194), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pickup", "a6a721c7-8a2b-4dff-be16-67eb716c8c52" },
                    { "godfcWTbkcPalBYq3j5Q", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5171), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Matrix", "744f4bbb-0d44-4caf-85e4-923b685e2533" },
                    { "gogNIgL2MSMruQ5Mup1F", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6607), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tiguan", "a4d8a3b2-8e50-413e-a2b2-163639814eb2" },
                    { "goK51TutI3KbQMp55SG9", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8549), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S8", "50da8297-0d6f-4d41-94c0-8102ee06e7c3" },
                    { "GoYr2hkUyY1cMQNWkKEe", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3274), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Puma", "1c3ab13b-2f8d-4dd6-9098-d4cbe4a6c371" },
                    { "gQ59F8ERvEVrGQNQQwGn", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nexia", "ebe87d4a-a074-46f1-8b99-985b21a34ecd" },
                    { "GRoNweYEyWb6gorl3E2r", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Coupe gt", "6ee307c4-5eba-4d88-8a1c-de5abc390289" },
                    { "GsCwm9UxBxYdch8FVSeP", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(798), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL", "c3580fc5-6f92-4c76-b47f-95d041deb593" },
                    { "gSfxqLFaGLl6TcMMA5XW", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V60 Cross Country", "13b620b7-d5ca-425b-b28a-8bfb8a6e2714" },
                    { "gsRJN1Uv5f0J4DBzQV6p", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1135), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1100", "ed2fc81b-64ab-432a-9927-380e6ba8f28f" },
                    { "GuqtcAV9UJl6HQ25vqmj", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Regency", "d8fe69aa-8846-4c06-a915-cb6e7f6228b3" },
                    { "GUVHPHeznMoAezJoHMsr", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1570), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Terios", "26f8e5df-9b53-4125-a7c5-e936da5dc850" },
                    { "GUxrf6zSn93A4BD5yLtD", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nubira", "cb85d57c-554c-4aba-ae75-22892c2cbcca" },
                    { "GVA4AkT3qc97kD48yIFh", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1300", "86243432-895f-4119-b1c5-a3bc4504a776" },
                    { "GvDNmAR3Eu4pcRlwNChu", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3233), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mercury", "77312a4b-0241-4684-815e-c82526641407" },
                    { "gvDYIcSK60sh4XKfyMp0", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 220", "41550e29-f25d-4b9a-b17b-b89542d47437" },
                    { "gvjPDq4LTJlNGcWXyaCG", "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "JS3", "1f5ba4f0-c9e8-4210-9f9b-a0a0062ded19" },
                    { "GwELtbyupWhYhV0vTnu3", "SGKURGhEbYHIdqkxpDJh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4158), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fun Buggy", "2a5547e7-7eb0-4b8c-b416-bd458fc99c83" },
                    { "gWFzsMBVgxroLW2C5zDC", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8859), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 45", "cae43ac9-ac65-42c3-8148-f2985892c677" },
                    { "gWgyxNpGKcYEXQn5rsy3", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Montero", "42005781-c669-40e6-af10-067d2d672a27" },
                    { "GYXpqjHu47DbadQjqPJu", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4843), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Elantra", "931c75e3-9da5-429b-8e11-4b3a30bf30fb" },
                    { "gyXQpT4HVDYBRcbxmpAW", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9877), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CT6", "123e2e24-4593-423a-8ef8-f5fb5ec8775c" },
                    { "gz2ck9wGFuUy4aUU9E1g", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9266), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina XD3", "5ca99be5-5ef5-4734-970a-fca3880b68a9" },
                    { "gzc7SvBYVQb4vhpWSrzl", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pulsar", "1732ce62-480c-461f-b610-654a38348de1" },
                    { "gzTYua3JfoLL4peoKCut", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6519), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Phaeton", "9e8e87b1-257f-4fa5-b46a-1c8407fb7460" },
                    { "h0LHmm9JdNL3EBpgfoWR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "120", "171505ea-ab30-4491-bae4-49a7eb96c1e7" },
                    { "h0pg30sDl10pzQxUFgyh", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand scenic", "fdeb22c7-67e2-402a-be56-fc2534c0a1b0" },
                    { "H16cMFPhMjBb4GDg3UJV", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6239), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Carens", "4663cb7e-ee24-46c7-8752-769e4e641c3f" },
                    { "H2beYXCM1yW3VIFNsbnb", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8949), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B 200", "85cf23a4-21c5-4147-95b1-151bd0c20097" },
                    { "H5qtFS3BCNAB1A6sPWhN", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MiTo", "b86b1649-293d-44ed-bf23-542b719bbd24" },
                    { "h6z9eWWRMWYWzyl6dM0V", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cx", "d9fedfdc-d9bc-46b2-b0de-97f5fd0af20d" },
                    { "H7b0srIBDPxyXSAayS0T", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5376), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Indica", "41034ca0-71fe-48a3-a4d0-272e5e0b6dbe" },
                    { "H7EKeRzxcQcdlelyG8fh", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8013), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Db9", "e32c3887-1051-4683-9c87-9b6ceae2fc70" },
                    { "H7su82W5ADebwsX1xXEH", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9385), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M3", "b42ca4a7-b6c9-4329-bd8b-d122acb199cb" },
                    { "h7xkGhv2HUmAaUaj8lju", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S4", "f31f793b-6e88-4cb7-92e1-e4eab0d33eef" },
                    { "H9TaH7RDkobWJVY6P5sq", "zpPwsvLWKJ4CmjHmU1ES", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7395), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C", "3bc9ee4b-8e0b-42e0-bb33-004cbdb437c9" },
                    { "haUwdqfmCXWhCWvyE92k", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4434), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Leon", "17a7a269-e3f7-4c01-b880-8f8f06798cba" },
                    { "hBdSzQl2tryd9Tt2xBUH", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cherry", "6bdfc8c9-2e10-4bfb-b041-d4f2a24c5bc2" },
                    { "hBIK5GamntM3KvtgkqeK", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6108), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xkr", "16ddc6c7-9fa5-4ca0-8631-3bd36ee94073" },
                    { "hBxU4NyxW2zrNucvJGcN", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3998), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Steed 5", "45e9f46a-740f-4653-ae3a-9dceb602bb8b" },
                    { "hC3pAND92f1y2JygadWq", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1309", "7769ccc9-aa56-4e6b-8f9c-acad815509d5" },
                    { "HdFXQW6l2I6uSRGR5MIT", "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6140), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Compass", "e05d48f3-dcdc-486f-bd59-afc521611168" },
                    { "hePblYjJ4d6Fp1qgh300", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GL 350", "93ad6b81-9c92-4e51-b0bd-e5ae0b13a4d3" },
                    { "HFHWLIKuKtcUcCN9XsM2", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6826), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "343", "48fbb536-c3a5-4343-9d47-05542469f278" },
                    { "HgSL24uHhFMYGer4LRtw", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1537), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Иж", "ae2b8f96-bd95-4e6b-bd89-e11435f7ca05" },
                    { "hgyPzR8HdTPEojB5Vc2f", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3636), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Megane", "587ff1fc-8474-4696-9e4a-08487125fd11" },
                    { "hhljQJwN17xFHWTt4kK9", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3784), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zoe", "c21a128e-e6ec-4d06-92e5-6b0681cc6be3" },
                    { "HHPmu5YwfAFQzKd4Mwn8", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5768), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Land cruiser", "d2f8af4c-7131-46d4-8616-7f1453711db6" },
                    { "HHTPwejLLrAoxQGf1w2A", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4045), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "620", "4840c48f-bce2-4e01-a365-fc02296ac329" },
                    { "hILzr5YXav5VQShq1Vzg", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(373), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Volt", "2fe6101e-5e6f-4521-97f2-98707480fd92" },
                    { "hkglQJTXd7Um8cbTK4EC", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Torrent", "e0f8923e-7746-40d0-8cff-8ef5016d7da6" },
                    { "HkqpuU3mt1gI04I8sTPS", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7009), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S80", "ee0097bb-50e5-455d-85fb-cc3c1705fd61" },
                    { "hl2sAfXnQXzvlyHueUqG", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9750), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EQS", "6a136420-8884-4394-a1b1-c3f35cb353e9" },
                    { "hLKfeRPGhayMDtg8nnoS", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(331), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GTS", "8fbae167-1cb2-4a45-8789-f1559fd52a56" },
                    { "hmCygM6xQq9H7Dd8QpXx", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9937), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "STS", "42980301-604a-46a4-97cd-faefcfde3e1e" },
                    { "HmhXRAme23XtumQ6UvKX", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pickup", "ab991d6b-87b2-4aed-8223-dcc407688dd9" },
                    { "HNacuvP7pf3WUQGrzPgw", "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7439), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LF620", "d65a7cda-1b0c-49af-8e95-fb8e06e05e29" },
                    { "hnlLXutIY9ctLW7YE6Ct", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9805), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Regal", "d6804b6b-093a-46d8-bd84-6521eabad6c9" },
                    { "hNNlNaqvxKmzjMpSHwXY", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(825), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS7", "a69a8ec6-18cb-4f09-a5d4-b2127a606e4a" },
                    { "HNsffh7MtFQsjSGLn7et", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B3", "e47adc6a-86c2-42fc-9534-0027c25533f2" },
                    { "hoFQSC3KBhH82Pgv9KuS", "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1907), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DR6", "a03fcc24-a23e-42ea-93a9-57b63cda7807" },
                    { "HQY2XFTlNeH6006MPKqy", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(70), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLC 400", "fbb6b5f0-057f-45b6-9381-f3d23fed3c99" },
                    { "HrEGfN0bPEDfRGQR4X4y", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Carina", "f741622f-dbff-4c2a-9d8f-aaebb15f363b" },
                    { "hS5gfAPVd9KS3tNJrzbT", "zzzbw5sz2hj27fvp4x2v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ES7", "c82b5bee-1ef2-482b-9924-198977e6af8e" },
                    { "HS9eszrgPBRo0rb3s12z", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(494), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Neon", "ce19ae30-f530-44c9-97d2-a4ff21e7990d" },
                    { "hSCRGBBwDCDpG9Y3vNgu", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spider", "7711ef67-476c-4d56-904c-62331ef03afa" },
                    { "hSoUnCvNWs1WXEBWwp98", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Punto", "51a61ab8-3283-409e-a35d-b9c350b4125f" },
                    { "hSrskwA6NcLAEMaw0X5c", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7086), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XC40", "61ac858a-88c1-4f22-b542-c1ed3d07bac0" },
                    { "ht66EVYqoAzrEg3AmSYB", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cooper s cabrio", "f0b2912a-6da1-4465-b8f7-86a28796d711" },
                    { "HTBRPqLFrI604h0x5EJw", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tempra", "2de1e12c-4653-42f9-a516-3a1ae5ec03b7" },
                    { "HTFrKmzp2wyvJD4Jzwpd", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Civic ballade", "5113ebea-0267-4bdf-9766-4b54d7bf970a" },
                    { "HtrGLGGN9pQgLM9LNuBa", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Elysion", "8fe31879-1ec9-4f42-9fad-deed1d6005ec" },
                    { "hTWQ6wk954mAxF281NdF", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "806", "9b569e21-aad7-4471-8186-81c0a4facf5c" },
                    { "HTx8nIx8U8dGGXhx8zze", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rav4", "17f81a26-df29-4079-8430-963ab914d13e" },
                    { "HukfYVIeCyJE7qNNaVns", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2046), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Firenza", "92ea9a55-4ff5-4806-913f-4d96a46c0980" },
                    { "HUsYJTuvj3HD5LFUKwH0", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(744), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 65", "0f0d7ee8-47ce-41a8-89b9-6e57569d675f" },
                    { "Hv55ILe5m4qIflQpyuwH", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1754), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maxima", "482b3e75-2c04-42c0-b2d6-6d1b2704cda2" },
                    { "hVNMUvW07JIuVoBsR9L1", "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7479), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LF7160", "7c097e5f-e4b8-4474-a5a6-9676695af6ca" },
                    { "HVspFYelb5KIVuXBYo0Y", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C5", "7e2b171d-e2cb-4134-9a54-81cb72733c61" },
                    { "hw7PKnRCoVNkm3C9WAgm", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Duster", "505bd5c1-dfca-48c2-9dc1-696c2783ff44" },
                    { "HWaf28L5nkx6zDMY2vaI", "DV94kh1MyMbGW3P4aac5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Premire", "afc2534b-e3dc-47c9-813a-bcc85f15827e" },
                    { "HwUaRbIXhFb135dXphrG", "V9HWmNFfpUS2Y5eLqrct", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5469), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zero", "bd27054a-afb5-453e-9aaa-cf46e5d1efbe" },
                    { "hWXdCQavVH4KvWVup3px", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4762), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Octavia", "76c50df2-45d4-4496-8295-a7f658ba2877" },
                    { "hxafjcEQUtJyMekeJc14", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "228", "1d00e429-539b-4285-93d2-f60e1f8b1aa8" },
                    { "Hxc0cWxfPutL0bKSLpNs", "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6151), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand Wagoneer", "0f8c40d7-1165-46d0-826f-22855ef1fd1a" },
                    { "hxGfRoWgbX2kA4RsAzaG", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "206", "2d85aca8-cdf9-4981-88ea-85efc0067bca" },
                    { "HY49P8QQ3j5RPvvNusHg", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8341), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q7", "e9cf6601-b64d-4cd5-846c-9848d9a26383" },
                    { "hYBvmc41BKzChyVFHvnk", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1545), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "100 nx", "8af793f9-a5ea-4a53-9aa0-45d7b28d3ddb" },
                    { "HyEnHASVhtNaXaFxJaTq", "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7210), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Range Rover Sport", "5cb9083b-1892-4dac-baca-9c826044a785" },
                    { "HYRDT3tyIRvxEBFjdE2b", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6515), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spectra", "d28b6510-e7cf-4a59-b77d-4556a3b8310a" },
                    { "Hyubd6jUo9JJbwkHtIrQ", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2800), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bronco", "a8ac4141-08b7-4df1-832a-27a10b0945f0" },
                    { "hyyf4CM1In1UeHG8zvcI", "sx9Vqv3yxRnX4SGwQa4y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4300), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sky", "f58d1901-9ff3-4cf7-828b-1fc3a5eac918" },
                    { "HzBof7GUlEIzds4lsG72", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(343), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tracker", "319015f4-22ad-476a-8176-8b66915ca3f9" },
                    { "hzEXSyh4lp4B1MIxMoHT", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9760), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Electra", "14f4e815-a3d1-46ca-bed4-bd5a1cd4ccc4" },
                    { "I0mo12GSGKXQcElwQANf", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Auris", "6788936e-20c0-42d6-a95d-ef9fe6e3779e" },
                    { "I4DYgaDbRV5VPB5cBWyU", "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Herald", "4ef007e4-bb51-4d24-9f58-47f3d77b4203" },
                    { "I5Av4k1IryIXQtPKzkzv", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2153), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Combo", "d2cebe40-92b0-4542-84a9-370f64a2f110" },
                    { "I5WK7dA3ACpGXgMcnIMa", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(136), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 250", "9573e905-c47a-40b8-9a1e-2c6a0de7ab5a" },
                    { "I7NhDzEWzpSUeVwtUQAl", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Steed 6", "7417e45f-626f-4ae0-9554-ccc4db9e2958" },
                    { "I8TvGoQFtI8ddh4N4KNH", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4620), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "100", "24dc56ea-510a-445d-ae2b-7b44a99cdfff" },
                    { "I8Y38fhGBrA2cPrFvSgK", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(488), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lebaron", "4d32cea2-e4bd-497b-af7e-d8aef4cc0f91" },
                    { "I9PwkrBDwXVgES2MYdLh", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "One", "9beb96ea-57f0-414b-89a4-3203498284e9" },
                    { "IARgA78D7U0txLaPI3ox", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B9 tribeca", "7bd22451-8ede-46fd-b961-dd94b022a25e" },
                    { "IAXb4HeHmEqGcxr6mGpn", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "405", "f7fff621-2303-4315-a7b5-f19e90563132" },
                    { "IB4Rohx2fEU3leXnDIuL", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7890), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Quattroporte", "74550b86-5778-4e51-b87a-5bb42b20c9f2" },
                    { "ICSjDJcdmhXtcxB3fUyx", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8279), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "540C Coupe", "9e57d4f4-2150-41a7-8511-456b651ab1a7" },
                    { "IdjXrn01KgYSQG24QkLW", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(36), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Astro", "f10b001a-739d-4416-92ce-d71df77f6fcc" },
                    { "IE7m6V35F3uDLr284qnD", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8047), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B2500", "a7a87a5e-68f5-4ab6-9db8-7b6dd54c42e1" },
                    { "IeBM2aSs17VWg47sQ5Y1", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7985), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3", "826bd56c-b248-4099-b491-111d9ec5f2db" },
                    { "IERft9YINY4vUxGQNUgz", "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5874), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "T8 PRO", "2ac71046-f93e-4a03-874c-7a592b0e6a47" },
                    { "IFWh13gItbtMu1CaqJve", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1174), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1307", "7b23615c-b704-4f78-8906-fe913d343cba" },
                    { "IHJm9vfdox6xCny81p1f", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(533), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R 280", "581c99ad-5d5e-45c0-b744-100c3c87e407" },
                    { "IHt6q88nBpjnmH228Y8C", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4768), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Praktik", "33ca3ca1-4cbc-44ed-a530-5b11279f0a76" },
                    { "IKIpRvgb5MmfDGD4tcIe", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F575m maranello", "802b1df5-1a55-4436-8017-7696dbc288c3" },
                    { "IkKx0F4jpGSTQ3v1UGxX", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1349), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lacetti", "87771178-ed63-45c9-a549-9cdf285ef65e" },
                    { "IpH4GK1LlTaxVVT9B64x", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 250", "07c6b174-6d28-4c69-bd5a-a9e7f2bd3172" },
                    { "IQh4q3JgH2CNpl16BHXq", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7162), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Y", "6597c0b4-603c-4427-87b3-ab756d86ca45" },
                    { "IrLq5Igtfnr7bd5741cG", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 280", "c674e776-4f64-484b-8fb0-82b8905779fd" },
                    { "IShvDQgB0dgGt9mTobuB", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21053", "2c679d4a-efee-488f-a605-5594fbe46c45" },
                    { "ISXPc4jaKonHKMsSG0Qe", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Outback", "22b9e823-a7ff-47e3-b9ae-8311e60474ee" },
                    { "ITTMrXMQnJeRNFn97nRD", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7739), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cl", "809aa7e0-43d6-4c04-89ad-a706ec390e19" },
                    { "IUzKYERwExBhgBTu9WT3", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8358), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS3", "2966b2e3-def2-49db-8fee-63d340df26b3" },
                    { "IVGQh5qlprKmzCem65m2", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8419), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "113", "1e0b52d0-920e-4269-9c37-aa9b15dd4c37" },
                    { "IWknrxUB0fsQ57H9amvJ", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8064), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CX-30", "6ac993b4-9049-431b-86e7-e7632c251dcb" },
                    { "IznxEqrGlPtUyKpX0zUL", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(446), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand cherokee", "ed4e27e2-14be-417a-a984-e29d9cb046ec" },
                    { "J0IdNbjhvxryxr5BvJ5R", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1990), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "458 Italia", "1a97eddc-f679-4689-8e68-354fc4844a62" },
                    { "j0Q5seckwcwoXEJ21nTG", "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Miami", "77f20891-6c2a-4f11-927b-2f5294b2bd77" },
                    { "j1CpjNq2AgoX9pHzHBgS", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3972), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Poer", "0f2e6acc-bc24-47da-8cae-8432f3c5ee05" },
                    { "J1rxX9Vn0r6PrzqJHD5w", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8685), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "350", "27e2bb9a-35b6-48c7-a55b-750b83649be6" },
                    { "J1SwecYFhm3K9KVoHRRq", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7373), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rx350", "2c41ba88-4ea2-466a-8c4d-a9c2beab4fa3" },
                    { "J2TYGzd05kmHRYVX6tVU", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6273), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1302", "9cd32649-f336-4773-9f92-98bb477cb25c" },
                    { "J4nYLXmzW02TzfgWUsee", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5773), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tfs", "e6db9515-2b03-46e9-ac28-10ea25d51128" },
                    { "J57wfvr54BlG2F0smXqj", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9369), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS", "5cca1743-ecd1-48a2-967b-b57466a2d2f0" },
                    { "j5WVSsoH1eEewpvB2gDN", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C6", "8684e8af-a7e1-448e-bd82-16aa2639e82a" },
                    { "J6h9tv7gmGAtbonv0LLv", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2449), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bravo", "40d9ba2b-b32c-4ec5-9329-f703ae0a33ac" },
                    { "J7PzEmj7W0yNG83fxaPj", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3064), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vibe", "fb0227ad-f357-4bc6-8062-7a40b4bca899" },
                    { "J7tqeMufLTwJvtkAzBn8", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rogue", "02ae051c-237b-4d2f-afdf-f744dff1bb27" },
                    { "j7yChCtlnAnyYdadEHvu", "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4149), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Avenger", "8c9f5f88-679d-4dd5-a834-b2cde7ba2723" },
                    { "j8693gACmgcKBNHqFrSF", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2148), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cascada", "d4278257-efdf-45d8-b9e4-d9733f941ac2" },
                    { "j8H6p0s5doC0VIF6hefD", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 450", "60c541e8-4e24-413e-b972-33583af2272f" },
                    { "J8pX1k8twS3GAaV4Q7UR", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5878), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tacoma", "61e7acd7-44cc-44f6-9a15-4b536d2e556e" },
                    { "j8qGuv2ACjpGB0K1AQEy", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(475), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maybach", "cb843f41-e336-4ec5-8dd8-b647a236796e" },
                    { "J9TvjUgAqJHfd1SyasyV", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C5 Aircross", "6c4ed950-83fb-466a-b8bc-3ad42f812969" },
                    { "JaXzdkx4PfolsIEd8nHM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8771), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "216", "9a6b4efb-a080-4d01-90ad-f2f3fff18af3" },
                    { "JbArFCgN84CYo5navbPW", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4395), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fura", "7d33d2c2-9223-4fc4-918e-9bf9e277565a" },
                    { "JbPu4Sd6YqglYGmazHhX", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2", "85218a48-f0fd-43c7-b1eb-d91203ba3c22" },
                    { "Jd00rVMM81l3besBpvoS", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Berlingo", "e77842fe-6a87-432b-8d93-38d349f9cfa7" },
                    { "JDJQRuWYYRT3Ac6SMmPM", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8463), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S3", "4d45e9c3-eb40-423f-9904-19e67809e426" },
                    { "jdSxK4tFX4zMSNKqNFyE", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4734), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Felicia", "04657c91-3df6-4828-a3d3-1c1ebfe9ffeb" },
                    { "jDUgGoH6efBNKncjzqKP", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1498), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "407", "19eee1ba-fe37-4157-928f-c9c1ab245bf2" },
                    { "Jdw3fR2gRzqbKF3MRF0C", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9834), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 350", "4d8245dc-d998-40ea-8ad7-8506a86085f7" },
                    { "JEljwEKzqzUMGq6Frkzf", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "304", "68e3cdeb-0432-485e-a17f-8233f1070793" },
                    { "jFwepLzpNNKYpX6cXgm5", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6849), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "440", "33f790b5-9d36-45e8-a46e-2ec4746c93e5" },
                    { "JG8D8PmEhSTc7p9aPFW6", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(109), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cavalier", "3a8bd415-4dad-4cdc-be9b-f645261b80ef" },
                    { "JgxI2bnpCfwwK6NbLSGH", "W5TnArCA9xCEodsTpDHG", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5541), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roadster", "c6ec5c4b-b408-44bf-94f8-31f924371d18" },
                    { "JhpFjTYaTqtodSCoB4om", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2937), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Escape", "61757fc1-9e0f-47cf-87a1-aedaa25fdccc" },
                    { "jHTBfKapT8blnoyeUylV", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1734), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Interpid", "3e49e207-2c33-4b4b-a1b4-e12a4ba040d4" },
                    { "jHUHhDBjlyAJsMprLxIf", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6715), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21051", "d7d1a98b-3692-43a9-8a16-7a32ff9f06cf" },
                    { "JHV9kjSHfLhXda739lV5", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Evasion", "1b2233c3-ca3a-4f27-b1bc-704a6701d099" },
                    { "jHwQS6EUg6CIbzfxUcsn", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cupra", "7ff9f59d-dc03-4579-9563-064c8cd98262" },
                    { "JIuez8A19jNTcLIYzNwr", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(64), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLC 350", "39254b5b-0b29-4292-bb0f-a53da8414189" },
                    { "JjCRmC2t4BcA2oeQ8cER", "PsbTIAKWHCVgruG7IgRE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rusa", "736352c5-0209-4800-bac9-424429712dc0" },
                    { "jjxjsyp0lNH0gtjC8Cvf", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2137), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roma", "5cff5a57-b1c8-4457-8574-4842cb17036c" },
                    { "JkDJVHn7zvSBuNgNETKI", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jimny", "1c627726-eaf8-4ffc-b6f7-696c42be1e2f" },
                    { "jkfEsBS78EhFlNz6Bzda", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kizashi", "afab25ec-964b-4be6-af54-bcce6a084471" },
                    { "JLd0wSjVHt9GQD1z4lvP", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6001), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XE", "bcd23c44-e80d-42aa-b5e1-4be1081d1ee7" },
                    { "jM1VMG8VwuXVDzrwByHC", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2113), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GTC4Lusso", "7922f897-23a6-40ca-9c83-bc534444b6da" },
                    { "jMFLc28db5cn97njhzKI", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1504), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gran move", "a8de6ee5-8bf4-43d8-bbd7-ed11c489eee4" },
                    { "jMJVowIV2LRhwfbmP0YT", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3968), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "400", "cde427a2-695f-4ac5-83c7-2313b42da794" },
                    { "JmpLdWKmvVY9T2vvXBHS", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ioniq 5", "70ee4b8b-6d4b-4b15-bc7e-eeaaa2004d81" },
                    { "JnEbb8hoTfMpK0pRv9jU", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2040), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "California", "71741f72-1fd3-4c6f-948e-8c6db8efd8c4" },
                    { "JnGbPW19JwvABQLdrDzI", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8316), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "720 S", "ddba59d9-d5d6-4da2-b158-eb0e23290640" },
                    { "Jp1blFat4gp8ASI5FfF5", "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6064), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tr7", "0b8163b2-4015-460c-9d06-83462ba4abab" },
                    { "jPppok3VWPUxkzyJ6R4u", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A3", "707e311c-1770-4ef4-bef8-2c80528e5a47" },
                    { "JQkvBPPf9ALSUpq1pReF", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6741), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "144", "8398de9e-bb75-4e8a-8c19-27e97089bebc" },
                    { "Js1jAIseHhGNuaf2h4o0", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1800 es", "9b66d33f-3bf8-430c-a099-7e9fbcbebe75" },
                    { "Jsf1dl8WEYGfJ138vorN", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "500", "02b32440-3712-4b61-adf1-a5a04961f2ee" },
                    { "JsRdgblCz5M7MpbnpbgW", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9871), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 500", "da71e62e-ee76-4e11-8232-3c7058ee99b9" },
                    { "jSxWIlG03BnBvM1Cv2MW", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1252), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nova", "209aaf03-6e36-4226-81a2-654c9810401d" },
                    { "JU3FFd5brXFxlFKew6Ca", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "150", "982c3c12-1477-4bfd-93f0-958d82360bbd" },
                    { "Jv7ACgB0hdMkMJ5XWjNm", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5605), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q", "bf8ffa74-fb8e-409c-94b1-4298093566ba" },
                    { "JVlLD8oS2YpMzke5cMR3", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7119), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xc70", "959945ae-5524-4671-a159-6ae46035efcb" },
                    { "JW1IgRQkqswnxD8tvY7L", "d6V8Py7xGhHTTVvS02QR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sovereign", "c5e3b308-591b-465c-b0e4-a5257d1147d8" },
                    { "JwGwknxDYEQsl2ETVnKt", "FcCNt3RVlzMFl9Jtw38m", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G70", "74fc01ef-745b-449d-b128-c1f76ceabb7c" },
                    { "jwRjmvGQDhh4hC5MGxkc", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "605", "77b2edb1-1954-41d0-9ee3-75618745ca5b" },
                    { "JxANYRTzvWpSFFapdtAy", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ln", "2428791f-6316-46ef-b36b-999c461d9eb1" },
                    { "JxC0YHUaGmX70f1ozmYK", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6897), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "744", "0a909de7-c3ec-496e-b622-029c1f0f6371" },
                    { "Jxzf4XNM6d1uvwJEctCW", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9613), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 43 AMG", "56fdde01-c0c5-40e8-960d-9e3e6860ff13" },
                    { "jy3KpQeGXwuCGwyak5Mb", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4401), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ibiza", "d535e15e-0b2a-461b-9c1e-df14320307e9" },
                    { "JYlLm274osuIe90Nff2z", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2953), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aztec", "7ac29615-8e47-49e4-97a9-2371f4881c6e" },
                    { "Jyq9KC9xFzMI6XobNp7l", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9218), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750IL", "2dee0ac8-430f-4f49-8fce-9cb2fa06ccae" },
                    { "jyWoxjRBV28X0xhTA1PJ", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Partner", "26ab2fb7-d167-48cd-89b7-b29f027ac88b" },
                    { "jzTFtNnKS81s5PjjrGBE", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "735", "08201d1b-2e9a-4963-a9a5-96ba4e61fd58" },
                    { "K0h4SErGavvxf2rKsI75", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mark lt", "f31a0350-7730-46d9-acd6-6fae0000675a" },
                    { "k1mDJgkTbTj39kQrGfFo", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3619), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Laguna", "ca18e14b-ed26-495b-bf63-ce7e7b77a9e7" },
                    { "K2NUDcTwLwMg9taE030G", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1742), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Laurel", "80610d0e-e7bd-4591-bb6e-1a9007be8728" },
                    { "K2zJqDWq0awUjVC2F7hb", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9289), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLC 160", "2ab5f14e-31be-4384-a848-09dac61195dd" },
                    { "K4SoePTYPN9KQbk2DEdu", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2023), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "599", "38bf3a98-fa21-4c51-96bc-20d93f340a75" },
                    { "K4tajPP498WsCIKdYs7S", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5623), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Avensis", "aa51ddf1-4a01-4eec-bbf4-cc669e874338" },
                    { "k5VJjDxL4CQEU2rbI2f4", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1921), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sunny", "2a24561e-6974-4a2f-a3a5-8e660a42155f" },
                    { "K79cngzy1q206kU0tD5L", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7367), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rx300", "766b5b10-5fa1-454d-abd5-5eb728f1aa26" },
                    { "K7KwBTnWMpuGwQQrjG3o", "SGKURGhEbYHIdqkxpDJh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fun Quad", "b7193659-d351-4b32-a60c-017ff541aefc" },
                    { "KAeltWGtAf9vzqYW3GH8", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1699), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Frontier", "b8cca112-e27d-4e86-85a6-006d8c8aba3d" },
                    { "kaHbEwIA8xwpMR3xkw1P", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1516), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "426", "5e8a924c-9d56-443e-b9f2-3287cb351e40" },
                    { "KB5N7e74Quo1LITXB7e5", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7762), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stelvio", "c4013ae6-d616-4eec-afbe-d591dfe9b50a" },
                    { "KBAFenzXwAdV8G69IhDJ", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6949), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Countach", "2d4c5118-4255-4ce2-a307-5dd99cd9d68a" },
                    { "kbtyKgXSmETfBcDrw8Az", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6297), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alltrack", "4c64a460-2083-45d2-8fb8-ea9550b2ca6b" },
                    { "kbuAwa1h8v1Hlugtbf4B", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Yrv", "cfd83749-5503-4425-a784-3254f37f3b55" },
                    { "KCjRm58XAKeEp9caxCvf", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 350", "c4d343dc-3cdf-4756-8f7b-e2dd50641adf" },
                    { "kCS0xXId7rhgkoDFd0EK", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3807), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dawn", "41bcab4d-4bfa-46d6-82f8-517cb35d059e" },
                    { "kCsRs6ReoATxKxWsAGJj", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2528), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fiorino", "d8b73361-5a86-4051-a65b-ea81dee6d1b5" },
                    { "Kdd0TccMEGSIRmuBnXgb", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8633), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "230", "85f6d380-e2fe-40f7-b96b-17fa7039db02" },
                    { "kDhesGn46TQ68CEUqnCd", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B2600", "f6a6d7ff-7943-4df7-a1a9-f01a40e1ce28" },
                    { "kE3aGRcLKokHbVYzx2jy", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2247), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1400", "67e131cb-e190-4a92-9181-2a64e6e69286" },
                    { "keVP90F7MSnw3r8BbJHg", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7417), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Integra", "290a99e7-4d60-483b-92e5-ebb3aafe26a3" },
                    { "Kf4AVUBmY4sPzDKJQcVU", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4537), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Insight", "0753c41e-508e-477d-a093-f9963982a57e" },
                    { "kF9Hz7eYQtILRWYE8F5u", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6629), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1600", "e72a79ce-e5db-458e-8884-dd3332cbc9b2" },
                    { "KgGk1RSXhqm2hYq18h66", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "23602 Cargo", "c3d091ec-c114-47e0-a7b0-972af74578c8" },
                    { "KGH1H5adJ2QJvszI9uWw", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(275), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLS 63 AMG", "dfeb8c91-4cae-4138-9a56-8d8b9fdc5b39" },
                    { "KIIul0CVrKa5UqSlkX4W", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7088), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kappa", "cc9f35dd-a9ef-4eff-b195-e33bfac2576a" },
                    { "KJ4KGqq14MN9g1xAl3A9", "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Freelander", "2f707639-f6c0-4807-8277-218925fb5d44" },
                    { "Kjk6663xoJ8h0tfrI3Au", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(422), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crossfire", "5a52967c-6976-41d5-bd01-314a96433da4" },
                    { "KjkzpwMSuLslGD4bu93D", "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 4 Crossback", "b1acde38-df3f-43b5-9e38-03aa1cfed353" },
                    { "kjXThH2HzhQEwxCIPQ9r", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7745), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Commander", "8a0333e9-d007-405b-9f4e-ea42091bdb75" },
                    { "kkhQXQETPaB2J9s0dy85", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4663), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Prelude", "5ff0a62c-238a-4884-80de-a2572739e644" },
                    { "KkSj3Y5mCDysJXgVLIgS", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6387), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fox", "c6b5b6d6-3963-463d-9e10-7e619bbd217d" },
                    { "kKToPs9GPxwGxwyt4PLM", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5183), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Palisade", "e32c01fa-39f4-4df5-bb0d-865f79499bcc" },
                    { "KktU8qGkHLexRFzov7Hg", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8370), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS4", "ecd37443-9e21-4675-9d61-c8703fa8c0e0" },
                    { "Kl892LwrcrBqfdLFFlJb", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8608), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TT Roadster", "4ac95860-9a18-4ebd-ae00-6a426a0c939c" },
                    { "KlGmLnqPTVQDHd1b18CA", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "New yorker", "90169fc9-8c1f-4911-b5e6-b20cf5f39ddb" },
                    { "KLh3C30TghgepKLFWzpV", "sQ5C4f7H60rzJLhMA0T5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4232), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "9-7x", "f022a695-9852-42d7-8106-feb4eb2307dc" },
                    { "KmbDFyD6DvtkdQkvGBC6", "06MxFkB3ArFfVraVWN1u", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "b0484a9a-b45f-4dc3-9d05-eaa2a7c75ca2" },
                    { "KMmD393BwTMJTp5WULKp", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(82), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLC 63 AMG", "499bba5d-24e9-4d08-93d5-308fb3126276" },
                    { "kMzc2WHHC6IhY51R9SKq", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4775), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rapid", "53d9fb8a-e089-4cb1-b2b7-aacd36cb1d78" },
                    { "KnBI0lWolrxKTkEwmwoB", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7355), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rx", "2933eaa6-1470-49d8-a8fb-8b72b46e9703" },
                    { "koBCuXqpUg1cJFgQFF3g", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5116), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lantra", "b66c4dad-97b4-4b09-9e9c-03e3349787dd" },
                    { "koBxlegcfAlNYNPAxus1", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8007), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Db7", "4a7cda9d-57ea-4fba-8d6d-68d7bd531376" },
                    { "koE270DDjT4JqNX1t5GF", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B11", "3941716a-0001-4e54-8add-4b27a97a822c" },
                    { "KoQQ96py1tGIVMdI2jty", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2964), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fiero", "13aea1b4-dae6-46d6-b655-37827c8eb527" },
                    { "koYnRetrMmGxDLqk49Jh", "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7283), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Florida", "7379f806-bcfc-4bc3-8e3c-da787dba0308" },
                    { "kpwdJGvwx6Cjl8eGaMct", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9495), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X4", "df9cc4f0-4281-4e12-b1fe-5c50e14f09c0" },
                    { "kQhbWzRyp51X3dWY34Lz", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4412), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Electric", "e87d90bd-0dd3-4f50-a1c8-9ca6d281f85f" },
                    { "KQy1VywnfMwSBuTq6tum", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2929), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Edge", "271c2e1a-6602-442e-b4df-046977fd4143" },
                    { "ks4REYrfTgxUdAWTptfj", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Eclipse Cross", "597ffb94-2b45-4599-a48a-3dc8fee33c04" },
                    { "ksjazg9bmE9A58pcEk2v", "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1056), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 3", "d7485252-d422-46b6-8849-ce831cec757c" },
                    { "KSXAarKg30fXhjzqhWSg", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9671), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "FRV", "b727ec0e-3b97-49f3-82e5-1dc474a1e34f" },
                    { "KsxbXqclpfetL0WgqBzh", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5713), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fj cruiser", "51a331c5-932e-4f8c-ae46-b62e96128ff5" },
                    { "kTzKH11XeMgr9cg2LfGK", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B-Max", "61fc6da8-662e-4503-83bb-bc1f0773e65c" },
                    { "kuhM1X1cJwEyuX0qFTxv", "sx9Vqv3yxRnX4SGwQa4y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4282), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Astra", "f40888e8-12c5-43e0-8e62-98eb0210c9d2" },
                    { "KunGGrBLIERqm7UT9c2I", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3284), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ranger", "aa28b183-2d7c-4c35-a385-1c63f39ee722" },
                    { "kv0yI6ESWbgtWKRfhDPX", "FcCNt3RVlzMFl9Jtw38m", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3625), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GV60", "627c0233-62bd-4fb5-9627-1918874da344" },
                    { "kv2jycf8R39nYmtd9AxL", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5490), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fx 37", "0f956d29-24bf-452a-b361-d81537ee24ac" },
                    { "kv4gVSdtt0gBUJK5AezU", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "131", "6771224a-ffa2-4b7d-9512-fec5a8056bc4" },
                    { "kvCborFLw5nyY0nrjyfG", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(469), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 63 AMG", "096dccb4-a5cb-4a3b-95d0-db503f22ade0" },
                    { "kvDR9sgf7WvW4ffMyr2x", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6882), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Samara", "b4f554f6-b794-45fd-bc47-dd8f5dffc174" },
                    { "KvL7ta1e5nxe332yIyRo", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Atlas", "5c5896c8-4f8a-494a-88bc-70f61dc5dad7" },
                    { "KVTxUGRBz1D8ouHvrWIS", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9883), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cts", "93e1fa0d-822f-4209-a10c-9c14c788af85" },
                    { "KvUdvlyoBV1yhfQnWhXb", "Xz43eo1VM5H41uNJ9x28", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mf5", "c94ddd0c-3deb-4f23-b33a-45ec96cc2cd0" },
                    { "Kwu28HXLUs7usWgLsAzC", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5696), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Corolla verso", "713cc5d3-4e27-4517-8a08-cdb88ae76068" },
                    { "kwWyKnfUBX3NBDzTUbTL", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS7", "2c39e154-86de-4fc4-8fa9-067cb0dcfb44" },
                    { "KwyPJzbIGEXcASeEetfe", "v4vruTNk6WkdcxN3fFA0", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5450), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dana", "170b7646-df37-47bd-ad99-f224a1aa6f25" },
                    { "Ky3dSayVkbBVo1DxUTP2", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6831), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "344", "b67b77ae-2766-4560-aa55-0336b569d852" },
                    { "KYqMfaYFY821nx8njY0b", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2689), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "607", "ea576f05-16b3-4032-b85a-fcca27dad60d" },
                    { "kzadTzbPpFTYRdqQHTmb", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5370), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Estate", "f00fbd5a-d511-4b81-8eff-2ac3d27bdd50" },
                    { "l19d2A4PGKwJCDFT9law", "HKjqbIm3EQ96YdfpakFI", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5448), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F9", "f9a276aa-6ea6-4967-9274-71dfece36e5c" },
                    { "L1QxkdoWbp4bHgfefSpx", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9103), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 36 AMG", "bfdeb13f-df06-4316-940f-1f7131b8e148" },
                    { "L1UmKzfedYF4grqUafQz", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(506), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pacifica", "5a411590-fe35-46b9-af39-89c05d0c325c" },
                    { "L26xM6tHzyG13yj7AWwc", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crossland X", "82611b8f-c331-4d70-9541-e671fcb60586" },
                    { "L2LmKr8R39CkYxglm7v8", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Voyager", "7e3ed342-f3b5-49d6-8567-e0cf791c48c4" },
                    { "l2MfAgRKvcK9JfmfqMvz", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5251), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sonica", "f2fff353-9a61-4a14-831a-af5c29abdc79" },
                    { "l3sEM5CPMPbNqLbJ3Yox", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4508), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fit", "b838a517-1049-4e92-9a74-9f90587db39d" },
                    { "L3VcrQMxaPuWP27g0Etv", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7941), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D4", "bf9cc886-f81f-4d0a-9bb0-c13f0b1cc0db" },
                    { "l4VyxSs1QmcP2spklmKL", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2354), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tigra", "7636fd68-94dc-4399-a163-d7f4679b6810" },
                    { "l4XgU5DkxSe22fb371Kt", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sunfire", "544401b4-786f-409f-bbaa-8aeda43d1c2f" },
                    { "L5Jzuhs4YCjwrNkmD0NY", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(642), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C-Crosser", "672f7cb8-454d-480b-9e7d-ecfa8c0bc853" },
                    { "l66tl4w15wAKEpYofP3X", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6661), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "24", "8beb71ee-c61c-4c36-9cd1-19babf6739e0" },
                    { "l6RKHAFVIAS6SKKxuJFL", "zzzbw5sz2hj27fvp4x2v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ES6", "1e4a40d4-bc13-4115-91d8-84cb3691d8e0" },
                    { "l6Y628QR6IyENAc9ch59", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "33", "73fb2c74-0ffb-40da-a644-cfc829436220" },
                    { "l7CSBgus4F4Fkv8HeTzV", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7733), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bolero", "e4c083af-46c5-40ef-84d8-b9efd680c566" },
                    { "L7cVRNXQXFPp4bexeQzX", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2196), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Diplomat", "2bdfaae1-2492-42ed-81b3-334efe23eb0b" },
                    { "L7DgVavtolHzDNH3W42y", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9518), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All Z-series", "363f6e3a-7549-49fc-a015-99395068cc84" },
                    { "L9kRzKy7yQmooPphgewd", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7879), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B6", "2d4f23e4-a7f3-4d9b-95af-23a5e80c0d45" },
                    { "L9L8La8wT12NfsPT6GFz", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6455), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jetta", "f2bee807-90cd-45ec-8576-63fc61552797" },
                    { "la3GJa0hUEaoz01KrU5V", "lgRSEHsdarS0gC4osQWQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7606), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Evora", "f74bae63-c9dc-4674-a5a5-81b3174869ab" },
                    { "ladFrcvCGSVklyJqe4Tp", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M", "097be20d-9a51-428b-8555-7515c47c4e1c" },
                    { "LaMSNs9p0y8FLEdm0409", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(193), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hhr", "a3386f39-ebac-4e85-beb0-8520c4494efb" },
                    { "lAxa6tM1XfgFet4RJ9CW", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "125", "8d1d98be-1114-4980-aaea-f219bf2bd9da" },
                    { "LB5k8cFVuFU8wXCfPrKP", "yjnmBGS0tfeUY6wppqlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7234), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2021s", "3cf93b02-a652-40da-9d57-316b0dfaff13" },
                    { "lBy0y5Bt7LC5VM38RRHa", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3362), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sierra", "ceeb7395-baea-47ea-b19f-584365816eb4" },
                    { "lcoVro6Il7AJyI5EyaSQ", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1793), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RAM 1500", "5ea163b0-838a-406a-85b1-6c630af0822c" },
                    { "LDacScpkvV1BJ4XAnNMm", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(30), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alero", "147d397b-87fe-44d7-bd6d-8625a9ce4742" },
                    { "lDkJDBjrtu4Tn6D3YG01", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6401), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Niro", "bb207707-905c-46b4-bc68-8c89f855dea0" },
                    { "LDqN3MaeAEdepPMhREa7", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Favorit", "a06d6841-3f72-4d15-b75d-bcec79732f9d" },
                    { "ldThopsn4Yh5jh4LHF8g", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1782), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Note", "f7d64c36-92a3-4240-ba7f-1dabb83b7dc8" },
                    { "LEh7gwWjD2pqcJV7INaJ", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1811), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ram", "f26b926c-2d79-4703-b529-291028db2a23" },
                    { "lEJcNQSDnK9G5zW6S91t", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Baleno", "f116fc8b-8436-4593-b454-1f19bbe90ba5" },
                    { "LEyrjJrokKfw13JWzvUK", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(538), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R 300", "a2e74452-748e-4705-8516-9b752b20a7c4" },
                    { "lFH2sDUcEdCVbTdNcJmU", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(132), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cruze", "9be1c363-0fca-4857-96d9-5b4a93653650" },
                    { "lHH8MlVYduYEoGIXufo5", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2790), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iOn", "be999c64-18f5-487d-a44b-0ba6750b220a" },
                    { "Lhxqdc5UB4ewrewzRj8a", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9008), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "523", "1d801486-dced-4545-b787-1ee0d97627d0" },
                    { "LHzV9SfcPMtVyhKJ15Xf", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Symbol", "1c11c058-dd04-4472-a8a2-9f49cd202318" },
                    { "lJcxFeaEnr5pHropuyWH", "6mI4J3fGUdG5KvEHYjqL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9612), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Freeclimber", "8847d801-f29f-4839-b3ee-254cf782f3a8" },
                    { "lJg6mARHqIguSa5nPhsg", "whPfE6p1LaKgaGTWoNqj", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5985), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "601", "313540ca-702f-4ee2-b0e1-fe9ea54f2bd4" },
                    { "ljkwUIomPB3hsXPFBmHk", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1342), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Space star", "b46a849c-10c9-4d3d-88d1-9083ae579447" },
                    { "LjTPVD57ejK8e4EGUS7P", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9453), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 550", "d68d055a-5e5d-4f49-b652-db3e62b1c24e" },
                    { "Lk8M2KS2HRV5CetzAo5z", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Silhouette", "bb53306f-255a-4986-914d-40c24c6b2e0c" },
                    { "LLAzREJDyw9e2ChnsrbY", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mgb", "6799b190-37ce-4e2b-93ac-225a0be64bc0" },
                    { "LlMTuFSPKV9sLduqWtJq", "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7473), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LF7130", "6bd06ba6-3ac6-49a5-b02c-ea60ab63eef6" },
                    { "llQJ37XCIEg6G9kEuxIK", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(453), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 450", "20ef999c-db40-4530-9767-8ad61bdc62e5" },
                    { "llzq5GDBSzPz2WBBoK24", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6053), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xjsc", "9ff360cb-6b6d-424a-b9f8-57f3ee66b607" },
                    { "LmDE7hL1LH8VmlokrXkE", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7814), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Biturbo", "b3976aba-5723-4d19-8641-66b6e719df1d" },
                    { "lMox0HIPapnMpS7uozkI", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V90 Cross Country", "3e711ccf-fbd7-4535-8c42-cfa9924f3e76" },
                    { "lmvNjturEXGYNmo3oBcr", "3qGrKAnyJ2rmHlevXb8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7963), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "ef3dceb1-9536-438c-8e23-6f6f63822e88" },
                    { "LmVwgzx27o06gCCy1TwM", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1349), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Space wagon", "0659a1c7-8570-4e7b-be2f-b7c9bb3bcf94" },
                    { "LMYAA5BFN9fJfRzK22jE", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C3 Aircross", "0d80ff25-bc5e-4689-acf2-d5fc63a5c1b1" },
                    { "LmYp77INhzX6zx6DgGJp", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3774), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sierra", "1f8823d8-3554-4b23-95e4-d925d6bf6345" },
                    { "LMYSXFbpbLnFoItxBoFp", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2993), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gto", "12ebdecb-8c69-4319-b94f-40036f61110a" },
                    { "Ln9c7hJq3kCy4TWaQ6L0", "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cherokee", "68ca4c52-0ff7-4ba3-9d4e-1209f5dff54e" },
                    { "lnDY03d4BjMEGShVm9GT", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8364), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS3 Sportback", "541976d5-5482-40ca-93b3-65e98152dd0a" },
                    { "lnnCoadnucEcFEh1I1Fv", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6362), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caddy", "4da6c9a3-9c6f-4b03-b3ed-9f6517a211ca" },
                    { "loTdersMNgyACeAztPFR", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4579), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aront", "5a407ce8-1f19-491b-a584-76f212d920d5" },
                    { "LPKmXltEK71qbz2CCFtR", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B 250", "838d3920-364e-4e6f-b4cb-8f0d33923e3a" },
                    { "LpowFoSQHBxJoNWwsgfx", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(361), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Traverse", "c6dda07e-98db-45c1-a100-6b7e3b08e2b0" },
                    { "LPxrCWCK6oYf37713Iz0", "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1885), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "4", "189b93f2-132a-492b-8511-9fd537a97b6b" },
                    { "lqQSyTvHlURAkduH7JDl", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4404), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crz", "4eac4c6f-727b-45c0-8094-ef5bab67a349" },
                    { "lr4P4VD8kmYRqa3Cmdok", "u3lzgWdKo9KaByo34lmN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4841), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mc", "f502775f-3089-4a90-8968-faf37f5b5e96" },
                    { "LRMkXYLYs0gHxfYlpSEb", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(927), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Saxo", "c010ef7b-f3e6-4f29-9769-a29d913469c2" },
                    { "LrvUHlX28YrHs8petI7R", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4584), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chrysler", "4a5d52f5-7cc9-42a0-b8a1-e49ae51707a2" },
                    { "LS9B0QqQxxw0aksljvks", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(960), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xsara", "9be41fa7-ec8e-4ec6-816d-d63a76946ffb" },
                    { "LSIHz0FHyI3HY67Wev7Y", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7770), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Quanto", "686d0da6-3ba8-4c3f-9d1a-07c601eb3765" },
                    { "LSKm2SGLxRmMRXo0Qpzb", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4980), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Legacy", "cf57ad5a-8de6-4aeb-8cf1-9e391ff8ebc6" },
                    { "LtPURXBIrU1LqoAw2F8E", "qnkV2dT7G6arP780Dwxs", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2917), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Polestar Electric", "ca4403fc-57e2-47f3-af87-3db9ecd7b83c" },
                    { "luHf7wKIlwHNtXWHJu67", "MvMqrrJaUbAAVIvJHQcu", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7919), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "57", "f73d0b3d-ebe5-4355-99dd-3688b7b158d9" },
                    { "LvArMbsNaGEkM7FhUPf2", "v4vruTNk6WkdcxN3fFA0", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5456), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kombi", "8f607aa9-7ff6-4088-ad9f-e6f5bee3908c" },
                    { "LvE3Dfqv5DFJkk0px22J", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Accent", "4eade578-fb7f-410a-8edc-917b31c076f5" },
                    { "lVlaB84e1dHh2H0f92pp", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6685), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M 20", "d0e97dcb-93fe-415e-90a4-b6bc0f34fb49" },
                    { "LwWaLxAauQb41IYG3tTg", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 320", "a26908b5-38ac-4bc6-9afd-635174bc0a57" },
                    { "lWx0UndUX0HFVLc3xoh9", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4751), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Karoq", "3af0b62c-78a5-4d88-88c3-678134868ea1" },
                    { "lYHNbcon30pYFVQzFBS5", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4379), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cr-v", "9f5eca0d-506c-4b61-ace7-98965607e134" },
                    { "lyQY9oQrcjHkvjr3N4fx", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4288), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cbr", "78a7c365-28f3-433e-911d-a3d6750f1812" },
                    { "Lz9oEWXpjPFFzdzDAomx", "Sn4CRrl6hfVTTra5B0pd", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ceo", "cff26acc-c55d-4691-9c1f-0529c26c4ea1" },
                    { "lzaelNYfYRe5AGM5CTgw", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9203), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CL 63 AMG", "990e615d-65ad-4968-bab2-7182c491e094" },
                    { "LzE0YedxwBmepgawBpqT", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Camry", "4584773c-6fcd-4cde-b91a-d3cb2c12124c" },
                    { "m16nDjPmGYuYtQvIceJC", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8937), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B 170", "28c4bdc9-bf55-4e22-8ba6-5b36a005ef8d" },
                    { "m2volRoT59ID0UaxB61q", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "645", "88efbf39-63ab-4756-84be-8dbd630fcb3d" },
                    { "M3zvto3EYLgxamNaBz9d", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2289), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1500", "f4f1ffbc-69d3-4318-b693-ce7a1e6dce13" },
                    { "m4ppNTAPIlS0qx2I0W7E", "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Murena", "4195d2db-cb1a-4298-b89e-36fc037c33f3" },
                    { "M5smY8DoGG9xBB2cb7HG", "MlFe1uw8xqqhdAUnqcHd", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7913), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rancho", "8ce4f8b4-cad0-4db9-a5ec-1c6b4150c9fd" },
                    { "M6DhHaeXJD7hBDlXeLc7", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2569), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "308", "b9d7810e-ee6e-4b56-bf47-510cb65e45d8" },
                    { "M7Uxm6nPL3bh2jYxVcyq", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1710), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dakota", "41eff5dd-ef18-43f8-b679-ed349e428d0f" },
                    { "M805mAWLWPfeuhDIb1xY", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(565), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S", "761e0857-be21-4912-93db-9940cc71facb" },
                    { "m8jV10FCUSo9TF9esLfr", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8253), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-tron Sportback", "059110c3-fba8-40b2-a8f6-19d2e88ebb64" },
                    { "m94aV50tKeA3F8hdv50V", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Impreza", "b475be24-b9a5-4612-a76e-6f734ee73db5" },
                    { "m9EvGd55VP146Np29zay", "sQ5C4f7H60rzJLhMA0T5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4237), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "900", "be422d18-75bd-437a-bb99-c04fe1b9fd8c" },
                    { "M9lu8GBAlAYpl47dcqKz", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Armada", "59275dc6-e70a-4329-89c4-62e20fd30515" },
                    { "MA7l1PwP8yeInKrnxthc", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6431), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ID.3", "4d0448a5-fc67-43b8-809e-c0ccc169e19e" },
                    { "mb2Lm3CHpomMlwLmXKVf", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trevis", "0afada3b-1374-4334-8c4a-5edba191d643" },
                    { "mbFYXCD0x5PIUfuYvdPX", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1891), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sentra", "300e1e33-e469-4693-bda1-717369a40ad0" },
                    { "mcSWCjSLIR0KPAzsmYcU", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2468), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cinquecento", "c6c18ef7-3442-4caa-a36f-7f2d9975606d" },
                    { "Md4H7mFJuHpCyama7NXt", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S680", "6499a2b9-a640-443f-9c39-ae8bfc963a3a" },
                    { "MddumcjzKpw0ybJV8UPF", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7873), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B5", "1432f2e6-af0f-41d3-932f-003ea67255aa" },
                    { "mDGIv8YVC7b38V5BlKDx", "DV94kh1MyMbGW3P4aac5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vision", "e18904cd-cab0-4c7a-8f04-f448b21c10ad" },
                    { "mDpeshknRqkAu0N8QkAm", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6338), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "K7", "7518cbf5-18fa-4484-b8d7-e8475d716674" },
                    { "mEltf0l4NRfFgkJzjvxT", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5148), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SX4", "e9205ba7-5e1c-44d1-b29c-e91f372eadaf" },
                    { "MenLgbyGGWoJ2ckqUdbq", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9536), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arnage", "764e9547-a5cb-4b00-8ef1-afddc3ca5c3f" },
                    { "meQQEgfhpC8JDUK4CRBe", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ray", "44160080-ff1b-47a8-9405-75464d17956d" },
                    { "MeQzhWpt7QQp6yETg6VD", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3058), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trans sport", "3f0e19c0-238b-412b-a909-39449d60510b" },
                    { "mfCw2nDgrbjPVc5Tn8rk", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3526), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Duster", "1a178eec-3431-4693-af47-5c7842b09353" },
                    { "mFLj5XWVj9oAo9z8lX5r", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(349), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 250", "f8988a84-ba4a-408f-8ba4-68cdb922f2d6" },
                    { "MFxdk2E9ezBIJ9R5gY1z", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6227), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Avella delta", "278fb7af-10b9-40cf-8760-c7fee575cf61" },
                    { "MH6TpGywhaGoFl18lrdU", "e7NrNKeWFc73uCAkz1Ar", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Polonez", "2ddb8464-1b85-4ff8-855c-25fdb1e0986e" },
                    { "Mjffl0HwvudlxQT4mYoM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "128", "3ddf7f5c-06e2-4241-ae68-082c9e9de606" },
                    { "mJGN6kQEMUNUkYlGd28Q", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21043", "abc388fc-4746-4d00-ade5-eb9f8b6c0787" },
                    { "MKJEyGRF6cnMhDmlnacu", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2219), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Insignia", "256c7cca-089e-49ff-8c00-0170fc94332b" },
                    { "mkuAraxPhajlH93KAepG", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6857), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Niva", "86642958-1a05-4397-b25f-f69dfbf8d303" },
                    { "mkw7FeywSVNzoazKzmBf", "yjnmBGS0tfeUY6wppqlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7215), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1021ls", "a5a76850-fdce-403f-ac11-4e1255723018" },
                    { "Ml0aNU8m4rsmkcApTJAj", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4427), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Element", "1b4bf729-37df-4e22-9751-1c21f0e672fd" },
                    { "mL25zANaJ9soR5QVmwMG", "XECbl6phGcsYXQWHwrT7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6213), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rhea", "3aa548e1-6770-446d-a46e-a869be1fabab" },
                    { "MmI5wJgEeDYVCBSgEqoJ", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Express", "180a2312-ba60-48e0-98b6-1ceb419ee4ac" },
                    { "MmjGXYIWATNbHDB69PCl", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8863), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "323", "a676150b-18c1-41a9-b064-ed1dd02d4c2c" },
                    { "mmor06U3hguTM9mWbL9g", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2103", "c1307087-35d0-4883-90ab-81105b7143b2" },
                    { "mndxasXQ5zGIbEEqQUkW", "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1100", "aa23a98c-ef1e-4c08-a3ad-51c18db63bd1" },
                    { "mNqENI20FYmDogKmc9WK", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Acura", "9ce01f6c-5b1e-4adc-a041-2abc5120b02e" },
                    { "mnx21bCj0qwRV2N8qmXt", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "315", "02d510d8-b47b-44fa-93cc-8d4ac523865c" },
                    { "MosWpCVsDkHl9KMPplwU", "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5820), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-S2", "4cc8c900-29b0-4be4-b76e-ae2d0762effb" },
                    { "mP0fxefdWWPeFda9uHoK", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daimler double six", "f894a1ba-22f2-49ef-8bcc-f05b4a0f85f2" },
                    { "mptPQhbDTbngb6KxxWJl", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7524), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "146", "84b42bbe-2825-4240-9e46-d0ba4743380e" },
                    { "mqg1vsePKqoUITsnQjg6", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8185), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6 Allroad", "97e18e5c-fa3a-4886-bf8c-ba9e4e7997f8" },
                    { "MQq7VHYYwJL7Nx0eLnHr", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3963), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hover H6", "d6229d83-168a-4268-b1a0-46bafd597ef6" },
                    { "mR2BcRDAU7Im5o0Kahx9", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9431), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 500", "1271e32f-94de-4096-9539-41e09ccabcb5" },
                    { "mRLRCo1Ur6uB9UNmGdXv", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1822), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stealth", "b4ca9f07-b1ec-4999-a2e3-aed3a76a5825" },
                    { "mrqqY07TsGt86z0w39Ix", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4819), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bayon", "df4ba024-cae4-4995-9a61-b454522e0b8d" },
                    { "mrYnsLz49QveuBjxpxQA", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5356), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trajet", "1936b276-4169-4f29-a069-848750f1ea62" },
                    { "mSlW2RXU8BbJpdmhl1KY", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9515), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 230", "3a366543-0f16-4e49-adb1-01054975d60a" },
                    { "mThMVAcGgSeRByxS7eqf", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6461), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "K 70", "1295f9c7-053c-4436-a769-35b71f109a2d" },
                    { "MTT1sd1Sfyl0Vyd0yeuU", "YK3zzVEmH55kg41f1s2M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7472), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "P7", "7c58f2ef-c2c4-4870-81d8-d3324fd80afa" },
                    { "Mvh2WI99JHrJRCJqRdzC", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6679), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3111", "18a86732-a577-4946-a171-ca435503f732" },
                    { "mW0LBmccphBp7uKUx8c9", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9284), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i3", "cb98abe2-89e0-42e7-b277-191e13a7b5c6" },
                    { "Mw8UTTvzTuPuu6TnXLzr", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1276), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spring", "528c24aa-1033-4c36-9eea-5ad4c146d4d7" },
                    { "mWlMqs8UhIQ7w0RANhLl", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mii", "5ae66bc2-8c9a-48bf-9c17-c414fe2b18a6" },
                    { "mx2TCN20ACCtD1Qv5YXF", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fiesta", "2080cd7e-98dc-42b6-852a-e3631f7b5bca" },
                    { "mxY2KczTAvzVDf4EaIlB", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9688), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 60", "36b74b38-2bcf-4baf-b42d-bea9c2daa6f2" },
                    { "mYgvvPADQSYrvDv7r4qj", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ceed", "15e3ad2d-b3df-4ba3-b23f-be6bc28f01f9" },
                    { "mYjy3JHGGxy3702yukkn", "cjnwEk8Wle037jtonYsj", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E3", "6eee30ce-9917-4870-acb6-3fd5d4465a80" },
                    { "MyNnSwPDKSJPQ8ILavGo", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6825), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Granta", "4e191df4-c3a2-49f7-9194-c95ea79c0f3b" },
                    { "mYSJBQTmW4Aa4znQ3pBL", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7721), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GT", "19dd9f41-eee0-432f-b24d-ff1637d5d06e" },
                    { "mYymHns6rgbBD4AsXFSk", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLB", "e1ac46a4-ae74-4a58-8e77-2185af46f1a9" },
                    { "n1XKvJxNKljJhXFJvF8h", "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4157), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Forteen", "2c06b2d1-a60b-4cec-818e-e515609e25bd" },
                    { "N2FmmG3RGnCJdtXRyWaE", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "956", "06179969-62f9-4dba-ba57-01562c289d7e" },
                    { "n2geo9kXxYr5cBHbKgma", "TjjXJlSeru5Ccm3G2Vet", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stella", "d75adac5-0dcf-4901-b5c3-b0f1bdda001b" },
                    { "n3AB08Tq2rxd7aEkUbfP", "bymbQs0TabKzPsrN3TlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1007), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Powa", "710bc6d5-e999-42f2-a68e-b54689fdc891" },
                    { "N3eU2yslx3PjBYhSj5q6", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q4 e-tron", "6276eb10-1290-40ba-a65d-0fc8938fe7f4" },
                    { "n4blo4X3ldAUQbFhCxaa", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1155), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Carisma", "e6d77f1f-13b0-4eb3-bd72-42f2b357034a" },
                    { "n58VzcN68Dl6L0BUjxb6", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7441), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rl", "e305525d-c1ef-4c6c-a5d3-b6b68ae6f0ad" },
                    { "n5PPhUvIbVN7nnvDLeSV", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(247), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Malibu", "c9b8aa5b-fee0-4dfd-adca-01bd5f39d4d9" },
                    { "N79mPdJyLpTKRGfbT3Dz", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9271), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLA 250", "70cd714c-77fb-40d6-9ec9-736ea193f77b" },
                    { "N8K9R0vEkYCmQN3E2CY2", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Picanto", "ff14113a-7123-4866-9848-09458964a536" },
                    { "n8NkIhd56BxBG6ExAbgP", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6450), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ID.6", "5229774a-9b34-48c5-addc-0acd29fc294c" },
                    { "N8uqafx5QU0exHfAAwkN", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 36 AMG", "bbae6236-ae5b-4a70-a372-ece14c0839e5" },
                    { "N9gXED7kI4YVyNL4WVN3", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2887), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Reliant", "6ed67802-8c34-4268-8d40-97920f6fdf09" },
                    { "N9VUz6dFzyTYotqhl2Y3", "ghyFhm7jzcjYDrjMVLs1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4104), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F7x", "de6aba4b-f527-44ee-838f-53207c519b40" },
                    { "nAmTue1eB6PmtGSmhunt", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Doblo", "32017f3b-298f-48c0-968a-ca44dcb4553a" },
                    { "Nawq2nzpeVvXx8zjwG8z", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(911), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SLS AMG", "b86cfa82-8ebd-4e84-9a12-e63110227a83" },
                    { "NBanyv35cL9yaLcpron1", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 450", "9fae0880-2cac-4c2a-bf77-d1cc90aac9c3" },
                    { "NBveTMrmjc7aQNFMuqDs", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLS 350", "9a5e0a30-d4c9-4629-91d4-b36a416bc48a" },
                    { "Ncpuo23P7yepk4IKA35D", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2819), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Connect", "2c7786a2-a8a0-48c3-bd68-09ed401a490e" },
                    { "NcrhdQlla2zw0zA9Kr8z", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6653), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21013", "8b8bf5e0-2205-4e87-bc07-8cae75ac58d5" },
                    { "ND1ljzMFjoBu8LW3vhXJ", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2432), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "104", "4c0f8fa5-c6bf-4168-bbf7-28e1a4ffee10" },
                    { "nd1NkYr02nka7RhhJpAG", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5096), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kona", "1a877aa9-cb72-4017-8bf5-f0712fe22d35" },
                    { "ndmLuJtvVrtMvJtRjkyp", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Picnic", "cf2ea842-dd17-4405-b45f-5b09e9323ce1" },
                    { "NdQ8bUkCBD9xnG70We95", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7498), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ls", "6926f9a7-04d7-48eb-9b1c-2ee81bea9e3d" },
                    { "NDteFLNgPPoLJ6CG8AN1", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Taigo", "6e13fea4-c6ae-4a77-a6a8-e80f7777a29d" },
                    { "NDxd38C79jSrLcqHq19o", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4685), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "136", "f471dcaf-0a12-4de8-ae2c-2092553a8f85" },
                    { "Ne2Le6jWRgrxnGGpFr9T", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Montego", "0596d05a-9a00-4f2b-a2f1-8ef4ffc754ed" },
                    { "NeTWG3h4hs9GyHH9Vtml", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2416), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Barchetta", "a3a70f5f-9008-431d-af7f-1e64c45eab08" },
                    { "NG0NvHrNCo9UzplhJxK3", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "262 c", "234b714b-eb2f-4ae6-938f-45e38fc01e5e" },
                    { "nhcwAdUI8WrU6MtRG3WM", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1617), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Almera tino", "f5ded38c-cafa-4c26-9549-0bdd463a5038" },
                    { "NHPfeo42dwRafSI7nYy8", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5039), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vivio", "91966aef-6ccf-406c-90d5-1be618f3b93a" },
                    { "nhU2wV5A6jzv1FGvmYNK", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1926), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Teana", "9319d06f-da77-49f8-a9e1-daa33cceac9d" },
                    { "nhUTKGS1xEvLaEgXuVGs", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Genesis", "af0d4fad-f7c9-46d4-a6b3-56cd8e7d48da" },
                    { "NIXW6ax637sVMnmTzAvn", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1007", "73d84e8e-0ce9-42e5-9e00-7240d3f22aa8" },
                    { "nJ4FNPNaztosDX9AQaJa", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "335", "3cb2f44e-7f9c-41fb-b4a6-d10e69834823" },
                    { "nJJg4mLMCpHTWDnCwEX2", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7061), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fulvia", "d4ddd924-0aef-4ed7-97c2-2f02147a1a88" },
                    { "nJl5UngHagasPpzIuQJ4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9272), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bertone", "1fbb2d0f-87f3-4712-8bec-77cbd7a12eed" },
                    { "nJWADKy2u6IrrgtfQCPg", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "09c0137a-4911-4979-a886-75fc578365fa" },
                    { "NkH48BKvFCdqbDBFYdEN", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3473), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caravelle", "e3b6d8d1-0d24-4c9b-8add-bb3a145c19e8" },
                    { "NKnyG42LHRl96ogHoLkQ", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1042), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Clubman", "5d442379-a268-4151-8ed3-60bfd94ea9cc" },
                    { "NKY6b2kyATIgyDkKTQ3V", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 250", "6803d905-ca28-4cfb-ae86-321d0f4f30df" },
                    { "nLRvEA0KJD0p0DIF3D5x", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Terracan", "cb7e7166-d5cf-4d82-9283-3c30f094a11d" },
                    { "nM6aWVwESHqge5oqo0fN", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4703), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Shuttle", "49b0cdb3-fb01-4598-ae58-8d9fe80d032e" },
                    { "nmrJ9efXP5s7WhXPJ3Hs", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "I10", "083257e6-cc09-4890-b440-22de07b18492" },
                    { "nmysS4fXNhKz11mDgzn1", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1361), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tredia", "b3d2fee0-b99d-4b26-9d2f-cc1c54b636c2" },
                    { "Nn3otEz7X4Q9VLPzkXmj", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pride", "dfe218b1-0d9c-4dc7-9477-0c6ac75c7774" },
                    { "NNGm5g8jMwMa58Gc4k1K", "FcCNt3RVlzMFl9Jtw38m", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G90", "855da5b3-80b4-48d7-abb0-e942702aacb6" },
                    { "NoMmrvpubbn9ffpr5bcI", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(234), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLK", "9b08fc57-22b9-4ee6-9194-95422fc63205" },
                    { "NP0AEuUnr0rMgjQNgz4X", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7491), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Continental", "461cd0ec-4680-4c98-be3e-533f90891ba0" },
                    { "nP2G4GfbfCxTEzhRf3W0", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6431), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pro ceed", "05549c32-fe29-4813-af65-69b096fba8b9" },
                    { "nPMl5HcrRV5sVJ7xzPz4", "yjnmBGS0tfeUY6wppqlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7209), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1021d", "240985de-2e84-4be7-ab16-7268854100c8" },
                    { "npRUXAmILVhQVopEAs7L", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8335), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q5 Sportback", "f7896de9-ebe1-4bee-b96c-130049660872" },
                    { "Npt5LD2qarb1mWgFSgoM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9429), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M6", "bd353df9-b0eb-4c33-8a67-16b44abdb903" },
                    { "NQ1qkrD4fJBsqMCEXcSY", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6955), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Diablo", "28f4124b-513d-475a-81ae-f6c0166b89bc" },
                    { "Nqea9mtXEanMC0j99s6j", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4745), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kamiq", "aac09f75-3735-4278-bee1-fbe2bbd6dd53" },
                    { "NQfQUVsYBTrNNt73Tybn", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1343), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Korando", "c891d0e9-1f44-4d87-8a6e-cabf5de0952d" },
                    { "NQGGPD3uzLauSBTql8mb", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1161), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Colt", "acbab9c8-d44b-4730-a81a-961608a22e9c" },
                    { "nqPA2LgdRJkIvvHhWtM5", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9019), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 220", "563aae42-ddf2-4eac-80da-be732e997486" },
                    { "nQPtrJqVcBjttvWHlGn7", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "928", "509da1eb-6e97-45ec-bfda-18271cc76269" },
                    { "nQQ06wmCTtG4uHvY2ma9", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(555), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R 500", "319444ea-ba4b-4285-bd11-15ca53c25d86" },
                    { "NQQV5qoEnVaRJ1oRNgWj", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "924", "b88b047f-5fd0-45f7-9007-95063a947ef7" },
                    { "nrAlxARWoTRDUgnvcTg7", "l5Xv7WgEwDFBEEnFG9uC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7249), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jx6476da", "b0323077-25d0-41d5-9280-ab8464877dca" },
                    { "nRFm7ubF8BhDTu3kw8M4", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2136), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Calibra", "8a501185-af9b-41ae-87c7-50281028ef53" },
                    { "nrua7CpPhSfMvCTIt7UW", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2561), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Multipla", "fe4bb90e-40c0-49d3-9b4b-b27ba84df34c" },
                    { "NsqbGy4PIu8ReC4jR81o", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9364), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLK 63 AMG", "4575629d-ed40-4849-8b36-72a6a21c4004" },
                    { "nstjcESJPGWWe2Jv509m", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9507), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X6", "45cf77da-d61d-406a-88f4-597ad88917ea" },
                    { "Nsw8tPS1c10ywsDCK833", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arna", "2262619a-e16a-45a3-a09b-1d09913526b5" },
                    { "NT02QjfgISs1nDh2p031", "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "6", "b77ffa4d-747b-49ef-9512-742285c9d470" },
                    { "NTeCetTNbDo9HqTHEGlW", "sSh78RpjbHGvjL43TzMl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4249), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LX", "683d81ed-8455-4b12-8803-f9aaefbffa25" },
                    { "Ntqu3Gr895HzJ8wGa0B1", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6899), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vesta", "236e0e8d-2bfe-440a-b2d8-ba696122a004" },
                    { "NTxpEyDvkBGmaktojPf9", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sharan", "7bd27511-83e8-49f6-8925-b172c1425978" },
                    { "NUxYCgKpHu3pnbk8WRpn", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8923), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 4-series", "85b8e6a3-31ac-438d-a297-f212b50e50cd" },
                    { "nvkt1bMuuXfkzM5sNGUl", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "AMG GT C", "2432c833-66c4-4193-a4c5-64a93aef592f" },
                    { "nVoJlDP4jvXd0yu4Lr1S", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "NX", "87037197-3f65-40ef-9b28-775136825f43" },
                    { "NVy085J8aEYsd8An0hY9", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9521), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 240", "24c42659-0bbe-4aa2-b387-97b1481159a4" },
                    { "NwRjnhj6PnJzacTmNfl6", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ignis", "f2cbb9a0-7fc6-4617-b3a6-e94829c23380" },
                    { "nwsEaKDjn1DawULQtU91", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(682), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C3 Picasso", "1e9b1da9-1d27-4d8b-950a-e6be1d5b2746" },
                    { "nwxLWeBTc7Jkfl6CTqLG", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5603), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alphard", "62cd1c63-efa8-48e0-8f93-0413ab76adef" },
                    { "NxGffx00unNIhRTq4wpJ", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2838), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Horizon", "407a4d30-9a6a-4713-942a-b591431c8429" },
                    { "NytRnmpfmN8DKm1NHzsk", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8805), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 190", "d10fae3e-7467-4bc2-8e09-e4544052ccb7" },
                    { "NyUcvCj3uFdQMaIUhIrv", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8101), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A3 Sportback", "a8c3c0b1-ee67-4fed-8d69-df7f386adc9c" },
                    { "nzskXlvWWUbecontxBm6", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Highlander", "7cf11588-b535-48b7-9553-3e5e8f8ea7f6" },
                    { "o0V4k62Vtz12dVmTW1ce", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3018), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F150", "de717024-f963-4a0e-82f5-f41f523066a8" },
                    { "o14UQlxNaazMXRX3ASLY", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4342), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "City", "2cc66cf5-b091-49b7-b4df-959110ffaf9f" },
                    { "o3F70rsvj2Usn9P0XfCT", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6893), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Urban", "b144ba2e-610e-440a-be51-95b5b3b5d70b" },
                    { "o4lkqLmpj9SpTwQ40Sdz", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S-type", "d07ac2b3-4cc2-44fa-9891-6383a2d67315" },
                    { "o5ualICUEUzfb5A8xqEK", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1126), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "One cabrio", "abbb1cf8-dbef-4899-9670-45e8c034c387" },
                    { "o5zE3qSwnf5vkp5kRp0r", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Multivan", "540154d1-4e80-4e31-a7a7-8bf6e4010079" },
                    { "o6wCEVBg9jLL10r9DPdQ", "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7378), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tavria", "9b814e63-306f-4e69-a3d3-6e45556cbade" },
                    { "o7J915EBhPUa9a0r1EvG", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Applause", "badb03cf-44c1-42ab-ac71-1b64ac06974f" },
                    { "o99BU1BgN0yRwHEaLkE5", "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7359), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "965", "47947966-1113-4ea9-8af1-5485e81dde4f" },
                    { "o9P0I5JhS1SzkfqHJjpL", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Silvia", "e290661c-8472-46a0-9368-b721f72d520a" },
                    { "oAE6sYh3RhT1xCjNQVLB", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1822), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pickup", "a8cbc62a-b20a-4091-8624-4e67ef952725" },
                    { "ocXucdbCeEu8zz1xsmfN", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7801), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XUV 500", "879428f2-a298-4b46-9694-4b9b9a5a1282" },
                    { "oEuJLksLSurLsdPQ2A1z", "zzzbw5sz2hj27fvp4x2v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ES8", "17fe5dc4-865f-426e-b13b-6902e729cced" },
                    { "oeycyzHlh9cWdH7hB4lC", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2075), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Adam", "b88a8fd5-4f53-4766-a147-a50d88cb374c" },
                    { "oFgnspfaJqMwAkq4FPCj", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1415), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Prince", "4ef1afeb-2b7b-42d9-8ad0-fc313d873ab8" },
                    { "oFRnzATowzyYGuHzzHM2", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(142), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 350", "fd4d51cd-05fb-49c6-ab8a-8d96370dc039" },
                    { "oGtW8l5fjE478EFmm4sW", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S2", "5558f4be-8365-4e2c-9166-a541d3944bd8" },
                    { "ohCSSqzCBsdo2RYUd160", "fAVrUUNVKFbMuNlP7oUW", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3584), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Coolray", "7bffebdf-2f99-4aae-a69a-828d8c6486d9" },
                    { "oHUQdABcQP3Gf7P76kdQ", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3132), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fusion", "3342a93e-63b4-4d2d-aef7-6b32406b791c" },
                    { "oIBFdoS9BgtGUz4znaad", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1141), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1300", "4de21b40-e858-440a-86bd-5f9963f38e09" },
                    { "oIM15MxV1gLecIVf0lEU", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4428), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Inka", "1dd660c3-1f59-47b1-a11b-4304265ed3e4" },
                    { "oJwTjJNdNQFd2vHmPdzu", "PsbTIAKWHCVgruG7IgRE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2416), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nippa", "e5874a33-3ef6-4145-a506-56302b8cbf9f" },
                    { "oKh9CAXjr9Qb8X2m0gqM", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alero", "4c2491a9-c696-4b30-bb29-37c510332067" },
                    { "olrI955UaS8ogQMowtNb", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3149), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Granada", "6c50d46e-8b25-4d87-80ae-07070230859b" },
                    { "oNVsfTFBx5XPxe6DuLMf", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3139), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "991", "72eeb396-e1fc-41ec-88f2-bca1e748bd64" },
                    { "oouzt2mw824ruDom2bVE", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5904), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-pace", "2d6e9791-59dd-4e18-a05c-7972e7247683" },
                    { "opAcWj0cRGlNgooD9bgr", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Testarossa", "3552eec2-e264-4269-92e8-1efb9b42066a" },
                    { "opNNsa49oBUePRkmjzPS", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Forte", "f7a04aa6-640d-4f59-b77e-94758d69394c" },
                    { "opP4XNx6H8cCShzKD5Wv", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "420", "b9197aab-95e8-40c6-a6c5-8ac6b1915d6c" },
                    { "osVWIaLbp1zu89xn6ljb", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLC 220", "e64e45d8-767f-4987-84fa-cf7f5bfc6db7" },
                    { "oT9SLfY9oTfJ9phB0ArR", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6010), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xf", "f200942d-bec4-4d72-852a-b7580641dc21" },
                    { "otaoRbU4u23y7HYU1eJ2", "UG6N8tBL4hpBPkjX12Bh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rodius", "c43bec90-da27-4240-ad9e-0ae512217110" },
                    { "oTcTb3R4vY7rRLsReDwo", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7037), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dedra", "56c98ed9-4853-4a19-99e4-177a93183f35" },
                    { "ov2sQLNaDfvD8NTYRHVd", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9877), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 55 AMG", "4a2fe181-9971-4c17-a9e9-025df83c1056" },
                    { "oVf6ulrfpn12kWT1R0aE", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6977), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Reventon", "8f3bc523-c742-4723-ae18-d937c66372e4" },
                    { "oVFPjyKKSdIAmbdtLt2b", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8561), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ7", "10c5e4c2-576b-47a3-a527-388ef65878ca" },
                    { "oXfCgzm7Mhq5df3bzPKm", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1388), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2136", "525749ae-8508-451a-8dfc-2941b92f1400" },
                    { "oygxMj48FzID1JTjaxDH", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(810), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 43 AMG", "78039cdf-b274-4e44-99d2-0eb3ae6c72df" },
                    { "oYhCnwjg55L3TSUkP3Tu", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6200), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Профи", "7293025c-8129-49cc-907b-d1a9bb92238b" },
                    { "oz1V829moxKCgBcfF4xT", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "300c", "296c0647-0a72-4fe6-8b6c-0478f8875ba5" },
                    { "P0S0dhRjcahqFNxQsYVS", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Evanda", "c470bfc9-d0d4-4880-92ce-c7297f5f174a" },
                    { "p0tGsGBHwzfpoeuHuw8z", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8040), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "100", "3d3a58dd-0182-4c78-8d31-282ae51103a0" },
                    { "P1BcrvBx9jc1gEbvrbHs", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1740), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Journey", "6f823a26-ad26-44a3-b298-ff7957336f26" },
                    { "p2lAvbwDJP9oUedXD6eg", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5154), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SX4 S-Cross", "38ef80f6-3764-4b34-9e0e-9466b8f8afe6" },
                    { "p2zVbFxoR1AxF4tVcTem", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9694), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 60 AMG", "d41bfec2-4c1a-40eb-a0c0-04b3847a0a8d" },
                    { "P4MTIUBPFCLjSKpz0Fl4", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5558), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fx45", "6e2657d5-f11f-4159-b21d-fff8717f2635" },
                    { "p5KPSEuLzS11p9WRqXyQ", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7928), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C2", "8a98234f-aedb-4042-ada5-35b299478d3a" },
                    { "P5R5mJVojbocuqJgKm4u", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9821), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Skylark", "ea2dc369-7c38-455c-881c-3de7d523c47e" },
                    { "p6bnGyHq3dcyd8xJbMdd", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9358), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLK 55 AMG", "f588873a-0996-487f-bc0e-a3dd387c875b" },
                    { "pabGeAFv5WA4UCPn0mg0", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9683), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H220", "f6dbc767-58a1-4644-b450-762dffc044bf" },
                    { "paIyodhj3UXF0AF2x8zA", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grecale", "aae9be78-b21e-4fec-a7f4-0e0a9438486e" },
                    { "Pb0ukD46sHHXcrfEcUh9", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5202), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Porter", "118090d3-e977-4a39-9cd3-3ef21abe8fa6" },
                    { "pB4VBIRH5YxQzPmFTNWB", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7653), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mga", "8346e4fb-121c-48b4-824f-f7a41c08b842" },
                    { "PB8PVt8tV6kU98zxkp1m", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1963), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Titan crew cab", "245484cc-3660-4740-a2dc-c7c7dd7198ac" },
                    { "pBb4uzBGHlA3sR7eL22T", "3yTpJND7nxjtqoDcuc5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7968), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rocsta", "d1e381a6-9129-4932-8536-40202646537a" },
                    { "pbt3ygSUWsURRFhxKX75", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1409), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nubira", "f2883426-1d7c-455e-95c4-8185acf511bd" },
                    { "pBUAm5aajKIgXF1PKQ3t", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8176), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Premacy", "2a35b528-0a78-40e5-9a9d-b282bb8c99e3" },
                    { "pc5Dm9HB1kF6GPqxILvW", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9039), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "525", "b2d9e213-028d-4c23-a2c9-172cbac72a0f" },
                    { "pcjGmMojwxULQ0qppNpp", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Musa", "f8ad9e05-dfb2-455b-8c5e-03d956757608" },
                    { "PdGmmTrhjrvK5vxLrYq0", "Xsx7AcUNguMUYwC2eInr", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7131), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "223", "6066448d-efe9-4c39-9bc6-a0a3b8715731" },
                    { "Pe1vAIehSUf2S4SqPSUu", "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "11fff181-c7cd-4a40-96f9-4bd8e0287519" },
                    { "PE4E4GLnmtTh2JmxXsv9", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6624), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Up", "5bdc9ab9-4d30-44b6-904a-6ed19f96ab47" },
                    { "pEF156mqm6qaarhUPGyW", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1100", "ddd45e73-27ec-4a4d-bfd5-b2237e2e8ed3" },
                    { "Pfn1UVE7sByWrNAWWllQ", "FcCNt3RVlzMFl9Jtw38m", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GV80", "b80e3e1b-cb26-42cf-af6e-4313889062d3" },
                    { "PGbbXaF2ADjICaYbJFg7", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6467), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Karmann-ghia", "d5ed39ab-f169-4d3f-9e43-ac5ab044e3a4" },
                    { "PH7Ey6lq6mQl9VQGq4CR", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9918), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GL 450", "5d2285dc-ca28-4c05-8590-169dfb6d4f96" },
                    { "pHUMjfeIDm7rx0QmGDcJ", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alfetta", "6b619b95-7c63-4adf-903d-776109ca3457" },
                    { "PHzBNXItcd33A6Eytl0J", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3625), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Laguna Coupe", "fc7620c5-d2bb-4d99-86f7-ca48a4ee5b02" },
                    { "pIa2NxGzmjqQV0MoC7Ie", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9713), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H320", "61734c05-f3c1-4e82-ac92-89c24cfb3547" },
                    { "pj9toteThq15JEr9I8Ll", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A45 AMG", "c813c83b-93e6-415b-baa5-39be7357f9ad" },
                    { "PjJCWT9JtGRubTVah5jB", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3612), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Koleos", "1ba18f27-4bb9-4200-b537-51f029f0dfbf" },
                    { "pjP3s2ykCg8uHsC33yYw", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2102), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F8", "754b6382-11bc-40fb-9f4c-44093b408981" },
                    { "pJSa4z8nayxEU71aJt8G", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3544), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Floride", "e82eecdf-2b48-4c3b-b947-e4777e300c2d" },
                    { "pjXGKmULkPtBT6mIGDrV", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2621), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Regata", "d3656a93-f5c0-41d2-a40c-c155eea9787d" },
                    { "pkExD7gNaNrc4CUYR29L", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4573), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "9 Sport", "48508560-e700-49af-9769-1647d28c0890" },
                    { "pKqoY0sdzUp88IE4Ly6L", "Dfej8VedBqRvW5SVCeo3", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1643), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stanza", "447bbb7e-ffaf-41fd-a525-92eff5a14b8a" },
                    { "PkU2NMkhlQeyQEBIz8rb", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7952), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roadster", "76a9b113-4d40-4603-87c2-245ad64e7026" },
                    { "PL1tfgJTdE35bH4gHGmN", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6097), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xk8", "c0b76b99-fb1f-4654-a7a5-33d01b30acc0" },
                    { "PlJANek4tzK7lh1yH4xx", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5197), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Santana", "333b13c0-9945-42cd-bc2a-4848f6e5e4ff" },
                    { "Plq2tS1awE401Pz1fYY2", "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5831), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "J7", "36b46f80-5f9f-4239-8254-9b25480d6db5" },
                    { "plwSltMceLuaCuryTtPh", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2096), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F612 scaglietti", "b6df99c5-1dbf-4a42-ac68-2e76c671c4cc" },
                    { "pmnBgm4R5YqR4BGuTIgK", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7575), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "159", "3d04e2e1-491c-4ddf-9890-6f4ffae9c26e" },
                    { "pMNJcjG6YY2UfXxtvHVa", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4389), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Exeo", "907a0c80-9d62-4881-a16d-93d4cf6e182d" },
                    { "PmthPpPIIfnar5YgpnIL", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6537), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Santana", "f1add0ca-41cf-4ae1-9c7f-7ccb19cbac9b" },
                    { "PndJ31IQSsrHj78HgMq4", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1687), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cube", "7ef657be-3db8-4605-b1b8-2006f77c8bdf" },
                    { "PNGzI2DS2jb281IGSgzm", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "12", "3cfc5b09-5bf9-48fc-b890-a694d94c04b3" },
                    { "PNSGHjjz11WDeoXjyFvF", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Celerio", "ce192484-c68a-42d1-aad5-51b8664ee19b" },
                    { "PojmjNX8yr70pgN5huC9", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8974), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "435i", "3e03a9e7-c891-46a5-b321-034effe1ad8f" },
                    { "Pol3RBUkWnExUlfyb5oB", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(872), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gsa", "e30763e3-1fe2-4957-abcd-731eb0a09641" },
                    { "poNNekyB5tVCa14DLXaf", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLA", "4199af27-9581-474e-b2ca-067fff00dc86" },
                    { "ppa0GKYoUE5C2jFVt5Gy", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "200", "b2e295f7-d389-4428-80df-affd65ad3148" },
                    { "pq3ECmpDRxghP4s2cb60", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2563), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "307", "bc50432b-f03c-45fc-b33b-3ec1b1e800d1" },
                    { "pqH3ymFx11Yy600I8z1z", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8077), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CX-60", "cca6082b-55b3-44f3-b3c6-9ee92918d09e" },
                    { "PqMS8bhS5K5fgVcm1EB8", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8578), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "200", "d6d5f980-242b-4373-be7d-fed2b811d21b" },
                    { "pQrhcmoYAyJVmfMRjaH8", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ghibli", "d1ad40a8-5884-4a00-855b-7ba794d08387" },
                    { "PQVCcwGDh6TDUr6LBKrn", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5884), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tercel", "83753f16-093c-49e5-b2a7-8033603205b4" },
                    { "pqXLk5wcMIlR2c4KhE05", "wC0Q8eUqQLkE6cpVwHgu", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5572), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sahin", "9f044b95-708d-4ed0-b103-a2b74abc82c4" },
                    { "przoqWsu52mWWlHsWwQ1", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6188), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Patriot", "ff8fa14b-1ca3-4c31-ba60-e17d9922a8ff" },
                    { "pvl89d394I8nTdxWNJuU", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8845), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "316", "4e80e4cf-ffdc-4916-80fb-a63aa13f014e" },
                    { "PVlzqAYG5qCglbKCaAXz", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7896), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spyder", "99bf97cc-7107-42e0-a2f5-ab2ca5330e6e" },
                    { "pwCU4fgxAdQJs7d9efrJ", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A", "889f5dd0-91aa-46e2-a805-fa214d9a4c5c" },
                    { "pWdJTRySvVAPTxX6Roep", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9583), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Flying Spur", "b2269d66-eb40-40dc-8b59-c5479f77a07a" },
                    { "pwn8yC57KSoN76JWQSwo", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8899), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "328", "5050dad3-b994-4742-9daa-b848a9f112cf" },
                    { "PWr5Gp6gEUlh04Y333yt", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "508", "a7fcd30a-3559-4a02-811c-3f25bc915166" },
                    { "PwukcHjuJqcdjVG8FtBE", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6697), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2104", "51f062a6-94df-4ed2-8736-e43c3a87b3c7" },
                    { "PXRHFWCqwNDx32cSurtU", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2214), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gt", "ee8a2028-e9a3-42ac-8120-6acbe7c99d99" },
                    { "PXwNPzFy3IYfISwquEqG", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2649), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "407", "4f6f45f8-5038-47f4-a11f-b1eec58e0626" },
                    { "PyGI2W43wbok9hocoGs8", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "530", "0a64cf09-7bb6-4980-9bee-7fb29431ccb9" },
                    { "Pyz0BorNMM7TX3mtj2IP", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8817), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 210", "150c8d0a-4f3a-4a7b-9487-7985439e8841" },
                    { "PzP8Va5Aq6EpnyTkj7T4", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2342), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sintra", "290e7931-4415-4560-9b92-e00de5190670" },
                    { "pzQyYdB63Imn0Vy7Kp9A", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6492), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sephia", "30fe302f-ebe4-4705-bfa2-07aef78a987f" },
                    { "Q0HmqdjCA1ajmdvd0A3l", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8185), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rx-7", "3219c1f3-f8d2-4569-92f6-1b3a07ec7014" },
                    { "q0jUKAVlXKRjk0RSj8yv", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6162), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "669", "a77ceff6-2c31-4b15-9a53-d2363ffd4071" },
                    { "q0td9WDEEgTvv4tN0IqJ", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5382), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mint", "594bba86-83ba-438c-9141-bbbca290f817" },
                    { "q0uLVvjg69LYdPfptURD", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Metro", "0b561a06-0b32-4118-95fd-986002f4c715" },
                    { "Q2Eq813vQ3alR5SLmFWU", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6245), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Carnival", "4ec84fdc-b397-4f02-81a6-2072dd625156" },
                    { "q3pbcKSVcWufvNnCxX9t", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maestro", "d3b74fba-c408-43bc-ae5c-20be6e91f3c2" },
                    { "q4QYlyq4zKBCuTEMg05B", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4934), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Forester", "5510b5cf-04b7-43f7-b57b-24ddc22c3d3b" },
                    { "q962INYgLoATEsdgKxEH", "TJTAqICS7fjRu8I4afxm", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4512), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ceo", "225fe239-133a-4b79-97c4-59726a802bbd" },
                    { "Q9pLEPbrbC1V0xHSyfWe", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MX-30", "0ebf5597-6636-4c2b-90d1-459e29d36ffa" },
                    { "QAoekGG1C9XB32dCju7m", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7664), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mgf", "43481daa-bd14-43d2-81d2-d7800be4a13a" },
                    { "qAtaTez8ud9GGHBMTGG2", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GL 500", "e4bb26f2-f2de-47c3-8cf9-0a32b2bea43f" },
                    { "qavNUfyWd6I2Ggc4Ed4r", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8517), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "126", "1281fe87-3675-4720-8bfb-c5ef9034dd96" },
                    { "QbFDnIY1mQQ4FlPW6Ixy", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8163), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4 Avant", "9ad1ab30-6cb0-4df6-a743-4a0524658aa8" },
                    { "QC75yRphsY1NLSzCDNJl", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3369), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sportka", "107f0612-b141-48d6-aa1f-8da6cc906dda" },
                    { "QDyerwGfYnYmnoutEefa", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stratus", "c15e5b7b-3b48-460d-9965-12a870bae31d" },
                    { "qex0vVTPT9FIzbLsTwo1", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6343), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "K8", "45281a4f-9806-4fe5-81a5-2866808dd531" },
                    { "qFBK1SRQTNEsfc6zuGNe", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(653), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C1", "de6f81a4-309f-480d-9e44-f9627f202a43" },
                    { "qfcQtSekaLbTrQIB1hYL", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Canyon", "0f1b9e60-2c43-415e-ad42-fbb0825ca662" },
                    { "QfFqjtMeq1jALbuV67QL", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1225), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "L200", "14b3485d-8afb-43d7-9c8d-58ca108bacb2" },
                    { "QFNtUjybLjYRbm1D15C1", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(855), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-Mehari", "1c34de2d-8294-4723-b933-947890bd8b16" },
                    { "QFpI6Qr7EoEDjuEVXhpc", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3365), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "25", "fa2d4a7d-9431-42b1-88a2-d81b2454b4d8" },
                    { "QFRpNC95RQ3NqkXeo6xu", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Envoy", "5cdbf73c-8f77-4c68-b4d1-0ee6122138a6" },
                    { "QgowrtaApekjzUISQmFa", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8613), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TTS", "fe33d5e4-58a0-4289-b47d-add7627dd9ed" },
                    { "QGtw3vSDVVt9D7eMHxLa", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8981), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "440i", "59b72231-d50d-455b-8a9e-9f16d21e67f7" },
                    { "qhjIYFClKvnyaGtwE169", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Neon", "ccf82aeb-54fa-4416-b50e-f6fd1cd9fd64" },
                    { "qIpS34wGUR77a7gtkhJ2", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4655), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "105", "88d1b293-ea0c-4cad-9a3e-c3fba7354cc3" },
                    { "QjXJeTsFyV8Ans0IkM3v", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9839), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 36 AMG", "94d8ee11-87ea-4397-84c7-0dff2fae613e" },
                    { "Qk0MPlKHYVV6b1bDokld", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "70cffc24-bea1-473d-afc2-1e891643a986" },
                    { "QKHsnPHcVE5FIuq4VgEg", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(944), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xantia", "afaee849-2cc3-4db1-bfde-9690837c450f" },
                    { "qLg9WHUl8nFtS52Bfkqh", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7837), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GranTurismo", "bca23d12-2fea-4f84-9e99-cdf099f037de" },
                    { "QmH6RSksmXxKlFMn3vL8", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Epica", "df013530-8657-4b24-aad6-1ce370cf7606" },
                    { "QmsdByHY731IKvAfdF28", "B42TXsELwNJNBewRvcu5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9978), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tigo 4", "53c1ed4a-5002-44c8-8f71-eb6ac28d9c09" },
                    { "qMUu9d3gHmTddJ73GXMh", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mark Lt", "f7b9506c-2d1d-43ac-906d-b3c591a8caa1" },
                    { "qNKTwGYEVm5enhhdHexz", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fx 35", "666ea7b5-cfbc-4e4d-a3c4-c0bf26082ff2" },
                    { "qo3C4VAqulruNnXX80Jv", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8760), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2 Gran Tourer", "e7b5f8c4-ac7d-44a6-abb0-e687891ab552" },
                    { "QPc29HXeAgQntx7QV9NN", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9417), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 400", "34cf9733-a9dc-4b6b-b274-9f6a330ab38b" },
                    { "QpTlHjvflX6x575VTIYP", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8238), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rx-8", "c526d5fe-b5c7-4215-b977-2980acfabbf3" },
                    { "qqAxDNuDAPpEKdIKMFmW", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6395), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Morning", "a5a8554a-1ed5-45d9-8b40-f8ae4220db8f" },
                    { "QqeFNFTe6NtpphAMa2rt", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Carrera", "77f6a591-0d9b-41c4-abe6-c51f3f5ac8c2" },
                    { "qqI1Q2v73lT5bmGP39qQ", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9259), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLA 200", "4f9b3c95-41fb-49ac-a149-92f653b13ab2" },
                    { "qQQ7f5rLbfv3E8xnaBIX", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Steed 3", "49afb2aa-52bd-4957-9625-a0c03b36164c" },
                    { "QQyrnJyHvthSQqrdu6sR", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9601), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "T-series", "442c6427-05bc-4517-9db4-79f51559225c" },
                    { "Qr1R4IFJu3N6BhxJHIWR", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5829), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Proace City", "c253ffed-d0c0-4bbe-865a-3646fa6494f2" },
                    { "QRP5HTj96A17pcGRzwVW", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6665), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2102", "5f028eeb-7048-4a81-b65d-2daa79c48fb5" },
                    { "qrwnl9FGcxqG1mxk9XmS", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7501), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "400", "39cc9fef-67f5-4262-b0bb-9a02aa2e3d82" },
                    { "qSkVWHwcrJL4tVDqQMg7", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1669), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bluebird", "6a2c08a9-3f94-44c2-beb6-9af740369c25" },
                    { "QszK97tk9C0GDufJ7dly", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9573), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 290", "50f443c7-c329-4272-8160-cd39d68db88a" },
                    { "Qtmhge8AFNA6GvJ7E6dh", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9289), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i4", "ee399fd0-7199-429a-89ce-a7f8436ed3be" },
                    { "qtp2AS5rwfDu1g6hDDkM", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9884), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 63 AMG", "2c813789-8eba-4572-a4f1-a126d3fb31de" },
                    { "qTPBhJF7FxqrprClQdys", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7605), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "166", "17484a45-23be-4d66-9e14-5960f727e579" },
                    { "qTPt7dwdnSnG156zIKSj", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6583), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "T-Cross", "1a39efe6-0da9-4ca3-a732-d9aec2d023b1" },
                    { "QtrT36cdM3cJv2sJzCMp", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V70", "06f848ba-637d-4427-9ae5-9133fbbd3231" },
                    { "QuBMRCftWSuQyexnqRRj", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5221), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Splash", "220733d2-5543-4327-a2b0-fcdcf37cd184" },
                    { "QuK71pVqPUxjr6L1lglC", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5369), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tucson", "ec994419-8df6-4266-935d-0df80a3c825b" },
                    { "Quq3oppbITw2A3Qvr6ht", "nsITvMBs2Ujtv8rQ0KJM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(994), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MC1", "a34febb6-de5a-43fd-bee6-14daba7d8db1" },
                    { "QV3nrrDg4zo1XudzFplx", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1532), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aleko", "5f137073-f15e-4cce-b342-3a6cfb3e15cf" },
                    { "qvjJqz7H03le9Kq2xEAf", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xedos", "79b950e7-cbbe-4ac9-a5a0-b342efe2e64e" },
                    { "QW9RBX9Ukw6v6yJCCMIJ", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4531), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1308", "8df796cc-836a-4f7b-8eb3-92413776e409" },
                    { "QWptf2hQBJa4AuzY8dCA", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5215), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S", "433e0c03-8d31-40cd-9898-54081fc3db68" },
                    { "QX1BaVmws23B6V5ucgtI", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(789), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 3 Crossback", "a8df2d57-b197-4566-ac27-5109b13e4ef1" },
                    { "Qxwp6gpVmq9QGWFbemDq", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Opirus", "33a2e7af-dd8a-4ed5-91b1-81310f9082f3" },
                    { "qY90s6dE1TrTk5uhN7hh", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8635), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maxi", "9d402130-64f7-4ee3-995c-2ee8113713bd" },
                    { "qyKh2zPr4zUqT0C3Ppje", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2502), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "207", "3c0e9393-bf05-4769-8bd0-37b926007072" },
                    { "QyoQfqRRPjlzPyKv8HNj", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7884), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MC20", "18b5cffd-8f38-470d-ad4a-e2da5c1f6610" },
                    { "QzdA96hrI0z2Tp3H0p6k", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(844), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 63 AMG", "8ae77592-74b6-4b22-bf9f-3e70d124284f" },
                    { "R0cAaSY9M6V267ubWuv7", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Citigo", "4340f0db-e0fa-4635-88a7-49f00cdfa877" },
                    { "R1nyoee2t06sj73VnsQj", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2814), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Barracuda", "4aeb9e6e-f0fb-4c63-a0ce-55ed1fc27987" },
                    { "R2ov4KF6MQBH9oD2LHNo", "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LF1010", "bd78ffbc-373b-47a0-af39-36fc0cf506ad" },
                    { "R3kaSbCTrVc1UCjxnUjp", "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Koral", "bd674410-3cbb-4519-a2c9-1a538656a1c6" },
                    { "r3NDu4HC73I0ly6fbjJF", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(429), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daytona", "835b957b-8dbc-4752-91d3-5483238840bd" },
                    { "r4DWzVebqDqkbuhGlrB6", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4052), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "623", "93de4372-d308-4c7e-8aae-2a1ce20e1d28" },
                    { "R5EPDelS5Nx6FxDJIvgD", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9499), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E", "d23e815f-8fe1-4d6d-b78a-f319d47663e7" },
                    { "r79VGPaHe5XEkBWgbtUe", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B 160", "0cecf530-e168-4644-9ae1-ad7318253fa1" },
                    { "r7D5bLrbV6wxmFNmc7xz", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Focus", "40bff23f-83bb-43be-ae90-423175c85a5d" },
                    { "R8l8MYcN2gD0LK4TJW4F", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9677), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "FSV", "a3548a23-162e-40c1-b6c0-c2d7ef74a9fa" },
                    { "R9c8LhHDa1s7V2apc8UJ", "dksqVUhgDuHJ9KJ2uqyP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F102", "f26b2339-e2d4-464d-b5e2-17b546d21d32" },
                    { "R9huEzfXzV7JLXjwhRvG", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7990), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "323", "4caebda1-683d-4b49-ab0e-eb029e422f3b" },
                    { "R9kR82TzVhmHNhxmabvW", "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Range Rover Evoque", "f53699a1-2ad5-4c15-80fa-bb57ce55c3c0" },
                    { "R9R60mr3XbQ1jueRLXHG", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8624), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ambassador", "f9b589d0-6af4-43cd-a815-36b12eb4510b" },
                    { "RAvGnoBAjdjaewqYK92d", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3 Gran Turismo", "ee563e72-ed3a-46e2-b871-eb5161b7f552" },
                    { "rb5CBYHFyozN4YaJ61Rc", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9049), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 280", "57d1a419-f421-4082-9800-be16326ab9ed" },
                    { "RbrpfF21bvFclWFwSRU1", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1237), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mirage", "934f5c5e-7447-479a-ba93-5759df32a978" },
                    { "rBYuSTvuQQtRpYoKpe9Y", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1857), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Quest", "8de59626-28cb-4703-a329-f1c1ddd3c463" },
                    { "rCRkIeVDPqpPvwVqvsVH", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F1", "78196c3e-f44a-4975-89b5-79a1bab855fa" },
                    { "RdMSDmrN6gjvsrMjuFnM", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3008", "fb5fa672-7576-43a4-be6d-ad92d4a03000" },
                    { "RDRG7SRocwtrGPnGB6cP", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4562), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Legend", "83f2144e-2842-4f77-a7a1-8ca10977b87f" },
                    { "RDtA5IJEsb8w5tue7T5o", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(55), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Beretta", "e5316741-a9c6-497b-86fa-e75a784e35d3" },
                    { "rDUkvyumSUS4wKLJgE99", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 7-series", "7857009f-5f4d-4efa-82a5-374169ae1e92" },
                    { "ReAK2DphNR7hFM51Dwdj", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Astra", "114406dd-1fc2-47dc-9ffb-60ab5767d54f" },
                    { "RepzwCTWEmPD2bP70TYo", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1851), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Qashqai", "43d620d3-7640-413a-ba2e-dff8b35d2968" },
                    { "rExIMmFoHkph9Y2eApSW", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7058), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V60", "17cb3a79-6df1-448d-a6e7-5a4de5f39b30" },
                    { "rf9Vap1wyygQgIVKmyQV", "sQ5C4f7H60rzJLhMA0T5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "9-4X", "c665a877-6c9b-464d-b474-a48a549caec9" },
                    { "RFfHY845qQdIv4tkj6lM", "Dfej8VedBqRvW5SVCeo3", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1631), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bluebird", "80dd7e1e-7c1d-48cc-a053-5c7ae1e917ac" },
                    { "RFRa7f9z4hza2m3xyKQW", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9241), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina D4", "ad124c89-5b62-4b50-a36e-f5e092221d1f" },
                    { "rfyyjg7VI4W90nsQ2Y08", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2507), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "208", "fdd73453-c068-43c8-865f-103b3f701b87" },
                    { "rGMGb5kJftlgBa6sg3bq", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7094), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lybra", "de0512a9-ce51-4d96-a6a5-59c248bba385" },
                    { "RH5VNufM0vhIvvSctyag", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2119), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LaFerrari", "41bc028c-e85f-424d-ba7d-09fddfd7d8dd" },
                    { "rHG0SGQKoCIPGugVMfs5", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6934), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "850", "d0137b5c-5a95-4059-877e-249df1dafcee" },
                    { "rI7JBk6QtFqnwCXqerL2", "B42TXsELwNJNBewRvcu5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(24), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tigo 8 Pro Max", "fe53c4f2-101f-4e78-97ae-2db139fe2142" },
                    { "RIhBHlXyIH18ugFrS7TF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8900), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B", "ed91995b-4d9d-4639-83ac-d178e52b6eeb" },
                    { "rImRcorUJM6ardaIuwem", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8060), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "200", "9b5a85a6-79d5-469a-a930-96ec560c29ed" },
                    { "Rj51cywU2PLH2KpeNajf", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9652), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 450", "bfc0a370-f938-4a15-a96e-67bef18f160f" },
                    { "RJCospvI3PCtGrDNReuI", "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5330), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Simka", "d74de250-f8c8-48bc-8e9b-f36388845b23" },
                    { "rJCThBdW4wPmojw8NNjp", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21063", "6d5dc0d5-2058-4113-a23c-3979d385bad7" },
                    { "Rjg3454cnh3HEbTqt9G9", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(410), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "300m", "51116a7e-0fb8-48a8-9381-bb561ac5ac98" },
                    { "Rk1gMT4eCnMTrmwk3mF3", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MTK", "2cb95bb8-932e-4cc3-b1ec-ce0e8be5df98" },
                    { "rk3VVc0TGsMJtzBfaUAd", "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Commander", "cdf5abc9-7f5c-4aee-a17f-2d96deab5c66" },
                    { "RKgEGRJLTUMWt4xeD9bD", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2193), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "126", "55ef1c63-fd59-4d20-a01f-4783d7a23a08" },
                    { "RkTQYFAAtJVtYIaVlfAL", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3376), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "30", "abba6b28-9377-452d-9674-c25baf49fa1d" },
                    { "rkuWGXxPV1Pu4tQe4TwE", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1356), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lanos", "f83d93dc-fdb5-4f20-ba54-4734bbb3b2cd" },
                    { "rLpwX2IszvMpv9AkD4pU", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "115", "bbe4c614-1eab-42fd-be22-75c22e3564a6" },
                    { "rlQvm8eW0VjsBYbpmJSS", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(102), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Captiva", "ff198669-34a2-48eb-acb1-5fb9ab7b60fb" },
                    { "RLURXCYRSUBX0z3zwaYE", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9411), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 350", "ccf8d3f7-cf30-43d9-8fb4-0b10c478f781" },
                    { "rlVM1FhEjgxjzIXWN49p", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 600", "07ffba6d-ffec-4d5a-834b-74ec51587116" },
                    { "RM1GTp6sgCNYVpSdXxUn", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2755), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Range", "e8f43452-826a-4591-8f2b-00e49a4d1768" },
                    { "rm9LHsPuD0WSIMs8fbuX", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8168), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A5", "2d5b7d09-ad97-4174-9239-9ce8f9df3d68" },
                    { "RMbPmKXCVCV6xIycXs4j", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XC60", "67595fa0-91ce-4db8-992c-a4fac487673c" },
                    { "RMHYVjgVdatNteJpbjBD", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B2200", "bf8f998b-ee6d-4565-ad92-b7f9dc1bb436" },
                    { "rNj2cGVsS03I2cj55b9B", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "404", "36e18d5c-a4de-4dce-918c-33fa40efaed6" },
                    { "RnkeNBW2tC41jVnK9Awx", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "4008", "dafda18d-78cb-4c32-9795-bdd6b7b03b6c" },
                    { "rpAS268fwgWkg3Do8F7v", "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Matra", "150d1b7e-8495-4bbe-9b39-97773b635573" },
                    { "rPIUfAfvoX1vAHSpw3Ik", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9386), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 320", "db5f0755-7869-42b7-860b-3037a9422e7e" },
                    { "rQ14KunTKXmlFvGjRTRs", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5459), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ex30", "9718e575-84ae-4041-8fdf-ad11053a56cc" },
                    { "RqBYbqs4881wLb3x6I6J", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9486), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 63 AMG", "6f5d9959-03e4-4b53-a73f-779e3039bf2e" },
                    { "rQhF5Uch7XgpuD6aktyu", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1355), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Starion", "6af48af5-ac5b-4640-8d2c-ab4b1607f86f" },
                    { "rqWmI5a6MqetRv7ggeq8", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2015), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "488", "58220e71-725d-47f2-ac79-2bda9e45cc95" },
                    { "Rr926d76RG3KcjSt2KxR", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Super", "7cd29ba7-1069-40ed-b6ef-f84995a22aee" },
                    { "RSBnsFPkwxa2owsuAD0n", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EQE", "d0e839a4-4487-4bc7-9525-f547bbf4cb80" },
                    { "RSEkK3mEF38FrqbdDU8T", "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "JS7", "59ef0d30-f7c2-4dce-a0de-b7dd7ec13872" },
                    { "rSNIwt4WqXzXUFBfNb5f", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2809), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Acclaim", "807cbf1d-c91b-42dc-a449-3a098b8c03ad" },
                    { "RT2q7q2IDRom4jq9gc3f", "YK3JYVEmHcskgB4f1s9M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XS-D055", "b8fc908b-6af4-44e8-9e63-8f3d64ca3610" },
                    { "rtJrLtjYUjuXuNXM5fL1", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5804), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Prius", "c6e8b957-25e4-485a-8bc5-c6a56d7ceded" },
                    { "RTkrTfGN9wSRhWVtQ11R", "Fjw2xBL9BqCaQBzxcxDI", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3697), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Prizm", "c2b09849-cf02-4076-87ef-4d3446d57c5b" },
                    { "RtL7zAKKMLLQjQaRS2zR", "fAVrUUNVKFbMuNlP7oUW", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3592), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tugella", "ba4995c2-23fe-4c23-b2d7-04f8d1e33d53" },
                    { "RTnxnLlydwsYLpKVhe6k", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EV6", "71e9395b-c274-42e7-becf-7232bc47e73e" },
                    { "RTz1G41TfaVVpqbVQaMB", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1499), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Feroza", "e33f1288-9607-4c37-a7df-5fe8ee8c6589" },
                    { "Ru3qJVRcPtMza7BJCAXj", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5395), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Safari", "298679bc-8bd1-47f1-b6a9-dd6922b642c8" },
                    { "RU4nGTevR6EP0e74c2vA", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6745), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2107", "8d30c362-1878-4ae3-8988-4a747f0e513c" },
                    { "RUqGmQtcdyDV3KHdVvk0", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(398), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "200", "df3fd01b-9249-4ea7-90bd-054a06225250" },
                    { "rvpPeq9tnAddJ1CXgT7V", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(60), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Blazer", "ce71b324-20ad-460f-9bdc-69c93deecdff" },
                    { "RWcf4D6luYeGKycVSPbH", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rapid", "67fd16e8-e61d-4d6c-8c1d-7f111f0a387d" },
                    { "RwD50WA9g7KHoxIP4LYV", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Latitude", "b8745e14-e9c6-4df7-b8cd-05c87bda91b1" },
                    { "RWp6GwTRqH9QxHsyxvcs", "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Defender", "85792952-f8c0-40e0-a99c-c84589287bcb" },
                    { "RWuhz41vHa2k0A44r9Mc", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9443), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 55", "0f97010d-156d-4eb4-b7c4-a0c222b17237" },
                    { "RWzpgGUN2UkuaLGoIBmY", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2486), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Croma", "ee1c6eb0-0778-4692-a9dc-348e915e83fa" },
                    { "rX4ypaLoAI9t9w9nwWMN", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2354), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750", "b66b2172-1d5e-4f49-8fc2-6108ec7a091c" },
                    { "RX7v3lUa0eY73PK9FBg0", "nsITvMBs2Ujtv8rQ0KJM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1036), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MGO", "e00cab4e-8fb5-47a5-b209-35e7658437ef" },
                    { "RxTs1pru8pb0LldyELot", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8030), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "626", "f91fea71-de21-4735-92e9-eda00c1ccfc1" },
                    { "RYv9Tdy3q10pVpgcL40d", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7105), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Phedra", "a94cca2e-1362-473f-810a-1a6a8306bcc8" },
                    { "RyYrBRJXhjlxQr1wXrVd", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9066), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 32 AMG", "0d21a766-b6d0-4517-9413-f00849f26562" },
                    { "rz1yBKpnNBRYXjdqSh1d", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(590), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Axel", "5933d53d-4eb7-4775-b4cf-375d5e12332e" },
                    { "rzo9w80Ipgbbr8IEeSaJ", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6709), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2105", "fd72cf61-82f4-4efb-bfce-34546d6fbe19" },
                    { "S0WMeSfdzUu7AF06npLo", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sunbird", "82d2079b-dd5f-42e9-a559-9caee3c68791" },
                    { "S1dqwJPUb4fjK4gSnnlJ", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4597), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Shambord", "7ca16d5e-7948-4cf3-a7c9-c002c3b344a0" },
                    { "S1GE88mqhIwJJvgMKyEV", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7565), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mkx", "65cc1e14-bba9-4eee-94fd-52cc2efff0d7" },
                    { "S1NAhCVspmckv3nNPpsQ", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mdx", "24c5c1d6-08e9-4bad-80c6-66626561ee88" },
                    { "S1nuR5cSAVV6NGw0TNx4", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5669), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "QX50", "c9d3106a-445c-430f-9d93-d88d52d91c90" },
                    { "S2mqSnqJ0fFvRPphnRrN", "d6V8Py7xGhHTTVvS02QR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Double six", "6474e048-ad27-4e93-a248-320eb8aad521" },
                    { "s2vWKScaRnVqMUCThmxW", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "505", "16fa183d-c1bf-4475-8bd7-2bdadb1bbe0f" },
                    { "s4nly4HtUwxsQgHmwMxo", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(889), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SLK 32 AMG", "fa9063eb-f021-4ba3-9290-a4cf857e70f9" },
                    { "S5AVPcXDCCs1FS4DBE4u", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1422), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Racer", "61e75605-160c-4988-9e25-784cf59f9413" },
                    { "S5FwhNFCBsGrQVAgp4CT", "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7485), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X60", "9addf788-91b1-4312-b308-d46465f43f59" },
                    { "S5rz3sPQCzRewAdI3LMy", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sorento", "9fffcbcd-a3de-4503-878f-4cebb3966699" },
                    { "s5UGH6z4GtULkzvPClRa", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(523), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sebring", "cf091c29-9e16-48a5-baf9-56e9aa401828" },
                    { "S8LknaWczfVzBaFApjWo", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8165), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mx-6", "0b096fb4-8ebd-4184-b242-26b1dc9a7f2d" },
                    { "S9N9JsqkUNbJx4yD5FJr", "fAVrUUNVKFbMuNlP7oUW", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3523), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Atlas", "83919c43-2312-4e49-b5cd-f9b8e5e8992f" },
                    { "sA6uVGVdf49vJ4p8vsdE", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2598), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "403", "56262af9-9cda-4fef-b61a-ff95327f5981" },
                    { "SaEwDCWRqJnQDSG8Mev5", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "156 Sportwagon", "80842988-9e8d-4ad2-96bb-3415af4e3dd2" },
                    { "sb1wPl9IomSc4mLQSS3w", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "320", "adc0ac1c-0bd5-4aca-a2ad-24fc8eba4aeb" },
                    { "SbKLj8MfPslpkrc0fnwt", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6789), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21083", "6e79a042-b869-44dc-9f06-ac5ea444a316" },
                    { "SBNchgHvKJEU81f21VJf", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8230), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A7 Sportback", "2f467f2f-aa28-4e80-b4d9-a9a37d5a4d3e" },
                    { "SBY44AIF27yQLQJbDuWm", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B4", "a8e2695b-8944-4f4d-bfb2-72d28d40fbfd" },
                    { "Sc807gvUsrmWYehoeBy8", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sonata", "9184b9c7-6fde-451b-b41e-15e2236eb205" },
                    { "SCtzdNfppfyNxbbFPLrB", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8557), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "180", "0cfb2668-fd57-4f1d-be8a-4ad73fc60c85" },
                    { "sdEykMw4vD7fSXS3kF5a", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9949), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Srx", "39ce3235-ccd8-4c04-83a8-30bc7485e197" },
                    { "sdmMDybUAeRrcAA4s1uS", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 230", "f2969dce-dbdb-424b-a613-63fc07a8fb91" },
                    { "sEe967v5GSJv90v6e1JY", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8035), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vanquish", "4cdcddd3-be08-400d-a6fe-0c83bb7c2087" },
                    { "SEnDrynztwAs8VQWwRVT", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(831), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ds", "4d464e4b-7cf6-4112-aea0-8f13f1666286" },
                    { "SeQjFenIlJqqw3XvfT42", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6177), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Expedition", "e21cd7d3-a537-4d05-8e4b-3ae76d22fc49" },
                    { "SFDI85u6E8ycwY4gthqg", "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7244), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Range rover", "5cf3fc6a-ad5e-4f8d-8a72-1408203b5cfc" },
                    { "SFwdtYHlrDDT3l3cHUP8", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21015", "9afab223-4734-4034-982f-f92451549a5b" },
                    { "SFXRyYlseJR3z49dQU3k", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3110", "736cae19-ec39-4b1c-ab63-ae2d6e6bbf9d" },
                    { "sfzvSMDqP3TeeEchItkS", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2326), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "500X", "1fd161d7-fd83-47aa-a480-1d8cfb5e2842" },
                    { "sGsxXQvRlsXef6jFN3fa", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3327), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Raptor", "d6e24b14-483f-48c3-8950-ff934f3dbc9f" },
                    { "sIlAKjtlsVhzNF9gyM4x", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7523), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mark", "ae38344d-efaf-46e5-87a9-5c914342814d" },
                    { "sIonqVvP3WaIRAXerwYB", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GTV", "1bce8633-e1f3-48d8-9081-5802e5092709" },
                    { "sJh6Ic0yHj35C30GmufY", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(947), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vaneo", "5aa7d1fc-05f1-47cb-a27d-4ed89a9666f7" },
                    { "SJHbIR9BgRUFCxnmUJ7U", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4979), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "I20", "2e381b98-dae1-4229-a699-9e98ff6a6a4b" },
                    { "skCkF2nT4aMWjWxnvbrD", "vYf86TFDqUkh9RcEN9VN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5492), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sl3000", "bd1b46ff-d425-479f-8628-470a222df880" },
                    { "SKX1Phcb1IV7m7RuosaY", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2179), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Commodore", "651ec8f8-3d67-4b8b-b19f-f9e2d891453d" },
                    { "sL7Jj8v2Isko4jRTVs2R", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8971), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 160", "689b386d-2a6a-492d-8743-89d8186ede7e" },
                    { "SlefYBEm96rdaWTzFxco", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3802), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cullinan", "a9211a1f-cd5f-4d9a-ba37-0e9d10de9536" },
                    { "SlQ9zo85TTILdBL5Cq0L", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5232), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Swift", "3d7d8160-f45b-4d0b-a270-00613696a343" },
                    { "SMjrh1SIRwUzzeMfvPEk", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4757), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kodiaq", "f13ea885-7135-4d5e-b23e-448e7ddb8a41" },
                    { "smPIMBMQnmlvaDjvMVW1", "XW7Xpw80z3VgX82egcWN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7153), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "312", "37380183-ff1d-470e-a90a-45927af73125" },
                    { "sMQ6B6EVoQxmFPXVQ9RH", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Travel", "f1afa4c6-5cdf-43bf-8999-157f0ab709f2" },
                    { "snmd9lmdo1FS5nGPKVYQ", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X-type", "93d57d28-e3a8-4e18-8f7c-9715267fe818" },
                    { "SNnXnSV74wBqdpdWxSAB", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4819), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Superb", "22ed7fff-3438-4909-86e6-387333334b91" },
                    { "sNTccoB1LKHfovsebIPF", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6444), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ID.5", "716ac30c-78a5-4a78-9914-142520bedaa0" },
                    { "sNWLBDbn2PomPsBPMdmF", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5872), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Supra", "8edda649-7ed2-4599-93e7-2f0d347c468f" },
                    { "som40xH4Hs78zaGSGYKn", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alhambra", "54b0d6f1-fb8d-42dc-bd99-4ea9528ce3ea" },
                    { "sPENzKPr4Q5ElwgWj2DN", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5237), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vitara", "61c00659-3582-4ad8-8585-37a5e7b06bb7" },
                    { "Spla7qpLF4oaefQtVtss", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8059), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BT-50", "fbe2ddb2-b812-4687-abd2-99e6036578c3" },
                    { "spvwdpaXVGG3xNJtnICy", "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6004), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Acclaim", "854bb67d-9f5f-4001-ab48-178752997b8c" },
                    { "sq6dzlxUdYP2SAFS6L2S", "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aventador", "36889208-407b-465c-8f0e-ac8e1a58e999" },
                    { "sqUBUlq8uSAxwJLQ8auL", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "740", "378deb67-5915-45ee-942c-cc5b1b2af3f6" },
                    { "srJHCWzdXrFX4sUtnLz7", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 320", "77bd1262-5a1f-4c6d-b9d1-435782efc94d" },
                    { "SrodKV8PEx3Wwg5DerNc", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9989), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLA 250", "9512971c-2b66-4420-a278-dad5e85023ef" },
                    { "srxLI45G80lFzpDcAAQK", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2783), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "20m", "32664aea-82a9-4363-b72f-4e7e8a21f224" },
                    { "sSuBk2wJCP972qULMCQ0", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5225), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Santa fe", "2c734fea-6fa7-4f36-ad63-fab6149cc3e6" },
                    { "St8VCocRHYysxJ55g9SA", "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5387), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nano", "3fc5a4a8-200d-48b5-bd08-a18df8b1d2ae" },
                    { "sTHvdHtfy7urKgcKFBxd", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Oka", "bba81282-5516-4cf5-a7aa-2e8d960f6060" },
                    { "StTNp8JHV9juyPuo2wsT", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ILX", "441aa3be-960d-40f1-8434-c7fe19efcc1e" },
                    { "su0D88JXM1HUR61wfK8U", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7843), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gransport", "f34979c0-f751-42c6-a66c-02420722b89e" },
                    { "su0JAam1U391R869VdDQ", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Terrano", "c0d52a19-51c2-4218-ae47-b4c266b0a4e2" },
                    { "suCGyslPpmKtTVQ0cIxo", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(724), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C4 Cactus", "6d07e386-cfa3-483a-87c7-0ea3fcfe0bde" },
                    { "sv14IIzIxSl1jCWDrBtD", "KQMma7dRwtXlcym9oSWC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Magnum", "3d1c897f-c09a-440f-a4ba-0ef5fadbcb09" },
                    { "SVxMVecRtFrdX8Jb1BeA", "Xz43eo1VM5H41uNJ9x28", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7167), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gt", "d987b563-87e8-48c6-9bc0-ebc1b18a1480" },
                    { "swrEGVrHPSv33CjKw9pq", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3795), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MR", "9e490b34-9673-4d52-994f-023a0272a051" },
                    { "swwEQDwAHjjkR2TSNyxg", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1984), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "360 spider", "5b8065e4-a0bd-4216-b517-303020499a6d" },
                    { "sX3dGAH1rx62kENKjHGx", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9912), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fleetwood", "0523d791-4204-495a-924f-44d5d3e31923" },
                    { "sXzU8xmFdHf6PK72qpwp", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 600", "15f4f0c2-b6df-4d34-b80f-0ae2ab35d4cc" },
                    { "sYRxut3tuu5CrtfUI1gN", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1997), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Achieva", "316946ca-12f6-4974-b831-f3f84d17c0f3" },
                    { "T1jSwkcKJ96AsKYzJp0L", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9967), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XTS", "42586d10-4e20-47e2-ac32-79be9967c880" },
                    { "t1q6552Cjb6Mx9PchIrt", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3053), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trans am", "ca9f11f5-86d0-4286-9c2d-927035d16075" },
                    { "T1uuxRuKruIgCKwSlTzs", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6290), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1600", "a8b54848-b8b4-475a-8596-0d73e90e1345" },
                    { "T1XdgAENeov2oh4zABGE", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3134), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "968", "ded521d2-5f55-468a-9cbe-443537120147" },
                    { "t5GgWcAtYvmemoNgzDwM", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7122), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Thesis", "9546090d-a6d1-462d-bba2-7383eb0877bc" },
                    { "T5uYYqCA8mYU2UKAMQ5c", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5467), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ex35", "e87e8334-468a-417d-acec-c4dca0d2b576" },
                    { "t5yxwPeLYAxUzE20Pmv0", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2315), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "500L", "17a27762-eae5-43cc-bfa0-fa5ab5c15134" },
                    { "t61xvDXtqmJBQTmlo3H4", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(434), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Es", "8a7c8885-04be-4451-92fa-362a85d8e66e" },
                    { "T7lgAEzE2At93LvXD1Wb", "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 9", "b89fe841-350b-4660-8a5c-4737476c153f" },
                    { "T7Q8XdHf7exhBPCTIauf", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(153), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 43 AMG", "e9816f77-4a78-4eca-9b1f-40000fba83b6" },
                    { "t88Xmt1eaqIXbyKD66t1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9379), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M240i", "731f3493-fd42-4ec9-810e-9262bc4257b2" },
                    { "T8al4bIzQEW1wRFuANNx", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9345), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLC 350", "45567ca2-eee4-4bcf-befa-2d22d42b13fd" },
                    { "T9lokkctIP5WKgT9vBAe", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9527), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 250", "1a3139c0-030b-4741-aab7-8575861069be" },
                    { "t9qvPcSJ70MTNHlHyd1b", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "452", "94759f4e-ee9b-4f3c-a4ce-25490afb13c6" },
                    { "T9r4y7JV4YwYNAsUgB9J", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3290), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "14", "4d9c6f60-49fa-45c6-bb32-9e2922b7462d" },
                    { "t9RAXDA8LvhsL4WuNSCn", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(87), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE", "c6f0892f-5821-4e4b-9cfa-4ed7bfcaf074" },
                    { "t9vkz6zpJWazVaVpNkuD", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1212), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grandis", "97102636-955a-45f6-ba20-482cbffd9dca" },
                    { "taf0NlDAAUnhGepGJeJu", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(96), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caprice", "7c64ca00-0835-4056-bada-9efc1497db35" },
                    { "taf5rbyQp6P6wdtbWLgM", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(573), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wrangler", "0046a716-d9d1-4681-872a-810ca90bf34e" },
                    { "Tajcy73YmgG3VMEPHwMS", "YK3zzVEmH55kg41f1s2M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7478), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "P5", "9cd62846-cd01-4185-9719-dccbb699134c" },
                    { "tAMpKkt6GbeR04D7pNqg", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 300", "890d2c40-52a2-4723-848c-253435ef771f" },
                    { "taqJ1Ym9hvYUT225y225", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3395), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Taurus", "9d3fc7f7-ba27-4d65-a2ad-dcfb24c71e43" },
                    { "TaTISXXb9UarTkrd3lX6", "R9BIHlzCwb67GPT89e7F", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3216), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "400", "d131b7e3-aec1-4368-a1da-b4d5ae836d60" },
                    { "tB17zwtkM0WUSaJMF1II", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zr", "6379d2de-0955-45e8-90a0-100f61bef971" },
                    { "TB9Sv37ypzdNgthJ3qyX", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5581), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G37", "3fbe22c6-5272-44bc-b740-4b81f76363bc" },
                    { "tbP8WHP0tD3CLFjfXIXv", "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7277), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750", "9290fb86-8d0d-4554-80bd-625db62309ca" },
                    { "TBtP5l5TeLXzyqdo447p", "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4245), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Husky", "310d3893-d889-4f94-ac84-deabb6b6fc34" },
                    { "tBuesSqnJLQM64tXh7xa", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8382), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS6", "ed408ed8-ea1a-4a70-b8fb-171135571fea" },
                    { "tbVPLN5PWV4tg6fVQrf3", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Volare", "59fcb2a7-a7ab-4ecc-abb5-ac64e7ed7cf8" },
                    { "tBzQhYeP89eg3SFujcXE", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5899), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daimler six", "7a0068f4-4e5d-428e-909d-62665af74ffa" },
                    { "tCudMRWzmSoHaJq7gveW", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4825), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Yeti", "dbf09bf5-8621-43ac-8d48-e53a0ad0d3b8" },
                    { "Tcut3X5d9Ktz2TbuGUxj", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q45", "62282aa4-974a-40fa-bf80-637a0272544f" },
                    { "TcYWH4fltCp1PPrXhhHm", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9435), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M8", "ca8d3789-0791-4aa8-9f1f-01ff1ffc3b95" },
                    { "TDdpImQM2GBcXe1bQafj", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6548), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stinger", "47a4f0a4-41b9-4f05-a5d7-bc71cb46cac7" },
                    { "Tdjxrs1WtDrf8DcvqdAN", "YK3zzVEmH55kg41f1s2M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7510), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G9", "ffcc73b1-e9e3-45c5-ac25-2871c1a98462" },
                    { "TeBb2p4TU5uJrYTL1wmx", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GT86", "a1ccb61e-c5cd-4b72-9908-33306d0bbab1" },
                    { "teXMlIhfEgDVR1yjHo41", "oyETMjvBlpVLEDFlVADI", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1366), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aero", "b02c6b08-34da-4050-a894-31353a40a21d" },
                    { "teXWl7Y9192N1c8cQVQM", "UG6N8tBL4hpBPkjX12Bh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tivoli", "5b7de821-5ee6-459d-b9a0-39706118796f" },
                    { "tFmtII8c46nzjW6H1ckG", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9489), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X3", "d19b60d2-586a-4783-8c3c-f2380729d5d7" },
                    { "TfNr79zEsAKtBstGb4bV", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B 150", "7c101f74-f95f-418f-871d-20417f3ddd8b" },
                    { "tfYqbhDUudwB8MDVyDQy", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9306), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iX", "a8aa1db7-9893-43b0-9e18-0fde01541270" },
                    { "tG3N51x3VpzCzhToxDl2", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6928), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "780", "c8a4ae56-42d3-429d-bbeb-4a1920e6e5c8" },
                    { "tGh52cjftlB3qrTgDwRR", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crown victoria", "57d81f76-03a0-4cda-a504-8c70483c1cbf" },
                    { "TGPHrnku95HVfGEzlY8q", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G3x justy", "d027915e-98aa-41dc-9a76-7548eb411fef" },
                    { "tH3URmbEqXD9HzdkDtXH", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4459), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ronda", "2f991db5-aefc-4b46-ae52-9c7c02cc826c" },
                    { "thmGa1CKuDg7bHmYUSQE", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "428", "7913ddb6-8e62-4f1e-921e-0e7fc507ba56" },
                    { "TI2F7bNFA3dyXbkHzxBn", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6437), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ID.4", "7329c614-142b-411c-96ee-ae3826884e16" },
                    { "TIfLzWytVozFCg525GG4", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8288), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "570S Coupe", "d99de94a-ef3b-442c-8400-1ae40ea6da0e" },
                    { "tJ6PJ1HsEvzaEAKSaUkd", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3102", "15edb0a3-8b9c-4d30-9ab3-1607d9ebd58c" },
                    { "tJB0MeEE3xNXHukjHyvA", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2667), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "505", "27955863-10c6-4af0-8179-5eda026f41de" },
                    { "Tk450cUV7bYemwsBMAFa", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "264", "38ad8d44-4680-412d-b6ed-df60e99abffa" },
                    { "TKu2Ht44dqjzKwxL7N4z", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(518), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Saratoga", "7a929fdd-6184-43a5-b921-e75343f7e9ce" },
                    { "TLBfnlsxHMbF2ERE7YeG", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X-90", "dd289cec-5af5-4c5c-95c8-40002a9c74ee" },
                    { "tLGgRzkE75UHMMJdVdW1", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X-Trek", "54278d8b-eb07-4c2e-b095-8d96abdcd778" },
                    { "TljjFs4wtyRNn2ybKzfo", "nsITvMBs2Ujtv8rQ0KJM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1030), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MC2", "f45d44bc-35d2-458b-b0a8-0125dc2aad4b" },
                    { "TNCGU0JoNa60qH9wBH7V", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maruti", "968111e6-b73e-4d37-9085-0b78c2800725" },
                    { "TnnhAwANv8mlu0rTGPTp", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6831), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kalina", "d8945ded-032f-421b-96f9-69455aaa661d" },
                    { "tNXHpRIbWJQoSg9w0h0u", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6473), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lupo", "211d8659-f930-48b5-9aab-cf99457da908" },
                    { "toqe5WECT1cTuXJlgGR0", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8422), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS6 Avant", "bc3b5b75-2a87-469c-9fdd-13417ce835d9" },
                    { "ToUKRbX1EojTwH2QWzbo", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "218", "def192df-c644-4cb9-8bd5-e5a37e5ec325" },
                    { "tpEL3EMn5PuCaNYKvchd", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3336), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rs", "bcb5285b-fb1d-4202-afd2-bff4388d1def" },
                    { "tpj2fsChmbQSAdlyHB4H", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2987), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand prix", "7e8a8030-c3f2-460c-bffe-bd1342365241" },
                    { "tqeQFdruxvq0adtf9J1g", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xlr", "c06b4e21-e377-4895-9f14-ed69233154c9" },
                    { "tQhPqR2HMUE7AMgHkYxU", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6357), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CC", "f953157b-7744-46b3-9e0c-c811b1b1ec5f" },
                    { "tqX7X21Bw7YA4PoplBoq", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2203), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Frontera", "302710e6-d2ae-47c1-a339-1b231c523497" },
                    { "TRjIsnfHN5NsWuj06X93", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q2", "b1016e0b-95b7-4dd8-8a1b-69ea4e890a8f" },
                    { "TSKI6JvXBQB2wCL1kFrz", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3701), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scenic", "041c9092-9630-406b-b929-da19165e7c31" },
                    { "Tt1A5dQo3Wl1lN2L09Aa", "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LF320", "d6d4a390-f34a-497c-b62a-8dc627939989" },
                    { "TTl03BUTe03UrN48K5lT", "Xz43eo1VM5H41uNJ9x28", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7173), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mf3", "f5cec629-1119-481c-bd2c-c0bbfad9a7a9" },
                    { "ttPpC5E43I0zeumFVm69", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "340", "96a93194-6637-4adc-9989-9bb173e2bf7c" },
                    { "tu3sv7IXTXeNVkMhr82a", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8247), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-tron", "9f1ff282-5cf0-4b06-847a-d8fdcc54d203" },
                    { "tUmqqt8lsWAVVkqeDYLJ", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5086), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ix20", "e0d0e11e-26fc-464e-b3e2-293ad2ec09d3" },
                    { "tUq6K6oRjUUQ9jsD4cu9", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 3-series", "1bc8563c-4bea-4f6e-a7c0-8c7e7451cc81" },
                    { "tV3TBAw0q01Dew9gkv0n", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cielo", "2fe7aee3-8868-4ed3-9665-4b2e7e2a0045" },
                    { "tvoY5XQx1D9jQqgt0MXP", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9027), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 230", "00697400-b93d-483e-a7b7-4aed5f28ca0c" },
                    { "tVrAtDuYjo4H23gs9K6l", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5915), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F-Type", "1cda3f5f-05c6-4376-992f-d285937e00c4" },
                    { "Tvt9bYVjN2rgWN5f6K27", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3520), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Clio", "153c7e9f-3250-4f10-ac00-50203b5fdcf3" },
                    { "TVv24z2srCBnBBIledu3", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crosswagon", "a78d5e2e-87c3-4ce1-8cc5-6d18196a1ab5" },
                    { "tw45Wkr6eW3uLkfhQUms", "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7191), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Discovery", "11f32d3a-2a1f-4be3-b6b4-8a637409f36d" },
                    { "tWaur8qLlwSWT88qhKBH", "RgqbbBCJaJLWTlu87M9R", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3267), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3", "193bb828-2b59-406c-abf2-000050cd35ea" },
                    { "twgNlbvRaA2UK9BWykWP", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9648), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BS2", "68eddaed-ef12-41cb-8e11-9b3688f6285f" },
                    { "tWrcKI6T2UEP6aIYqEAQ", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ace", "8b212950-8959-4072-8cf9-98363d54d3f9" },
                    { "tXgT7FnVWCppJ9eMJVq3", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6588), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1200", "78545358-8219-46cf-84aa-2fd2e71a444c" },
                    { "TxJ6BQA3y2lr3nUIhqwF", "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6183), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Renegade", "d3bb04d9-6edd-4861-98bb-fe7709f9c549" },
                    { "TxREfWMQKXuxu0xKSzJv", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9658), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 50 AMG", "59697b79-01a6-4490-90cb-7ee463d0e923" },
                    { "txWBDPG82BPMgPoWGByE", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3205), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Panamera", "a30c644c-244d-48a4-85dd-6bfecd3822ea" },
                    { "tXWN0dx6hhoPFqHT5Dbd", "Q6kJ5uDgBmklCCBwofrx", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cevennes", "6a5c1ec7-3b00-4a24-a386-a1cd7df46d54" },
                    { "tynwIbwkzJAYkXscpf9K", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9675), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 55", "37c0b904-7f21-4cde-97b6-facecd967f4a" },
                    { "U0MHNJeBhf93FIcMuMcL", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3279), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "11", "92e0bdc6-ea97-4fbe-9f91-61f8148e3a9d" },
                    { "U3pSUyUMYR0MHGJcKpg5", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1809), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pathfinder", "4554a2dd-6eea-4f04-9cc3-1376b5221705" },
                    { "u4CAcI6QeF5Mr7qCcGlD", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 63 AMG", "4013db51-7791-4a87-999e-35d6302190f3" },
                    { "U5AhJIItQ1Rc7zaqLqyV", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "240 z", "d6888125-5b92-412a-88f4-97f8efc16ee9" },
                    { "U60evnMEw2hq7LcTRdFg", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Enclave", "bc181684-9761-4da6-9255-569069bf2e07" },
                    { "u8VJf42WF5rok89TS6UE", "7ReFhJXxyx7pAkvlW1eS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9637), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hansa", "64a7ca2a-c1fa-4df4-ac03-1738a3eee91c" },
                    { "u90wvhUQzQFrP9BYMWLN", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C - Zero", "ce0f7d09-7ec6-4819-9ce0-f8c6f3c29c04" },
                    { "U9yl3EkWEYsxfdMm8Hcw", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4702), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fabia", "ee2ce00d-4d6d-4a82-b6de-34c2f9fe965c" },
                    { "uAfp8PqfB4GQHWtFP6EJ", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "560", "2a6a79d8-249e-428f-9a57-bc5c35ad500d" },
                    { "Uarvq5K2extkAXqcxnc1", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(555), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Town and Country", "9a1a5901-15ad-4f21-adfb-3becbdec1846" },
                    { "ub6vRqc4FJbcE9zRMTpl", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jazz", "6cc1550b-8d84-449e-b884-192ab8fad607" },
                    { "UBD2njSwTorvp0zkbQ3r", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Espace", "6dd2ac0b-d421-450f-80ce-e2a66225c921" },
                    { "uClnh2EEXkBNKzmVdv5C", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7994), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DBS", "3752f66e-310b-4d2a-8d33-4ea754596064" },
                    { "uCQh7CCQgBPnBotB2ENc", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(287), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Silverado", "1baaad98-513e-4d6c-b082-2b4148e50b16" },
                    { "uCw5rMIJ9ewIW0aL3gvf", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tundra", "a223b588-6310-4d20-86a5-103d8ad0ec72" },
                    { "UdRGGMM4lNXhKPueMNEE", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2800", "f95aba06-e34a-4aca-8b4a-c41b120c35ab" },
                    { "UDSzEUmxqDPMIx70nXDB", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(188), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 63 S AMG", "a2c0432c-efb9-4408-add2-6a900bf54010" },
                    { "ueoSh5P3sny0vsBILShn", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Everest", "374a253b-b85f-405d-921a-0cf3b83a193a" },
                    { "uER4NAX96odPtWC7PWSv", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Joecs", "2aec271d-b354-404a-b7d5-7a700014b22c" },
                    { "UexN7sGkGntVdfd72QAe", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3377), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Streetka", "b6c63e07-00ac-4c37-83e9-a8005a5c8656" },
                    { "UFmPbQDykSobkYB0IS5g", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1515), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Materia", "623a5f73-32f4-4043-aeeb-41b42d6d2935" },
                    { "ufsg7jmSmn9CV7svkUT2", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2029), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "812 GTS", "51abc4f6-a06d-4962-9c89-9fb43afe98dc" },
                    { "Ug3mHfGJ0278ePoQrof1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8754), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "135", "a4ee6439-b608-4a17-a8da-1628aa8a2756" },
                    { "uGRsrRRUnKB73GLcx9tJ", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3912), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "214", "aede8aaa-ad56-493c-915e-461ef22654be" },
                    { "UgXP2x5kMTH254Pb1Mwl", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "45", "9bbd6338-8157-493d-8840-dcace37c85e6" },
                    { "UgXyLuUvGDCYzNBlK641", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pixo", "f5c3dd6e-3b88-4e9f-a381-72ea43a41afe" },
                    { "uhcfdI4WHyCIPTElhxHY", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Twizy", "92bf4fc7-20d9-4a86-b1fc-dbd39d799211" },
                    { "UHpuRUKALngwz4SaEHMP", "B42TXsELwNJNBewRvcu5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9985), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tigo 7 Pro", "698ae44c-8f4b-4287-a9c7-169abeea5289" },
                    { "UHwGYP11HWnQcRnpJcax", "QojugShL0F4QRXbwv1r3", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2922), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pickup", "432b1431-f4a8-40a1-b092-32bf0be9715e" },
                    { "Uhxj20LCIPbk6J39Dtfc", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1526), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "503", "dc74f01f-065f-48e0-9242-675a6db2b24e" },
                    { "UIpHr4PhEMCHnnI07PP6", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9504), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 200", "c2bff04f-90dc-49b2-b63a-e6d95a9d7c93" },
                    { "UJctHy9PTF8qXB4zpqht", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2404), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Argenta", "ab173ee4-7bb7-4e20-99ad-232fdd16de08" },
                    { "uk4w64lGMpyhMVMK8seK", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4663), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "120", "03aa971e-3f08-43af-be23-7bbef6722ed5" },
                    { "uKoDelsUrel2IbmyXNYX", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(731), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 63", "7a2f2804-56ba-43cd-9fc2-6abf79893f89" },
                    { "UKvoIV9gLesfLsP4Me21", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7180), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zeta", "c7eee033-d1ad-48d7-aa62-7d8f2e7f3da6" },
                    { "ulChmggPykuGpjVuFERh", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2034), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "812 Superfast", "fb1405ab-ade4-4a10-bfa7-2d977f1ba07c" },
                    { "UlfftWK0PGFyCkct2jtX", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8618), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allegro", "e830dea5-736f-4ec2-baf2-4b2966ef1906" },
                    { "Um5LAMFDgYj0UKKBHzfS", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "418", "fccb8d41-5ad4-43f1-87cf-49b691ab2d88" },
                    { "UmN24r32N6YMDtcE0gW0", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "535", "3aad37de-6832-4975-9246-c155acef9236" },
                    { "Un8ryqzs2joNHlGBg8cK", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(159), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 450 AMG", "85770c67-e517-492b-be3e-faa12f224e0b" },
                    { "Unplwtd4MhcLEBAQAaXy", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tb", "20950a86-ab6e-4ff6-841b-46d628408535" },
                    { "UNq0HGJzUbxCSCcfgK2n", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2455), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2008", "d3d240a5-3877-41e3-a9c7-9e0470b52a82" },
                    { "UnqS3KUtnoxwgkLEJhq4", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9380), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 300", "23f1f84c-d9d5-4966-b3bc-4e3d20babc42" },
                    { "UNYLhaGu6dV8Htj2DthC", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mpv", "96ffde0b-8b51-4725-a883-6ce4e54c6bc4" },
                    { "uprvzvTGTwlY0jfjjlwj", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1289), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chairman", "18185604-bbb7-40db-a0b1-38522354ee52" },
                    { "Uq9HxuoSykHmqB7KNKVm", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9872), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Brougham", "9f0cfefa-0ccb-411f-9687-658af08c1fdb" },
                    { "UQYNYNg9ymUbKzE29n55", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jimmy", "0f41c1c3-4273-42c3-ba32-401cfa91293a" },
                    { "URmPzEV5atxfItUK0Brt", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2130), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Portofino", "4b9ae286-8af0-4f67-9cb7-525c9d4208ee" },
                    { "URYCjhXfzlgL59FbPKG0", "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6174), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Patriot", "41731b1c-fd1c-43ac-984f-5d70eb2b735d" },
                    { "uRzxsLx7emlaYVhLareV", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9539), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 270", "48211c66-dd4b-4462-a84f-e8792ccb34d3" },
                    { "uS9mHD35sXdKDry71e1L", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 350", "04fd907f-a89c-469c-845a-0c51b12efc67" },
                    { "uSPsDvdFlrVa66ybBgs1", "MlFe1uw8xqqhdAUnqcHd", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7907), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Murena", "8fa65395-e702-4c0c-8ff6-5bf257e9a75f" },
                    { "UtqSPEAq77WWpogT3WML", "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5307), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Horizon", "d112109e-c892-45e9-817f-36969d099562" },
                    { "uTTJxCGf37uD0IECmLUq", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sc", "1dd5966b-771e-4c83-8714-fef5f53bbec0" },
                    { "Uu9sfvel6Ufx065YB6xf", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Serena", "8113f604-c047-47f5-9e4e-797db652044f" },
                    { "uUYqDjbuPX9uNr16denc", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Altima", "c80742da-aa79-4120-ab68-ccb956637354" },
                    { "Uvk3tEDoP9V03hhedGEB", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2760), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rifter", "7fffa74e-5687-4fb3-9ed0-8d5b01c00c64" },
                    { "uW7yaRvgv1RucfHtYNMX", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cuore", "704a5d34-aee0-4fbd-b1ac-cd12df13e43f" },
                    { "uW7YplaUw2bzznAlTp2k", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(665), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C2", "7db7c76d-e4f0-449b-9c41-e03e0ba3d73a" },
                    { "UWAl4aHhqffR4pa3Bhnu", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3734), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vel satis", "c95837dc-b2e3-4f32-a407-126e45517861" },
                    { "uWtzM359YM9FgF4oLTAz", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8512), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S4 Avant", "7f72a9e5-828c-4f43-ab22-67b7d8b8c060" },
                    { "UwU8jhaEaN3FBd7VARhj", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6572), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Visto", "7bcb9942-4101-4ec1-9a01-6bcb8ecc737b" },
                    { "uxjUlJ4QQcTdtzw99Wo9", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1510", "000fd6e4-9e0b-4f8c-89a2-e73a705d8d10" },
                    { "uXWboqwr6BE2uUGaDRz5", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2732), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bipper", "91b2c883-f285-4ab9-9b12-ebbc8cd86b6e" },
                    { "UytSoVYnDPLzk8SzSGcG", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1594), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "350z", "5cb8a9bd-1dc4-4c92-b780-5774c7155f83" },
                    { "uzwojqgqpfpHJr5b95f6", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pajero pinin", "ca9778e7-5822-4671-a23a-dbafaecb375d" },
                    { "v2drFV4EY1IQXXXM6xlu", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Voyager", "980b8310-1eb2-432b-8ebf-cba062204c00" },
                    { "V3kvfSwlrFTEcew0WFmU", "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spitfire", "f3f80e07-08a9-4d1d-a9d8-75fd73d5a270" },
                    { "V4cfjcQRbIFpfm2wXj2l", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "414", "b8e66e55-ae68-4abb-8ea5-e96939edf5dd" },
                    { "v66zxjx7spY5Uvzbu1n9", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2789), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aerostar", "85f4d97d-7030-4fe8-8ff1-99c22b042888" },
                    { "V6faggwTYECaV8HB72WK", "sx9Vqv3yxRnX4SGwQa4y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4305), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vue", "44caa3f9-2e57-4015-9a45-0bcd18c6778f" },
                    { "v6hW5bCQupsCdBqbXYaU", "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7352), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1105", "a13266ce-67a1-45b8-94de-daffe7df5b3f" },
                    { "v6PQ4KI00zoTufKkQNf4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9213), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750", "d50c8bdb-ae76-42ff-a0d9-8e90b622f72a" },
                    { "V6T83go78C23q7tY2Edd", "k4Lylg5nrM6Vt1MrWfxS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6221), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Montez", "40bdc2bf-cad6-4acc-b38d-d7b242c3cec6" },
                    { "v73LtYfU6It0eQmUwuBo", "etMtb4JLm7eB90mlnd72", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GEM E2", "c96fca0a-6b34-4f49-a6b6-2fa168a32f7a" },
                    { "V7XlhyU4LQV84zthLqEs", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "306", "985c0f46-4834-4145-821e-23c4f3cc8638" },
                    { "v8Bx97VQjXEmrXR6D3zd", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9367), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M135i", "5ba1a36f-fd12-49b3-9d06-665b6752ad37" },
                    { "V8qAr7McLxC4W83nVRkg", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(878), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gx", "27f99feb-a528-4132-911d-f01fe5107c22" },
                    { "v8yTa4mNlDjSngeRUSze", "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Siber", "5041194a-e37f-4ec4-b0e2-33b55932f477" },
                    { "v8z3JcQ6BIQDxeCX1bEL", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Landskape", "01e2c606-7391-4231-b635-63465963ce04" },
                    { "v9ENMIVUL4mcGWXnHPev", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4618), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nsx", "a8708eb3-38aa-432a-883d-89f11390718a" },
                    { "V9yQbPQXTz7nKT5gUxCu", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5659), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Celica", "26cf87ef-b57c-4301-8033-94c97209f104" },
                    { "vAW51kGEIcxp9JDSQM9m", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Uno", "1a29089c-c276-4518-859d-64698647b1d2" },
                    { "Vb11wgUDNHt9d9VCLzhI", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2052), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Intrigue", "cbe7dae7-a1b8-44ca-9702-f0b26257a2ca" },
                    { "VbaalFEyblykk7KRFohc", "bymbQs0TabKzPsrN3TlL", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C06 Convertible", "4e8c73bb-bd02-4a0a-bbaa-840066393ae2" },
                    { "VbfuXoxaYauYhkCrhuN5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9512), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X7", "60bd6b7a-b6e8-4cd3-8241-ac87222785d8" },
                    { "vC78hTB9XT4enMMbl6LX", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8248), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tribute", "224e3d7b-2059-4585-996e-082d721b3fb8" },
                    { "vcBK2mT8dAwyAd5RV3Ny", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8142), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mx-3", "db53bf3f-16e8-4fb8-be1c-2007e93886e0" },
                    { "VChRVCEVVp4LRH4SqjNP", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2632), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scudo", "475c5c77-f919-497e-9dff-2aca56493ef0" },
                    { "VCNcHFvv43dm52seTXrG", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7318), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LFA", "dd0cc8b1-e753-41f9-bfb6-f931fc96ef54" },
                    { "VcsoFJhQCbuFbczKLXz9", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9860), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allante", "41403978-d3e6-4d94-ba7f-aeb920c55583" },
                    { "VCU3hzQMs6a5WArCulAG", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 200", "52dae10a-7d42-4ab4-a9c3-d37965ff4ced" },
                    { "vcWyPaE8A9tB2ESnb0Yu", "lgRSEHsdarS0gC4osQWQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Elise", "084fe950-7466-403f-beab-98df71f37680" },
                    { "vDKn6wRttXQVNEkEX7dI", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7054), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Flavia", "a49ce339-cf56-4fbb-9daa-8bb7061c5f9e" },
                    { "vEN6Qd3hTcEL5EV54QIS", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zephyr", "0409e0ac-c35a-4224-afd3-bf86072af30f" },
                    { "vf62QRGmbs2q7b2ndvqJ", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sedona", "92480b6c-9883-46fb-93f1-c8f082b598c6" },
                    { "VFjcH3R65xRnGrThKMNL", "65B72rCez5bGWR7Po3Ny", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9607), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Coupe", "920af3c6-f69d-4e53-9d37-c99d47d7c86a" },
                    { "Vft9WXYwVtxwpCP1EUSp", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nova", "5c316046-b351-45fc-b1a3-8120a3a111ec" },
                    { "vfvMnPRvH4o1zvfcd8oy", "T8karRTfSTcM29oupBnt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4323), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xb", "f2cc1478-5b9d-48d2-acc9-5e3d6190090b" },
                    { "vGgQAVg4UKXkoXjFN8oD", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5058), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Across", "dc6c7e1b-7aa8-441f-aea3-6f956bc48fbc" },
                    { "VhFKTYyFT9ox6yCMp9r7", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H330", "168992dd-f829-4f29-90b2-81118733ae67" },
                    { "Vhl9sSAKXhD3IzgY4T9W", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2366), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zafira", "b3af82b5-40f3-4d87-bf04-9dcaaec308c0" },
                    { "VJ1qkKtGhgPnG7GMpgpw", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6972), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C30", "a527ece5-e2c2-44b9-8922-3eed900997e7" },
                    { "VJrkMWwgcT4qXeo9Qjnf", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Giulia", "43a65fdb-d277-4567-8dc4-98ae692e5bce" },
                    { "VjvSARDRWkbJP7UAyrow", "ghyFhm7jzcjYDrjMVLs1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dargo", "35b925bc-6186-4b89-9375-64b2bde6b307" },
                    { "vK9GBxC6AfuLQ00YIUaH", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(253), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Matiz", "f8d7e1de-dad9-468d-ab9b-e16603920811" },
                    { "vkVnsW9wc2aDf1J1x7Cy", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2118), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Antara", "d79b6af8-a16d-4c0f-a990-cc83cb14707a" },
                    { "VlemjAzETCrhmMKh2Uv0", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4643), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Passport", "a0afb324-a5fb-4644-a56f-41a744edb451" },
                    { "vlVnrtyKFLC07r9wgae9", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Town car", "f8b3bfd3-e7dd-4702-a253-3caac24aaa0d" },
                    { "vLWpNb3NcK9Ubffxa5Ke", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Impala", "0f7917db-0a30-41a1-92ce-9cbb79d62bb3" },
                    { "VM1fmr0lIrzpSwzt14dm", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2715", "2f2c762f-f2a8-49e5-8ea9-72333535aa29" },
                    { "VmJ0xSGEGA57wNWycd8b", "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3831), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Silver Cloud", "754c53a5-d05a-49f3-afd6-76cf8e2d644d" },
                    { "vmxHwfvyKkJNWCWtobKW", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1915), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stantza", "b1f8d57b-063e-4887-9871-b8b1649f511b" },
                    { "vnYtzXze8r4XTnumyKlz", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4683), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ridgeline", "426be5da-0119-4ee9-9ac2-c755fa8ce25c" },
                    { "vomDhzwtlUqQx0arJA57", "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5826), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-S4", "17467a35-fa2d-45ac-bf6b-868b213ca7d5" },
                    { "Vp7yofWGPECKMGmhXTJt", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(643), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 430", "824de45e-73b1-43af-b92b-9b9f507f809a" },
                    { "VpGPIouSRYX4cFVRK7IK", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(916), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "T-класа", "a791d962-a281-4a7e-b6f4-ed720ee002b8" },
                    { "vpoxmT2xytRy8wbxfBfu", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tempest", "804b1c7b-fae2-471e-b8f8-24350d6f3217" },
                    { "vpPATy16Ih7c2TPkqKB7", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9646), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 430", "d1bf840c-320d-4aab-8c8b-f16fde32e66f" },
                    { "vPYG1xwxNR8dwvdIPcF2", "SGKURGhEbYHIdqkxpDJh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4153), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F440DCI", "39be84a9-7b3f-4d8e-aa09-1bfc29776194" },
                    { "VRCP8yrUtyBBI8FmMgxo", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(49), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aveo", "8141ae01-7099-45be-9ad4-b10e236a7d5a" },
                    { "vRdNhK4gD6SFkDCR3tWf", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Giulietta", "7ef3acec-727c-4512-920b-fd6e189ad511" },
                    { "vRHBHpHoGxNQLluWd4HJ", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9731), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V3", "bf408f55-dbf5-4d61-ad6d-2755179eeb89" },
                    { "vsBxu4vopksWQYcNL1gV", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Is", "ac6ce1cb-2359-4f72-af3d-c533472b18a9" },
                    { "vSSR3SXCsG99zJJ2WhVz", "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Solara", "c494a586-0cad-4ab9-9d78-9ed4099e8284" },
                    { "VSXof2PzVPNpI3XRYItF", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(933), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spacetourer", "f998fcb3-c012-430c-b91d-e19f1f4db0a3" },
                    { "VT1bc5HYgbdzFFourQSS", "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3", "73abbbd5-2eba-4fa4-93e2-264c3f657b95" },
                    { "VtKbVrP5IhN7rWn5Dded", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6399), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Golf Plus", "f30ff775-5139-4d8c-9f11-3a134cdd973c" },
                    { "vtPf19oE91VzTJH3WWon", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6543), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scirocco", "2b9d6371-9813-43de-92fb-d44856bbb136" },
                    { "vU5pYs8vtMU3b3gxoVjv", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(584), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ax", "0dc1c042-2f68-4043-9d93-337c854c0353" },
                    { "Vujzw4Kwuds6cl3wqb2e", "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "968", "4a58a1b8-e335-49b5-aa7a-a1894806406f" },
                    { "vuRSlkANT3tDhMAu7o6A", "W5TnArCA9xCEodsTpDHG", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5497), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Model 3", "62fafb88-db4a-4e44-bb4f-d8c3d1c9abf8" },
                    { "vuTAjhjSpDgDR5lYH2bP", "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7434), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LF520", "b28bde00-04da-4093-9d62-08463694ae35" },
                    { "vV24TdCy36BxX6Ner4kP", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6072), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2206", "aeff0a22-f5ef-4c64-bbd3-4e5063deb251" },
                    { "vvcu2nNXx0sVKMn7kvQd", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2545), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Idea", "bbf5863c-1647-41cc-abf1-b76a2c9e1471" },
                    { "vVj51IHlq8art8VmeCK7", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1907), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Skyline", "f97a262b-91c5-43e6-8968-531291ae0ae6" },
                    { "vwmvH4A4aNhITbN0HYFs", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9799), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Park avenue", "fdc6cb46-98ee-4f85-9649-dd91b6d6c62f" },
                    { "vwWB1tpydD3eC1NWfrXR", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1745), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Magnum", "cce758e5-3e1b-405b-868c-d4a2d563cef9" },
                    { "VXALyC284WE5buspguQE", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ5", "9d0e6b8d-6c54-486b-9406-641ccec4c8f1" },
                    { "VxR5cjvCj0MbXf8LItbG", "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7688), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zt", "9355fc11-15ca-4117-b454-ffa2cc3b59c7" },
                    { "vy6HNPeGJmHKuXCnVP7m", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "518", "0b967aaf-6637-4cc8-b98d-39b0b8adcced" },
                    { "w0CNVvdpYe0MB7GjEtbM", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Excel", "e2f1e186-9e9f-4d3a-ae45-042ca629737c" },
                    { "w2997DoRBTIYfeXNpNhP", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "I-MiEV", "cc9ad4c6-da27-44c4-8f52-ffabcdad3e68" },
                    { "w2AcTsyDRIFue6Rxjlqy", "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1310", "ea5c8862-fc55-4fff-bf49-6e0572d954f5" },
                    { "W2foEIu1jwPT8f3tQxel", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1833), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Prairie", "82e1e4af-3216-4b71-be06-5d06f51d5797" },
                    { "W2qDQYww8EKbqFBDVShS", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S7", "f54d771d-b9c3-4e8f-8a0d-a97b00b1468a" },
                    { "w2UYPD3cdnDq7hztq9SG", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6171), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "69", "282c19de-3580-4ba1-8e69-bd97d015bdf8" },
                    { "W35BP1xFYqywB6CdgWM5", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SL 400", "7560ca57-7043-4a4e-808a-088a23e2e545" },
                    { "w3F1AhC5Ruhpt9Xxdv4j", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9578), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 300", "76a0ba3b-3382-45e7-b955-a3d61c4e3e27" },
                    { "w3lrKMLYH8uRLy3JnNGe", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7111), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Prisma", "e3c779ff-d278-413a-88e2-912cde595a63" },
                    { "W3od7XKspFA0gAlYT4ud", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F430", "4e2fc3e7-6c2a-40ab-bfb9-683b94b479a2" },
                    { "w44TKwrzHgneTEezYjrh", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3444), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arkana", "16ecde84-5764-4c4d-b784-cb13600f357a" },
                    { "w4DlS8G9kFHPl3oSuItT", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6505), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "New beetle", "85d56293-07cd-47a8-a1a9-a78aee69ac2b" },
                    { "W6TgsF0fvT8K6ceEPhQd", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1276), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pajero", "48ea13a8-3e04-42cf-9e2e-65dd19ae6d96" },
                    { "W74D9AFDxjrmBKKfJyRd", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2110", "2f118227-5798-4dd2-b73e-1a3626ab8474" },
                    { "W76Cxo79xRN5oPoFreld", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Marshall", "743e675a-f4c6-42bb-8fdd-c5a040c5fa35" },
                    { "W7B7KzrJGrSWcmjYDR5N", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "325", "628e75d3-1bbd-4ca6-85b8-ea822d14434a" },
                    { "w7pGouRms3Uq5JQrNvrA", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5953), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "bZ4X", "088b41eb-1457-45e0-bb55-0a618246cd64" },
                    { "W7rQMX749avrjQyR2huz", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8992), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 5-series", "9a9a18ac-f7c1-49aa-b775-babdc1f264c9" },
                    { "W8KkAswg7KqvkacAFXCl", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(331), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tacuma", "b91ce4de-0c6e-48e0-8751-093dc8adee2e" },
                    { "W993k6U0rs14rDmGXgsS", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2142), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SF 90", "a374c770-70a9-4267-9759-1ec97bddafc8" },
                    { "wAAUhost42enVo1eIcgV", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3894), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "114", "a71d6668-c60a-4cf0-a743-416c7faed5eb" },
                    { "WabhoS4DQ1hNjSJt79CR", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(655), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 500", "9cc9d995-8ec0-40cd-973e-4b9b1ab9bb40" },
                    { "waXazzmqA5L7d5cIgXB3", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "110", "79b6ea89-f8a7-4884-bc60-14c049e0096a" },
                    { "wBFs5qH2yqxp5Ah7RKNd", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "305", "5fa7853a-0f42-458c-99b5-b889c10db12d" },
                    { "wBovrNJJpzB3gp9fj0Cl", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3250), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mustang", "fd87236c-f561-4578-b20f-f5b5ad8662fe" },
                    { "wbuckmXX4gXWkf9AGEH4", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9033), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 240", "19d1dc7c-68f0-4708-9dc8-264116ea31a2" },
                    { "WcEhTTB3YUve65qw5veE", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4446), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Marbella", "b9347cfd-fbf7-43b0-ab25-ca138f5bc60a" },
                    { "wcMV0QRnlD78f1QYd1CK", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C15", "cd923b2a-5fc7-4002-a133-f58cb1f0543a" },
                    { "wdDqR4JFMdn17FGMXkjb", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5215), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sj", "cdf442c3-4328-4250-be40-2227bd51e7c4" },
                    { "WDJ73zfFtfGjIXtef0Tn", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7343), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RC", "d870d177-a3b7-4a3b-b862-246bd4496382" },
                    { "wE81hX6f965qzu5VUolh", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8429), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "114", "f59ee81f-9d79-45a5-9a36-b47aac09ab68" },
                    { "wE9706nR2cjvM8o14cbR", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7916), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B9", "8038518a-9f08-4d08-b9c4-1f0d4f9c4968" },
                    { "wEBMh3aEydCf7PezTUCF", "QojugShL0F4QRXbwv1r3", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2947), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Polestar", "bff189ca-d543-4735-9d99-59d327ff2ced" },
                    { "wEgenjvQDFaFXjueg09u", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7935), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D3", "082bc471-efdf-41ef-bdc0-bd01fd9df056" },
                    { "wElgvFBxFpbh62bkyWCo", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7452), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Slx", "8803b737-0116-4da9-b094-23597c756b99" },
                    { "WEmSDePUQfYEphdLQ03R", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(148), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 400", "9f58af74-5eed-4574-9859-ccb3447237ee" },
                    { "wffmePAbJgWS9lGflAl0", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9003), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "520", "f7fd2076-2d2e-4a56-8d81-d440db37ce06" },
                    { "WfrTjyJs7RdlkcMmJTcG", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9835), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ATS", "cd294c88-6571-498d-aaa9-475537aeb6fe" },
                    { "WFSxGM4VGEH6M5T6NnYD", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A112", "0f8eae7b-99f0-4810-9e80-47f7f6cd7736" },
                    { "wG9HY4bNJf1c8FWMECtd", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6039), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xjs", "61757a3d-697e-44df-85ff-c46c452dd3b6" },
                    { "WgSz2hq1G5PPx5pSx3JN", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7046), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V40 Cross Country", "1e3e0f2b-19b5-402d-a82f-80e0e0e53e29" },
                    { "WGTzNxl2HD38xKpTq94p", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(965), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xsara picasso", "2b549bb2-3ca9-482f-88d5-576058f3b237" },
                    { "WH8oqF8cgWBvu9e1CUGA", "Fjw2xBL9BqCaQBzxcxDI", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tracker", "dda9e199-ff16-4646-b9dc-eebad4f56e14" },
                    { "whQs7vmo2lqwYFp30RTX", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mulsanne", "c18c95e9-c3ab-4849-a7af-ad55bdf76b68" },
                    { "WHxSrV5rjXNrtPdVlXS0", "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7445), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "LF6361", "6e0ab586-5047-48ce-875e-22f812a86472" },
                    { "wIlsITp5oDAFVLjYGUVQ", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ8", "515e938c-f146-4a8b-af30-81f08b49c274" },
                    { "WISmLMGkJjavxRFAjhej", "gXuBjVjveGKf3R9Kc9vE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4140), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trojan", "d422602b-341a-417b-a3c8-90883361e03c" },
                    { "Wj3PTpkwEwrrlfsJxQ2F", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9131), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 63 AMG", "672a5759-99c4-49b7-a285-71e0dbad100c" },
                    { "wjtx76gjYBtJwBvXBnXK", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6783), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2108", "969ef83c-193b-46a7-9e9c-f009b6ddc92a" },
                    { "WjxncPltWC3njMAjcoke", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLS 55 AMG", "1263bb10-0373-44da-b116-7210846be0c9" },
                    { "WKIV38qyYnxIUWUNI56I", "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9666), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dolphin", "0c2c52b6-3480-4760-b9fd-cb44e9318e7b" },
                    { "wkoSNlxhRrtWJ1REWVQV", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "435", "8c152b08-3f41-418f-b6a2-f13bfe81650c" },
                    { "wlDHFK26eNGSQNvz4Ny4", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F456m", "e15680d4-4071-4aa0-b589-a545ec2ae10f" },
                    { "WlJ1WkwVQwcCS1Rsa1dY", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7490), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tsx", "e0c1e9e4-2a67-473d-8181-1559f3b51113" },
                    { "wLU7yhtpzDUGhx9ewgUV", "R9BIHlzCwb67GPT89e7F", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3250), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arena", "298ff36b-42f8-4576-8e3a-eec84ca72653" },
                    { "wLv7cSEP4zdn2M1ULy3I", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3917), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "216", "b23738d9-0f27-4b80-aa6e-929a584b1b66" },
                    { "wmDuQDMeaMd77q1FbQyG", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(366), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 300", "74e6a62b-422f-49e3-85dc-f70273462aae" },
                    { "Wn5VdG7MIwbqQU2RjRSE", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(164), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLE 500", "6290c1f0-f5af-4b55-afa1-3775c7249def" },
                    { "wn74Yn64jBNUKYLHbqHK", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2298), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1800", "ef430b50-897c-40a1-b398-175f78734250" },
                    { "Wnn01mAWrHrWr0ecXBJW", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "111", "82fb6fc1-c9a5-45ca-9804-d3ab63f1a4c7" },
                    { "wnxsfo7HqMH6hCLrE1u7", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2477), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Coupe", "b4ec7f77-29af-4811-84b3-bdd4c03773b1" },
                    { "Wo04np9UVtsdBdRuRTAj", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2556), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Marea", "6509a405-4b51-4f04-9807-d892483498bd" },
                    { "WoEl6Aa3YHufTTjLsCQa", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2638), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sedici", "349478d4-047a-41ea-9b61-493a936d7449" },
                    { "wohn7ElJym8ll4eEGt2t", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2998), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lemans", "032439b7-6e8f-4d62-9d42-ffe151e63b3d" },
                    { "wovY1t5YBKtn0rnqgrT0", "SGKURGhEbYHIdqkxpDJh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F16", "f3bbb50d-6e37-4148-a59c-20ca398d7270" },
                    { "WPjk3C2bX9WT9yttVt2E", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1230), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lancer", "d13f5865-eae8-4b68-bb74-63b748414f8a" },
                    { "WppN5h0a93jIHISmBU2m", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9452), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All X-series", "da1c4173-b14c-4479-8bcd-f1f5beb728cb" },
                    { "WQjfcp7MTFg0G1Swjv3R", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3984), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "418", "47ae0784-3fb3-4b32-abfc-50272794f5aa" },
                    { "WQnycgFV2z3cH6CkqdNC", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1456), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "401", "95ba7498-a74f-4bbe-af38-e91fef7d8a30" },
                    { "Wr1CLokye0t5Xj9lJYLV", "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7289), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gt 55", "fefa604e-5bd6-4676-9a0b-8828f99ea814" },
                    { "WreV6trS1putcSjuF4BN", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Goa", "4ed78344-f477-48a4-9ee6-ae43c0d3f55a" },
                    { "wRfYIFpYgK0TPXQx3EG2", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "260", "96c98545-82ec-46f2-9cad-14d9f19a9611" },
                    { "wrQ4n1PCEuDMbAKSg8qA", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2714), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Topolino", "6acd7d3e-724a-4add-9d75-b97e749ca187" },
                    { "WrruWfJUcpY9ztLCasww", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(441), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 420", "be1906a5-f476-4713-aeb2-dfb975a78c4e" },
                    { "WrV5oQM6mxDtXl0WuanN", "XW7Xpw80z3VgX82egcWN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "311", "ceb9fb92-a051-4985-95c3-14736f64fa72" },
                    { "WSBxgKTxbD2FtgafMgj8", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5592), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "J", "f24448ab-19d7-4f03-a922-d95a2c190ab0" },
                    { "WSDvNroQvwM30RBwX2V6", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aygo", "aead1b5d-20d0-41a0-a1e4-398ee78f6de2" },
                    { "wSVDH4kuXntqqvCwYDhU", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bakara", "461ec366-0694-4a08-8bd0-7a480cffb83a" },
                    { "wtcmfYxwTqvDbQGfrEYH", "SGKURGhEbYHIdqkxpDJh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4169), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fun Lander", "8ecedf40-49c7-4e1e-98f8-595f3fa4e317" },
                    { "WtMgk45JBTfN5sYYEHd6", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Yaris", "fdb61f3b-6adf-41b7-a0cf-35f7a4936eeb" },
                    { "wU0CosNH5qb3lJUuu2Pu", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7052), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V50", "12b79989-56a3-45a0-b41f-3b84ff9ce3f9" },
                    { "wUnerQbG2jj2Nzvg9sXl", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1208), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Liberta", "2d1b442a-f164-465e-bffc-dacab9658b12" },
                    { "WVdNo3ACJ2jlkGw8LcsW", "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Century", "c8521007-7c3b-4448-adb3-a8a9329e276d" },
                    { "wvvnl77Hn4TeABwJ6Pbw", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9120), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 450 AMG", "ef067090-d28b-48df-8bee-38bf4f822274" },
                    { "WvXeDyyWRb0I9nR6e7zx", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Telluride", "5a203282-8cb7-4bb0-8159-bc114656fb77" },
                    { "WwFDQdPBSbBSep2Bprxu", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8306), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "675LT", "21a544ab-6fa5-4689-ae1f-cf3134fe9025" },
                    { "wwLX0y8ujNBj1fgLKI8f", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9983), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLA 220", "637fa924-8103-472d-8907-44586fee082e" },
                    { "wx8YMsJRVys6Hm1qDm62", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8379), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MP4-12C", "e5d5c941-4220-44b0-9d2f-7d61721c76d5" },
                    { "Wx9FJthTdcXk8lP4QBe9", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fullback", "d9365591-35c7-460e-bc59-23edc8f66980" },
                    { "Wxfak7pEIKafG87lC1ot", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6029), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xjr", "33d4e39b-04ba-40e0-918d-3c1ef33fb4db" },
                    { "Wxgf55RQre99BKQfSDAI", "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1", "f0799aef-b1d9-4e98-864f-a24ed243c560" },
                    { "WXKRJKjehM6Esoq5uvKw", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tacuma", "876aca18-d0d9-4cf7-ac03-4f94d010c32f" },
                    { "WxmPEvHaR9o2tWz2ASBm", "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8297), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "650S", "853343e5-afd3-419b-af29-16d46b6a01e6" },
                    { "wxYyccupxMXKzjyurHVR", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4370), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ateca", "4d3eb23e-e61d-47e7-a953-d0f19e3bf25e" },
                    { "wYbfNuGhynA1frQm6po8", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Solenza", "2cb64bae-bc81-4e40-bd8f-a4ba34411530" },
                    { "wYlPI1qznGfw002p7Rwf", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5756), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Piazza", "b00285d6-ae5a-4497-b954-f79dae00cf8f" },
                    { "x0Fl50kYMktctokeIzrv", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3467), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Captur", "3f9137ce-b9b1-4c9b-8683-ecec0f3608a8" },
                    { "x0k6FJYJvBonGzJHcLbX", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6413), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Optima", "115d1e62-9ebd-4f04-9a62-5d95a3fdf47d" },
                    { "X0qNgG2GbBDBDAh1ScIF", "TJTAqICS7fjRu8I4afxm", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4518), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Noble", "eaa39871-4e4b-4ef2-9c90-b02d4f9e3520" },
                    { "x1Cy8nV7opYGEGoEjaCw", "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7215), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Range Rover Velar", "32caaf89-fbc1-411e-9835-c676edf418ba" },
                    { "x2mc3MS1ssomSFe4udQv", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "ba52376a-f7f7-4028-824a-1bdcc8b06003" },
                    { "x4agl5aI4EFucp54U3os", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1301), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Espero", "d8ca1e22-554e-4e8b-9983-5e5b286428bf" },
                    { "X5lj2Y92rSCmfu0yDSfT", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3905), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "213", "985714e5-297a-4f27-8256-09196e70d420" },
                    { "x6pHVhGEQuj7oauUmrh1", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9912), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GL 420", "12bf3c28-01ee-4479-a61a-d7ef2df8dfc4" },
                    { "X6w7YQlhNSESWD4k9jED", "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3831), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sonoma", "3f082552-7d49-4709-93e3-f984426f2bfb" },
                    { "X6X0JI1FHeNVHwgQGDo5", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(211), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lacetti", "5dc61b3e-83c2-4370-b9bf-0aed62e74f49" },
                    { "x6X4R1ENlX408m0HHAz6", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9109), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 400", "a054598e-ab3c-424b-a8e4-114a8555b225" },
                    { "x8BIauXAAI2nPnKkuFRd", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4077), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Voleex C20", "a677c43b-bee1-42a2-af67-d64fadef61bc" },
                    { "x8mv44rQS26usGLqGXYQ", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5917), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Urban Cruiser", "c9023d8c-4ed5-4b47-b58d-03d550b9e61d" },
                    { "x8oMNXjQ0a78qfyTxhK9", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Starex", "55c4f975-0c53-4e66-a24d-9a5454e5f626" },
                    { "X8XoBe9hRSxkRIGayPmg", "yL0kvEf81nf8Sd7CGQys", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7245), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MA", "ebfb5f96-378e-4428-904d-ee9c67914d6c" },
                    { "xa9FeNXFPreG5RafSIhx", "u3lzgWdKo9KaByo34lmN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Forfour", "7e16ff92-994f-4e6c-94a1-cad9f3d437dc" },
                    { "XAaxvSRkSQ1s3T55AJMm", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8152), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4", "9e67bcc4-9cc3-462b-9eef-16dec2290182" },
                    { "xAELoW8tSWUAXaSL5NdF", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(512), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pt cruiser", "b2c6f614-eac8-4f2d-846c-673b91255163" },
                    { "XAjswPr7cBA3C80vdP1A", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8434), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS7 Sportback", "c775d4b5-1610-425f-8fb5-7984d764260e" },
                    { "XAqutbu11nrKAC9tjGR9", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(759), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C8", "5b3015dc-c9c3-4206-bbe3-d13400bc259d" },
                    { "XaRaJva9LTmLPb5Y9WPy", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C5X", "a43cd25d-65cf-4803-9fde-f6da239ba221" },
                    { "XaRHYHJY7kzQ4qITfggp", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9978), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLA 200", "320ea109-b37a-404a-ba9b-116810b26ce6" },
                    { "Xb5ntKK83SPdw47BA7Ld", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A 35", "a4b90037-31dc-48ed-9d7c-90c1d669cdf8" },
                    { "xBa1aLxgjYTPjxdzjH14", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7773), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tonale", "12e093fe-7eb0-4dcf-80c9-ee73e1d617ff" },
                    { "XBQWKXokMXm80DIWArCp", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1815), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Patrol", "152429df-b68c-4add-bcb9-b4f633c159dd" },
                    { "XC7kLfSRGn4lVwdnYAuc", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Continental", "02074a41-a914-414d-9a9e-2cbb31897386" },
                    { "XC9ayKGRUhaV5VGe2PnD", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5502), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fx 50", "5420de1e-cada-4f0b-98e5-db6f6914c834" },
                    { "XcfXmtALBkAuuLfXYQdG", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1727), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Durango", "f9396c9c-b40b-458f-ab9d-87497588d88c" },
                    { "xCMhPbVrTrohhdKKT4D5", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3438), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpine", "1bc05940-3e18-4f1e-8224-842efd5ee988" },
                    { "xDnd4pkaq7V1YvEW3XvC", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "4007", "8dd7a511-fa7b-4935-a253-5a268bc7c1e8" },
                    { "xE2D1Fxo3DxGhD1C7xvT", "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6211), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wrangler", "33343d38-2e7b-4266-b209-8796e1ae1db0" },
                    { "xEXKxKb2TXaGgeyTmyur", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2521), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Duna", "39e9d22a-2e70-4285-8c60-e5023ed737e5" },
                    { "xeyLBGSW22L695yulhbE", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6375), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Derby", "bdf643df-9ca8-486b-86e5-87dc1bb2e92a" },
                    { "xFhgyvLCMfaLQmNfscFV", "XECbl6phGcsYXQWHwrT7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6207), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kiwi", "7bf7593b-3085-41b1-b89e-d709eb68aee4" },
                    { "xFU891AkwgqLhVddTC6H", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G coupe", "5f3a10b5-9faa-4537-8a64-89d4c36937d4" },
                    { "XFuN8t2mwv627WP6Kgna", "axxx6410rzzz3jxueox5", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Atto 3", "7a3e0642-f5f1-413d-9022-27578bf8aaf3" },
                    { "xG1XcBQvqt6SRUcpDewm", "R9BIHlzCwb67GPT89e7F", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3256), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Persone", "73bfc1eb-8f31-4457-8fd2-47435f03b551" },
                    { "xHQ42QnzMTEuz5vJByVD", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vectra", "e73548ab-c776-409c-97ea-b7eb13cff6d6" },
                    { "xhRh8wjHCIL6AWnSfhB9", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C3", "5d5b0b9a-0135-4e45-9c18-ddec7dc389e5" },
                    { "Xj6HVMGcTVvupyTe8hgj", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6019), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xj", "8abdb1d6-ca23-44ef-afdb-f981763f2cf6" },
                    { "XjEnX3TnG9Nfg5cqaRrN", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8983), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 200", "50d4e2a0-aeaa-4acd-a5c0-ae14f00a0bba" },
                    { "XJMcLnyzhImH2EMLh3fL", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1444), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tico", "9bdb27c2-c40b-4c56-8ce5-3446035a099f" },
                    { "xk2fuJJnuwF6P1olk3mY", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4975), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Justy", "884f8ca7-6eff-4649-a6ee-c15adf0b195d" },
                    { "XKCcpYuYVSB3oxJ5B8rg", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1131), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Paceman", "bf5e38ee-1bba-4ecc-896c-266ffc8bbbd5" },
                    { "Xmqe3GTY6mvsqgmIQT8u", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9683), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E 55 AMG", "d479fb21-5475-4eb3-b09d-4a9149b92a9d" },
                    { "xMusgvdUCNjm75Uhz9El", "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1118), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS 7", "d67cafb2-8598-4632-bde3-1816750b14fd" },
                    { "xnkTgohcB1oawFRRmRIc", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2651), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Siena", "518eb157-c809-40f9-b139-a3601e3113d9" },
                    { "xNm0z5TgeftClNwtHHG7", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8197), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A7", "25825d1a-8977-4cc0-9a6d-487e581601da" },
                    { "xNWoDVGLDdlsA2oo2omI", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2348), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Speedster", "6ca74f37-7275-490b-bdc8-34225e59a945" },
                    { "xo43tvaxXm5KSjUYtaHr", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7116), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Thema", "0107443f-d5f9-4337-8276-1657a64290d1" },
                    { "Xotyzy6opWP0whvllw5u", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6636), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2101", "e3db836c-7eff-4869-826a-499aea3232da" },
                    { "xP7NnFazUMHTNINSl0MB", "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7795), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scorpio", "8113121f-4535-4940-a987-66542a33227c" },
                    { "XpGtWBydo9QaNCsUuGGW", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3371), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "29", "5fc9a3ab-f29e-43e8-a731-6d39538dda47" },
                    { "XqC6sR2JEQMfcBLEUef4", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4632), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Odyssey", "e6578d94-3b38-455e-b41d-385edba46a41" },
                    { "xqYpE5yBzqBhrXu2fItv", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1180), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1310", "6e691ccb-e9e4-447e-b5ea-469518c3e282" },
                    { "xRCh46HYKxwSJKRBH9rT", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S6", "6c9dc019-031f-4011-9ba2-3adbbe54a494" },
                    { "Xrec4XacUSLNQTkhyTtC", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CX-9", "d7edd0f8-ec6b-418b-9c75-e10438a7cea1" },
                    { "xRf4WnmGT1UP5mTk867z", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9351), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CLK", "c2a34878-7596-459f-9232-2968d60e4bd3" },
                    { "xRMyLm4R9fz8J0gf1QTu", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xg", "784797a5-5bfa-4a70-a821-852f27cdb2a6" },
                    { "XRWSwef26XDrR3HWJo5l", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6525), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Polo", "9527a8c7-fe7c-4c36-82d4-63aa6c6597b5" },
                    { "xsdQhwWjcXpKoSKEfdfl", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2142", "db75b087-9aea-4c56-9bb1-6e7b7c09124d" },
                    { "XT4sMLsvXla8bK53j2EE", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3353), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scorpio", "38a819d7-c95c-4634-8e95-7a72e6eb173a" },
                    { "xTgwRncfsz1MUqP5LtyC", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1991), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "e-NV200", "6e76518e-3cbc-4546-b8c4-626eea34406c" },
                    { "xThGSlldkmRJsUSfeySw", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3297), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "16", "a46c76a4-752c-4b27-a6e7-da8d80f1d8ff" },
                    { "xTyAbrMnoSFbMt1jeng5", "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1326), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Evanda", "29ef8f1d-fe16-42e7-9a56-fc06cb526681" },
                    { "xuAEYelPz5DhL7qdeQcP", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8679), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "320", "091ce0bc-1c23-4bd8-bdfb-1d7408c3a778" },
                    { "xuCP5fABCdzfQIN26PRD", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "935", "d9f18672-bd28-405e-ad3a-223890cb2b0e" },
                    { "XUDLw3FrvxW604rKWekm", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7839), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B12", "27469bf3-1da3-4646-a2b7-cb130fc06abb" },
                    { "xUJUB0QaE2TGdBLYt0De", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7168), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Y10", "4f137076-25c1-4c30-b072-9ddfb423941b" },
                    { "Xul81fSzUFugwbcd1Gqu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9224), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "760", "2f36e8d1-0321-4efe-b161-30d3942225b0" },
                    { "XV5oPY0A0GW2mSffyexE", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "408", "d2e92a51-29df-4214-b2ea-3de4b570698d" },
                    { "XVbdb7DtVuhD90CLQt5o", "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3741", "37a585f3-e163-48d0-b3f9-5f34ba681672" },
                    { "XvmJf5zz3Gkwl70J4wUL", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7430), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "NSX", "4a8e0e2f-3702-46c1-bb13-3912d9527e5f" },
                    { "XVs2Dz0w3gE965g4osKq", "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2832), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Grand voyager", "c5aa88a1-ae67-4458-b2f7-e3cf125ddcbd" },
                    { "xw5fbWJAQPyzsLJ7C9sg", "MvMqrrJaUbAAVIvJHQcu", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7965), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S580", "93be917c-f752-40a1-b787-e4b9d2d19ee1" },
                    { "Xw9bNxa83fRWppMHbNYq", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6778), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "245", "9fd964f6-3305-43e3-9721-151b179d8c32" },
                    { "xWbDD8AhIsxI4yxzQ98H", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(896), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nemo", "1a076765-f893-4b32-9a20-213be3612594" },
                    { "xWFPFjseEKUeDxSNX6NE", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3463), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Windstar", "310a8f78-02ee-4c3d-8c6c-a580bd488f8a" },
                    { "XWnJBPSuYQ9fmGtcD47o", "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7274), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gs", "e2a075c0-3e10-4b49-8552-3da42cc59b9f" },
                    { "xwTLIN8AGe6TAAyKWSPN", "Fjw2xBL9BqCaQBzxcxDI", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Storm", "b9863931-4ca7-4870-9df8-3f8aaf6511a1" },
                    { "XX4SuThNF5njMjtlmhGW", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1660), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caliber", "1acbd504-beee-4bd0-8ef5-3869b03ab2cb" },
                    { "xx8Ep8SV7DEIJYN69ad0", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sequoia", "172324ab-57e7-4915-87d6-98b430cc46c2" },
                    { "xXmj7h2NC7Mpft62ACuA", "W5TnArCA9xCEodsTpDHG", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5535), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Model Y", "2a6f850d-70d7-4ef0-a38a-cba65cd03792" },
                    { "xXYspPMSV2zho3DwG7wB", "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7309), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Yugo 45", "33e9185b-be72-4e98-9a80-5e65e5c740cd" },
                    { "xYGHXJkXPjt6vWG7YScQ", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1816), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Shadow", "fa31ad30-022c-4b0b-9e0e-a609ede64c88" },
                    { "XYzDp0js3UVQlLvS9hR7", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7807), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3200 gt", "d3dbdb88-2b57-49e2-959e-260c7646e61f" },
                    { "Y0ppUpQTaq17VMGwfHFS", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6631), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vento", "a55a530a-589e-48e1-a5f2-1af87be45cc3" },
                    { "Y0QjFNkLdV5IrQbCfgMt", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9236), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "850", "0fb96e60-132e-4498-be01-78de7b41a06e" },
                    { "y1qUJhqHW8fJk2pXjU55", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(572), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 250", "ef22e956-ddca-4757-8720-1250c9b07821" },
                    { "Y1u7XRKawFGIYft9BH73", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XD3", "f0357808-9162-4c97-9574-0300a45a0c02" },
                    { "Y2pBzLlMy1qJsog6lwxj", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(458), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 500", "ce260919-fe5b-449e-bfbd-497cf3f3f194" },
                    { "Y3pj6fycY8Aouk3UHFfV", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(421), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML 320", "e4758699-b0ae-4b2a-987b-dcd2fb94d538" },
                    { "Y4KtEVwzHBFAfsCGnrml", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2335), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Signum", "83e308f8-fe24-4c4a-a2bc-787861479609" },
                    { "Y4nbEnUwxfcNwKuFg4Gd", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "QX70", "84ec267f-95c5-4508-a26e-1aaba2d69c4a" },
                    { "Y7dPXwWvuQKtTBGbs8Cz", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1521), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Move", "80673b5c-3e45-4534-9506-4cbbec67d6b9" },
                    { "Y7dU9IalBNtI7hd1bunx", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2550), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Linea", "9b8af90d-ad59-48b9-b491-70803ac26597" },
                    { "Y8zz3qc7mEpkLlxHuQHT", "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1215), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lodgy", "dc463510-3abc-4c0f-ad58-b971898e46c3" },
                    { "Y9cyoeSTTp2FYvnB9M90", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1553), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Sharade", "b3ba3411-a750-4d0b-b978-c19d73d8e2e3" },
                    { "Y9Yv3JwxtNqNg9n0zK3D", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8689), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 1-series", "e5942a14-6609-45e7-bc05-a5aadc11da9f" },
                    { "yAbf39hyYXsbjlfJSxxl", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "929", "134d1966-7a24-49b5-ac22-0b7556e71d1d" },
                    { "yAC5xhSlC8bRzPlcnBgR", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ascent", "e550a141-bdf0-4202-a446-72a025b3a177" },
                    { "yaGg0rTgMxXf6VzbjCjg", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3550), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fluence", "21dc31ce-f0b0-42ef-8736-0c095d92e4bf" },
                    { "YaPo4uNMCqtT7dAdT9UG", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5980), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Super v8", "002290a2-cfd3-4671-8fb9-244f888ed54c" },
                    { "yaQGSJsIaIEqzS1S1vIQ", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6263), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Clarus", "d39f6faf-88b0-4d04-88cf-e28225004a29" },
                    { "YazdkokjV3BVqC2ARY0T", "lgRSEHsdarS0gC4osQWQ", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7601), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Europe", "2c364c77-0d99-47a0-b2a3-afe28e64ea40" },
                    { "yB18N5stxfVmcwf7TSa0", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9055), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C 30 AMG", "4676f640-d58d-4942-8a44-e835d53d867f" },
                    { "yBmljB5rP1TgGIJLzNog", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5054), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "IX55", "d770c790-c70c-44f1-8a97-e7f2bbc5d2e6" },
                    { "ybvnKl0mDGU9hKpJjAUd", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8018), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rapide", "069f7a46-724f-4606-b0e0-01765a5eb581" },
                    { "ybx5t25wYVxSPPCvJ1yl", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8640), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Metro", "916eeeae-10ba-42fa-864e-d81b370f6120" },
                    { "yCTHpJuQ2gh8EpRlqHaq", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9995), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GLA 45 AMG", "da301d16-8794-4454-a0e2-544f358e6f32" },
                    { "ycwMWYdrPnYgAqNNBhrm", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8642), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "240", "d6ec539e-29bb-4c73-9b6f-e94e9b2e697c" },
                    { "ydg0J2kh8plKabCQWQ0G", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3199), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Macan", "703484d9-01a3-48e1-84d7-beb7eef553c8" },
                    { "YdhJCbkSy3X3t7VtAECC", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2334), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "c4737d1c-1b13-465c-aa96-29f1d926a459" },
                    { "YdjSfcQ1Ibxc3celEHvt", "zzzbw5sz2hj27fvp4x2v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ET7", "6029b4c0-7996-45d7-b5be-97ecb092ff31" },
                    { "ydLtnnsnXCKYHKQzb3qg", "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2035), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bravada", "d1cce7de-77a1-47d1-b5b1-2ce54275c16d" },
                    { "YDU6HtIkW4G1fc6k2Va9", "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GT Convertible", "47d30614-ca33-41a5-8248-a852f5231046" },
                    { "Ye8sKBf3GaXC7BeIqxwx", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stonic", "c803c668-2ecb-4771-9b91-85553690db5c" },
                    { "yEeYyBtdYjwmAFJTIhP9", "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2975), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G6", "82375d47-9061-4bc7-b269-33ca20c13077" },
                    { "YFE0h1k6xxSECKedtA7R", "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4058), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "75", "ce7a8df5-a1bb-4290-981d-0a24a3ff7d8f" },
                    { "YFJDTSU7zFN4L5TnksaM", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6648), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21012", "d8ca0c5e-fdff-497d-a778-ab14f80033de" },
                    { "YFmBKDVokfze0J9Fu88p", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 2-series", "aa773f92-e955-47c5-8dcc-38560b01ebd9" },
                    { "yh7dvRuBGJd2x9b7dSRn", "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(440), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gr.voyager", "51b5bba6-e05d-45d6-b98e-dc2b940ce5a5" },
                    { "yHo5ylhbwHecNNLnnD0p", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2306), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "500", "5c607bf0-202c-4231-a164-a83a50ecce64" },
                    { "yHoaUmlQI7huTgDFFTwg", "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3694), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Safrane", "e3f117f6-d03c-43f9-8d5e-521729f843a1" },
                    { "yhSwqHmRzPNHKIUvRvzU", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Adenauer", "bdcc3f08-f23d-4987-9432-c5754b62c4b3" },
                    { "YIyDMG7VS57K91nI8jQf", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1666), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caravan", "6280b0df-f317-4ef4-8a87-22ff3fec825b" },
                    { "yjq57HaxIpqHdqtp7WGH", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S 420", "ef8630ef-4cd5-4fb5-942a-a6ebc4224495" },
                    { "yKvJ2tSUlTsN1GHfyTX5", "FXHe5SU6zyIfYHPGygNC", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3872), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gonow", "71906445-436e-4dc6-b7cd-0a00933da727" },
                    { "YLDIGKIkTsM7AcpkrrQ1", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2187), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "125", "85682e79-1f96-4e5c-bc36-6813dc712ac0" },
                    { "yljLbmm7tcAJJG1Btr6n", "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "IX35", "9ff224a7-51d2-47a7-9602-14cdd0d1e2d8" },
                    { "yN1HWYB9nRmdqd7lLmuS", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(216), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lumina", "a4bde6c5-b128-4a0b-a0d8-445d157c748e" },
                    { "ynnXEtLVVMpuzh3PUE4v", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9805), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "G 270", "70e50614-af45-4fb0-a6d9-8999978dd7c5" },
                    { "yoKFH6KnA5S1tDYW0esI", "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1000", "7dc923f7-787c-4c37-930d-83f9ce54a373" },
                    { "YoQUzG46umIwgHzHJE1j", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "296GTB", "d76287a9-ab5a-4ba6-8682-4f9753094c52" },
                    { "YpKKk3vEPRp0NCa55vmq", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Navara", "e8bf91da-2c03-41e4-beab-11f25667176f" },
                    { "YqgNUsax2JgSBUAgGJ6d", "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(885), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jumpy", "235429b3-3cc2-46d8-b1b0-5fdd176b6df2" },
                    { "YqnKlK0z1GTU26EKk8MS", "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RCZ", "80f9d28b-af52-4381-b502-937493e1bf64" },
                    { "yQts8x5uuEdHA7Lxr1qt", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8678), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Montego", "92aa2a18-496a-4513-b24c-fae0dbc8a5af" },
                    { "yr6p0QCqc3UVm53k7ybr", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6801), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21093", "dbe8e6e1-a169-4d93-ad62-5cb0db4e065c" },
                    { "yr6wqWkaLMaplrYWMP7C", "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(3095), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "911", "2d955e7a-d906-45f2-a161-6737b8ea53d4" },
                    { "yrH496MFxVbvPsaSqmjs", "PsbTIAKWHCVgruG7IgRE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2390), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kenari", "abb301a9-6448-48ad-8f99-c9a7c8f02e8b" },
                    { "yRP4TMmAK1GHoTDamwKb", "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Navigator", "54ddf9c9-03e3-4ed5-b317-18030a3f9a8a" },
                    { "yshVTTldKq4QlEKXEgaF", "vYf86TFDqUkh9RcEN9VN", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fl2850", "e8971085-d333-43c4-b020-a79c54f25789" },
                    { "Ystaq2Bt17KjsuNFpmX3", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Corolla", "7b5bfa90-99ce-4771-b216-4679a4c3bfa4" },
                    { "ystdBfUkFUuw3FFXMLIg", "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3954), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hover H5", "9d5c1ce4-0644-4c15-8965-c686d510081d" },
                    { "yswbw1dW1dzbINudLII5", "SGKURGhEbYHIdqkxpDJh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4163), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fun Extreem", "1697f0f4-a742-460f-a30f-23fe5aefe14a" },
                    { "YTG33wjxY1Urpc5nxe3W", "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5920), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "I-Pace", "0e7304b9-b94d-43b4-8088-779f0326624c" },
                    { "yTlPyVF51DJB4IXXt0q7", "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5843), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "JS4", "c02ada0b-7490-4b86-944e-e2a8f6faed22" },
                    { "yTNAEjkscrD1E9mNwPR4", "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5587), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "I", "27cb8ed3-7732-40ee-b136-2c4835141e3f" },
                    { "yTWC86qbWUkANN9Lu5rN", "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "CX-5", "99fba5bf-b3d2-4e62-98a1-3c821380aa40" },
                    { "yukBISNExbDXF9L3wwqg", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A8", "a181f4f7-e371-4589-8a90-8aad8495928e" },
                    { "YUmoMFCIElo1pdHagILI", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Karl", "fbbf33bd-a5fe-4eef-b5ea-7b20faec8fd1" },
                    { "yvSn4YQnQqm0cuDeyE02", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(338), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ML", "3c5e6bc3-4fef-42b7-9439-2378c918b155" },
                    { "yVURUDnvsVt0byb274gh", "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Senator", "9617a8a5-486b-4c74-98f9-b4e5104edb35" },
                    { "yvxfFCEKtCY7opEatjHX", "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(5761), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pickup", "82470230-073b-4697-8a5f-0dc4175e4db9" },
                    { "yVxylhd9R3ztTCRpQzjM", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5617), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Avalon", "ba656016-9ee2-4402-bd2f-924f6a08487a" },
                    { "ywFmkbNBDWcAYrzTep21", "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4894), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "1800", "e40871ee-c627-4145-8665-190b0d21c040" },
                    { "YWjUuxUfcSW7ydNcWK1d", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2604), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Panda", "f1729202-4ba6-4853-8acf-3fe138af7d21" },
                    { "YX1gAsAc6IkktEhqYjya", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3344), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S-Max", "0919e8a6-ac88-49c0-980e-e8f8482fd09b" },
                    { "yxBhS9xXM6RGjaaJu4bt", "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Terra", "2947d883-82f4-4c42-9c85-f9ae324721ee" },
                    { "yxmHGyLB50jyvkLU0ruF", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S580", "68dbd0c5-37a3-4408-887d-1eeb24f72dee" },
                    { "yxP3AVt4P30NcYykCucQ", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2626), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ritmo", "1b3cd159-a149-41b8-81b2-ab4739bce116" },
                    { "Yy3BrLHsTzRoQ7bPRcyV", "nm2AJSoa0dWnayDNBRnh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(989), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Villager", "07b315f1-45b8-442e-bcd2-84a10e7a0b64" },
                    { "yy5hmY4uRhtAgW2uDzM0", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1654), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Avenger", "de5fddd8-6045-4cb1-8409-cf6d3f3f4456" },
                    { "yy6YWVEVkwhGkWKh1dsC", "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7877), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Levante", "31f01cd3-2a31-41e5-ab6f-045c82c29a7c" },
                    { "Yzb7UjMfvnmBfq7PlYnS", "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(3242), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mondeo", "c3f8562e-e947-405a-8e96-aaeff5255889" },
                    { "z0KMhStPxbaeKQ2BgtG3", "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4759), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stream", "50111a63-35a3-4a9c-b301-379348c793ec" },
                    { "z0pjAGPWjVA2aDA6vNzQ", "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ypsilon", "9bd611e0-964c-449e-8de7-4eb72b9ded66" },
                    { "z0sa8eEK0BrX9TUSw4m8", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2691), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stilo", "a6458fbc-56d1-451e-96c7-cf7df261ee16" },
                    { "z2q5MmnJFPcQahG3X7dl", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(905), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SLS", "197f1164-9760-481d-8156-6d832d3009e1" },
                    { "z3IsgvY2KNMFQGlaNkHv", "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "NP300", "5a775ef6-3e6e-4571-b332-1700a3891fbb" },
                    { "z3SJ8btGhb53EXD03nvD", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(7818), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B10", "9af49941-4b51-4962-808c-8f2c58001190" },
                    { "z6LsPPljGUydqcyIywju", "9NRn3UNnrPnf2yJoGIBH", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9742), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chiron", "c693ab21-17a6-45cb-97f6-7ff005ea253a" },
                    { "z6PmykBsPFyaWSfXrpnt", "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2644), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Seicento", "8c7ab6ca-40b1-4d9b-8ae8-f97d144e5d68" },
                    { "z7e3aVebphgLcHCyfetN", "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1462), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "403", "2ddff6b4-af79-455b-8fc4-a7813a4a2c5d" },
                    { "z7tC6STIx7IPvbMlddg9", "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4229), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hawk", "e0d94642-42e4-4582-91ac-96506a6cf121" },
                    { "z8F4CEGa0xWR1PPItczJ", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(354), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Transsport", "85fbb6ce-0762-4612-badb-130c57c12b10" },
                    { "z9CjAtgrFpm2aptTIc1L", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "760", "fda4355e-c01d-46f4-97d8-054fe1f0157d" },
                    { "z9qJSBkXq1aUbGdywYHs", "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5244), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wagon r", "c4d43d55-9081-4144-bf95-6a1d56117869" },
                    { "zb8srS5rDcHTHm0APTQK", "nm2AJSoa0dWnayDNBRnh", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(971), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Milan", "5a6de946-53b4-4729-b276-d0a845dcceb5" },
                    { "zeYEBHkeKne7McRszyuk", "wC0Q8eUqQLkE6cpVwHgu", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dogan", "a90a91c5-6d9c-4947-aefd-204f2e1ff7a7" },
                    { "zft27LPNuNjvJWYSEqdp", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9732), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EQB", "eb36c5e6-e993-435f-8e79-d59aad3c0251" },
                    { "zG1VMvv6yTcDCwVYR8h4", "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Venga", "c2fb7115-abbe-4f29-bb70-7c73e846dc1f" },
                    { "zgX3nCorMNVRgxFyA3Bp", "Sw3e46nyzgd7zmMPVG4r", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(4276), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "PS10", "ac4e9a7e-ff0c-4dda-bd9f-48448e45eec3" },
                    { "zHmQHLYpXmImBNnwb9fK", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(7125), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xc90", "2ad1aaf6-6a4b-4e29-96eb-872ef1cbd268" },
                    { "zJ8gyDV4FPWSgpLePAUF", "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Samba", "1a699a3e-471c-468e-a00b-08ce7ec99b10" },
                    { "zJkmMKXdBfTT1qvu4RFj", "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6600), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Taro", "861cc39d-469d-4858-a35b-da6d6922cabc" },
                    { "zKQNGMnMRvGNWuqVLzhR", "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 898, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Deville", "c3b8ffca-761d-4b34-bdfc-fd26374f8679" },
                    { "zKrE7CU7oqgN3fNVQP0V", "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(2051), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "F12berlinetta", "bcd3437b-e12e-4087-afca-17f1cc813d58" },
                    { "zl1QF6QoHS50u6ktVgmo", "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(143), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "El Camino", "e9d4601d-9638-4a4f-bf3b-0c0ce06a43f9" },
                    { "zL522MSEj054fsgzwHKp", "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1721), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daytona", "f9982ea9-ea49-4c2a-9ce2-7fb0215c8d29" },
                    { "zlSDuQjequoeqWmptqdm", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21213", "0b968f1b-d8ad-4417-8eec-c5b01a13a24d" },
                    { "zma5cnMLtXaPB1n6uvsV", "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1891), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "5", "7740ece2-d8bf-4b00-b8b5-314794c4ac24" },
                    { "zT4e3pU6jYIWKEwamvYE", "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Countryman", "fe517d36-9410-418f-a1ae-c9986570e7a0" },
                    { "zvEPA4yvGjJxDPCIFEQt", "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(6772), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "244", "c78fcb8a-0208-4dbf-9ce1-db7b63f7d236" },
                    { "zw6wpbaF8CU1yjpEfdB1", "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 900, DateTimeKind.Unspecified).AddTicks(5578), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "4runner", "aebe3d5c-2199-4dce-955b-035d6ed5955d" },
                    { "zWWF0r0eLPYNeCSp0z00", "Hc1zhgoBCF1639Rp1PkY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(4770), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "H1", "cd89823f-2189-494a-bad7-f4100cc6d1de" },
                    { "zwwhwN0RtQcWcYHkTtf0", "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(6750), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "21074", "e6cc9e8d-ee3d-4671-946e-76196ca2feac" },
                    { "zXFfL4dYwza62eeJRWBY", "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wildcat", "8d82bdfd-6a61-4706-b5e8-77a8cc30c059" },
                    { "zybGuk3LulMKSV58sWk1", "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 13, 57, 13, 899, DateTimeKind.Unspecified).AddTicks(9738), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EQC", "455ace2e-9a98-40d2-b096-f59da475c4ef" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models_CarBrandId",
                schema: "Cars",
                table: "Models",
                column: "CarBrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models",
                schema: "Cars");

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "06MxFkB3ArFfVraVWN1u",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7878), new TimeSpan(0, 0, 0, 0, 0)), "efd1f8cb-9f79-456c-b855-866e8408cf7c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "0SlIJFKD3VdaMAEnxfTT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7887), new TimeSpan(0, 0, 0, 0, 0)), "b87ebcbb-d460-4d76-89fc-78f6f766dd35" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2FEzeyYHYe3zlhjMeaEF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 0, 0, 0, 0)), "c822a296-7083-427f-9422-be370f78460a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2SBENlnqR76XRNAjbAs3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 0, 0, 0, 0)), "46838afa-ca9b-499c-91ba-95f89e04b490" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2VS5yLgAuj7VmYeRVxTD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7905), new TimeSpan(0, 0, 0, 0, 0)), "bbae4eff-4509-48aa-9884-b9a2f494858a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "2xSRLgR4QgzYhDLjfgAM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 0, 0, 0, 0)), "9975b097-7341-43b9-93b0-f5f9bbf24f57" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "3qGrKAnyJ2rmHlevXb8c",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7916), new TimeSpan(0, 0, 0, 0, 0)), "acb523f8-ac2b-4ae8-a76a-3e8ebb3bf94f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "3yTpJND7nxjtqoDcuc5M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 0, 0, 0, 0)), "babb5984-4bb8-456a-b9bf-a70fa8429d1d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "470SJrcKER8YaPHSS0br",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 0, 0, 0, 0)), "214eabd6-5019-410c-9484-1fca0e9c5dec" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "48xSUCHrRIfABkLmGHxD",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7934), new TimeSpan(0, 0, 0, 0, 0)), "5fbbd76f-5885-4710-9c87-2be984ae7f7a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5aFWwvagmpfBWQlHxU5M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, 0, 0, 0, 0)), "07e7810b-758a-4a95-a27d-0cacdba7113f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5kDhCqXf6JTAIvz61oEz",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7966), new TimeSpan(0, 0, 0, 0, 0)), "cd711186-6aaf-4fd9-87c5-ac6682ba30d5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "5TgVdpBPF4SsQWVFP08j",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7971), new TimeSpan(0, 0, 0, 0, 0)), "2c3968fa-390b-4d70-81aa-45e6c88f9864" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "65B72rCez5bGWR7Po3Ny",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7977), new TimeSpan(0, 0, 0, 0, 0)), "7c643f5f-458c-48dc-af4e-2ee5061787b0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "6mI4J3fGUdG5KvEHYjqL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7983), new TimeSpan(0, 0, 0, 0, 0)), "55015a7d-c1ee-42eb-9728-cb7c298c8f76" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "7ReFhJXxyx7pAkvlW1eS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7988), new TimeSpan(0, 0, 0, 0, 0)), "d567aa3c-3632-499a-ba1d-804f8169612f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "8mIlNn2498yIC72vgKBK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7994), new TimeSpan(0, 0, 0, 0, 0)), "fa4c25be-b722-4b94-a849-6cd8483c8f6e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "9NRn3UNnrPnf2yJoGIBH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, 0, 0, 0, 0)), "7f6446fc-40ff-43c6-a8ef-b06577e2f504" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "aPIB6410rSAP3jxueo2Y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8006), new TimeSpan(0, 0, 0, 0, 0)), "7550088e-5368-4673-bb54-a413b7757af5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ATbb9NezfDxSdpBXdqd6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8043), new TimeSpan(0, 0, 0, 0, 0)), "4d2c4d3b-04f0-4c53-9721-fc1d28d50731" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "axxx6410rzzz3jxueox5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 0, 0, 0, 0)), "7b1cc648-f5c2-4886-86a7-f07deac765e0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "B42TXsELwNJNBewRvcu5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8049), new TimeSpan(0, 0, 0, 0, 0)), "f2edfc89-a510-4c31-99e2-d7ae3acf282a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "BESQA89ghmpmxnMv6lb4",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 0, 0, 0, 0)), "8fc6e022-1a3b-4f37-b9e0-43cb93032267" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bshsdfzU1lNaPe58k9Io",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8060), new TimeSpan(0, 0, 0, 0, 0)), "6ec4cebc-4a1f-4322-ac0e-7356049976ee" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bXGDbcoVlUUFaUAeuBhU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8066), new TimeSpan(0, 0, 0, 0, 0)), "8f5cd8f4-a719-4f10-b781-5cc210c91eed" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "bymbQs0TabKzPsrN3TlL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 0, 0, 0, 0)), "acef923b-cbb2-4dde-8ca4-f5ad1d1d3000" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "CDKhu32A8uPkeWM4eblC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 0, 0, 0, 0)), "53c7ff77-1bdb-484d-ba07-7d89b7dc0c97" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cjnwEk8Wle037jtonYsj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 0, 0, 0, 0)), "3e452af7-b583-4c08-94c4-37b08f963de3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cYgoBzV1QqkgGALBMqxE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 0, 0, 0, 0)), "b0526c84-2228-4b93-af7e-e1dbb722adad" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "cYlq5o6z4W9RcnLLB6zq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8124), new TimeSpan(0, 0, 0, 0, 0)), "57c76f5d-cb25-4917-82e9-828ec918948f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "D67BxpjC6stcD4YYGmdn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8129), new TimeSpan(0, 0, 0, 0, 0)), "ece27c60-7b3a-4a13-bcfa-cb0d60effb91" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "D6a4Vo3VE2WzDdgA5AFo",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8135), new TimeSpan(0, 0, 0, 0, 0)), "3153fc88-8ce5-43bd-8043-0c3b9a61017e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "d6V8Py7xGhHTTVvS02QR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8141), new TimeSpan(0, 0, 0, 0, 0)), "d58097e8-8726-482d-a76a-2aa1e76d4039" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Dfej8VedBqRvW5SVCeo3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8147), new TimeSpan(0, 0, 0, 0, 0)), "446410c2-b00c-40bf-a3f4-b102d922c829" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "dksqVUhgDuHJ9KJ2uqyP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8152), new TimeSpan(0, 0, 0, 0, 0)), "dacaf6eb-6261-4c88-91bf-772b915f841b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DsQDYqGhCx8KL7zF4UFK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 0, 0, 0, 0)), "0b8e59b2-e716-44ad-aa0c-0e11757727bf" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DumA309cvKSKLalqcW6h",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8164), new TimeSpan(0, 0, 0, 0, 0)), "a5947f4e-e75d-499e-9b7d-4feada1809b9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "DV94kh1MyMbGW3P4aac5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8169), new TimeSpan(0, 0, 0, 0, 0)), "91fe67a6-19bf-4025-bf3c-da2839fa90a3" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "e7NrNKeWFc73uCAkz1Ar",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8222), new TimeSpan(0, 0, 0, 0, 0)), "45229057-c5a3-4351-8168-c1c53818393d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eF1lrB1EP63Y0DablBJF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8228), new TimeSpan(0, 0, 0, 0, 0)), "49e65e0e-eaff-4d04-8bda-e93a401a8635" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "EMczl7VAvCRwT3kAz4In",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 0, 0, 0, 0)), "74c0a307-142b-42b4-a53f-5075216c50fe" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "emn3h8NrhdSz7ojPBV2H",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, 0, 0, 0, 0)), "700b3f70-c797-4580-b31b-0b2a4945b616" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "etMtb4JLm7eB90mlnd72",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8247), new TimeSpan(0, 0, 0, 0, 0)), "303663ae-82c5-45d9-8bd7-47d6bb18a28e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "eUMYrz00U0nQH5KTc7uR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8252), new TimeSpan(0, 0, 0, 0, 0)), "fd242a59-8add-4fa4-b880-c15662a130ed" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "fAVrUUNVKFbMuNlP7oUW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), "be06d062-ddc1-4bec-b294-e38ea2b55520" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FcCNt3RVlzMFl9Jtw38m",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8263), new TimeSpan(0, 0, 0, 0, 0)), "c9274abf-4d9c-4cbb-af8e-99a731861917" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Fjw2xBL9BqCaQBzxcxDI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8268), new TimeSpan(0, 0, 0, 0, 0)), "70893c72-a9ac-49fc-90ff-ffcc80d93e4f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FtX2HosXUQDnvSScsyP8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8274), new TimeSpan(0, 0, 0, 0, 0)), "6c3cba6d-eaa9-4ed8-8253-e5cbb486c3ab" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "FXHe5SU6zyIfYHPGygNC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8312), new TimeSpan(0, 0, 0, 0, 0)), "b2230142-b5b9-430a-a7c3-d99e5f613f28" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "GBnMMAvdjskIFpKTYLb1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 0, 0, 0, 0)), "b739c33d-4deb-458b-8ee4-8cf71aba4d67" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ghyFhm7jzcjYDrjMVLs1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8323), new TimeSpan(0, 0, 0, 0, 0)), "c63f76e3-3e51-4b4d-99bb-7f9cbab54b3b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "gXuBjVjveGKf3R9Kc9vE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8328), new TimeSpan(0, 0, 0, 0, 0)), "3247a1af-264f-40f2-960b-c2ca24bab176" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "h6Bfvk5LdFwXv9QzKLxU",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8334), new TimeSpan(0, 0, 0, 0, 0)), "e2e129b3-11d4-421f-a21f-ebe0d38ba697" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hajLAGmn9WWXQco4CXw1",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8339), new TimeSpan(0, 0, 0, 0, 0)), "fcebc047-3260-4585-9e1c-407171397f01" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Hc1zhgoBCF1639Rp1PkY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8345), new TimeSpan(0, 0, 0, 0, 0)), "0aca729e-925e-40da-afe0-86c1eb9eb642" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HhvYG9GBNEg7RhQBIjtY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8350), new TimeSpan(0, 0, 0, 0, 0)), "bd443d7e-3488-42c7-973c-07058de97497" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HKjqbIm3EQ96YdfpakFI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8357), new TimeSpan(0, 0, 0, 0, 0)), "d810c817-6f09-4b52-af09-244769cc68b7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "HrERVHUdBMrdUrgLsvuT",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, 0, 0, 0, 0)), "9b1558a1-1942-42f0-8195-8b1fcbc03f26" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "hy7DsFSFE0ugKvGj8Hfk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8406), new TimeSpan(0, 0, 0, 0, 0)), "a91b5f4b-56e8-49f3-8eef-54e4caf409db" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IIqtbBpQcKHy7TVA10Nl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8412), new TimeSpan(0, 0, 0, 0, 0)), "59cc08e6-1c2a-49ac-b148-30ee5a8bb0ef" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "IR6qs66ukTVnB4w0NIFq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, 0, 0, 0, 0)), "5b944318-f77b-42c9-9dc7-9e770fbc7f21" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "j0N3jEL5HfQ9Ve0KVNUl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "f4088539-d850-478e-9df2-8a9942f62b46" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "J3wnurM4CgKVkRFfRvHs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 0, 0, 0, 0)), "57b3aee5-6e33-4376-9d6a-9476aa7bbd5a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "JqgJmqpSsWvQ7b60GLvq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8434), new TimeSpan(0, 0, 0, 0, 0)), "48ca48a9-1832-425c-8084-9edbb3f321e8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "jyCumAseWnFjQjPzn3kQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8441), new TimeSpan(0, 0, 0, 0, 0)), "fc2cd733-ed56-45a9-bbeb-8a3ef9c1c6e4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "k4Lylg5nrM6Vt1MrWfxS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), "c6ccc369-b9ec-40e7-9376-c6fb52b4bd66" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KCEkkBQL72L0jmEutbgl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, 0, 0, 0, 0)), "abca428b-e3ab-4b5c-9c44-68029e7dcb31" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kF0x9WcUJs7aHYtoKzWY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8477), new TimeSpan(0, 0, 0, 0, 0)), "01766a30-1bf6-47c8-a0fe-eadffc6cda06" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KQMma7dRwtXlcym9oSWC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8483), new TimeSpan(0, 0, 0, 0, 0)), "bb8a73dc-12a5-481a-9d94-5870f37de6da" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KRmmVEwPAtzSzJQgD6HY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8488), new TimeSpan(0, 0, 0, 0, 0)), "4d873b3a-7f1e-4d18-af1a-16119d76eb88" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "KvyHwQN3QMrXmgbsvne9",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, 0, 0, 0, 0)), "7381997c-de9f-4f25-aec0-4b1489f3a77c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "kXULxNaVDJWKs2ACmH5C",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, 0, 0, 0, 0)), "67557a47-b775-4014-91b5-aca0b2370cbe" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "l5Xv7WgEwDFBEEnFG9uC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 0, 0, 0, 0)), "eb24ff59-55c4-4928-ad04-22eceea422d8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "laJM8lrsRY8D0eRYypqk",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8513), new TimeSpan(0, 0, 0, 0, 0)), "aa316fb7-38a7-414a-98bb-59f3fe4e8276" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "LcuKvSewzBSW3KEJdLIa",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8518), new TimeSpan(0, 0, 0, 0, 0)), "44bc4c4d-1c35-4b85-80e3-49223e1a93ce" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "lEVEcrE9FIVtGbtFarHV",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8523), new TimeSpan(0, 0, 0, 0, 0)), "75bd1644-39f1-4df5-aa27-275d850d83c9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "lgRSEHsdarS0gC4osQWQ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8547), new TimeSpan(0, 0, 0, 0, 0)), "5cb0b19a-85f9-4d9c-aa43-93a95dcbc861" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Lxge9Bn07u7pWE0RqbwJ",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, 0, 0, 0, 0)), "19108277-4033-4829-a204-055f2889abcb" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "m5L90Q8l2fTcbPyeA3GF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 0, 0, 0, 0)), "f27a20a5-4bce-424d-9cb3-f0d826b29275" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "mEjXfYc5wzIHYnGGpCbE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8564), new TimeSpan(0, 0, 0, 0, 0)), "6db1b731-c56a-45e3-a420-2a52c1f399f5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MlFe1uw8xqqhdAUnqcHd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 0, 0, 0, 0)), "6954756d-7cb8-439f-9eca-10c7cab7c61b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MvMqrrJaUbAAVIvJHQcu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, 0, 0, 0, 0)), "715f22b8-1d66-47a6-bc69-8fc7150a5b31" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "MX3aL9JN6gD0F4KRl0Nq",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 0, 0, 0, 0)), "1f334407-54a2-4350-b293-7050d7f511ef" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "n1jg2wtcteSRvhvMGm4n",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8587), new TimeSpan(0, 0, 0, 0, 0)), "5d587297-0b5e-4e97-bceb-c6064682fc0a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nDxKpo5IAKk62ekEBbNS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), "4055c4ce-8b7d-46cc-9a5d-a8391d89a829" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nm2AJSoa0dWnayDNBRnh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 0, 0, 0, 0)), "1eca92ac-9340-476a-b3ff-f8f8ed7d26ab" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nsITvMBs2Ujtv8rQ0KJM",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8623), new TimeSpan(0, 0, 0, 0, 0)), "75819f5b-0e2c-4eb4-b008-6b1137e078a6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nul5YjFdxToWeg1GrlCX",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8629), new TimeSpan(0, 0, 0, 0, 0)), "ecbf1f04-fbaf-4ee2-ad97-ac52e33748d4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "nWD6UJdXnV7cjq8tP6R8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8636), new TimeSpan(0, 0, 0, 0, 0)), "3850fa24-3f69-4775-a01e-85670d23a44c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "oyETMjvBlpVLEDFlVADI",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8641), new TimeSpan(0, 0, 0, 0, 0)), "86beaac8-167c-401a-b242-eab49c0e6edd" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "p4hD4RsKIPD68JMtt4N2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8647), new TimeSpan(0, 0, 0, 0, 0)), "4b28deee-65cd-483e-8dc3-9af78d902412" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "p6Wbw5sW2Fj67lvp482v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 0, 0, 0, 0)), "62ebf936-d1e9-4511-b043-528b48171c6b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pjQ5tv7x5L1UYaKzhokc",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 0, 0, 0, 0)), "cb2aeff2-b0fd-4aab-8a6b-50dabadbe0ce" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "PpQFVF4cAQlfX3BppjFB",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8668), new TimeSpan(0, 0, 0, 0, 0)), "7a5734ca-d345-428c-b64c-cbc0e4801284" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "PsbTIAKWHCVgruG7IgRE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8674), new TimeSpan(0, 0, 0, 0, 0)), "ed0af8e1-fec4-4324-9715-ba7e6afdf5aa" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "pTCUtnhqCmkJALgYU8NY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 0, 0, 0, 0)), "f2f3e495-4665-4b10-b393-b49cc3ff0ebc" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Q6kJ5uDgBmklCCBwofrx",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 0, 0, 0, 0)), "a7c9dddf-f29a-48b7-8afe-03d3e2f33a6f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QExc6n8HRxp39gGTKXSt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 0, 0, 0, 0)), "955e7ce2-0310-4202-80e0-702607f93299" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "qnkV2dT7G6arP780Dwxs",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 0, 0, 0, 0)), "4cda0a01-9e6b-430c-b30a-de6fc3bea274" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QojugShL0F4QRXbwv1r3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8727), new TimeSpan(0, 0, 0, 0, 0)), "11fe6f04-c809-4f33-b670-6b0a2d2b9d8e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "QS0jwSg5owyS3XS5xnbY",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 0, 0, 0, 0)), "bf3f590c-1528-44bb-a0e4-3ecaea2556ba" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "R0e7DzoQBFL5UIyTpqDP",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 0, 0, 0, 0)), "6c7f9600-0a4b-4370-91f2-481137a6e0ff" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "R9BIHlzCwb67GPT89e7F",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 0, 0, 0, 0)), "e7506bf4-5934-454e-b5bd-efc7ea9df1c7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RgqbbBCJaJLWTlu87M9R",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 0, 0, 0, 0)), "c4a2fdca-f5ce-405c-aad5-c2b5e9860fe4" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RRr4RDrnqyqmT3ehdy6Q",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, 0, 0, 0, 0)), "c34b1be2-811f-44a0-bc9b-e7dc8279495b" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "RuSMmRIATbwWRYSkgIrH",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8788), new TimeSpan(0, 0, 0, 0, 0)), "76ae1d78-fdd1-4311-bb34-ef6f82ac29bb" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "rYJp3Jg61wKdUqFGSAp3",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)), "d0298049-a975-4c8a-9fcf-091b55b931f1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sAKTDDgl9EDeyYnG77R8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 0, 0, 0, 0)), "1673dbb7-076e-4521-af5e-8d6d8daf67bd" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "SGKURGhEbYHIdqkxpDJh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8804), new TimeSpan(0, 0, 0, 0, 0)), "b815525d-bb82-4906-9d85-edbd513f1bad" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Sn4CRrl6hfVTTra5B0pd",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0)), "a5a60b18-fe83-4bf9-9ae0-855bb4276d44" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sQ5C4f7H60rzJLhMA0T5",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 0, 0, 0, 0)), "ee3e0a11-4e53-4373-86ad-fd42b71f9878" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sSh78RpjbHGvjL43TzMl",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0)), "24a938f6-34c3-40f3-8af7-6804745ab093" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Sw3e46nyzgd7zmMPVG4r",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)), "d56324cc-2f33-4eec-84d0-652f02c0b1da" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "sx9Vqv3yxRnX4SGwQa4y",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 0, 0, 0, 0)), "7b9fec32-2c34-48c8-b951-02d8d8b3d1e2" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "T8karRTfSTcM29oupBnt",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 0, 0, 0, 0)), "38b4087a-6904-4a6d-a034-8c9807b277a8" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "t9gPoXWQAlKYkzxc7EaK",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8876), new TimeSpan(0, 0, 0, 0, 0)), "f79d1b49-25dd-4983-a5a8-916660cd53fc" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TjjXJlSeru5Ccm3G2Vet",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 0, 0, 0, 0)), "118610a9-ddc3-4176-90e7-185fbefed808" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TJTAqICS7fjRu8I4afxm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8887), new TimeSpan(0, 0, 0, 0, 0)), "91de28c3-0c1c-4f8a-812c-4256f81bf089" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Tuaz0kuNQvU5jsy459u2",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 0, 0, 0, 0)), "f21a5a21-7bd4-496d-b9a7-2c2a89e1c48f" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "TXVRNj5SbqClTvNfEI8c",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8900), new TimeSpan(0, 0, 0, 0, 0)), "1060e003-cd13-4378-ae73-0082043ebe30" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "u3lzgWdKo9KaByo34lmN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8906), new TimeSpan(0, 0, 0, 0, 0)), "af28f5bc-c53c-4874-a375-7980d0ea8554" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UG6N8tBL4hpBPkjX12Bh",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 0, 0, 0, 0)), "159e6ec2-aa1b-4b1e-bca6-9575c6a3f3df" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "ulCdKx22IbD50hbfYtIE",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 0, 0, 0, 0)), "a05d5412-a16a-461d-b3fc-693137d05d89" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UpE1pLHfAgAQDHEVWdAb",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, 0, 0, 0, 0)), "a0df49fe-94c7-4bad-bcad-0da860fc15d5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "UpsGGKBQ2fXfNQBgABoF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), "fcfba8ae-a651-4dd3-be72-16c47da9cf0c" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "v1Q2gNvx2B1YX6h2w0TR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 0, 0, 0, 0)), "189a96f2-9be6-4585-8aa6-b5942e55afa7" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "v4vruTNk6WkdcxN3fFA0",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), "b6cb45f7-5663-4857-886a-a5e739c70111" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "V9HWmNFfpUS2Y5eLqrct",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8978), new TimeSpan(0, 0, 0, 0, 0)), "24cf7564-e56b-469e-b2d7-80a9ef6f55e9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vMFor3Ks1QECjDpWHUqW",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8983), new TimeSpan(0, 0, 0, 0, 0)), "5c773575-efe4-4fca-98ae-adaf341d282e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "vYf86TFDqUkh9RcEN9VN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8989), new TimeSpan(0, 0, 0, 0, 0)), "9066de6f-5adb-4656-baf4-75b618530973" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "W5TnArCA9xCEodsTpDHG",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8995), new TimeSpan(0, 0, 0, 0, 0)), "5f776f86-0478-49d8-be15-e87fe5d1a6a9" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wC0Q8eUqQLkE6cpVwHgu",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 0, 0, 0, 0)), "744c01ab-47e5-4644-b481-294e22434672" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wDseIgWSpqkLesX2ftwn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9006), new TimeSpan(0, 0, 0, 0, 0)), "f3460810-eb36-4e20-aaea-34fda0a29496" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "whPfE6p1LaKgaGTWoNqj",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, 0, 0, 0, 0)), "2f3051cd-afcc-4cdc-a38b-838f4da2a3f1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wMQSzkfJzJhYwfV22Ew6",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 0, 0, 0, 0)), "346f505e-dfbf-44d1-97de-54ebbfb93906" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "wwSqJWvMPuau2LBxW24w",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 0, 0, 0, 0)), "fb762b6f-8129-4822-a148-a1c56343960e" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XECbl6phGcsYXQWHwrT7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 0, 0, 0, 0)), "57b50fc1-2c40-4183-9523-6cac965c4d2d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "xHqKd4nN6cMLEAaL4zdp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9065), new TimeSpan(0, 0, 0, 0, 0)), "7f42fa42-0e5a-4ecd-aca5-1faa5c9ac20a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XQ0Nk2N0zDYDydY9CEpC",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9071), new TimeSpan(0, 0, 0, 0, 0)), "15d9297e-5f1f-472b-bc0f-2370f89e08c1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "xqP1xuan2MoXnMkwolM7",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 0, 0, 0, 0)), "69d0e194-94be-4afe-bf88-235de2fdcadb" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Xsx7AcUNguMUYwC2eInr",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9083), new TimeSpan(0, 0, 0, 0, 0)), "7067021c-be8c-4e94-8574-b809811681ce" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "XW7Xpw80z3VgX82egcWN",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, 0, 0, 0, 0)), "8dd9bd94-734c-4b55-a7fa-927679428cc5" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "Xz43eo1VM5H41uNJ9x28",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9126), new TimeSpan(0, 0, 0, 0, 0)), "d4b9220f-6dbf-42a3-99fa-eae30d5484de" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yjnmBGS0tfeUY6wppqlL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9134), new TimeSpan(0, 0, 0, 0, 0)), "e9ed7f72-e01e-45bc-b13c-433f31af832a" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YK3JYVEmHcskgB4f1s9M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9140), new TimeSpan(0, 0, 0, 0, 0)), "97d42b6a-cdee-4be3-8694-35331995b9c0" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YK3zzVEmH55kg41f1s2M",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), "be75255b-4972-4247-ab76-a454a0c97d99" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "yL0kvEf81nf8Sd7CGQys",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 0, 0, 0, 0)), "af2fedd5-c272-4324-b6fd-d1b3f2ae82c6" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YSHfWTR5rJ8vCR2S95xp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9157), new TimeSpan(0, 0, 0, 0, 0)), "f83b9c76-4c62-4c51-8724-c3c198d851a1" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "YUWNuWGy76j0cK9LWTP8",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)), "00d29878-5b84-476c-8c14-26dfbdeaecce" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zlaX6newWoQPagELHC4J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9168), new TimeSpan(0, 0, 0, 0, 0)), "cee08c24-e758-469f-b946-017c7c8d2880" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zmtbQwqcCyHjrSKk77Se",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 0, 0, 0, 0)), "79da50ae-6e15-4f5b-99cc-a6444502ac71" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zpPwsvLWKJ4CmjHmU1ES",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9180), new TimeSpan(0, 0, 0, 0, 0)), "362f256c-4d12-4b23-a1a8-570bca80965d" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zvQcGcl1nR7SpAfIMvxF",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 0, 0, 0, 0)), "c1405234-8d5c-40da-9b2f-5a4d8f305183" });

            migrationBuilder.UpdateData(
                schema: "Cars",
                table: "Brands",
                keyColumn: "Id",
                keyValue: "zzzbw5sz2hj27fvp4x2v",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8657), new TimeSpan(0, 0, 0, 0, 0)), "3f2f9c45-5dbf-42f6-995a-17cb5afeb684" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0Uun56AGjKNM2f07qMBS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(2232), new TimeSpan(0, 0, 0, 0, 0)), "b4f9c445-064b-4f58-9dbe-8dabd0bf1979" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "AhHuT41lRddLH1wachlm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 0, 0, 0, 0)), "21d44743-842f-4a91-8f20-79857d127530" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "DARdvjHJcTyGCYGekfIn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, 0, 0, 0, 0)), "bc918c00-e74d-40fa-a54e-fa94af9d4bec" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ExCL3LNxUqXNC8LFF8rL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), "37be675f-5343-4fea-aefd-8116c79dbc16" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "GFF7R0xsM4muSxEG8k0J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(2302), new TimeSpan(0, 0, 0, 0, 0)), "e4d1b75e-020c-44a3-a6b1-8d2934e4186c" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "lnm5mTuNV56JTQQYWPRe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(2307), new TimeSpan(0, 0, 0, 0, 0)), "2a2e1acb-8660-42bc-8b7d-e58591cc4b38" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "NUSX1N5R2xUS9WfTo3lp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(2313), new TimeSpan(0, 0, 0, 0, 0)), "fbc73333-6c47-4b57-ae64-03926a82db98" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "poo2JeVEhMn8wJz0KJdR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(2319), new TimeSpan(0, 0, 0, 0, 0)), "87878474-f946-4fd7-bdab-4a2cf6698c13" });
        }
    }
}
