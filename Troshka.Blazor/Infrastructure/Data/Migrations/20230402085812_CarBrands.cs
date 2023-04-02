using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Troshka.Blazor.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CarBrands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Cars");

            migrationBuilder.CreateTable(
                name: "Brands",
                schema: "Cars",
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
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Cars",
                table: "Brands",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "06MxFkB3ArFfVraVWN1u", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7878), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "AC", "efd1f8cb-9f79-456c-b855-866e8408cf7c" },
                    { "0SlIJFKD3VdaMAEnxfTT", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7887), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Abarth", "b87ebcbb-d460-4d76-89fc-78f6f766dd35" },
                    { "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Acura", "c822a296-7083-427f-9422-be370f78460a" },
                    { "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aixam", "46838afa-ca9b-499c-91ba-95f89e04b490" },
                    { "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7905), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alfa Romeo", "bbae4eff-4509-48aa-9884-b9a2f494858a" },
                    { "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina", "9975b097-7341-43b9-93b0-f5f9bbf24f57" },
                    { "3qGrKAnyJ2rmHlevXb8c", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7916), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aro", "acb523f8-ac2b-4ae8-a76a-3e8ebb3bf94f" },
                    { "3yTpJND7nxjtqoDcuc5M", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7921), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Asia", "babb5984-4bb8-456a-b9bf-a70fa8429d1d" },
                    { "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aston Martin", "214eabd6-5019-410c-9484-1fca0e9c5dec" },
                    { "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7934), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Audi", "5fbbd76f-5885-4710-9c87-2be984ae7f7a" },
                    { "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Austin", "07e7810b-758a-4a95-a27d-0cacdba7113f" },
                    { "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7966), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BMW", "cd711186-6aaf-4fd9-87c5-ac6682ba30d5" },
                    { "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7971), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bentley", "2c3968fa-390b-4d70-81aa-45e6c88f9864" },
                    { "65B72rCez5bGWR7Po3Ny", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7977), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Berliner", "7c643f5f-458c-48dc-af4e-2ee5061787b0" },
                    { "6mI4J3fGUdG5KvEHYjqL", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7983), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bertone", "55015a7d-c1ee-42eb-9728-cb7c298c8f76" },
                    { "7ReFhJXxyx7pAkvlW1eS", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7988), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Borgward", "d567aa3c-3632-499a-ba1d-804f8169612f" },
                    { "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(7994), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Brilliance", "fa4c25be-b722-4b94-a849-6cd8483c8f6e" },
                    { "9NRn3UNnrPnf2yJoGIBH", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bugatti", "7f6446fc-40ff-43c6-a8ef-b06577e2f504" },
                    { "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8006), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Buick", "7550088e-5368-4673-bb54-a413b7757af5" },
                    { "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8043), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cadillac", "4d2c4d3b-04f0-4c53-9721-fc1d28d50731" },
                    { "axxx6410rzzz3jxueox5", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BYD", "7b1cc648-f5c2-4886-86a7-f07deac765e0" },
                    { "B42TXsELwNJNBewRvcu5", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8049), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chery", "f2edfc89-a510-4c31-99e2-d7ae3acf282a" },
                    { "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chevrolet", "8fc6e022-1a3b-4f37-b9e0-43cb93032267" },
                    { "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8060), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chrysler", "6ec4cebc-4a1f-4322-ac0e-7356049976ee" },
                    { "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8066), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Citroen", "8f5cd8f4-a719-4f10-b781-5cc210c91eed" },
                    { "bymbQs0TabKzPsrN3TlL", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Corvette", "acef923b-cbb2-4dde-8ca4-f5ad1d1d3000" },
                    { "CDKhu32A8uPkeWM4eblC", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8078), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cupra", "53c7ff77-1bdb-484d-ba07-7d89b7dc0c97" },
                    { "cjnwEk8Wle037jtonYsj", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DONGFENG", "3e452af7-b583-4c08-94c4-37b08f963de3" },
                    { "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS", "b0526c84-2228-4b93-af7e-e1dbb722adad" },
                    { "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dacia", "57c76f5d-cb25-4917-82e9-828ec918948f" },
                    { "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8129), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daewoo", "ece27c60-7b3a-4a13-bcfa-cb0d60effb91" },
                    { "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8135), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daihatsu", "3153fc88-8ce5-43bd-8043-0c3b9a61017e" },
                    { "d6V8Py7xGhHTTVvS02QR", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8141), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daimler", "d58097e8-8726-482d-a76a-2aa1e76d4039" },
                    { "Dfej8VedBqRvW5SVCeo3", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8147), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Datsun", "446410c2-b00c-40bf-a3f4-b102d922c829" },
                    { "dksqVUhgDuHJ9KJ2uqyP", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8152), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dkw", "dacaf6eb-6261-4c88-91bf-772b915f841b" },
                    { "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dodge", "0b8e59b2-e716-44ad-aa0c-0e11757727bf" },
                    { "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8164), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dr", "a5947f4e-e75d-499e-9b7d-4feada1809b9" },
                    { "DV94kh1MyMbGW3P4aac5", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8169), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Eagle", "91fe67a6-19bf-4025-bf3c-da2839fa90a3" },
                    { "e7NrNKeWFc73uCAkz1Ar", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8222), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "FSO", "45229057-c5a3-4351-8168-c1c53818393d" },
                    { "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8228), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ferrari", "49e65e0e-eaff-4d04-8bda-e93a401a8635" },
                    { "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8235), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fiat", "74c0a307-142b-42b4-a53f-5075216c50fe" },
                    { "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8241), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ford", "700b3f70-c797-4580-b31b-0b2a4945b616" },
                    { "etMtb4JLm7eB90mlnd72", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8247), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GOUPIL", "303663ae-82c5-45d9-8bd7-47d6bb18a28e" },
                    { "eUMYrz00U0nQH5KTc7uR", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8252), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gaz", "fd242a59-8add-4fa4-b880-c15662a130ed" },
                    { "fAVrUUNVKFbMuNlP7oUW", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Geely", "be06d062-ddc1-4bec-b294-e38ea2b55520" },
                    { "FcCNt3RVlzMFl9Jtw38m", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8263), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Genesis", "c9274abf-4d9c-4cbb-af8e-99a731861917" },
                    { "Fjw2xBL9BqCaQBzxcxDI", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8268), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Geo", "70893c72-a9ac-49fc-90ff-ffcc80d93e4f" },
                    { "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8274), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GMC", "6c3cba6d-eaa9-4ed8-8253-e5cbb486c3ab" },
                    { "FXHe5SU6zyIfYHPGygNC", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8312), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gonow", "b2230142-b5b9-430a-a7c3-d99e5f613f28" },
                    { "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Great Wall", "b739c33d-4deb-458b-8ee4-8cf71aba4d67" },
                    { "ghyFhm7jzcjYDrjMVLs1", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8323), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Haval", "c63f76e3-3e51-4b4d-99bb-7f9cbab54b3b" },
                    { "gXuBjVjveGKf3R9Kc9vE", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8328), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Heinkel", "3247a1af-264f-40f2-960b-c2ca24bab176" },
                    { "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8334), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hillman", "e2e129b3-11d4-421f-a21f-ebe0d38ba697" },
                    { "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8339), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Honda", "fcebc047-3260-4585-9e1c-407171397f01" },
                    { "Hc1zhgoBCF1639Rp1PkY", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8345), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hummer", "0aca729e-925e-40da-afe0-86c1eb9eb642" },
                    { "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8350), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hyundai", "bd443d7e-3488-42c7-973c-07058de97497" },
                    { "HKjqbIm3EQ96YdfpakFI", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8357), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ifa", "d810c817-6f09-4b52-af09-244769cc68b7" },
                    { "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Infiniti", "9b1558a1-1942-42f0-8195-8b1fcbc03f26" },
                    { "hy7DsFSFE0ugKvGj8Hfk", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8406), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Innocenti", "a91b5f4b-56e8-49f3-8eef-54e4caf409db" },
                    { "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8412), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Isuzu", "59cc08e6-1c2a-49ac-b148-30ee5a8bb0ef" },
                    { "IR6qs66ukTVnB4w0NIFq", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8417), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Iveco", "5b944318-f77b-42c9-9dc7-9e770fbc7f21" },
                    { "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "JAC", "f4088539-d850-478e-9df2-8a9942f62b46" },
                    { "J3wnurM4CgKVkRFfRvHs", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8428), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "JAS", "57b3aee5-6e33-4376-9d6a-9476aa7bbd5a" },
                    { "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8434), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jaguar", "48ca48a9-1832-425c-8084-9edbb3f321e8" },
                    { "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8441), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jeep", "fc2cd733-ed56-45a9-bbeb-8a3ef9c1c6e4" },
                    { "k4Lylg5nrM6Vt1MrWfxS", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jpx", "c6ccc369-b9ec-40e7-9376-c6fb52b4bd66" },
                    { "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kia", "abca428b-e3ab-4b5c-9c44-68029e7dcb31" },
                    { "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8477), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lada", "01766a30-1bf6-47c8-a0fe-eadffc6cda06" },
                    { "KQMma7dRwtXlcym9oSWC", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8483), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Laforza", "bb8a73dc-12a5-481a-9d94-5870f37de6da" },
                    { "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8488), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lamborghini", "4d873b3a-7f1e-4d18-af1a-16119d76eb88" },
                    { "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lancia", "7381997c-de9f-4f25-aec0-4b1489f3a77c" },
                    { "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Land Rover", "67557a47-b775-4014-91b5-aca0b2370cbe" },
                    { "l5Xv7WgEwDFBEEnFG9uC", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Landwind", "eb24ff59-55c4-4928-ad04-22eceea422d8" },
                    { "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8513), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lexus", "aa316fb7-38a7-414a-98bb-59f3fe4e8276" },
                    { "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8518), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lifan", "44bc4c4d-1c35-4b85-80e3-49223e1a93ce" },
                    { "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8523), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lincoln", "75bd1644-39f1-4df5-aa27-275d850d83c9" },
                    { "lgRSEHsdarS0gC4osQWQ", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8547), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lotus", "5cb0b19a-85f9-4d9c-aa43-93a95dcbc861" },
                    { "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MG", "19108277-4033-4829-a204-055f2889abcb" },
                    { "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mahindra", "f27a20a5-4bce-424d-9cb3-f0d826b29275" },
                    { "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8564), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maserati", "6db1b731-c56a-45e3-a420-2a52c1f399f5" },
                    { "MlFe1uw8xqqhdAUnqcHd", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Matra", "6954756d-7cb8-439f-9eca-10c7cab7c61b" },
                    { "MvMqrrJaUbAAVIvJHQcu", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maybach", "715f22b8-1d66-47a6-bc69-8fc7150a5b31" },
                    { "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mazda", "1f334407-54a2-4350-b293-7050d7f511ef" },
                    { "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8587), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "McLaren", "5d587297-0b5e-4e97-bceb-c6064682fc0a" },
                    { "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mercedes-Benz", "4055c4ce-8b7d-46cc-9a5d-a8391d89a829" },
                    { "nm2AJSoa0dWnayDNBRnh", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mercury", "1eca92ac-9340-476a-b3ff-f8f8ed7d26ab" },
                    { "nsITvMBs2Ujtv8rQ0KJM", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8623), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Microcar", "75819f5b-0e2c-4eb4-b008-6b1137e078a6" },
                    { "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8629), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "ecbf1f04-fbaf-4ee2-ad97-ac52e33748d4" },
                    { "nWD6UJdXnV7cjq8tP6R8", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8636), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mitsubishi", "3850fa24-3f69-4775-a01e-85670d23a44c" },
                    { "oyETMjvBlpVLEDFlVADI", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8641), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Morgan", "86beaac8-167c-401a-b242-eab49c0e6edd" },
                    { "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8647), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Moskvich", "4b28deee-65cd-483e-8dc3-9af78d902412" },
                    { "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nissan", "62ebf936-d1e9-4511-b043-528b48171c6b" },
                    { "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Oldsmobile", "cb2aeff2-b0fd-4aab-8a6b-50dabadbe0ce" },
                    { "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8668), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Opel", "7a5734ca-d345-428c-b64c-cbc0e4801284" },
                    { "PsbTIAKWHCVgruG7IgRE", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8674), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Perodua", "ed0af8e1-fec4-4324-9715-ba7e6afdf5aa" },
                    { "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Peugeot", "f2f3e495-4665-4b10-b393-b49cc3ff0ebc" },
                    { "Q6kJ5uDgBmklCCBwofrx", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pgo", "a7c9dddf-f29a-48b7-8afe-03d3e2f33a6f" },
                    { "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Plymouth", "955e7ce2-0310-4202-80e0-702607f93299" },
                    { "qnkV2dT7G6arP780Dwxs", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Polestar", "4cda0a01-9e6b-430c-b30a-de6fc3bea274" },
                    { "QojugShL0F4QRXbwv1r3", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8727), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Polonez", "11fe6f04-c809-4f33-b670-6b0a2d2b9d8e" },
                    { "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pontiac", "bf3f590c-1528-44bb-a0e4-3ecaea2556ba" },
                    { "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Porsche", "6c7f9600-0a4b-4370-91f2-481137a6e0ff" },
                    { "R9BIHlzCwb67GPT89e7F", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Proton", "e7506bf4-5934-454e-b5bd-efc7ea9df1c7" },
                    { "RgqbbBCJaJLWTlu87M9R", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Qoros", "c4a2fdca-f5ce-405c-aad5-c2b5e9860fe4" },
                    { "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Renault", "c34b1be2-811f-44a0-bc9b-e7dc8279495b" },
                    { "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8788), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rieju", "76ae1d78-fdd1-4311-bb34-ef6f82ac29bb" },
                    { "rYJp3Jg61wKdUqFGSAp3", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rolls-Royce", "d0298049-a975-4c8a-9fcf-091b55b931f1" },
                    { "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8798), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rover", "1673dbb7-076e-4521-af5e-8d6d8daf67bd" },
                    { "SGKURGhEbYHIdqkxpDJh", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8804), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SECMA", "b815525d-bb82-4906-9d85-edbd513f1bad" },
                    { "Sn4CRrl6hfVTTra5B0pd", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SH auto", "a5a60b18-fe83-4bf9-9ae0-855bb4276d44" },
                    { "sQ5C4f7H60rzJLhMA0T5", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Saab", "ee3e0a11-4e53-4373-86ad-fd42b71f9878" },
                    { "sSh78RpjbHGvjL43TzMl", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Samand", "24a938f6-34c3-40f3-8af7-6804745ab093" },
                    { "Sw3e46nyzgd7zmMPVG4r", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Santana", "d56324cc-2f33-4eec-84d0-652f02c0b1da" },
                    { "sx9Vqv3yxRnX4SGwQa4y", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Saturn", "7b9fec32-2c34-48c8-b951-02d8d8b3d1e2" },
                    { "T8karRTfSTcM29oupBnt", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scion", "38b4087a-6904-4a6d-a034-8c9807b277a8" },
                    { "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Seat", "f79d1b49-25dd-4983-a5a8-916660cd53fc" },
                    { "TjjXJlSeru5Ccm3G2Vet", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Shatenet", "118610a9-ddc3-4176-90e7-185fbefed808" },
                    { "TJTAqICS7fjRu8I4afxm", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8887), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Shuanghuan", "91de28c3-0c1c-4f8a-812c-4256f81bf089" },
                    { "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8893), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Simca", "f21a5a21-7bd4-496d-b9a7-2c2a89e1c48f" },
                    { "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8900), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Skoda", "1060e003-cd13-4378-ae73-0082043ebe30" },
                    { "u3lzgWdKo9KaByo34lmN", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8906), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Smart", "af28f5bc-c53c-4874-a375-7980d0ea8554" },
                    { "UG6N8tBL4hpBPkjX12Bh", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8911), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SsangYong", "159e6ec2-aa1b-4b1e-bca6-9575c6a3f3df" },
                    { "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Subaru", "a05d5412-a16a-461d-b3fc-693137d05d89" },
                    { "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Suzuki", "a0df49fe-94c7-4bad-bcad-0da860fc15d5" },
                    { "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Talbot", "fcfba8ae-a651-4dd3-be72-16c47da9cf0c" },
                    { "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tata", "189a96f2-9be6-4585-8aa6-b5942e55afa7" },
                    { "v4vruTNk6WkdcxN3fFA0", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tavria", "b6cb45f7-5663-4857-886a-a5e739c70111" },
                    { "V9HWmNFfpUS2Y5eLqrct", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8978), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tazzari", "24cf7564-e56b-469e-b2d7-80a9ef6f55e9" },
                    { "vMFor3Ks1QECjDpWHUqW", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8983), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tempo", "5c773575-efe4-4fca-98ae-adaf341d282e" },
                    { "vYf86TFDqUkh9RcEN9VN", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8989), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Terberg", "9066de6f-5adb-4656-baf4-75b618530973" },
                    { "W5TnArCA9xCEodsTpDHG", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8995), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tesla", "5f776f86-0478-49d8-be15-e87fe5d1a6a9" },
                    { "wC0Q8eUqQLkE6cpVwHgu", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tofas", "744c01ab-47e5-4644-b481-294e22434672" },
                    { "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9006), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Toyota", "f3460810-eb36-4e20-aaea-34fda0a29496" },
                    { "whPfE6p1LaKgaGTWoNqj", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9041), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trabant", "2f3051cd-afcc-4cdc-a38b-838f4da2a3f1" },
                    { "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9047), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Triumph", "346f505e-dfbf-44d1-97de-54ebbfb93906" },
                    { "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9054), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Uaz", "fb762b6f-8129-4822-a148-a1c56343960e" },
                    { "XECbl6phGcsYXQWHwrT7", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "VROMOS", "57b50fc1-2c40-4183-9523-6cac965c4d2d" },
                    { "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9065), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "VW", "7f42fa42-0e5a-4ecd-aca5-1faa5c9ac20a" },
                    { "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9071), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Volga", "15d9297e-5f1f-472b-bc0f-2370f89e08c1" },
                    { "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9077), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Volvo", "69d0e194-94be-4afe-bf88-235de2fdcadb" },
                    { "Xsx7AcUNguMUYwC2eInr", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9083), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Warszawa", "7067021c-be8c-4e94-8574-b809811681ce" },
                    { "XW7Xpw80z3VgX82egcWN", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wartburg", "8dd9bd94-734c-4b55-a7fa-927679428cc5" },
                    { "Xz43eo1VM5H41uNJ9x28", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9126), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wiesmann", "d4b9220f-6dbf-42a3-99fa-eae30d5484de" },
                    { "yjnmBGS0tfeUY6wppqlL", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9134), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xinkai", "e9ed7f72-e01e-45bc-b13c-433f31af832a" },
                    { "YK3JYVEmHcskgB4f1s9M", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9140), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xinshun", "97d42b6a-cdee-4be3-8694-35331995b9c0" },
                    { "YK3zzVEmH55kg41f1s2M", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xpeng", "be75255b-4972-4247-ab76-a454a0c97d99" },
                    { "yL0kvEf81nf8Sd7CGQys", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Yogomo", "af2fedd5-c272-4324-b6fd-d1b3f2ae82c6" },
                    { "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9157), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zastava", "f83b9c76-4c62-4c51-8724-c3c198d851a1" },
                    { "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9163), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zaz", "00d29878-5b84-476c-8c14-26dfbdeaecce" },
                    { "zlaX6newWoQPagELHC4J", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9168), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Other", "cee08c24-e758-469f-b946-017c7c8d2880" },
                    { "zmtbQwqcCyHjrSKk77Se", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Победа", "79da50ae-6e15-4f5b-99cc-a6444502ac71" },
                    { "zpPwsvLWKJ4CmjHmU1ES", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9180), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "София", "362f256c-4d12-4b23-a1a8-570bca80965d" },
                    { "zvQcGcl1nR7SpAfIMvxF", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Чайка", "c1405234-8d5c-40da-9b2f-5a4d8f305183" },
                    { "zzzbw5sz2hj27fvp4x2v", new DateTimeOffset(new DateTime(2023, 4, 2, 8, 58, 12, 304, DateTimeKind.Unspecified).AddTicks(8657), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "NIO", "3f2f9c45-5dbf-42f6-995a-17cb5afeb684" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands",
                schema: "Cars");

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "0Uun56AGjKNM2f07qMBS",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(3995), new TimeSpan(0, 0, 0, 0, 0)), "577532f1-4438-4a2d-a226-ea751f91fe5a" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "AhHuT41lRddLH1wachlm",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 0, 0, 0, 0)), "38ada8a6-a5f3-42e4-8b97-e88e0b6756f3" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "DARdvjHJcTyGCYGekfIn",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4018), new TimeSpan(0, 0, 0, 0, 0)), "6ddfbf40-cf4a-4566-a2af-9a722dcd3070" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ExCL3LNxUqXNC8LFF8rL",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 0, 0, 0, 0)), "015b0d13-186d-4971-9fad-4572ac08bff2" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "GFF7R0xsM4muSxEG8k0J",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), "b7ae5262-cd7b-49db-828a-523bb7c8a811" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "lnm5mTuNV56JTQQYWPRe",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4101), new TimeSpan(0, 0, 0, 0, 0)), "3574dd5c-354f-430f-bf0a-5240a2ebdd0f" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "NUSX1N5R2xUS9WfTo3lp",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4118), new TimeSpan(0, 0, 0, 0, 0)), "cd80e9ba-b7a2-4b70-80e9-e7d9d4784b96" });

            migrationBuilder.UpdateData(
                schema: "Troshka",
                table: "Categories",
                keyColumn: "Id",
                keyValue: "poo2JeVEhMn8wJz0KJdR",
                columns: new[] { "DateCreated", "TrackId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 19, 4, 504, DateTimeKind.Unspecified).AddTicks(4124), new TimeSpan(0, 0, 0, 0, 0)), "ffe20117-1803-44e2-a2da-08995c1372f9" });
        }
    }
}
