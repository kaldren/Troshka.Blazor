using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Troshka.Blazor.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Cars");

            migrationBuilder.EnsureSchema(
                name: "Troshka");

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

            migrationBuilder.CreateTable(
                name: "Coupe",
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
                    table.PrimaryKey("PK_Coupe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
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
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
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
                    table.PrimaryKey("PK_Engines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EuroStandards",
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
                    table.PrimaryKey("PK_EuroStandards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
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
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
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
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
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
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "Troshka",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Regions_RegionId",
                        column: x => x.RegionId,
                        principalSchema: "Troshka",
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarOffers",
                schema: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoupeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BrandId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EngineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TransmissionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaterialId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EuroStandardId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrencyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horsepower = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    MonthProduced = table.Column<int>(type: "int", nullable: false),
                    YearProduced = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    Cubics = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PriceUponRequest = table.Column<bool>(type: "bit", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    HasABS = table.Column<bool>(type: "bit", nullable: false),
                    HasESP = table.Column<bool>(type: "bit", nullable: false),
                    HasASR = table.Column<bool>(type: "bit", nullable: false),
                    HasHillStartAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasFatigueWarningSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasLaneChangeAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasBlindSpotAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasNightVisionAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyBrakeAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyCallSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasTrafficSignRecognition = table.Column<bool>(type: "bit", nullable: false),
                    HasCruiseControl = table.Column<bool>(type: "bit", nullable: false),
                    HasAdaptiveCruiseControl = table.Column<bool>(type: "bit", nullable: false),
                    HasSpeedLimitControlSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasDistanceWarningSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasDriverAirbag = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontAirbags = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontAndSideAirbags = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontAndSideAndMoreAirbags = table.Column<bool>(type: "bit", nullable: false),
                    HasIsofix = table.Column<bool>(type: "bit", nullable: false),
                    HasBiXenonHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasLaserHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasLedHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasXenonHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasHeadlightWasherSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasGlareFreeHighBeamHeadlights = table.Column<bool>(type: "bit", nullable: false),
                    HasHighBeamAssist = table.Column<bool>(type: "bit", nullable: false),
                    HasAdaptiveCorneringLights = table.Column<bool>(type: "bit", nullable: false),
                    HasAdaptiveLighting = table.Column<bool>(type: "bit", nullable: false),
                    HasFogLamps = table.Column<bool>(type: "bit", nullable: false),
                    HasAlarm = table.Column<bool>(type: "bit", nullable: false),
                    HasEngineImobilizer = table.Column<bool>(type: "bit", nullable: false),
                    HasAirConditioner = table.Column<bool>(type: "bit", nullable: false),
                    HasClimateControl = table.Column<bool>(type: "bit", nullable: false),
                    HasHeatedWindshield = table.Column<bool>(type: "bit", nullable: false),
                    HasHeatedSteeringWheel = table.Column<bool>(type: "bit", nullable: false),
                    HasSelfSteeringSystems = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontParkAssistant = table.Column<bool>(type: "bit", nullable: false),
                    HasRearParkAssistant = table.Column<bool>(type: "bit", nullable: false),
                    HasCameraAssistant = table.Column<bool>(type: "bit", nullable: false),
                    Has360DegreeCameraAssistant = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontHeatedSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasBackHeatedSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasFrontAdjustableSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasBackAdjustableSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasSportSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasArmRest = table.Column<bool>(type: "bit", nullable: false),
                    HasMassageSeats = table.Column<bool>(type: "bit", nullable: false),
                    HasSeatVentilation = table.Column<bool>(type: "bit", nullable: false),
                    HasElectricWindows = table.Column<bool>(type: "bit", nullable: false),
                    HasElectricSideMirror = table.Column<bool>(type: "bit", nullable: false),
                    HasElectricTailgate = table.Column<bool>(type: "bit", nullable: false),
                    HasCentralLocking = table.Column<bool>(type: "bit", nullable: false),
                    HasKeylessCentralLocking = table.Column<bool>(type: "bit", nullable: false),
                    HasLightSensor = table.Column<bool>(type: "bit", nullable: false),
                    HasRainSensor = table.Column<bool>(type: "bit", nullable: false),
                    HasPowerAssistedSteering = table.Column<bool>(type: "bit", nullable: false),
                    HasAmbientLighting = table.Column<bool>(type: "bit", nullable: false),
                    HasLeatherSteeringWheel = table.Column<bool>(type: "bit", nullable: false),
                    HasRadio = table.Column<bool>(type: "bit", nullable: false),
                    HasCDPlayer = table.Column<bool>(type: "bit", nullable: false),
                    HasTV = table.Column<bool>(type: "bit", nullable: false),
                    HasNavigationSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasSoundSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasTouchScreen = table.Column<bool>(type: "bit", nullable: false),
                    HasVoiceControl = table.Column<bool>(type: "bit", nullable: false),
                    HasMultifunctionSteeringWheel = table.Column<bool>(type: "bit", nullable: false),
                    HasHandsfreeKit = table.Column<bool>(type: "bit", nullable: false),
                    HasUSBPort = table.Column<bool>(type: "bit", nullable: false),
                    HasBluetooth = table.Column<bool>(type: "bit", nullable: false),
                    HasAppleCarPlay = table.Column<bool>(type: "bit", nullable: false),
                    HasAndroidAuto = table.Column<bool>(type: "bit", nullable: false),
                    HasOnboardComputer = table.Column<bool>(type: "bit", nullable: false),
                    HasHeadupDisplay = table.Column<bool>(type: "bit", nullable: false),
                    HasDigitalCockpit = table.Column<bool>(type: "bit", nullable: false),
                    HasSummerTires = table.Column<bool>(type: "bit", nullable: false),
                    HasWinterTires = table.Column<bool>(type: "bit", nullable: false),
                    HasAllSeasonTires = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyTire = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyTireKit = table.Column<bool>(type: "bit", nullable: false),
                    HasPanoramicRoof = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarOffers_Brands_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "Cars",
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_Coupe_CoupeId",
                        column: x => x.CoupeId,
                        principalSchema: "Cars",
                        principalTable: "Coupe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "Troshka",
                        principalTable: "Currencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_Engines_EngineId",
                        column: x => x.EngineId,
                        principalSchema: "Troshka",
                        principalTable: "Engines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_EuroStandards_EuroStandardId",
                        column: x => x.EuroStandardId,
                        principalSchema: "Troshka",
                        principalTable: "EuroStandards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_Interior_MaterialId",
                        column: x => x.MaterialId,
                        principalSchema: "Troshka",
                        principalTable: "Interior",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "Troshka",
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_Models_ModelId",
                        column: x => x.ModelId,
                        principalSchema: "Cars",
                        principalTable: "Models",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_Regions_RegionId",
                        column: x => x.RegionId,
                        principalSchema: "Troshka",
                        principalTable: "Regions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarOffers_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalSchema: "Troshka",
                        principalTable: "Transmissions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OfferImages",
                schema: "Troshka",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfferId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrackId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferImages_CarOffers_OfferId",
                        column: x => x.OfferId,
                        principalSchema: "Cars",
                        principalTable: "CarOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Cars",
                table: "Brands",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "06MxFkB3ArFfVraVWN1u", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "AC", "8561de47-a8a3-4621-b5bd-ff4cec653da0" },
                    { "0SlIJFKD3VdaMAEnxfTT", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7457), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Abarth", "8d9cb9c7-933a-4512-a836-71dd6ad69db6" },
                    { "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Acura", "50cda7da-5646-4bff-8226-1a959c7b7c3b" },
                    { "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aixam", "502005fb-0ce3-4965-887f-dc553ad604bc" },
                    { "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7477), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alfa Romeo", "6949da22-6d36-47f3-a384-1a4584352ad5" },
                    { "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina", "b14e178c-30e6-41cf-96d5-532c73ff9125" },
                    { "3qGrKAnyJ2rmHlevXb8c", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aro", "0d629f46-45a1-4c93-83a0-2d3c51c913e5" },
                    { "3yTpJND7nxjtqoDcuc5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Asia", "4c654fa6-fd5b-4b15-b1de-d3911e6769ee" },
                    { "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7522), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Aston Martin", "b46bbc9a-9c57-48d3-bb84-b7a7ee17fe5b" },
                    { "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7529), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Audi", "2eab586b-47ea-4168-a3fe-10a59fa6c3f3" },
                    { "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Austin", "8ccb10c6-251b-4829-a5c2-4a8a1a6fa7c5" },
                    { "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BMW", "96f3bf39-bfb3-4fcf-a905-d83adf6f0be7" },
                    { "5TgVdpBPF4SsQWVFP08j", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7549), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bentley", "d73b1e69-83b9-434b-b3c5-71b1538722bb" },
                    { "65B72rCez5bGWR7Po3Ny", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Berliner", "5e468a42-9148-4775-bd9a-eb9b9f93f141" },
                    { "6mI4J3fGUdG5KvEHYjqL", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bertone", "2d0b80da-0fb5-4a88-8dc5-d39e5f4e218a" },
                    { "7ReFhJXxyx7pAkvlW1eS", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Borgward", "3725be63-8e2d-4ed2-910b-9447a3dbb566" },
                    { "8mIlNn2498yIC72vgKBK", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7572), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Brilliance", "bbd28904-b4b6-4380-ba92-c32213aa1ed3" },
                    { "9NRn3UNnrPnf2yJoGIBH", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bugatti", "dc0fa1f6-31ce-4144-b7db-57d5853d653e" },
                    { "aPIB6410rSAP3jxueo2Y", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7607), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Buick", "f7972435-b968-4a0a-8252-ec386a527e1b" },
                    { "ATbb9NezfDxSdpBXdqd6", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cadillac", "debb0f65-c311-480b-aa5d-97b8901c1f6b" },
                    { "axxx6410rzzz3jxueox5", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7613), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BYD", "7b40a785-001c-432d-beed-ef76561caff1" },
                    { "B42TXsELwNJNBewRvcu5", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7625), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chery", "7e01726f-e541-4145-b899-6508d59c6d9a" },
                    { "BESQA89ghmpmxnMv6lb4", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7630), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chevrolet", "281e4c08-2f99-4740-9a1a-345430009b1d" },
                    { "bshsdfzU1lNaPe58k9Io", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Chrysler", "d5fc1624-b584-4081-a9ac-bf6d54c8788d" },
                    { "bXGDbcoVlUUFaUAeuBhU", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7642), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Citroen", "b4417ebc-2fe5-4858-87cd-fcaa19cc46dc" },
                    { "bymbQs0TabKzPsrN3TlL", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Corvette", "9f097000-7a08-4d36-a410-8c9d5d86c801" },
                    { "CDKhu32A8uPkeWM4eblC", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cupra", "055f148c-6492-421b-97c1-1b3064e33979" },
                    { "cjnwEk8Wle037jtonYsj", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7660), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DONGFENG", "da4c7870-e2f2-46c5-94de-ff9e115cbf77" },
                    { "cYgoBzV1QqkgGALBMqxE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7702), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DS", "a2fc9953-d1ba-485d-8508-2ef2fef9fbc2" },
                    { "cYlq5o6z4W9RcnLLB6zq", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dacia", "a5228c97-0d71-4d5a-952e-8f42bd485444" },
                    { "D67BxpjC6stcD4YYGmdn", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daewoo", "1693b1bd-4a90-4678-b9aa-9be49b448cad" },
                    { "D6a4Vo3VE2WzDdgA5AFo", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7719), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daihatsu", "745299af-4249-4f39-a533-8e6223ecb79b" },
                    { "d6V8Py7xGhHTTVvS02QR", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7725), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Daimler", "67817e54-e006-4948-948f-e04cccfe7f85" },
                    { "Dfej8VedBqRvW5SVCeo3", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Datsun", "30ff5cb1-46d1-41ff-8278-2aab307035c6" },
                    { "dksqVUhgDuHJ9KJ2uqyP", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dkw", "cfd18fc6-e590-46a9-b4ac-4265ca0ffee1" },
                    { "DsQDYqGhCx8KL7zF4UFK", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dodge", "363c01f6-a4c1-4089-8e31-b5e827d300cc" },
                    { "DumA309cvKSKLalqcW6h", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7749), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Dr", "4c5625ec-c4a0-4774-84fc-80fc66236597" },
                    { "DV94kh1MyMbGW3P4aac5", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7776), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Eagle", "2f83a3d3-3a53-4b31-b9d1-89e20ee7e37f" },
                    { "e7NrNKeWFc73uCAkz1Ar", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7783), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "FSO", "e286b3a7-747e-4dce-8e5b-44589b373016" },
                    { "eF1lrB1EP63Y0DablBJF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ferrari", "73446cdb-fd7e-4224-b05c-b2a596947071" },
                    { "EMczl7VAvCRwT3kAz4In", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7794), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Fiat", "d6b2e809-4e41-403e-b570-74e6fda94e7d" },
                    { "emn3h8NrhdSz7ojPBV2H", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7799), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ford", "1b86478b-ca8e-4215-90d7-84ffa872375e" },
                    { "etMtb4JLm7eB90mlnd72", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7807), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GOUPIL", "93540179-d62a-401b-9c21-54cce37f22a9" },
                    { "eUMYrz00U0nQH5KTc7uR", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7812), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gaz", "566c12a5-929d-4443-b868-e8daffc55d0d" },
                    { "fAVrUUNVKFbMuNlP7oUW", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7817), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Geely", "fa5b2da1-d557-40b6-9e18-2e1812f86e51" },
                    { "FcCNt3RVlzMFl9Jtw38m", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7823), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Genesis", "6cab884b-9ab5-46d7-a0bc-26d9feb7dd0f" },
                    { "Fjw2xBL9BqCaQBzxcxDI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Geo", "f4e7de03-58a0-4676-a844-d76099f10ac1" },
                    { "FtX2HosXUQDnvSScsyP8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7855), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GMC", "ec935e07-f380-4d7c-9ade-6781f306efd9" },
                    { "FXHe5SU6zyIfYHPGygNC", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7861), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gonow", "27a90db2-599b-48e5-87ad-01f9a599ad98" },
                    { "GBnMMAvdjskIFpKTYLb1", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7867), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Great Wall", "ab1d9438-fd5e-44dc-98e5-28a56642f210" },
                    { "ghyFhm7jzcjYDrjMVLs1", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7874), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Haval", "5fcdca35-3413-4be0-a916-d14b8d62d8bc" },
                    { "gXuBjVjveGKf3R9Kc9vE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7880), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Heinkel", "3877fa8d-b837-4e7e-a84c-13c94354462c" },
                    { "h6Bfvk5LdFwXv9QzKLxU", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7885), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hillman", "3c5c29b1-ebca-4192-8105-3103efc13695" },
                    { "hajLAGmn9WWXQco4CXw1", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Honda", "558b6250-3ca4-4a54-9d82-2789a2bc6cb5" },
                    { "Hc1zhgoBCF1639Rp1PkY", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7896), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hummer", "76b66d61-9eb4-459a-b38f-bc00f5be10a6" },
                    { "HhvYG9GBNEg7RhQBIjtY", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7902), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Hyundai", "5cb7aeb2-7295-4e7d-a621-76fa9fce7caa" },
                    { "HKjqbIm3EQ96YdfpakFI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ifa", "f0fe2cf2-4c5c-4ba4-bf4c-d4cbdfe918bc" },
                    { "HrERVHUdBMrdUrgLsvuT", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7935), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Infiniti", "f04fe7ab-1bc0-4f70-b5a4-516381304abd" },
                    { "hy7DsFSFE0ugKvGj8Hfk", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7942), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Innocenti", "280edc77-8f4e-4fff-8f6d-4bb2faa8b906" },
                    { "IIqtbBpQcKHy7TVA10Nl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7948), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Isuzu", "78efabbb-2489-4ac5-a8e3-dde0efcebc47" },
                    { "IR6qs66ukTVnB4w0NIFq", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7953), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Iveco", "ba8812cf-bf67-4b07-8a99-00cbde08138b" },
                    { "j0N3jEL5HfQ9Ve0KVNUl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "JAC", "bbe97548-0051-4401-99ca-72afd810d4be" },
                    { "J3wnurM4CgKVkRFfRvHs", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "JAS", "39f81293-67e2-406b-b9b2-e003ddee361d" },
                    { "JqgJmqpSsWvQ7b60GLvq", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jaguar", "9612115d-ce2b-42db-a918-bd9966c77e21" },
                    { "jyCumAseWnFjQjPzn3kQ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7975), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jeep", "d5811bb6-5c67-4c75-8a5c-cd0d37da48d6" },
                    { "k4Lylg5nrM6Vt1MrWfxS", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Jpx", "69258266-b11f-4dfa-8a81-c2257e7b9eeb" },
                    { "KCEkkBQL72L0jmEutbgl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8008), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Kia", "1a45b1de-5b45-4d07-966d-ed94c2b1ee03" },
                    { "kF0x9WcUJs7aHYtoKzWY", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lada", "04daee41-17aa-4ba0-b09b-9858c4757bf5" },
                    { "KQMma7dRwtXlcym9oSWC", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8019), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Laforza", "f2e6d530-c12d-464c-b825-821f84049263" },
                    { "KRmmVEwPAtzSzJQgD6HY", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8026), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lamborghini", "0e4a8755-dcbf-45d7-aa15-339e1a410a8c" },
                    { "KvyHwQN3QMrXmgbsvne9", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8031), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lancia", "3c9cdb1b-e2d5-459f-aef8-18728e45f59f" },
                    { "kXULxNaVDJWKs2ACmH5C", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8037), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Land Rover", "7a66918f-a593-47ff-ac73-b0ccad69d745" },
                    { "l5Xv7WgEwDFBEEnFG9uC", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8043), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Landwind", "e0a24241-8962-4402-b60f-9a63e8140de8" },
                    { "laJM8lrsRY8D0eRYypqk", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8049), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lexus", "0dc0412f-722d-4d50-9304-d3a4648a77f0" },
                    { "LcuKvSewzBSW3KEJdLIa", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8056), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lifan", "6449d3b0-94ea-43a0-a14b-f23b1979f76d" },
                    { "lEVEcrE9FIVtGbtFarHV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lincoln", "10655f79-f199-4a05-a2ff-70cf639d70aa" },
                    { "lgRSEHsdarS0gC4osQWQ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8088), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Lotus", "8ee6602f-6101-4f43-a339-3a19bfd6ceac" },
                    { "Lxge9Bn07u7pWE0RqbwJ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MG", "4f431636-d21a-4b7e-a467-b32b2ed2c5ab" },
                    { "m5L90Q8l2fTcbPyeA3GF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mahindra", "1f9bbf57-9883-477b-a9ee-e813dd5cbb8e" },
                    { "mEjXfYc5wzIHYnGGpCbE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maserati", "8852e899-5dfd-4b1a-aef2-d82616214518" },
                    { "MlFe1uw8xqqhdAUnqcHd", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Matra", "b80546a3-9e28-44af-83bb-7889bf4b8685" },
                    { "MvMqrrJaUbAAVIvJHQcu", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maybach", "75154250-e6fa-4b12-a1d0-5a23b1cc5c2f" },
                    { "MX3aL9JN6gD0F4KRl0Nq", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mazda", "5550df8f-2930-4342-8f39-7cda983cf4ab" },
                    { "n1jg2wtcteSRvhvMGm4n", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8130), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "McLaren", "a98839ee-e5cc-4b13-b8c3-4897c6f83a7b" },
                    { "nDxKpo5IAKk62ekEBbNS", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8136), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mercedes-Benz", "390476d7-0ac4-4216-a120-9041cf2873a0" },
                    { "nm2AJSoa0dWnayDNBRnh", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8162), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mercury", "08229495-4c6f-4231-93d5-f6d15c01a520" },
                    { "nsITvMBs2Ujtv8rQ0KJM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8169), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Microcar", "3cb18dbe-1e58-4355-b208-17fad58806c1" },
                    { "nul5YjFdxToWeg1GrlCX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8174), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "152b27af-ae96-487d-91bd-982a7d422039" },
                    { "nWD6UJdXnV7cjq8tP6R8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8179), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mitsubishi", "022274c9-9a6b-4353-a425-3a51a128c180" },
                    { "oyETMjvBlpVLEDFlVADI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8185), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Morgan", "ed6f21fd-3639-4874-8af1-9bf3c9e79cff" },
                    { "p4hD4RsKIPD68JMtt4N2", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8192), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Moskvich", "f0a3f123-69bb-4488-9828-5f612d5f1c7d" },
                    { "p6Wbw5sW2Fj67lvp482v", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8198), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Nissan", "a8534811-1493-44f9-b592-74dae0c1594f" },
                    { "pjQ5tv7x5L1UYaKzhokc", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8209), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Oldsmobile", "a651dc01-ea3a-4ffc-a178-fd06e57e8023" },
                    { "PpQFVF4cAQlfX3BppjFB", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Opel", "785ee565-804b-462d-a151-ef2f2051ed47" },
                    { "PsbTIAKWHCVgruG7IgRE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8242), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Perodua", "dd29476b-0d5f-4aba-b640-a0e44cd69d8f" },
                    { "pTCUtnhqCmkJALgYU8NY", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8248), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Peugeot", "2bdc9236-6afb-4de6-afb2-52124725ca3d" },
                    { "Q6kJ5uDgBmklCCBwofrx", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8254), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pgo", "dee0fac8-ed3b-45dc-84d8-8200cbcc56a3" },
                    { "QExc6n8HRxp39gGTKXSt", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8261), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Plymouth", "9cfb9ba7-6a2d-49e1-8bfa-3192fa72fd66" },
                    { "qnkV2dT7G6arP780Dwxs", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Polestar", "71145aef-8616-4ae6-b5e6-9a7c084113f7" },
                    { "QojugShL0F4QRXbwv1r3", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8272), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Polonez", "20842c3c-70e8-4831-96b1-6c28fe56310a" },
                    { "QS0jwSg5owyS3XS5xnbY", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Pontiac", "c7bd4fd1-f983-40bf-8a1e-1f7ac9327d6e" },
                    { "R0e7DzoQBFL5UIyTpqDP", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8283), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Porsche", "608c8535-210f-433b-aee3-b1337edda564" },
                    { "R9BIHlzCwb67GPT89e7F", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8288), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Proton", "44b6a548-3f73-48b6-b8a9-904e7658600b" },
                    { "RgqbbBCJaJLWTlu87M9R", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8323), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Qoros", "1de2863f-7a03-48de-9cd4-31531881142d" },
                    { "RRr4RDrnqyqmT3ehdy6Q", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Renault", "d1acf0ce-1ac5-4e03-a9c8-5748feb10151" },
                    { "RuSMmRIATbwWRYSkgIrH", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8336), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rieju", "1c8fd6b7-64d9-4dbb-8d72-b8daf369cc1b" },
                    { "rYJp3Jg61wKdUqFGSAp3", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8342), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rolls-Royce", "770a241c-e3fc-4286-b69e-3c292f1e602f" },
                    { "sAKTDDgl9EDeyYnG77R8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8347), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rover", "2519ae6c-4704-4eb0-9b81-469bf5810e8f" },
                    { "SGKURGhEbYHIdqkxpDJh", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8353), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SECMA", "c55ed865-276b-4cbe-bfe0-de0e14f80f0a" },
                    { "Sn4CRrl6hfVTTra5B0pd", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8358), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SH auto", "6adc16bc-941f-48d3-88a4-faadfd700477" },
                    { "sQ5C4f7H60rzJLhMA0T5", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8364), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Saab", "6d9dac6b-f13c-46b8-aeb4-dae9b60c4239" },
                    { "sSh78RpjbHGvjL43TzMl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Samand", "01f8ff28-a3f1-4595-acc4-10651a61d7ff" },
                    { "Sw3e46nyzgd7zmMPVG4r", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8395), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Santana", "9656c54f-66bf-43da-a518-5a22a37f73c3" },
                    { "sx9Vqv3yxRnX4SGwQa4y", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8403), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Saturn", "99b25bdc-b884-46e8-908b-8123c18d38c7" },
                    { "T8karRTfSTcM29oupBnt", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8409), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Scion", "6cbcbe70-b9d5-4a01-a5ca-9e69e6c89aec" },
                    { "t9gPoXWQAlKYkzxc7EaK", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8415), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Seat", "8c5d0f66-4c3e-4a1f-98a3-05e0e9499220" },
                    { "TjjXJlSeru5Ccm3G2Vet", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8420), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Shatenet", "fe72f06a-181b-4677-8cae-00e57b932fe3" },
                    { "TJTAqICS7fjRu8I4afxm", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8426), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Shuanghuan", "f1343275-b5fa-434e-9c6c-889f158b0768" },
                    { "Tuaz0kuNQvU5jsy459u2", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8431), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Simca", "3f29dbd9-8d5e-465f-9825-8edc50609baa" },
                    { "TXVRNj5SbqClTvNfEI8c", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8437), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Skoda", "b26be70b-69a2-4e75-8c5b-823ee0728940" },
                    { "u3lzgWdKo9KaByo34lmN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8442), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Smart", "ee802363-7472-453b-9d32-a44642799654" },
                    { "UG6N8tBL4hpBPkjX12Bh", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8450), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SsangYong", "16d79143-8709-4f1e-b412-badfc57649e2" },
                    { "ulCdKx22IbD50hbfYtIE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8478), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Subaru", "ddc0891e-f60f-4d9c-9d90-489322aa94a5" },
                    { "UpE1pLHfAgAQDHEVWdAb", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8484), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Suzuki", "c5d2df21-9845-46c3-89fe-edc89f9d3bc8" },
                    { "UpsGGKBQ2fXfNQBgABoF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Talbot", "d54394d3-4119-4124-874f-866fb90a97e5" },
                    { "v1Q2gNvx2B1YX6h2w0TR", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8495), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tata", "8f0c9b9a-a063-4195-b0de-55e1e1ce0226" },
                    { "v4vruTNk6WkdcxN3fFA0", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tavria", "5fd3c21c-d9a4-41af-9ed9-25360b07c4b9" },
                    { "V9HWmNFfpUS2Y5eLqrct", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8508), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tazzari", "85693a95-01ca-40cf-a6ff-75e36914c2cc" },
                    { "vMFor3Ks1QECjDpWHUqW", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8513), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tempo", "def6af54-eb8d-4871-9c72-a7445912c2fa" },
                    { "vYf86TFDqUkh9RcEN9VN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8521), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Terberg", "67cfc568-8c26-4a01-80da-9412321dd121" },
                    { "W5TnArCA9xCEodsTpDHG", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8526), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tesla", "4473d86f-a31a-4da0-b467-00dab628fede" },
                    { "wC0Q8eUqQLkE6cpVwHgu", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8553), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tofas", "6a992040-9542-4a60-89e3-a87a64b00ee0" },
                    { "wDseIgWSpqkLesX2ftwn", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Toyota", "9d497dfd-8a17-4f7b-b5d8-539eae7c51fe" },
                    { "whPfE6p1LaKgaGTWoNqj", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trabant", "59d5250a-6698-4cc9-b62a-50d9734239d4" },
                    { "wMQSzkfJzJhYwfV22Ew6", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Triumph", "fca7cba2-d30e-46b4-8529-384959c17a27" },
                    { "wwSqJWvMPuau2LBxW24w", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Uaz", "968c2d8a-f410-4e89-8354-2a43770e5c26" },
                    { "XECbl6phGcsYXQWHwrT7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "VROMOS", "b73f2e84-2bbf-4b90-b2fc-a0a2fe2a5080" },
                    { "xHqKd4nN6cMLEAaL4zdp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8590), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "VW", "b5911539-5d9a-49a3-a116-38d36deb6a04" },
                    { "XQ0Nk2N0zDYDydY9CEpC", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8595), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Volga", "59c4a8fb-326d-4203-b3a5-377d5c2dec5e" },
                    { "xqP1xuan2MoXnMkwolM7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8601), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Volvo", "9f2d1aa3-3a00-469f-86cb-8f3ad3b987b2" },
                    { "Xsx7AcUNguMUYwC2eInr", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8606), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Warszawa", "b8ca9425-0efc-4440-971a-d7e9fd72e0e8" },
                    { "XW7Xpw80z3VgX82egcWN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8634), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wartburg", "149ca15a-7b5f-41f2-afd6-eb26d169529b" },
                    { "Xz43eo1VM5H41uNJ9x28", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8640), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Wiesmann", "c0909b11-eb25-4d3f-94fb-9fe3d440c0e8" },
                    { "yjnmBGS0tfeUY6wppqlL", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8646), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xinkai", "9153e0ac-4fd4-4529-8742-2542e66d2803" },
                    { "YK3JYVEmHcskgB4f1s9M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xinshun", "32546980-0629-4f83-8c96-15bcdd2e39f9" },
                    { "YK3zzVEmH55kg41f1s2M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8659), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Xpeng", "716b3da0-5a83-485d-8e53-f90a2d418e92" },
                    { "yL0kvEf81nf8Sd7CGQys", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Yogomo", "674b795a-1d55-44d8-9f62-0de11ca42f6c" },
                    { "YSHfWTR5rJ8vCR2S95xp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zastava", "ea5f1cb2-ab35-4cb9-a91a-3cf10f45bb0e" },
                    { "YUWNuWGy76j0cK9LWTP8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Zaz", "8f0c801d-5747-4341-9949-2928a3679cc8" },
                    { "zlaX6newWoQPagELHC4J", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8681), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Other", "d32a2c79-c4d6-4bca-968f-45098283590d" },
                    { "zmtbQwqcCyHjrSKk77Se", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Победа", "2626d6b7-27e2-406d-a7d2-6409ce17fd50" },
                    { "zpPwsvLWKJ4CmjHmU1ES", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "София", "ad76f23a-6d16-4f95-89aa-f8d47d0d3e36" },
                    { "zvQcGcl1nR7SpAfIMvxF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Чайка", "aa7fd760-57b9-493a-bce1-3be7a827dfa8" },
                    { "zzzbw5sz2hj27fvp4x2v", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "NIO", "87ec7d14-2702-4327-97fc-c6c13b33df62" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "0Uun56AGjKNM2f07qMBS", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7079), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Cars", "c3010ae5-e8d9-45cc-b752-d4fe55c59619" },
                    { "AhHuT41lRddLH1wachlm", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Buses", "ec74c7d3-4450-4414-b744-589466c05c4e" },
                    { "DARdvjHJcTyGCYGekfIn", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7105), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Motorcycles", "ea034b82-4260-4d94-840e-d23a7244115b" },
                    { "ExCL3LNxUqXNC8LFF8rL", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7140), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Trucks", "2d66afde-1425-4c05-8945-d4f6b5e41779" },
                    { "GFF7R0xsM4muSxEG8k0J", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Caravans", "1a71f3c6-1765-4174-8396-777f6fe77d0a" },
                    { "lnm5mTuNV56JTQQYWPRe", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7152), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Boats", "74a8187f-a7f5-4e44-851a-e7eb8a4478c0" },
                    { "NUSX1N5R2xUS9WfTo3lp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7158), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Construction", "125b7531-4db1-45e2-953a-8649cbc69ad7" },
                    { "poo2JeVEhMn8wJz0KJdR", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 318, DateTimeKind.Unspecified).AddTicks(7164), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Agriciltural", "477bc911-876b-450d-b1a8-83dd7112f835" }
                });

            migrationBuilder.InsertData(
                schema: "Cars",
                table: "Coupe",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "17uwRnksm3dHVtGXjxg8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Кабрио", "880e923c-435f-48bb-b4ac-96ac05c9bc0a" },
                    { "3GLNa5pkWPOWVuSdVjdX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Седан", "a71dd29e-edd2-4ac5-b50d-a8fe6d8717a3" },
                    { "JD9wmJVdkgyRHCXjCs7V", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2563), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Хечбек", "6c73dfb1-bb41-4eed-a553-b7069a8c752c" },
                    { "pPrhSk2DBNYBz6sCoF81", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2612), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Джип", "320ab690-2110-48d7-be95-1935d598e109" },
                    { "qpfpQc2ba4RuH4SUb2uI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2624), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ван", "fe4c1f10-0797-4a59-a5e0-1d9b8ce9f0c2" },
                    { "vqB7n29Zlq6pL8TKKL7j", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Купе", "de911e5e-560b-4fd6-964c-68a88db1fa64" },
                    { "xrAUDYo0LOc0HQWGSXVW", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2617), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Пикап", "29d9946e-a624-434b-af72-a26551be6585" },
                    { "ZfEvTe27FGIJe7I1eQkG", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2571), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Комби", "4691f3e4-87a7-40de-9554-e051898cd3a0" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Currencies",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "D0lwShX77YcUMSuQdET7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "USD", "7639727a-6f03-4316-a2c7-c88b0289e15d" },
                    { "Kg0F4nyzIG3HqQ4t1akl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "EUR", "fe88466d-0f7c-4dce-866a-bc65c9de9fec" },
                    { "rclPPUzk7rGwNc1SqIfW", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5814), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "BGN", "8bed29d3-5f79-4375-bb0a-3e9e34b05243" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Engines",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "2RoShtYNcgmlgSgygwVy", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Plug-in хибрид", "64eb4a0b-5bb7-4a69-bba6-bbdbc5e35bf2" },
                    { "7IWNqEa2tndgaBdjBtwL", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Бензин", "3ec7fee5-9480-4cb3-afd3-ca04b96bd2f0" },
                    { "bLu2HDXgeElNRCYy3lqh", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5619), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Хибрид", "28ac862d-a8c5-4395-b477-d7d1e48dde57" },
                    { "N1Pfu9Dmk1tIJQufyzIV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5605), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Дизел", "cb465755-ee8e-4a04-8a6c-67356215f47c" },
                    { "Rod471Iewg4QrzIVplT0", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Електрически", "ee5ebaa8-98a9-4b66-acf3-caf133373974" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "EuroStandards",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "BzzW2BWxALTYuyygmok7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5899), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 1", "60efb465-6530-4df9-96ce-e7f956abb9c6" },
                    { "mAenXWxTffogDNCUMCHq", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 3", "7c87f0cb-7db2-40b8-86d6-031ce926510f" },
                    { "oSBaceW67wS0gFzjfE22", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5943), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 5", "eee3e9d2-c8ed-47a5-825a-6266997a4695" },
                    { "SQoVBmrNdPENldf57dks", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5948), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 6", "66a2f260-32f5-4b47-a662-4f677730568e" },
                    { "tGFt1dJ7GuF9EjfQY8y0", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 7", "b78970ea-8675-4c3a-b034-f817179cceaf" },
                    { "UaJtLxqm6NdmQmGJFUvX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5937), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 4", "9e61a113-df7c-4280-a3a7-6cb574896490" },
                    { "ur7vYmat3ncazvmUfH07", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5904), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Евро 2", "f58cc87f-dc16-434b-bdd6-32c196199397" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Interior",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "85GvlmAnVrrfgolmLLl2", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(6063), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Велур", "17070a68-1601-42d2-9b74-739768831fdb" },
                    { "A6P9FuPldfJjJXzzNtyF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Кожа", "c0086b32-ae65-42bc-92cd-323e32f0375d" },
                    { "GmY6vd8X5WQ4IUuq9dd6", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(6107), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Текстил", "300b3662-0931-4b55-96e0-23492b36aec5" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Regions",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "04PuHiqcRv9DcREApg5u", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Плевен", "114cfa1c-ab16-4a3c-9e7f-36fd14278eac" },
                    { "0MQA2If8a5Z4HRefov5m", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2725), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Велико Търново", "ac008ce2-4407-465b-a92a-19987571f70b" },
                    { "3Lvd5SaVBSvRZqXMpqgg", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2712), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Бургас", "5d389f77-d03b-4981-8684-821dba17e9b9" },
                    { "4zMLDb0jRA6DOWg2PGAu", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Смолян", "15c29818-3ee6-4f12-8eac-299d017c1580" },
                    { "54yDT5opPXBpYNO2h6Xk", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Благоевград", "2f91c17a-285f-4d81-9de3-76e6dd5cb865" },
                    { "8uqXyyo70K5SRg5ktRGQ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2791), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Кюстендил", "af8f21c3-fc56-4fc4-aa78-123b77745545" },
                    { "A1CnH1tLY9MO6PWS6ORl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2858), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Русе", "a4742f72-1617-408b-8025-65161b5a4c7b" },
                    { "AAH7gkgvxTPPovngcfsJ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2870), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Сливен", "81cd4302-92e4-4fec-aed1-28bcee9801a9" },
                    { "AFmN6OptpMY0LezPyjyz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Видин", "913bbd4d-cd7f-47c9-8d06-ebb78c615738" },
                    { "BzA0a14BLyuBXlDvgNVl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2846), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Пловдив", "87a29987-5967-425b-adba-69901bb99684" },
                    { "cebjaOy1ByfOBnYYM8Ye", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2760), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Враца", "95829f1a-a9db-4c35-a470-fea844656116" },
                    { "eVRJzKNQ1NW4BCuqwCkE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Перник", "d5aa1321-a0a5-471c-989f-e521ad3094fa" },
                    { "EWVXiJYgSdc7UFofpRDu", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2778), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Дупница", "842f24d0-2cc0-4cc2-a0a0-392b6d5cc467" },
                    { "EzC6JDofCCRkKgHzu3dI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2783), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Кърджали", "9ca98564-4296-46af-a908-d2b978063f3e" },
                    { "hTvSc0MvBTkedmyyA7NN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2772), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Добрич", "86287e3a-56d6-4125-8ae3-8c9f6cc22dcb" },
                    { "iP5gptdNCnAzqRorUYop", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2926), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Шумен", "02868e27-e5b1-442c-8774-8749ad778413" },
                    { "iW1OjUiHcqYURewMo7b7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2766), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Габрово", "4b43e53e-ab1a-476f-a9c8-cf86ffb7c195" },
                    { "kUDuBIKZ6DZuHytq19Jp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2932), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ямбол", "d0afeba0-39a5-4b90-9d5d-382ce6d3907f" },
                    { "lfwOlRqHcAYTpbxUmiBK", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Търговище", "3958984a-0b14-4e49-a0fe-1ef071a2f5da" },
                    { "m6nvdcOx04SwKS3JmQuu", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2864), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Силистра", "ae6ba0bb-5db8-4dee-8966-b5b09907206b" },
                    { "qys6uigQzGAe5CFRquPE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2908), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Стара Загора", "56db9f2d-48a7-4036-a334-b3b66005ef67" },
                    { "sPB8FQRwlj7zkzWNSHPp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Варна", "5faa1678-e026-4eae-b1bf-fe977ba1a819" },
                    { "ssHgRpb69ARnCL27lW8Z", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Разград", "b9b67465-a994-4d5f-93a6-53d53d085f25" },
                    { "tGOFKGTIXre5MbB6nbPo", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2802), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Монтана", "690bfba9-d7ea-48b8-bba0-6e0303df5331" },
                    { "tISK82svC0LzIBzGRgRs", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ловеч", "71279071-63fe-4bc6-bfa6-40fa90e39d26" },
                    { "U7BLcxhRiK259caYZtoe", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Пазарджик", "0b8e47fe-4c5f-4630-be23-35366a7a0302" },
                    { "xC8qGAbw5YtdET2UURuP", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Хасково", "fc7e6c15-d274-4ac4-89d0-458aa50ae34d" },
                    { "xseBOjqVjozxkJcgGubc", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2881), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "София", "5d91bfc4-90be-4b13-8bd0-c3605e9d62df" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Transmissions",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "36jFhHnMEmsESR6bNcH4", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5716), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ръчна", "f751b6ff-f3ec-4748-a380-5d02146cf765" },
                    { "BMGw5SzfuNwL2jLY4zYE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Полу-автоматик", "7fef2601-b339-4cf8-a52e-5a31afb5cf39" },
                    { "RrrtQ1Reyn13kdtGQt9B", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5705), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Автоматик", "e42a5513-42c2-4a4e-9cb5-dd1bf4b699c5" }
                });

            migrationBuilder.InsertData(
                schema: "Troshka",
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "RegionId", "TrackId" },
                values: new object[,]
                {
                    { "0CjCASZC0LSzs6ToWDPf", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4772), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ощава", "54yDT5opPXBpYNO2h6Xk", "135ca3ee-a0fa-4e53-a6c7-5cff1beb9213" },
                    { "0cN6OnAaAEe9twTMKNSL", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лешко", "54yDT5opPXBpYNO2h6Xk", "eeae827b-7a95-4dae-b1db-92732cfd11ec" },
                    { "0gRnjKRsK5HpggmJ35QP", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Рибново", "54yDT5opPXBpYNO2h6Xk", "bc545851-f592-4a10-afa6-4939db712992" },
                    { "0kOlcUqNX3GmlqXlAfpU", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4610), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Места", "54yDT5opPXBpYNO2h6Xk", "a8630d12-7394-4d93-a9dd-4d38f7d86884" },
                    { "0mJJ1TNvJytdx93FG939", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4415), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ладарево", "54yDT5opPXBpYNO2h6Xk", "324293d5-4d52-49e2-b22f-cc1da01c07dd" },
                    { "0OiRluH0unBrqtgrdIhc", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Чучулигово", "54yDT5opPXBpYNO2h6Xk", "74020ad5-e703-412d-990b-8c50a380245f" },
                    { "10unCs9PybUykwTtnWpJ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4981), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Садово", "54yDT5opPXBpYNO2h6Xk", "48c8e2cc-dc41-4763-ab7a-759fbd681ffa" },
                    { "1bHqd1rUVLg6h6qfGLcS", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4131), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кавракирово", "54yDT5opPXBpYNO2h6Xk", "0338d4b5-b4c2-42c6-bf01-6f3b6048c440" },
                    { "1GRbG3rjQ2ofrU18THaz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3287), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бельово", "54yDT5opPXBpYNO2h6Xk", "eb324110-2b4a-4b90-944b-2e2a86d870c3" },
                    { "1yxBQ20RxnTqWYg7ZpVO", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3637), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горна Рибница", "54yDT5opPXBpYNO2h6Xk", "3311f1dc-1122-4ced-9cc5-89d487931269" },
                    { "20Fc8tVmtdLnnO9dK9PJ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4766), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Осина", "54yDT5opPXBpYNO2h6Xk", "3e76af45-cffa-4265-bd6b-d4757942c29b" },
                    { "21myeuJwmBnKkl1V22jb", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5063), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Слащен", "54yDT5opPXBpYNO2h6Xk", "f5d13077-14da-43aa-99f1-d414c0361906" },
                    { "2IGYvWW5HtTpuUhzJzW0", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4975), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ръждак", "54yDT5opPXBpYNO2h6Xk", "ad8e86a6-184e-4e6c-ae8a-ca7e77f38e40" },
                    { "2Q8Cnvp0xt0RlhXwWFrM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4879), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Покровник", "54yDT5opPXBpYNO2h6Xk", "35f04b94-e212-4560-980a-5e73fc1aba32" },
                    { "2RlfSIT8tVjqvQoF3Yzh", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4428), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лебница", "54yDT5opPXBpYNO2h6Xk", "eda0aa7d-41c1-4557-88c7-cf3ab0335971" },
                    { "3ON8ZtRO2cHeFGcMhvnT", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3364), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Брежани", "54yDT5opPXBpYNO2h6Xk", "8362ead4-1128-4755-8033-0dfd8f67a466" },
                    { "4Niku3WHFIAqKT1bLKbM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4313), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Крупник", "54yDT5opPXBpYNO2h6Xk", "78eab921-699b-4915-8809-7a95ae88ff80" },
                    { "51NCl8sofLRt5CZ6Ijb9", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Златолист", "54yDT5opPXBpYNO2h6Xk", "93f1f52e-0af6-4270-bc8b-209c0fe544a6" },
                    { "58SC1K92gC6TIqc6YieE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3528), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Габрово", "54yDT5opPXBpYNO2h6Xk", "6d7b9651-d0b2-4068-b301-bcdc1bf08bd6" },
                    { "5dVT6X9b1jLvkFx5kfAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4195), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кладенци", "54yDT5opPXBpYNO2h6Xk", "cea1d103-e0bb-4d5d-bb69-ea19a738095f" },
                    { "5fCsOxNvMUvksRS1ZpQV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кърпелево", "54yDT5opPXBpYNO2h6Xk", "b4ca4a18-411c-4524-99c9-8a2b9f65bb8c" },
                    { "5m7B9g75rKUL9NPw6d8X", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Боголин", "54yDT5opPXBpYNO2h6Xk", "175d8cee-bbaa-478e-9b98-ba3fe33e6a01" },
                    { "5Rqixw4lSU7SBGqdw1Zw", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Гостун", "54yDT5opPXBpYNO2h6Xk", "d2687792-4faf-4a01-a7c5-2e82a2c6a8c5" },
                    { "60EtxqsrwIKU0ltomD8Z", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Сенокос", "54yDT5opPXBpYNO2h6Xk", "479e746c-2c91-4675-95dd-45331e4c40ae" },
                    { "6GF8DxWoU9qXj4LQ5PQx", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3160), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Сандански", "54yDT5opPXBpYNO2h6Xk", "b9334d2b-ddfe-4e95-9a00-78aad4815e08" },
                    { "72K7099RJLSbKsSfj3vN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Крънджилица", "54yDT5opPXBpYNO2h6Xk", "06f5eca0-0fd5-49a2-8cdc-c03c9deb2caf" },
                    { "7keXP3PumDqPy2TtIJyE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3100), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Гоце Делчев", "54yDT5opPXBpYNO2h6Xk", "326ec1ad-333e-401d-8a3f-1836fa10db70" },
                    { "7s493n3iCAcI9eV6xOsf", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Клепало", "54yDT5opPXBpYNO2h6Xk", "f0186b65-6bbf-4a07-9076-6bc24cc027ba" },
                    { "7VIIUaptNwzhj8ej05ur", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3875), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долене", "54yDT5opPXBpYNO2h6Xk", "2759da1f-1f11-4989-a938-b8435bead697" },
                    { "818vJeBIuImlcdJGphu8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3574), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Годешево", "54yDT5opPXBpYNO2h6Xk", "2df79b50-5e6b-45b4-99a7-680ef1fb4337" },
                    { "82mULi1IDzKqLOn3G2uP", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3685), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горчево", "54yDT5opPXBpYNO2h6Xk", "8260a536-500c-48f4-af72-766f36cf734e" },
                    { "8Be2RRzbuSU59GLX3Ezl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4658), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Мощанец", "54yDT5opPXBpYNO2h6Xk", "0eae04b8-f5c2-4b7e-b173-e6573f27c51a" },
                    { "8HyYUQaPF48Tit9PqSQi", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3818), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Добри лаки", "54yDT5opPXBpYNO2h6Xk", "21cbfef5-653c-41d1-9c74-b825b63e806e" },
                    { "8nHE5KIPw9tUyknXo3Jl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3964), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дрангово", "54yDT5opPXBpYNO2h6Xk", "322c6b71-9fda-4a52-8fc4-76eb5c7655e0" },
                    { "8Q8i1YjiArjCDECWmWRb", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дренково", "54yDT5opPXBpYNO2h6Xk", "54228cfa-ff2c-4f4d-8e65-d6a3b503bfc5" },
                    { "8QQI9EeWHMOtwxCOcWIT", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5288), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Церово", "54yDT5opPXBpYNO2h6Xk", "c1972702-2e02-49d7-8066-5f0ae820e8a6" },
                    { "8U43LpX9MGvI2cmLw4rD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4580), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Марино поле", "54yDT5opPXBpYNO2h6Xk", "1ebefa47-8bf4-4812-8391-d681f9642190" },
                    { "9feUqBzVA8eZsdMvXqvG", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Добринище", "54yDT5opPXBpYNO2h6Xk", "0bd9d7a3-448a-4cbd-95fe-74e07e05e1ba" },
                    { "9sFruqb4xl1tBUAlCjnb", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Джигурово", "54yDT5opPXBpYNO2h6Xk", "4f4fd745-7d49-4b37-a114-07a672393bbd" },
                    { "9twC0sUO1RE8B9LYfWdX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4265), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Конарско", "54yDT5opPXBpYNO2h6Xk", "bf13d80f-f6c5-4d60-9508-fae6a58d84dd" },
                    { "9vN2sGt2IhEntOysf32e", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Микрево", "54yDT5opPXBpYNO2h6Xk", "bfad5650-3fb1-4d02-b61b-cefd0ce30f36" },
                    { "a0p6Ajl1TVHmaGVNKNLi", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3888), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долна Градешница", "54yDT5opPXBpYNO2h6Xk", "e0961f98-2e2c-4eb2-ae93-f9aaff2b9408" },
                    { "AAAO3LJLeMao6iml66wC", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4986), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Самуилова крепост", "54yDT5opPXBpYNO2h6Xk", "8b53256f-b9b4-4b7b-b263-fcd32ffef0c4" },
                    { "Ab0ApUhICf7zaMFmHTFt", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лютово", "54yDT5opPXBpYNO2h6Xk", "63528aab-7a8c-430c-a7da-263a3f883ff7" },
                    { "AcHS4Qb4HuqEnBoT32eu", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Краище", "54yDT5opPXBpYNO2h6Xk", "b76c1776-44a8-414c-bd72-eebd223aafcd" },
                    { "ady7xTwdtnixVQs3O2oz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3358), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Борово", "54yDT5opPXBpYNO2h6Xk", "39391ba2-1a73-4981-aa0a-d5f49fcab7b8" },
                    { "AMp3jRxQAkoccRtMGfvg", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4927), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Рибник", "54yDT5opPXBpYNO2h6Xk", "95755c3a-604b-405f-a749-e443623b7687" },
                    { "an3o0hYhG7sP6YemnTPr", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Струмешница", "54yDT5opPXBpYNO2h6Xk", "0334dace-439b-4ab6-aabf-621a0e551e05" },
                    { "aOeUgHmp1DYlbgus1iym", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4107), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Игралище", "54yDT5opPXBpYNO2h6Xk", "6b3898e9-cfc7-4d7c-8e9b-4a492df2aa5c" },
                    { "arzgr2kBPnf94eLvHmzF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5276), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Хърсово", "54yDT5opPXBpYNO2h6Xk", "4887f854-a5ae-4df5-bffb-35a9094bc483" },
                    { "AUdHMyIrucbK1QPSuEl6", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4804), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Палат", "54yDT5opPXBpYNO2h6Xk", "12aa72e4-b695-4d8f-9a98-6e86eb3c30ac" },
                    { "ayxopMnHP3GynSD3phZ0", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3743), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Гюргево", "54yDT5opPXBpYNO2h6Xk", "63ce31e7-9db9-416e-9328-bfbed5ca4e7d" },
                    { "B6fEB97ylQL7Np47vtYV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Склаве", "54yDT5opPXBpYNO2h6Xk", "27e8e69d-6bcd-4f3a-9855-4dd90105f956" },
                    { "BCxe8rk6vzMhYhXTO0rU", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4670), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Никудин", "54yDT5opPXBpYNO2h6Xk", "73309da7-e00e-4bb1-8f43-3cc98be8021f" },
                    { "bHGMKKJTtQuMC0vS9i3Z", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3668), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горно Осеново", "54yDT5opPXBpYNO2h6Xk", "17d14ae9-58d7-40fc-9fbf-65344a538a2b" },
                    { "Bj7la6MGA3NvSSopnJri", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3481), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Вишлене", "54yDT5opPXBpYNO2h6Xk", "f330b1dc-20f7-47c4-818e-14ab03de974c" },
                    { "blP0EqOltrrA4kScx9XG", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Хотово", "54yDT5opPXBpYNO2h6Xk", "510dfc1b-03e3-4670-b5bf-ed669fa389db" },
                    { "bnc8v9kl9VlsefVCPL0W", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4546), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Малки Цалим", "54yDT5opPXBpYNO2h6Xk", "d13d6e35-b607-4c92-aca4-a88d7bf355c3" },
                    { "BnHAwhVpD8t3wGhxo8Sg", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4075), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Зорница", "54yDT5opPXBpYNO2h6Xk", "9e8a0233-2d1c-4522-8309-2bf0de28e889" },
                    { "BOqOCxCIc5jNlWXHJUK4", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4056), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Златарица", "54yDT5opPXBpYNO2h6Xk", "79c09bcd-dded-4fcd-ae9f-2edfc83e1b18" },
                    { "BpmCmi2yyMLJaOKrSPZQ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Пиперица", "54yDT5opPXBpYNO2h6Xk", "0da8ae71-558a-425b-9921-53c45d852939" },
                    { "bQptTR8qPbrqS4Wg6ZQN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3352), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Боровичене", "54yDT5opPXBpYNO2h6Xk", "94c2cae3-a3a2-42a0-bb6d-b356513cab5d" },
                    { "bsf5H4yuihOunxGQvTRs", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4652), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Михнево", "54yDT5opPXBpYNO2h6Xk", "6792df76-0661-4a55-8898-453861e0f184" },
                    { "BslBNBCNreUaRxaYYFz8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5056), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Скрът", "54yDT5opPXBpYNO2h6Xk", "56701767-1fe5-47d6-8c98-6b40dd1e7cbf" },
                    { "BxBkLPfjqiPnspDDl02r", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4464), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лиляново", "54yDT5opPXBpYNO2h6Xk", "2380ab4f-125a-45a4-a828-e7ed4dd2c063" },
                    { "Byx9xuuqRVNwAvPtVdUA", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Еленово", "54yDT5opPXBpYNO2h6Xk", "8a4515be-7897-48ac-8f0e-61acff19565a" },
                    { "cAm9i5Xr8AKbjxd4a0X5", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3327), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Блатска", "54yDT5opPXBpYNO2h6Xk", "18870b5c-c90a-4f91-9c6a-28bac342ad72" },
                    { "CBDlQzM1rROQtTHgzVwT", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лъки", "54yDT5opPXBpYNO2h6Xk", "1715cfed-589e-426a-82e3-ff1fa567088c" },
                    { "cBnRQo0enzpUXFrymVl7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3183), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Абланица", "54yDT5opPXBpYNO2h6Xk", "0e9c90c1-5263-4cc9-8a9b-f71318cf6615" },
                    { "cEztanE91e85HAt8d1sE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4761), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Осиково", "54yDT5opPXBpYNO2h6Xk", "e0366a32-9514-4ef5-9bf5-3e626429c204" },
                    { "cHIsh4O8DiS3aa6BpqGy", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3453), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Вихрен", "54yDT5opPXBpYNO2h6Xk", "01ce7c5a-2dbc-4573-9e03-09f2e35f6b49" },
                    { "chRNgs4uXAUiB7dw6T4M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Камена", "54yDT5opPXBpYNO2h6Xk", "d90b786f-96b8-4240-bcfc-5541b965e4e5" },
                    { "CM7iD1yu2CS7hvScKNMO", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4284), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кочан", "54yDT5opPXBpYNO2h6Xk", "656bef27-be66-47c5-8295-114edb46c1ad" },
                    { "cr5i9babcZns6KgEyn24", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Мендово", "54yDT5opPXBpYNO2h6Xk", "a702660b-d8a5-4579-b5a7-cf952b917b36" },
                    { "cU4r5FiNJgbiM6dhG8ER", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3799), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Делвино", "54yDT5opPXBpYNO2h6Xk", "afc90845-daa0-4c83-800f-edded5c16e43" },
                    { "cW98FxYnDNVMNflmC8q7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4896), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Полето", "54yDT5opPXBpYNO2h6Xk", "b5663249-bc99-4dfd-aabd-d2c856fc050b" },
                    { "dh8S1ZT9W1jajYz9EGG4", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5162), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Сушица", "54yDT5opPXBpYNO2h6Xk", "892820d9-3505-4748-afc0-0b1d46476153" },
                    { "DjTHGizW8wBL6URovDng", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3604), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горна Брезница", "54yDT5opPXBpYNO2h6Xk", "6c4cc35c-6cf0-4054-961b-892fff90ad0b" },
                    { "dKTky4haW2fNOzMjNTiu", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5146), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Струмяни", "54yDT5opPXBpYNO2h6Xk", "63817d30-b995-43cc-890a-05c329eb3e9a" },
                    { "dlWGw4uU8kpnrXq4zbyN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3894), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долна Крушица", "54yDT5opPXBpYNO2h6Xk", "a0561c5e-1628-437c-ad55-a8974edb516e" },
                    { "DNQ3KHJkxqiNtn14gcaB", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Симитли", "54yDT5opPXBpYNO2h6Xk", "2fb77f81-350c-4fa2-b815-3de29f91acdc" },
                    { "DUwLGmp9EcEq3WlpZPAt", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3975), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дреновица", "54yDT5opPXBpYNO2h6Xk", "eb8f6abe-2055-4eaf-a50b-aed4859bbea5" },
                    { "DxK5hs209av1QkpAm0DU", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горно Хърсово", "54yDT5opPXBpYNO2h6Xk", "65b1d5e8-df1e-493d-b546-a0f32210d351" },
                    { "e0HXhaClTvD2A0rwtnk8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5081), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Спатово", "54yDT5opPXBpYNO2h6Xk", "ae5be93c-d1de-4621-83bb-212c664235d1" },
                    { "e6WZlTMDT3B7oqZqPIVD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4101), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Иваново", "54yDT5opPXBpYNO2h6Xk", "52f4734b-e9ec-49c8-8f88-3318471843aa" },
                    { "E7yPisre4COe7jyOEBCT", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Колибите", "54yDT5opPXBpYNO2h6Xk", "202e7640-b139-43f6-a353-2aa3e044bfd1" },
                    { "Eg5zvbKnhciCCWDjnQoJ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4689), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ново Кономлади", "54yDT5opPXBpYNO2h6Xk", "1b6b0aba-923b-423d-8337-c382f496ff10" },
                    { "EKkLEcWxNiBqkVhNmeOz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Господинци", "54yDT5opPXBpYNO2h6Xk", "650f26ae-3dbc-456d-89db-b44a9efc70bf" },
                    { "eKyPX0e83l5ulQWnQqAI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4032), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Железница", "54yDT5opPXBpYNO2h6Xk", "c4dd5f94-917b-4783-bf18-b6633d689510" },
                    { "EyhQMWwBO7hDquOyZ7UR", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3882), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долени", "54yDT5opPXBpYNO2h6Xk", "7b78b0f0-8d8f-4857-ba4d-1b3845a68def" },
                    { "f0B7ngALDcChR0qeW8Kx", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3397), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Брестово", "54yDT5opPXBpYNO2h6Xk", "dcb08da6-9e83-42d6-ac47-8273c952c60e" },
                    { "f58Np5BqUrjaHzzHcI3B", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4226), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ковачево", "54yDT5opPXBpYNO2h6Xk", "1aac9582-e084-4f3e-a9b0-86bbef48f084" },
                    { "fAzTPYCw6IPYt7r0nyQt", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4597), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Махалата", "54yDT5opPXBpYNO2h6Xk", "1af447c8-1f29-450d-88b5-c1f5dbd52318" },
                    { "fgY39cfPxP44RFl3ufXm", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Плоски", "54yDT5opPXBpYNO2h6Xk", "7bc9e2f0-8e52-4bf3-bff9-b132cad0894f" },
                    { "FHbfSPlAuKWuO2xnrfmB", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Любовка", "54yDT5opPXBpYNO2h6Xk", "ac19c659-1cf8-469a-a4dc-47052d6c6b4a" },
                    { "fjV17FeFYtdG87NIzTTV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дагоново", "54yDT5opPXBpYNO2h6Xk", "9fa82db4-a7b3-49e3-8140-7e60e54ef22b" },
                    { "fz3K8nqEexm4AndgrQi4", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3447), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Виногради", "54yDT5opPXBpYNO2h6Xk", "2a11d09a-1cd2-4eef-9499-184a00a7e10a" },
                    { "G6fX1XjbGqPoS8RLnpnc", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4383), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кърналово", "54yDT5opPXBpYNO2h6Xk", "4faa6741-616c-42b0-bb81-8adda5d77dd6" },
                    { "G9twrE4qbivdKWJfpaTn", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4371), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кулата", "54yDT5opPXBpYNO2h6Xk", "efbf1eb2-f7c0-4c5c-81c6-01e65f33e2b2" },
                    { "gaYFbNX9SJExqDV2IGvI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3440), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Велющец", "54yDT5opPXBpYNO2h6Xk", "40dad271-3697-4aee-8b45-8dec910edf4f" },
                    { "GdwsyBgAwg4b5jBslBmv", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3830), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Добърско", "54yDT5opPXBpYNO2h6Xk", "48d5796a-a590-4694-9d13-6ef328b488ed" },
                    { "GGQuu1mCVa2XyHe6OHwd", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3674), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горно Спанчево", "54yDT5opPXBpYNO2h6Xk", "57904d1f-480a-4458-b28e-d3e24abae14f" },
                    { "GPKXXzuRLzBmQY8OGUYN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Черна Места", "54yDT5opPXBpYNO2h6Xk", "6ceba27a-3815-4a9e-8131-152e1c3d30ec" },
                    { "GtwBz0xireBoNWHleled", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4677), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Нова Ловча", "54yDT5opPXBpYNO2h6Xk", "68166db9-1840-4db4-a4d7-22e7593c2341" },
                    { "GUdg4bsLNwKisWTQ9rHA", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3403), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Будилци", "54yDT5opPXBpYNO2h6Xk", "5861c569-64eb-4b98-8db6-7b7a1d932827" },
                    { "gvRcMsNyR0UElUrasG12", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5207), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Тополница", "54yDT5opPXBpYNO2h6Xk", "5a63e85e-e618-403d-92e3-65b481af5605" },
                    { "Gwe46q5lQ75V8o4b39Lc", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5133), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Струма", "54yDT5opPXBpYNO2h6Xk", "5dbbc050-b82d-4a2e-8f0d-f0a3f9c2a224" },
                    { "GXHYSrHAuQTT3NwQiNod", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3499), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Вракуповица", "54yDT5opPXBpYNO2h6Xk", "662a7b99-f837-4926-ae46-f40be6e863d3" },
                    { "h7D65pNQ08GHx9b3AcxU", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4778), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Падеш", "54yDT5opPXBpYNO2h6Xk", "0ea77afe-3b0d-48f1-a685-bbcaf3f3dd6e" },
                    { "hcWnu9tdf7PvuUE1Z86G", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5168), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Теплен", "54yDT5opPXBpYNO2h6Xk", "897c735f-bef3-4574-b0fb-1df86459557e" },
                    { "HDEj5O0QzUUz6dXZUQUC", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3922), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долно Спанчево", "54yDT5opPXBpYNO2h6Xk", "46463baa-a558-4063-9c26-2d9e64677ccb" },
                    { "hfO3HfINfWDV0vWSfNeY", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3835), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Докатичево", "54yDT5opPXBpYNO2h6Xk", "cc60c7d6-8b3b-4664-bcbf-6f5e3306f538" },
                    { "hWDOJO1XVbMZtq69lVJo", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долно Дряново", "54yDT5opPXBpYNO2h6Xk", "60bf818d-2998-4fcd-b04d-10a5203de40b" },
                    { "hY5scKz0GZmfw1t4hHrg", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5114), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Стара Кресна", "54yDT5opPXBpYNO2h6Xk", "b5c0c93c-645d-4806-93b8-efad30df096a" },
                    { "I3o2PelffQGQZ2tg4PCf", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5362), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Яворница", "54yDT5opPXBpYNO2h6Xk", "3f264bff-94aa-4a50-b0ce-1847475fbeb2" },
                    { "i8zmw7rcQnoJw83TtkbJ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горна Сушица", "54yDT5opPXBpYNO2h6Xk", "b1b05269-87c1-4307-9796-c7e3a446b9cc" },
                    { "ICeAWglJ3SZW8AKlNJJV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5121), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Старчево", "54yDT5opPXBpYNO2h6Xk", "27f90d44-b03b-487d-a5d3-5e006e860379" },
                    { "IlhkJUtQ8sLs4YnQmRHN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3276), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Белевехчево", "54yDT5opPXBpYNO2h6Xk", "1f3692c5-da09-4e92-8d40-9ee0bbb288ec" },
                    { "iu4VWQqmLdHN17PQdvzH", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лисия", "54yDT5opPXBpYNO2h6Xk", "efa1bd76-5076-4485-91cd-141cb488b908" },
                    { "iWDmKxgAGouVUA50vC4M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5344), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Чуричени", "54yDT5opPXBpYNO2h6Xk", "01ce8251-3ca1-4d37-aadd-4cb2d991459b" },
                    { "IxJYV5M8k3tW6QNI1XNy", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4214), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ключ", "54yDT5opPXBpYNO2h6Xk", "c51a5491-9ede-481c-8b1d-4f7292138f02" },
                    { "j69zA6NGRTWjfaJiFgAv", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5075), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Смолево", "54yDT5opPXBpYNO2h6Xk", "e31c4ff9-cf08-4b98-8433-0b3139efa4c2" },
                    { "J9xfAHAcdeoqMZf5Z32o", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Зелендол", "54yDT5opPXBpYNO2h6Xk", "5a9859de-a3ed-4c5d-b7ae-8b1d61a643b6" },
                    { "JcR9lG8H05RZRXqxVcdn", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5356), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Юруково", "54yDT5opPXBpYNO2h6Xk", "225293fe-781d-42c4-9e37-c66f2c28fe43" },
                    { "jgBCeqg0TYU2bwGYLlyj", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4552), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Марикостиново", "54yDT5opPXBpYNO2h6Xk", "c8335337-7305-4432-8585-ceada38c0965" },
                    { "Jh36r96IWwkRc0jtT8Uz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Сухострел", "54yDT5opPXBpYNO2h6Xk", "c86a104e-16bf-4db7-8a29-e907d91dc4e3" },
                    { "jP1vOHqdRr77lzEQOhUV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Мечкул", "54yDT5opPXBpYNO2h6Xk", "8d9b39e6-5c52-49a2-a24b-eacaea57fba9" },
                    { "JsJF774TI5lhUXT7lyu6", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Богородица", "54yDT5opPXBpYNO2h6Xk", "62fcc653-7208-4147-863f-c97ec734e3a0" },
                    { "jz9QoDqp8nMi3sT5bxrf", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Голешово", "54yDT5opPXBpYNO2h6Xk", "e73f3d42-3453-4326-a0b4-6e456d31dc60" },
                    { "k0qeWBID2X22pEgtfvgo", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3417), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бунцево", "54yDT5opPXBpYNO2h6Xk", "e93cffd3-f877-4c11-85b8-85816163899a" },
                    { "K25n9KJ1vxNw3MGsoreR", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3952), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Драгуш", "54yDT5opPXBpYNO2h6Xk", "c71f80ff-53bb-4865-9a62-d297b899a1b7" },
                    { "KmSbHInKfoSIyIlT2gWX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3649), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горно Драглище", "54yDT5opPXBpYNO2h6Xk", "6790928c-f6a5-4bdb-b419-0e18f19ee09e" },
                    { "Krd6NYyD0XMYztMGhAiX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4914), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Раздол", "54yDT5opPXBpYNO2h6Xk", "41a59aad-343b-4f16-9770-9ed2b3d53dcc" },
                    { "ktNgoxLzSAUwMztZhavh", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Белица", "54yDT5opPXBpYNO2h6Xk", "091c0e56-dd0f-41ec-97b2-eb6a3ba364bb" },
                    { "KzVg96EpghmFIyTZQXFu", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5225), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Филипово", "54yDT5opPXBpYNO2h6Xk", "9d811375-eacb-4926-bd7b-703be095c375" },
                    { "l2yUOjlKLR2h1V5VrYsi", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3197), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бабяк", "54yDT5opPXBpYNO2h6Xk", "39b98e69-0948-4e2a-9e87-91aca510f421" },
                    { "lAdtqn0mI1TymJG9ZH8W", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4885), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Полена", "54yDT5opPXBpYNO2h6Xk", "58eddbe7-b264-4062-9b72-9e8d01f85ddc" },
                    { "lDcp7H9Ze01LedaVkc1t", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4755), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Осеново", "54yDT5opPXBpYNO2h6Xk", "813d4fa5-56bd-4502-9c11-9a3f8929576b" },
                    { "LhvYW2Zd57VcnjPFJSSH", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Копривлен", "54yDT5opPXBpYNO2h6Xk", "df5aa76f-f6ce-4d2e-91b6-13c73ad9127d" },
                    { "LMNgjYs8Wlk3fn3BAgwI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5213), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Тросково", "54yDT5opPXBpYNO2h6Xk", "0d3a9ee1-e782-48ec-aeb0-bcf16bfb09ed" },
                    { "LrGsNZNeH2n6cJIxmXxJ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4591), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Марчево", "54yDT5opPXBpYNO2h6Xk", "1383db9f-484b-42d9-b23d-ecf0d01f1ac3" },
                    { "LvGdpqiL8WD3lrR9DTV5", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Гълъбово", "54yDT5opPXBpYNO2h6Xk", "0ff6511f-ba5d-4baa-9ee2-1f6379471636" },
                    { "lY3jQ83TvYtUO7AGHTeG", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Петрелик", "54yDT5opPXBpYNO2h6Xk", "cb45b8e1-10f9-46ef-b36b-f4ad285033d2" },
                    { "M20lrAzqGZHVUI9MA8Wd", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5294), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Черешница", "54yDT5opPXBpYNO2h6Xk", "22e863b1-30a6-49b4-bb87-9e8929f7de92" },
                    { "mcqsM242WDKe5RWonk0N", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Гърмен", "54yDT5opPXBpYNO2h6Xk", "198ae956-7142-405a-9298-7d073f84299a" },
                    { "mHwqAk1qNheJohLB1Jzd", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3346), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бождово", "54yDT5opPXBpYNO2h6Xk", "d7a012ca-3510-47ae-b5a6-ab7cdd40449e" },
                    { "mJ1WHQcCFBdZ8GLGCU3Z", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4307), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кромидово", "54yDT5opPXBpYNO2h6Xk", "7f73ccdb-583d-42d1-ac90-c801798e001a" },
                    { "mjSinueV18LNv9TvBaYV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4891), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Поленица", "54yDT5opPXBpYNO2h6Xk", "4bee208a-b9fa-4a3e-9682-bd0cd7a0ada3" },
                    { "mkCTXyHRMwybEqLo25cz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4220), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ковачевица", "54yDT5opPXBpYNO2h6Xk", "0e1e4c93-607a-4ae4-ba9a-7aab5dddc43d" },
                    { "MleUdK6EdxEEgMvRFgvw", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5151), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Сугарево", "54yDT5opPXBpYNO2h6Xk", "0c52a104-097f-46df-b76e-55911f023f59" },
                    { "mMScQFWGBGj82JUVSfa8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кукурахцево", "54yDT5opPXBpYNO2h6Xk", "af71ff2f-02ef-4f08-ac1a-4eac66922cf2" },
                    { "MrQ6MrxoNdLH9AHWd1sZ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4376), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кърланово", "54yDT5opPXBpYNO2h6Xk", "26df23d7-4f2c-465f-b2ba-6272abe9837e" },
                    { "Mslmta38lcifuPv0Epep", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4156), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Капатово", "54yDT5opPXBpYNO2h6Xk", "e697d7ae-4740-4e4d-bca1-49c13fefe8ac" },
                    { "MWLluWB5yYYo6dNJNfEy", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3661), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горно Краище", "54yDT5opPXBpYNO2h6Xk", "ad4cef28-8e88-4db9-86db-c7be89e4726b" },
                    { "N7ZpDTXSfenP8ZWklmhn", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3126), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Петрич", "54yDT5opPXBpYNO2h6Xk", "5a5cc0d8-52c4-4d68-b970-f40ec7b8ba16" },
                    { "n9ejZ3UFp2QRKGnJBZTQ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3917), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долно Осеново", "54yDT5opPXBpYNO2h6Xk", "0ca27561-8883-420a-b63b-601bdaba656c" },
                    { "neRh5vRSDkskEiRjkGmS", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3245), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Баня", "54yDT5opPXBpYNO2h6Xk", "232f019d-5ebf-482a-aecd-64389a90854d" },
                    { "NJ4WrirIVRD2CL5LFVgZ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3555), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Гайтаниново", "54yDT5opPXBpYNO2h6Xk", "3dd960d6-e984-48d7-bfe9-64d6a36caca9" },
                    { "NjMzJSgUCrBYha1Zyfz9", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4812), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Палатик", "54yDT5opPXBpYNO2h6Xk", "e1ed59b3-41d1-4aa0-b7ea-3495c4f24caf" },
                    { "nKjgqQ7r6rWE89oasS55", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5049), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Скребатно", "54yDT5opPXBpYNO2h6Xk", "4a6f8a8d-8f2b-4327-9195-0a3c322b8736" },
                    { "nT6rVJX6LUwa4voci7P3", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3493), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Волно", "54yDT5opPXBpYNO2h6Xk", "ea3d4f37-57c0-47ae-892b-ba9dbb40ce51" },
                    { "nXHE363SurLsIHyCMiBp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Якоруда", "54yDT5opPXBpYNO2h6Xk", "ce480895-ba03-4fcc-a1c3-29bdc2401f50" },
                    { "nXrAW7KU9IUVnH36ttyB", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4278), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Корница", "54yDT5opPXBpYNO2h6Xk", "724489de-9370-4bf7-aec8-add4814ae178" },
                    { "o0cKUmrKeP32BdCL110f", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3257), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бачево", "54yDT5opPXBpYNO2h6Xk", "7c331b3d-9664-4c10-a563-a8e433f84b38" },
                    { "o5LA79ma20RbnbEWYkmI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3568), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Генерал Тодоров", "54yDT5opPXBpYNO2h6Xk", "fe65f13f-243d-4aa7-a4e9-5ff82d7a8a7f" },
                    { "oAcrUAlW0ogYQ0RbRpVR", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3088), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Банско", "54yDT5opPXBpYNO2h6Xk", "da7dee97-7a31-49bc-a73e-58430e018a88" },
                    { "oaVzgKrfm2dtvEtulIPH", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3754), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дамяница", "54yDT5opPXBpYNO2h6Xk", "8c1b999f-21a1-4123-b5ae-433a06edf563" },
                    { "OCfs7lrhfbA9Wg6Rfx5F", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4527), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Любовище", "54yDT5opPXBpYNO2h6Xk", "b77707ee-f4d4-4b6e-96c2-e83de24ca438" },
                    { "oEevNbxEQnzGOkwJ6yy6", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4353), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кръстилци", "54yDT5opPXBpYNO2h6Xk", "57fe4b54-fb64-4376-8fcc-6ad278f75bc5" },
                    { "oJ208ZU4uli478vZ4M6i", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Благоевград", "54yDT5opPXBpYNO2h6Xk", "fff1dacd-acec-4640-b536-1262e0d60f0f" },
                    { "OkZdYcu0vosTiBUlsaTK", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5032), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Селище", "54yDT5opPXBpYNO2h6Xk", "631fef8a-94f5-4f62-89ea-5e21e037c330" },
                    { "OT5qlZSGxMGbWwUlhaKg", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3806), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Делчево", "54yDT5opPXBpYNO2h6Xk", "1ee0cb18-fbda-4c3f-a7ad-a2ef91dcb80a" },
                    { "OULp9a8mh6nxjaqmen44", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3239), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Баничан", "54yDT5opPXBpYNO2h6Xk", "4de1aa19-393c-4191-b64d-d043347fa0ca" },
                    { "OXQIGhEAp5LWzfAAiIMw", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3504), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Враня", "54yDT5opPXBpYNO2h6Xk", "557a72d1-df27-4bf3-9d62-89642367a1d3" },
                    { "OXw0BOe4VgQX1Dulp8Y7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5127), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Стожа", "54yDT5opPXBpYNO2h6Xk", "527be89c-43e2-4214-947c-97b69b3204e9" },
                    { "p2tNo4gVXkKryIhrQO7O", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4817), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Парил", "54yDT5opPXBpYNO2h6Xk", "c8995eae-e553-4ee0-bf7a-1134e4c4123b" },
                    { "PJj3P4Dm64a1F2VWqRoA", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Градево", "54yDT5opPXBpYNO2h6Xk", "a5aeba9d-0198-48a4-b871-59c53fcaa0ea" },
                    { "pm4OxVXHinF0L6nCdnMD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3270), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Беласица", "54yDT5opPXBpYNO2h6Xk", "50634748-cbec-4ae3-a6c3-291a674694ff" },
                    { "PnW2WNjEeVFRvyrv5ZBt", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5231), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Фъргово", "54yDT5opPXBpYNO2h6Xk", "a93fdf99-bfa8-490b-94cc-01febba09624" },
                    { "psNuk1A7JD7egnOkzY7h", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4829), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Петрово", "54yDT5opPXBpYNO2h6Xk", "888cb0c3-41ee-4cf3-b149-64ac49043eaf" },
                    { "PyyPB23ytzhgST9DVsqT", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Сливница", "54yDT5opPXBpYNO2h6Xk", "0073cb6e-7c8a-4747-8f3d-c329f3a9c35f" },
                    { "pznK4lXtvyzmSPVnsE7K", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горна Крушица", "54yDT5opPXBpYNO2h6Xk", "cb85f152-cb0c-41d2-8180-eae465e0f0fa" },
                    { "QARSrEJj0U53F2F3gZw5", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4044), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Занога", "54yDT5opPXBpYNO2h6Xk", "85b913e5-aad9-4f85-98d6-676584c12ddc" },
                    { "qctT3P6FBPGWKggtZQxz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5005), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Седелец", "54yDT5opPXBpYNO2h6Xk", "b45b086b-69c5-431d-a094-ae328e34cd21" },
                    { "QdJXciCjgzXbHUnB0vdc", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3981), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дреново", "54yDT5opPXBpYNO2h6Xk", "4d8db030-734e-469a-b6e2-479c1cf774f5" },
                    { "QDy1m1rsNP05N2pThvQD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3171), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Хаджидимово", "54yDT5opPXBpYNO2h6Xk", "e6df1d23-6117-4910-9fc1-3497fbacca05" },
                    { "QI7qoqQIrRMgOewnFUHl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лешница", "54yDT5opPXBpYNO2h6Xk", "2d900fa4-88f9-4cda-b057-795eeb349150" },
                    { "qMj4zvnLsSjVcJIHifMa", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Изгрев", "54yDT5opPXBpYNO2h6Xk", "bc15f0b6-a7c7-4c13-bc8b-a45eed3ea4dc" },
                    { "qy9lR5La7DGButn4oAWa", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3434), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ваклиново", "54yDT5opPXBpYNO2h6Xk", "626c3ea0-1d1d-48c0-98db-013e6afb9d25" },
                    { "RaapWhH7MlJ4KqXrk1sK", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3422), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бучино", "54yDT5opPXBpYNO2h6Xk", "5b98a3f2-2b98-49d9-8aec-596c022fa7dd" },
                    { "rawPiSej2aJVSDBqB4OV", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5201), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Тонско дабе", "54yDT5opPXBpYNO2h6Xk", "906c94a0-ccd2-452c-acb9-07f731f64fa9" },
                    { "RDwk0wPVlEf8krGzgn1F", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5311), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Черниче", "54yDT5opPXBpYNO2h6Xk", "5cb89c48-a5b4-4777-b221-bee1ea0fe667" },
                    { "rKsGztdt3tpTLP8oJaGm", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Кресна", "54yDT5opPXBpYNO2h6Xk", "0d099957-cd74-40ef-9d34-7a483b56e768" },
                    { "RlHMkFktfQKSYU27BYAd", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4208), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Клисура", "54yDT5opPXBpYNO2h6Xk", "16307d06-f4a0-4cda-a0ea-944d2e050f53" },
                    { "RQXQFDTvCpoZ0a3Kayho", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ракитна", "54yDT5opPXBpYNO2h6Xk", "8474f420-8236-45f6-87a5-25ed8f677efe" },
                    { "rQywXXnmGKlGHQnnNhwN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5367), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Яково", "54yDT5opPXBpYNO2h6Xk", "69425883-2723-4fe1-82bf-3ce2251e5fca" },
                    { "rViPdOyzRTCEfafaZZva", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лъжница", "54yDT5opPXBpYNO2h6Xk", "1ee546ad-6d91-4724-8403-fb79dd3b241f" },
                    { "RxhSMfo1HmcWTgMQZq3K", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4994), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Самуилово", "54yDT5opPXBpYNO2h6Xk", "5b09fa65-4c72-4ddc-b154-759d3a49a6cf" },
                    { "S1sGzqNFLkd3UFZaAo80", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4627), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Митино", "54yDT5opPXBpYNO2h6Xk", "b1bca722-2887-4782-923c-a7dd00acf6d5" },
                    { "S2vkQdfficf7Nt5zW1qQ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4433), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Левуново", "54yDT5opPXBpYNO2h6Xk", "9dd7fbe1-eb8c-4968-8e96-9e1b6e89a151" },
                    { "S2w6rTeyOaF1tXhaJ8Jk", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3203), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Балдево", "54yDT5opPXBpYNO2h6Xk", "5616f490-1755-4417-9166-3d2a6a5ff4a1" },
                    { "S4kkzIbMy9o6PaBFS1bp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5237), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Хвостяне", "54yDT5opPXBpYNO2h6Xk", "ed1d143e-3585-418c-8667-8f527f3c60b1" },
                    { "s5pCgajzVG8nPssxC28v", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3487), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Влахи", "54yDT5opPXBpYNO2h6Xk", "8cf75651-75ee-4214-93eb-ad24b74a8a66" },
                    { "S7um2STVboFUapfqAwjX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Рупите", "54yDT5opPXBpYNO2h6Xk", "44ded871-a26a-4685-8bec-679a8542b082" },
                    { "sB1J1ycWUKtRgMNkZPMs", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Крушево", "54yDT5opPXBpYNO2h6Xk", "bc314cd8-fd64-4a24-b08b-9e73a0405dd4" },
                    { "SFS0FQsFpzKsA1bb8z8t", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4439), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лехово", "54yDT5opPXBpYNO2h6Xk", "4704b525-1916-4091-91d0-07f8c6843f37" },
                    { "siPMFqiO6URwVNHYeZQe", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4731), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Обидим", "54yDT5opPXBpYNO2h6Xk", "8b0c7098-ccad-4a02-8f37-221e08735a1d" },
                    { "t0rlN2Z8xXtbnjiGbn2g", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5299), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Черешово", "54yDT5opPXBpYNO2h6Xk", "70034da3-69aa-4a10-9469-03350f44d74f" },
                    { "T8SgJhTrIV9JeuZoxWmp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4964), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Рожен", "54yDT5opPXBpYNO2h6Xk", "e5e45001-8f4c-40a9-b888-f6e07c1171e7" },
                    { "TCw3kE7IFoavq1DbZIQ4", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5219), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Туховища", "54yDT5opPXBpYNO2h6Xk", "2b81f136-0671-466a-bdd8-991f1caf2ee6" },
                    { "TeV2DdAFfdCOkrbb4CNX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4457), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лещен", "54yDT5opPXBpYNO2h6Xk", "4972fe55-a407-4418-b111-9edc1165d442" },
                    { "TfR3QRJKEIPZ013jXnSy", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кремен", "54yDT5opPXBpYNO2h6Xk", "9e8d59e3-78eb-4360-83bb-810d555eb25a" },
                    { "tnvDmxac1e1cknTnvewl", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3958), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Драката", "54yDT5opPXBpYNO2h6Xk", "2f0a147e-54ff-49ae-a35f-97b84144b44a" },
                    { "tossPcPHuBlDNrBKT570", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4125), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Илинденци", "54yDT5opPXBpYNO2h6Xk", "ceae9914-a44a-4f41-82f1-b394587f142c" },
                    { "tWUWYSi2oFeTNgxzijUa", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3993), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дъбрава", "54yDT5opPXBpYNO2h6Xk", "81db2efb-c284-4722-8861-82b18825461a" },
                    { "TZS5F9cqVHqil0FHGjpq", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4744), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ореше", "54yDT5opPXBpYNO2h6Xk", "877862f4-a74b-48f5-bae3-e249c10a30b7" },
                    { "U7FlCWfts6poIKCBCEUU", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5269), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Храсна", "54yDT5opPXBpYNO2h6Xk", "3554e5e6-be1d-4a3d-9e5c-b000c9c30b18" },
                    { "ue1Ma8tBRIWUsbflrxM2", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4737), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Огняново", "54yDT5opPXBpYNO2h6Xk", "285885b8-6cdc-4c32-a9cb-0380c0685777" },
                    { "ueZ1MdWK7lmwfn8Z91ap", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4908), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Първомай", "54yDT5opPXBpYNO2h6Xk", "82084f37-9a4e-4707-b770-086758d62d8c" },
                    { "UFqsRmjk0qf0RLhr0Auj", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4301), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Крибул", "54yDT5opPXBpYNO2h6Xk", "dccb556e-e4e3-487d-b488-d4f1635508de" },
                    { "UFVPO52TDL6wvWCmU2ZR", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3251), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Баскалци", "54yDT5opPXBpYNO2h6Xk", "8021b23d-302a-45dc-a179-39900b63eb87" },
                    { "UkaOFcL7n0R9GPOULEYg", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5317), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Чурилово", "54yDT5opPXBpYNO2h6Xk", "73eb2648-90fe-4442-914a-3ad71ba2998b" },
                    { "ULEf4zBQJFH3WxKNk8qE", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4664), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Мусомища", "54yDT5opPXBpYNO2h6Xk", "8ccc196b-0e58-4781-85b9-e9a62c820dd5" },
                    { "uozP72hWugpEffJ4nCt8", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5283), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Цапарево", "54yDT5opPXBpYNO2h6Xk", "75d18ace-f644-4b18-8280-0e32e0bded68" },
                    { "uRYk2q61neGVw3zxySGO", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3263), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бел камен", "54yDT5opPXBpYNO2h6Xk", "1deca84b-a882-4e32-8b07-ceccccff7f4c" },
                    { "uviWBW7fJ2gsQ1lwXmdj", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4359), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кузьово", "54yDT5opPXBpYNO2h6Xk", "03666fea-624f-46d9-b166-3782a591fc60" },
                    { "uwfIrR3Z8Ynyl0MG2A5s", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Горно Дряново", "54yDT5opPXBpYNO2h6Xk", "3e362171-37cf-4bec-b1a9-54b134eb025b" },
                    { "V0LP9OYPgo6qtjJ9zHMi", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4232), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Коларово", "54yDT5opPXBpYNO2h6Xk", "9f8cec93-3ac3-4ac7-8bf2-3cb963395e5e" },
                    { "v8hGEwckM6erxaGpA72C", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3760), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дебочица", "54yDT5opPXBpYNO2h6Xk", "fbe9ca0c-2c2f-49b3-b4d2-a2bb1ebf7226" },
                    { "vdSm3tjuFT4nRQYiGddC", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3521), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Габрене", "54yDT5opPXBpYNO2h6Xk", "ef564239-9893-4318-a177-098c1d6b7924" },
                    { "Vfy5GV76GiSUSdOz5mwK", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3369), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Брезница", "54yDT5opPXBpYNO2h6Xk", "cb650904-b54b-4566-9d38-50cadde86471" },
                    { "VG0ih8K83XZFUAsfIqvH", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4183), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Катунци", "54yDT5opPXBpYNO2h6Xk", "822b0975-136b-447f-9a7d-82af3c867107" },
                    { "vGWAQsutHV7z2BelkL0i", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3580), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Годлево", "54yDT5opPXBpYNO2h6Xk", "8a59c552-a076-443d-aa06-2074adde3212" },
                    { "vihA0IRoR5Kl5EEfkVKA", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4750), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Орцево", "54yDT5opPXBpYNO2h6Xk", "e57d32af-8fa3-4b4b-bbba-9f35283125aa" },
                    { "vmzK8CfKyFJmDVvFPQ2u", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5195), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Тешово", "54yDT5opPXBpYNO2h6Xk", "2063fd3c-f253-4cf0-b87b-9e717763017e" },
                    { "Vnt8sAfEcMbGnLsS2WVk", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3599), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Гореме", "54yDT5opPXBpYNO2h6Xk", "cf1c6923-5cdb-4730-8b4c-cdb294d359c1" },
                    { "vSQqEMQgaXGdqyiaTLFB", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Илинден", "54yDT5opPXBpYNO2h6Xk", "a4fb3a6f-bde5-444b-83d8-1466b6bcd2ed" },
                    { "VuIX2IXpHEMaONwRXNNc", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3515), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Вълкосел", "54yDT5opPXBpYNO2h6Xk", "75972d0b-7844-439f-9611-2ffd7bbceea1" },
                    { "VuXIqlejSA1q847cQu09", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3321), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бистрица", "54yDT5opPXBpYNO2h6Xk", "c3c0997f-82ca-4ff6-9b54-dc95134f25ec" },
                    { "w1Sz1FJaKCzennpUAe1k", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Каменица", "54yDT5opPXBpYNO2h6Xk", "e1003aab-91d4-415f-bba0-d31af6efd674" },
                    { "w9zUArINXv0niL56fPfN", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4840), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Пирин", "54yDT5opPXBpYNO2h6Xk", "0b5d549a-8c0c-4d30-9124-93349d874b58" },
                    { "wf5BJ3JkTFhZmAvXig4z", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4069), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Зойчене", "54yDT5opPXBpYNO2h6Xk", "caff9450-1d95-495d-8108-2a4da255507d" },
                    { "Whp8KN0wly7vyJBV08dx", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3293), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Беслен", "54yDT5opPXBpYNO2h6Xk", "9b499392-86f9-4127-97cc-11046690af45" },
                    { "WKmKGc87G61qV36YDZQI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4138), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Калиманци", "54yDT5opPXBpYNO2h6Xk", "7bafac5a-5b8e-4ca8-893c-693ca8b8d809" },
                    { "wlwq7kXv477tP5l8h2w6", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3793), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дебрене", "54yDT5opPXBpYNO2h6Xk", "b44c3dc8-4a42-4522-be0d-3c0362150e64" },
                    { "WNsQxDfQ62aPnftdMy3Y", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3190), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Аврамово", "54yDT5opPXBpYNO2h6Xk", "aaab6793-d437-409c-90b1-d711e9074a6d" },
                    { "WNylfUSJCwHOuKoxQZto", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4026), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Елешница", "54yDT5opPXBpYNO2h6Xk", "ebf05a2e-a422-44ef-a5f9-49f39348148d" },
                    { "WQKG79hP3NOpph6GIYmZ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ново Ходжово", "54yDT5opPXBpYNO2h6Xk", "05065f83-1e2c-4f4b-b49a-235afe118d13" },
                    { "WwDGt8iofwVBruHGDqvF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3586), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Голем Цалим", "54yDT5opPXBpYNO2h6Xk", "2db295f5-4463-4f93-8bcf-a4e98f5f411f" },
                    { "x6bJPDAAZoGfIMiYm0A1", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3899), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долна Рибница", "54yDT5opPXBpYNO2h6Xk", "225d5621-f310-4a1f-8e9b-76c9b0596c8d" },
                    { "Xc5DkNFRN3YDCKSXjqmD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3787), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дебрен", "54yDT5opPXBpYNO2h6Xk", "fd326fb9-5918-44b1-bc41-adb56941cbee" },
                    { "xG94yBtSqXmcNHqlkfpF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Жижево", "54yDT5opPXBpYNO2h6Xk", "7b420071-c619-44a3-a2ca-8e6a0bcfb39c" },
                    { "XITLm79cIkPGCUZIseRi", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Гега", "54yDT5opPXBpYNO2h6Xk", "6f34958f-deac-4a27-ad2e-c187638be9e7" },
                    { "xnp3ZB1fKARKQ1hlkCew", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Плетена", "54yDT5opPXBpYNO2h6Xk", "7da7e25f-5469-4195-a6a9-b157858d255b" },
                    { "XQiCPslzUNbQ4bGuRTLH", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4725), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Обел", "54yDT5opPXBpYNO2h6Xk", "a829abd3-80a0-4431-9b77-661abe071cc8" },
                    { "XQnjZaeTz0HbMKc25iUO", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3905), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долно Драглище", "54yDT5opPXBpYNO2h6Xk", "1716f830-d487-40d3-9123-2e1a99a9a7e8" },
                    { "xtviuqZWNHgI8Vm3uDvm", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4683), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ново Делчево", "54yDT5opPXBpYNO2h6Xk", "acbdc7d2-7271-4cad-8887-3b10d375e27a" },
                    { "XW6zBYsRpc1kLLE5Kz6m", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3428), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Българчево", "54yDT5opPXBpYNO2h6Xk", "d37b9853-0313-485d-890a-3a1ab1c26a27" },
                    { "XyBpFKul4FhqG6qJbjeJ", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3509), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Вълково", "54yDT5opPXBpYNO2h6Xk", "13301749-a808-4e80-a552-189007919ce6" },
                    { "xzmKSRB4qDTxvbyF3uRp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4503), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Логодаж", "54yDT5opPXBpYNO2h6Xk", "91a731ed-35b6-467b-9fc7-6b0dee1de091" },
                    { "yCK4ieG4tnpBiiDiZenX", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4695), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ново Лески", "54yDT5opPXBpYNO2h6Xk", "b5a10000-9a98-495d-b60e-fb46110e7b99" },
                    { "yCp9InZJJIMpwiOkNs19", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4422), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Ласкарево", "54yDT5opPXBpYNO2h6Xk", "ca44ea4c-2bbd-4eb1-b3e9-bb22587c619e" },
                    { "Yf3xbaXybnoCEGoBzXXp", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4999), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Сатовча", "54yDT5opPXBpYNO2h6Xk", "7bcc68ce-0022-416d-a877-5a5d628ac5a3" },
                    { "YlRTjjDvXo6T9jUyAoXm", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3281), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Бело поле", "54yDT5opPXBpYNO2h6Xk", "289c64fa-9c39-4da0-97e4-65e99a43f01b" },
                    { "yltDkNBX68HMpeUHLfOr", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4958), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Рилци", "54yDT5opPXBpYNO2h6Xk", "cca19dfa-9faf-43f3-a57b-f83e04f759ff" },
                    { "YLUdtyrlc6gLjsr7R609", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3153), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Разлог", "54yDT5opPXBpYNO2h6Xk", "c9c06749-4f90-4ddd-bde1-9630882cf639" },
                    { "YryGMVv9dOjqLh0TT5Ip", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3987), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Дъбница", "54yDT5opPXBpYNO2h6Xk", "0f8c100d-a24b-4367-bd1e-4840d45d1471" },
                    { "YtdC9THcgwBXzcqEKCi5", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3411), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Буково", "54yDT5opPXBpYNO2h6Xk", "e35eaf80-03a1-4efd-b43c-96fb7a1d96ba" },
                    { "yuA0YdFLUb4Xs0ud6awq", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Добротино", "54yDT5opPXBpYNO2h6Xk", "8a61e3c7-4ba1-4612-bf5f-0f6e909e81c2" },
                    { "YUgFQ7igSTdKCm5qBjl4", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4586), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Марулево", "54yDT5opPXBpYNO2h6Xk", "09d0f841-049b-4790-8460-526ddcaa2958" },
                    { "yURtV8KVpsCiFrfZfUOI", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4902), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Право бърдо", "54yDT5opPXBpYNO2h6Xk", "f8795581-9bf3-4ce1-b2d5-7c375ce094df" },
                    { "YvNF8L5OFrgNQAt8MyWv", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3120), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "гр. Мелник", "54yDT5opPXBpYNO2h6Xk", "5d73dc88-840c-4cd4-b553-5e2fbe20cdf5" },
                    { "yXx1bXVPWWU4h7uV2zBo", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(5373), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Яново", "54yDT5opPXBpYNO2h6Xk", "056f01e8-7f29-4097-bedf-522c548714be" },
                    { "ZMKNREeEFhom9N1wEbeO", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4509), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Лозеница", "54yDT5opPXBpYNO2h6Xk", "e502279f-759a-4ae4-a5f4-538184b972f7" },
                    { "Zp2mKsaYrEc2WBZhjtj7", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Долен", "54yDT5opPXBpYNO2h6Xk", "fe82ea60-357f-4a8a-bb7c-3807ad71880c" },
                    { "ZZTm6w0YgaHTc4LjEk5d", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "с. Кашина", "54yDT5opPXBpYNO2h6Xk", "5381f90a-13eb-48a0-b937-60153ceed79f" }
                });

            migrationBuilder.InsertData(
                schema: "Cars",
                table: "Models",
                columns: new[] { "Id", "CarBrandId", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name", "TrackId" },
                values: new object[,]
                {
                    { "1ahyRg3wjH8WqLCemWm0", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "320", "0f6a12ed-8d75-4fef-acbd-198309b048ea" },
                    { "1CQsRhbXxvVfVjMeBF80", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2033), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Gran Coupe", "ebd4c9ce-83c9-4c88-b7ae-68e4d27a6da7" },
                    { "1edrRwU14P1G2qB2W6Mg", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2089), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iX3", "b940ee8c-aa88-4015-8661-f1938c795f18" },
                    { "1GSECcyMaolzKegHec5b", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Vanquish", "3a7e0461-0439-4728-a3a4-d68812568f2e" },
                    { "1Hh6y3Hd2B57B5Yhv1Qz", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(530), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "33", "3230367c-8ab5-4648-88d9-5945ef24fc49" },
                    { "1KwaAqv0oGLLXlYgFtmr", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1739), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 5-series", "530dff71-3260-4ffc-9574-4c1ab72caf5e" },
                    { "1lv9EhJCWKzEuaQFHUCt", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1889), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "645", "e37f2d26-b1e2-4246-97fe-b6c2145472f8" },
                    { "1PUJjwfQmcB5Xa4hR8p7", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "135", "a1745b18-0656-4cfd-8db9-2bd255430d54" },
                    { "2DSnM9XahzMLHgHux60x", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(448), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "145", "9a9a98ae-8d93-4176-9a69-c4f44759f4ac" },
                    { "2HFIV01uMElh6qkgUfA3", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(843), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V8 Vantage", "85e2d9b9-1c26-4972-81c1-21130f0e0315" },
                    { "2m7XUHI0ajGvJfrJsbtf", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1196), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S1", "0581cb8e-d5ce-4dd8-bcf2-900eedff8941" },
                    { "2RAE2dR7uAb2nrVxuq7A", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(752), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D5", "f21e90c5-7f0c-4d95-ae54-b2a18bc35cb3" },
                    { "2uN7Vcde9EM5KTradjV4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1716), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "435", "d970b6be-6194-4891-afd6-bbd5d716128d" },
                    { "34V233Sjg67orQkafzvx", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1032), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-tron Sportback", "0349def7-7d4e-49c7-a2d0-c1571dcfd49b" },
                    { "3fWgLE2vTsVHzNV0BWBA", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1773), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "520", "cd4ad3ef-934a-4406-bc98-09ea28c14796" },
                    { "3JhtXs555ANW7aalItVQ", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(334), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rl", "571f425a-a37b-4cef-ba20-3d0b12f368e4" },
                    { "3pcKnHc69gKraLTHtVJ6", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1253), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S5", "23c176b1-8e1f-4501-bbfd-172e1829ed71" },
                    { "3Qqcv8SX9s9gKMhBo4d6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1647), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "330", "c25e19b4-7300-4bbd-8bc8-8e22ce8392c1" },
                    { "5IvbeNX1a9TzpvJzzhq2", "0SlIJFKD3VdaMAEnxfTT", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(83), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "f0baf112-0355-44b9-b077-d193e3b8337c" },
                    { "6lThIjIusg9pJSfFQwYI", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(680), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B5", "78e34b7e-be28-46b4-a46d-179bb727b41e" },
                    { "6mp3PpLYTHFqlw7wSVdc", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1549), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "228", "1ab4dd35-926b-408d-98ff-0570f3e05f37" },
                    { "6qHLv1cB9YIS2V1BkyES", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2056), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i8", "b98e99dc-b2da-435d-9b00-e9f7af91aa00" },
                    { "6skH4KqJN4KIm7sVqFdB", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1536), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "218", "55acd23a-8da2-4f3a-b7b6-0ac6da4de083" },
                    { "6uJSjoavBTwEVTVlEgId", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1461), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "118", "9f26b6a7-f4ec-4eeb-8a18-eb4994efb568" },
                    { "73MytTHBvB28B0BqC9un", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tl", "0b9e9d61-2f5c-4037-83be-5e9614a0f055" },
                    { "7atd3z0fabVAGpcv1h5J", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1236), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S3 Sportback", "33d52b5e-9945-4802-aaed-ff80e7a42b51" },
                    { "7DMDUDBG0WXdEvaLSA6c", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B11", "767583a5-4fda-4273-8056-44bdb80676eb" },
                    { "7eNL8dH4ktrNMwpeFma0", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1900), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 7-series", "a51cfb3b-d4a0-41a0-a5a2-46167cc4e2f9" },
                    { "7WPGkqHcSXS48a9J95H4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1859), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "620d", "1c4cacc0-2f91-4ea1-b2e4-d33df44f4324" },
                    { "7zR4NBxlnMJqD1cV0HH5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1785), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "524", "1ffa9ecb-61f2-47af-b9ec-b9cbf38593aa" },
                    { "85kID6EknR0bkThGFBVq", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1642), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "328", "5558f85d-e1a8-43ea-a343-c34d9845c7d9" },
                    { "8UPLz1Ixw0ktFe3HInJ4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1820), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "545", "ad0a6ceb-2ecb-4405-a020-98dd531dd70e" },
                    { "8vUgXthGUabhwwJTlnyw", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "318", "fa865f85-9c0b-4dd1-bfd3-44e2726d5e1b" },
                    { "9kjmuhLIbefrKVr0b2ok", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A1", "f0cd5af4-8477-4bfe-b616-5274bb549cb6" },
                    { "A2Fsv2xeYceLtQHc6Nd5", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1094), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q7", "debbf2cb-9941-4ac0-bd0b-dece790fb131" },
                    { "a5Jm0TzVPCpJF81LguD1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2175), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X6 M", "1fb918ba-5f40-4804-8861-5b164eb15665" },
                    { "AhbEAEWHAM31ewbHHPzN", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(837), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "V12 Vantage", "33d33124-11ca-4d99-88d3-b19f408af0bf" },
                    { "albHp3Rdp86AacauEHdv", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(372), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rsx", "ee006566-9b50-4e75-98e9-1f0a4b67c4a7" },
                    { "aPdfbP6oPzzWdmS08Av4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1427), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "114", "18b5613b-b8ae-4716-8bc6-4091fb511baf" },
                    { "aQ8WYwaNKaTKE1jgos0n", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2044), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i4", "28c93576-83f1-4185-be02-b066e7177eff" },
                    { "Aqq0hKNDWuF8glgvLm2f", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(996), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6 Avant", "c3f026d9-0781-4f07-911f-92ffa9b6ae94" },
                    { "Avkb9IKLda60pUzIuzth", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1543), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "220", "b2c97933-0136-4014-9eb2-5b13ccefccd4" },
                    { "AyFFbcS9gCbuleb3tMGr", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ZDX", "e2522683-31b8-4896-b7a6-73dde51fbd49" },
                    { "azgl8F93q1cYKrIV0xkE", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1402), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mini", "99a25c64-d39f-40f1-b1d0-5f091e848b18" },
                    { "b1f0G0rjQMomWbCpDqdu", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1624), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "323", "bbd98969-f06d-4dc7-b9d8-4b49490d392f" },
                    { "bCSfuMLkVpqzIX5cTcQH", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1974), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "760", "75dded46-8ee0-41e6-8b69-85e3c80fe914" },
                    { "bjuhgEKKjxEAkICeCTe0", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2186), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X1", "90847711-34f2-4afb-8a8b-dfd5b0de9041" },
                    { "BUz0BH37tbNyHk8Ljsq5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2096), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All M-series", "a2bbe4f4-2b94-44ec-986c-6ba5198c8dfe" },
                    { "BXb1v9Prnf4Lk9D1gyfD", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2163), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M8", "ed4fa3ee-8313-43c9-85b9-ce8591a503bb" },
                    { "byvU3FcH9cQ2CoMq8hjw", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(865), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "80", "2ab300c8-8ace-45b1-ab85-a969723cf24c" },
                    { "C7KJhTQzXq42Rtut4fyw", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1037), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q2", "d1a15093-9dca-4833-b60d-cb8cbd35ba9c" },
                    { "CBUEHvQbRKK3y1uxIEkq", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2020), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina XD3", "838bd523-859b-4ca7-b850-e2b64d3dd9a6" },
                    { "cJCmsBnHLXYY63QNMB0Q", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1081), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q5", "705d73e9-0008-4e9e-b384-2fcc821a06d9" },
                    { "ckFSJe5u9Qmf3HFEuzrL", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "735", "2b2b07a4-f69f-46c5-bedb-d841d1057604" },
                    { "CL7CGRfkJdrIl50k3blc", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(704), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B9", "be9002e4-5d6f-445d-8d70-f99ad4a267a8" },
                    { "ClRL1SUNAjmx7qVNqapl", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1498), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2 Gran Tourer", "27dbfd11-ef96-4af5-a261-55d1a3a43956" },
                    { "CmlSztvajtonNXqqo42N", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2113), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M240i", "5c472da3-e2ef-44f9-934d-e867f9d7c95c" },
                    { "CMvQmtqKhT8JXD7vhxHT", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1352), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Ambassador", "f355faa3-aa01-460b-a435-2d39b6499623" },
                    { "co9rD8Ks2hto9DnDdePJ", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GTV", "b104ea05-6ebc-4cf0-b347-43ea6d03dc1d" },
                    { "CQ9zrBWlKrdlsswblB4f", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(617), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Stelvio", "bbe1cc65-52b3-4616-9226-ad6857703c09" },
                    { "CY3br0SDRLQCeLhqXJow", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "100", "30d95d8b-0dcf-4a36-918e-5ed04c08db3c" },
                    { "dAjsbgBuGzpWSdvy20m6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2008), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "850", "67d79f32-c759-4020-ac1a-0c305eaee1c7" },
                    { "ddLYr8bXthffNd6Ta59g", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(933), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4 Allroad", "2cdb2afc-62f6-4378-84a0-68a0dc56c888" },
                    { "dfMsSfwG9y6C3xzTQzqT", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1339), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TTS", "b502d9b2-b835-480e-98fc-c59e4e2fdaf7" },
                    { "DJKsSDbEyeJTzg8FdQru", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S3", "e2158cc5-74a1-4001-9546-08642e534361" },
                    { "DKVGVsLsUVKpWJJUtWnJ", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Metro", "25a1bb35-1ef2-446f-a689-d5d4232732cd" },
                    { "dPbjnFSzLlBpF0mA0AMP", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1727), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "440i", "2a1cc5b7-484d-4897-8bfc-dadb6c8d812d" },
                    { "Dr0xpQxhk2bAkEoEjEBR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2204), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X4", "008b45b5-c188-43d8-b07d-e37e4a8ff7a6" },
                    { "E0qhePsINKDN4NbmLJBp", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1414), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Princess", "4ecf28a6-5f40-4e6a-9c63-2125eb1d355d" },
                    { "e1nqI8kL4tXRDvl2h0LA", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1573), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "315", "a86c1632-23eb-49e0-a6d5-ad05bc002c82" },
                    { "E8F1hbfaguqrBlgATLCg", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1468), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "120", "a361c477-e3af-49d0-84c2-f13de7fe3df8" },
                    { "EgxVJW9vJm3bYxun00Cp", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1258), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S5 Sportback", "c77330a5-0ebe-42a9-9e7e-49355b958031" },
                    { "eIkojxQyAf82FH1TflpU", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1019), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allroad", "a3068e9e-5dd4-4376-a068-de9077f8cb0a" },
                    { "ELgpTQCVEGVSkpY36s7L", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(420), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "600", "b5906962-9b54-44e9-8dfc-57aa560a4800" },
                    { "EvVyEryDrWXMrntT8r5V", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1926), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "725", "36c361c6-6d6f-4072-b2f6-c34c843e9705" },
                    { "eyBmzkDa1phHXht7sqD1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1658), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "340", "475154bd-0e91-4a13-a9c6-ca350afe227c" },
                    { "Fa0qkDJJxwrsUGkYKc9n", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS4", "a51246d3-f511-4fb9-9014-20c4cbea0443" },
                    { "FKIfIz1TykX5qvBuxHSR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1802), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "530", "7f80163b-5288-44ee-9d8b-82df6c138e9b" },
                    { "FV97XVk6Vn1PWTHNIL8M", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "418", "859c8810-4d08-4e7f-88f3-644d9dc9bd2e" },
                    { "G1G1TlhP3F0IJd9wCjP2", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z3", "0226dbb4-3089-4e61-a980-ba1e84b7eeb2" },
                    { "GFg4EHq0dlpDjAelrrRq", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2124), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M4", "e483eb95-a6f2-4052-a7f1-449db222801e" },
                    { "gnBKlYFJ2XQoVYlgCstr", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(308), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Integra", "5405becc-39d5-4155-92cc-aa2fa01fe07a" },
                    { "gnREzTfvNp4JB3DlyCHJ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1697), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "420", "4a9fd92a-24ff-4981-8dc0-10ad1fea294c" },
                    { "GrCzBhfVK23C8DAf8khz", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(478), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "156 Sportwagon", "6f516ec2-1542-4b7a-ba62-6dda5bf5a7b5" },
                    { "GtkP5LG7PFxeN8rLSFW6", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(686), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B6", "f7897959-d890-4f45-8bc4-2aeb1de80d20" },
                    { "GY4JSY6wXjA7qxQTq73V", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(945), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A5", "ada1e800-b7c4-421d-af97-4c0dc8459f07" },
                    { "H74dA1wkIb49StIQzCHs", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1242), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S4", "22ddac4a-571e-46c7-941c-366bfb5ce053" },
                    { "hv4MSQbTrkuTWtgyP3T4", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1408), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Montego", "1a710f06-50e6-4674-b447-2e262f428491" },
                    { "I86aewYfXMn91kcaXlhc", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maestro", "9c346e2e-a25b-42a5-a340-25039dd6cb12" },
                    { "IacRec9Mpo3bkS1XWHjV", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(699), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B8", "d10d446a-e48f-42df-bd61-fa0c9c2795ac" },
                    { "IFAkbbbh6MW5HRUfN6TV", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1345), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Allegro", "a376b416-d8f3-4415-b46d-ac2c888eb12b" },
                    { "IGmkF3ho6EJsSkhU0oSY", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1722), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "435i", "d0debec2-baf2-43ff-b17f-c95463c21d16" },
                    { "IKeLr2wWU25Wml667AsA", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Db9", "61db2026-cad5-41b7-be2d-ee95a6ae5a5f" },
                    { "IuMVrlqL543eHonI4FbL", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1871), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "630", "1749d6f8-7578-4252-bb11-57cc8474572c" },
                    { "IWqlsCHKoXA2tKJa4JAb", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B10", "c8915a04-9515-4c5d-b52e-2fdd8f6eb741" },
                    { "Ix8eJhXC4BenvtAQUXF8", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1248), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S4 Avant", "00fe806e-a6fc-4072-a9a5-d8d8ed2e4279" },
                    { "Ja2mXmefMCv3vmemDb96", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1509), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "216", "677545eb-3d05-447e-934d-14eef909acfa" },
                    { "jbI09TkHmqCLAPfXv2WK", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TLX", "87f4d244-23a7-4162-84ae-1f878499d7d3" },
                    { "jeotKxdW5A4Pk8e1VkaK", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1173), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS7", "2864a9e1-4c42-44bc-a0e8-e255b636e4f6" },
                    { "JeQkIPgWMTmyFt8omk1x", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(641), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B12", "af08d354-566b-457b-a615-3e303c09acb6" },
                    { "jfyoKqRgl5HJj0wIQpW8", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1962), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750", "9f9ff083-2a3a-469e-88b3-28230d09cbe5" },
                    { "JmEtBH9Y3IX7S9UxM08P", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "316", "fbde19da-5444-4cfe-ade5-d02e12fc018a" },
                    { "JNVNsBu0D2Kn6lYXBqvT", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Z4", "17a45ece-3dc6-4b79-9a98-4dc4fef46ddd" },
                    { "jSczhSNPcsR5tae5DDdM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1796), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "528", "85f16ee4-b6f3-402e-bd4c-ed01e9484c79" },
                    { "jV5f40APfmSlaycjhNq7", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS6", "c5f18dc6-7638-45db-84d6-caf55a8dbaf5" },
                    { "jvDyhpfT1TwurET4gNBC", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(461), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "147", "6cba3653-08af-4452-9ee4-e2d4a00d3b14" },
                    { "k5cLfXCQuH5GaT27TKl5", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(939), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4 Avant", "7054be48-26a1-4bcf-b9a9-75fc0cc3ba7e" },
                    { "K6jMQLV06NnjT9VlswjM", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2238), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X5", "862fd4b3-737d-48d0-b5ba-a35572cd8ee2" },
                    { "KB1xVe50VvY9cFetJoBj", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(928), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A4", "be4745b1-a37f-4505-b281-352f10b066d4" },
                    { "KbhRqSPl4w7y3b7RVN7d", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1105), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "R8", "aad5ac28-da45-4a07-845f-d11f373b2add" },
                    { "KCDoILFmGDM3qwqKrtxw", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(691), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B7", "4ecfd9ac-e377-4707-9290-963ebc514684" },
                    { "Ko7lsc3R3tVhXK01CpLE", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X5 M", "d322b035-6306-40c5-8827-6e0dc05c6080" },
                    { "ksEJT9DHkAdqLeVIe1MQ", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D3", "f8e7872f-66a4-4a46-8e85-a61f78883a24" },
                    { "KWtbUESfFqWo41aPa8TQ", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(767), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "XD3", "68767b6e-c8d9-42f6-8370-e0a4af95b165" },
                    { "kWTEbMKIvHSh0aDzqumL", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1322), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ8", "b522531b-740d-4e6c-8c6b-d10365e41d3f" },
                    { "L7F8zSGRusMwbMLvf7nl", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(536), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alfetta", "93a1261b-6276-49a5-b09c-2e65baa1c43e" },
                    { "leXKoBX6VN8TGcnc8uWB", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(322), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "NSX", "612347f1-6f3f-45e4-8ef1-5d6f3690590d" },
                    { "lFLaFlJdQRvlWCgrlTMx", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S6", "409a454b-5c4b-4635-a7c5-b388ac572d03" },
                    { "LfnWy0dheVBMVwAFcFNW", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2192), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X2", "d012af68-9cf4-4301-89c6-792d16be0ab1" },
                    { "Lj94x6e6locYABbrDBnM", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1305), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S8", "472ea92a-783d-4296-b468-1fd5df628e23" },
                    { "ljHD8Mom9EIzajSJqluB", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1876), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "635", "3be3a995-a53f-46c1-8671-82eb2ec93fb1" },
                    { "LK1NRVwv8vhle5It531Y", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1636), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "325", "9d3ce567-dc45-490f-bfdb-508cb1889a26" },
                    { "Lm8IaL3WswgKL134qV0D", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1111), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS3", "75925aba-1484-4452-a86e-2db98688accc" },
                    { "lsGyRU8oXBerI0MJaPgq", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1745), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "518", "b652c375-1f7b-4abd-8e2d-275fae84778e" },
                    { "lXEdbRFa1nv22ruovP1P", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "540", "701a53f6-74af-4e4a-b4e7-3ea30c4e54a8" },
                    { "M4CsJfL5xyX2r20JrG8y", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(916), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A3", "42b59bb9-beae-4422-a619-c8381f9cedb5" },
                    { "M8pMtGEQ4cloRq9slwIT", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1479), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "125", "9acc096b-0247-405c-93a1-40714b44824e" },
                    { "mllgYwUvetSl11cEv6E5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2102), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M135i", "75074561-1cc7-4698-bf8d-4cf14177b55f" },
                    { "Mm1ez0VjHeXS72SY3rD1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X6", "5fb2ccc3-fbc3-46ae-97c2-117e0416034b" },
                    { "MnV8GF1QzjK1aIJ7eTmR", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1949), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "740", "17f193e4-5583-47ed-b69e-1c8a9faf5574" },
                    { "MPDrCmH9txfanS72gc9r", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2256), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All Z-series", "c43bd7b3-a289-40ba-82a5-52fe9befbac0" },
                    { "MPvPd3VwQdClQE4tFScv", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(496), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "164", "fb3c822e-d79b-445f-b7e9-46353e8543dd" },
                    { "MXpw5lDM0IjcopFy8aHQ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2050), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i7", "352d1aff-7198-4eab-9427-847cdfa100ee" },
                    { "nEL5MhBVIyA3maL6YUaf", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(547), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Brera", "dda296d2-1bfd-4e59-8606-01885d3a110e" },
                    { "ngXJJ8CQJQWIJ1kHGrtR", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Arna", "7f8230fc-4bb5-4f12-9e50-f8fbe374b4ed" },
                    { "NKm485qpHrLJIFKpP54n", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(466), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "155", "a72ce6ff-b477-4c20-97e0-5c986758fdbb" },
                    { "Nmena3EKaMxNh96AXqnW", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1779), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "523", "8ae4f41b-e7a2-4625-bbaa-3166288c5fae" },
                    { "nR8tcCF24TqvoN3gvwvw", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RSQ8", "6ba0c5cd-b68e-4973-b6e1-9789fcd0f234" },
                    { "nSA5cjhnA3agEnGmdw5B", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(957), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6", "d0894479-59fe-4eca-95bb-4168a450d913" },
                    { "ob5pNpHL71T7tHaXU13R", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2198), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X3", "e58fd426-1d4d-4f8e-8b67-e7969c68148f" },
                    { "ob7AoVQuCMa6qA5gqLr1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "650", "1e3cbedc-dacb-4510-afc5-1d37b58ab1c2" },
                    { "oozshkoRg9CCfoJeowWz", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1968), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "750IL", "134e7a80-8d0b-4f4a-8c52-36f665aa38c4" },
                    { "oUPtbLwxolaKhNdASqmg", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1567), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 3-series", "002a13b1-f375-49a9-90c5-0130fd67fc5f" },
                    { "oywJUSfnnsU5NVC9QRGX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2038), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "i3", "2419fa1b-b305-443a-8bb1-67f28150da1d" },
                    { "P0w7nNKI1pX7wfyXlGoT", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1087), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q5 Sportback", "c0522032-f649-4679-b6ed-28539ebdd3c4" },
                    { "p1AU44AT0QEvKyXpgS6d", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1178), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS7 Sportback", "921658f4-ddc1-43be-a36d-34ac63683a7c" },
                    { "p5eEds4JuxENqakxtoDv", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1554), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "2800", "f5f32a9d-a722-4e3d-a24c-f324cadfc14c" },
                    { "p9acrcU7qLMdVMh8efIz", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1153), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS5", "f8082679-c698-4a47-a8fc-ccb0127bc00b" },
                    { "pbrBFqIfcSeCnaWdUqB2", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Giulia", "397aeeed-da08-4ef9-a405-1ed9cabb2899" },
                    { "PgN0BCsJ8lUYE4BpuHjN", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1733), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "5 Gran Turismo", "6e864db8-dd52-4aa7-af24-a518b2ffde70" },
                    { "pmFry22w0A6Fxuw3tmCe", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "200", "829f2c01-5990-4a71-b165-430f90794171" },
                    { "pPnmYBcUpM33IRnThVyW", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(883), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A1 Sportback", "770f943f-9b79-48e6-b804-aebf2a994a1f" },
                    { "QbsJtfxuImamwjpzpq8g", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1808), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "535", "9133f795-cf3e-4746-8855-30ac61b0235e" },
                    { "qDDmbnu4xVI330PKFAbB", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mg", "16140d90-5d6a-479a-8854-a79d856685dc" },
                    { "qDLcQLQDYnnIKuNwhdAU", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2107), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M2", "670b08f2-7a8f-4231-ad44-69242e17dde3" },
                    { "Qf7GSJUwW03wIEqjRelA", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2082), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "iX", "75a68250-fd29-4b53-acd0-980898caba0e" },
                    { "Qk2NYtUoc1RIICGCmTkh", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1026), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "E-tron", "927e27a4-b811-4c14-9382-33901a04a9c8" },
                    { "Qm650FDGlgbXHd15r3QJ", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1201), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S2", "17ee6c29-dac8-4680-8c19-f2ec7cfc3220" },
                    { "qmcR6XmKsKEsMnw8lRRK", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(315), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Mdx", "0a0da51f-ccaf-4a39-b223-2b3a92038c1c" },
                    { "QmgMK6K3wY1VXBbMV1sE", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "628", "0eb5b042-8348-4fb5-bab7-83444405a026" },
                    { "QpLRcu8BurDpdjwM2eVf", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2001), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "840", "ed74df6f-caa0-4213-81aa-6be4e22537ad" },
                    { "qPmDnMxDcMrtqrcy2WQa", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(395), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tsx", "dfb71921-f3c5-4c4e-b521-65c1a0e99fbf" },
                    { "QsYdna3SIK2EUeeBtf15", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1076), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q4 e-tron", "591e3be5-240c-460a-9f5b-4e0e0a6bd06c" },
                    { "QtPLupfdDcCTjFdyvjK9", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1630), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "324", "23c8638d-e00f-478a-8175-c5a232f830d3" },
                    { "qyvG98eSq9UdXQD1082R", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(952), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A5 Sportback", "f92b6b69-331c-4ae8-b65b-dbca013a9680" },
                    { "qz3HRorns4T2KLqSQ2Rd", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1328), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TT", "daace7d3-25fe-4d90-82a7-7f664c5ff1f3" },
                    { "r1NHfsCyX2EgjGCrfcEh", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1317), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ7", "bd8fd30b-24c5-4349-bc11-e4996c1117e8" },
                    { "ramWSSpstIfupQ6p3oE6", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "116", "71865357-efec-4983-b6fc-750fd7f34e91" },
                    { "RfahGkmDGWgeyES2Yyxt", "06MxFkB3ArFfVraVWN1u", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "e9918e36-1b28-4dd3-8e2b-7a8c755029ae" },
                    { "RpuVc9IT9FsJgw6xHvFA", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DBX", "4ac79edf-918e-44db-85fe-401930625afc" },
                    { "Rt0brs7eXrIoMhslItgL", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1333), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "TT Roadster", "cfe21738-a7c7-4ecd-a52c-c4f73a97b9cf" },
                    { "rvudrKS1stCeT9D65wQf", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(572), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "GT", "ebf2fb77-15de-4ecc-aa0a-bb2199c261ae" },
                    { "RyMtRmx2Y19sLqfCaMSI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1474), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "123", "a2b72d75-3cc3-4443-93f4-292ef14765b8" },
                    { "S6tx26LPQDxRY3B0bNCk", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(566), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Giulietta", "3cb29e58-64d9-419f-ac6d-31bec9ee9107" },
                    { "SE429tJ6ol6wjJjSBC9m", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1710), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "430", "d1f70e2a-d560-4662-93f7-bb8394efaa97" },
                    { "SLsdBhp5aSaQCDwPblmG", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q8", "1127c50d-21ad-4b3a-8073-971693539300" },
                    { "Smve6BazsbcEWbRs8Sxe", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1117), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS3 Sportback", "6f93bfeb-4150-40ae-b9d9-5d7cd1f9e433" },
                    { "soDweMEkoVjwUs4YxTAJ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1653), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "335", "b4d3f95d-6157-4e9c-b134-d751d3e9101b" },
                    { "SuXX5RCyDYVgD2GNatIa", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1276), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S7 Sportback", "9753af75-8fe2-4047-a350-6a27372e2f06" },
                    { "Swg2g3ItEUTm3YeWJ0zD", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(328), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rdx", "67ad05a4-cddc-4b7f-a615-ad4f3ce24985" },
                    { "Sx6FD3RGth8bWsf94VHo", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(807), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rapide", "6b5edb37-a369-4334-9f7d-4d81474e6fe0" },
                    { "sx8EyseSCVIwQ5z6dGNA", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(406), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "400", "131184e6-1197-4777-87ff-0c8729b91d5f" },
                    { "SxfXFVyuzIkp4asT9sNe", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A8", "b4a7bfc8-d62c-4db8-a9c6-960cf8078f01" },
                    { "t2nBKWvUmcU9rGzQ8hYx", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q3 Sportback", "cbc4c488-0929-4122-bb80-073ee387abf7" },
                    { "TFweSXXrUUqrQPoz78GP", "5aFWwvagmpfBWQlHxU5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1385), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Maxi", "eb47178b-037a-468a-b755-782e046b7372" },
                    { "tGdjmRm7qqpTXNhKD33T", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "MiTo", "e6324bad-68cb-40bb-bed4-42c3981fc4ae" },
                    { "TGjeCD5B4W8AMz3KCrRb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1827), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "550", "9433c7e0-48ed-4fcb-9531-63d0f7db48d8" },
                    { "tICPHSXgW2lopJzV9JmD", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Tonale", "01acdfd5-7f44-4a9d-b7f5-3de8592b0164" },
                    { "TV2EkQDJMhMx1NeJX6wg", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(483), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "159", "2d3fdfe4-d44b-42da-8eab-495ad7d8a67e" },
                    { "u0WxvmkNs4ITgklDspLG", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2250), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "X7", "915df7b2-ca47-4fc5-a16a-ab5afe4d2406" },
                    { "UBjSGxcglIcILLMM4R2K", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "DBS", "f9394af1-93d9-4f29-a5f5-646cd03d8a3d" },
                    { "UgTtBLNVmb0HDwzVIB3x", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "728", "79d2e188-2e21-43df-9a1f-932315f4834f" },
                    { "uHwB9sxsLkase2JvDSjt", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(871), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "90", "9769b9e8-1e4b-4b50-96f3-96815fe53492" },
                    { "UI5CsgRYC5545z4EAo6d", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "D4", "7689fe02-aee1-47ae-b888-2d5d7c285977" },
                    { "ulK3CezGwd6jHGU0egcr", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Q3", "08bb0511-2d5e-485b-b5b6-6f00c3011ce6" },
                    { "UotXzQLdnvfqgMXzz50G", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(473), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "156", "630b327e-22c6-46b3-b941-4afdbbd4d4b3" },
                    { "UQUcLaAdkhlVsP4K4Pj4", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(611), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Spider", "e7c1d1c6-067b-4d2f-9833-6fde4447c6d4" },
                    { "v1Cj0F2PVyUo1WYdUPzm", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1664), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 4-series", "c78518fb-2a20-4de2-9a5c-bd181e1e2efb" },
                    { "VfdcJBeXq0HG5JTsbFLX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1791), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "525", "52afe5b7-9f4b-4dd0-84aa-39dca088729f" },
                    { "VhcDLXN0CEyMRP2RILkJ", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2130), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M5", "0a400234-61d0-43e4-8904-4d97e3f7e6e8" },
                    { "VhWLKgvKA37GHk0VbLu5", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1421), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 1-series", "e78a5cd5-656f-4d33-a8ab-7deb609b9a6e" },
                    { "vKbhMzyFF0xKeII7MKw1", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(652), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B4", "eba346f1-3f73-404a-a53a-18f298d7236b" },
                    { "Vxk4XEsaVfKpPCc3ugmz", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1561), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "3 Gran Turismo", "8d504ad0-b45c-47b3-90f5-1f4c4100fb04" },
                    { "VYkPzMqAeDlnL7IhGq5N", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A6 Allroad", "e1da8649-131a-405a-8caa-953f16ad6891" },
                    { "w0GETq9mpaggbgAWGcd2", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1008), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A7 Sportback", "51168ec3-1cd9-4359-a23c-45bfcc8a8769" },
                    { "W34o8Q3qlw3DeCthrN2z", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(759), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Roadster", "ae692c9e-c596-49ff-8b25-fba59f2ce0a0" },
                    { "w7Nd6FoyzgdVeedgtT8q", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A2", "18e35e3a-5810-401b-aee3-2198f2ea2e9f" },
                    { "W9uk8BA6VYEMELojAwrL", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1938), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "730", "9fe8df96-067c-447a-a8fe-9f99acdbee40" },
                    { "WCP9Y0rbVpom3tUTRHj1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1503), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 2-series", "54571c8a-2bf5-476e-8664-09b016885f0c" },
                    { "WEWpPFB50lLhHUx3kQPX", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1956), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "745", "291012e8-5fee-4c31-adee-660e65927531" },
                    { "whTYAstU8fnpGvGcBvbT", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2027), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Bertone", "9e476a1a-a9ba-4a36-9634-99f03860d181" },
                    { "wmEEUUXlgJXCFLUQXArI", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All X-series", "cd4cd3fc-1a67-4fa1-a389-71cdc76644e7" },
                    { "wofHM1dmVNs8aMzyHx5R", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1184), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RSQ3", "8dd87259-99cc-4136-b758-adf80b9c845a" },
                    { "WQP4yRjpu7pQFx3g1hfA", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1311), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "SQ5", "2ca96624-441a-4f93-932f-804b3a40fc0e" },
                    { "wuRAPjNVNBtNGnRFpCIS", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "128", "934965a0-08d5-490d-92a2-59ff2524c3a1" },
                    { "WxfqbFQhTNCUbxlhW7IY", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "B3", "07e89750-8862-4165-9ed6-ebd98839ab6b" },
                    { "Wy2vXDXAonyldmvpYvm4", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2156), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M6", "9144ecaf-31de-458e-8c30-d4735b38c048" },
                    { "xEB05YPa1KFtsBANxV5U", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1270), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "S7", "da51d540-d54b-42ec-a0b9-3c86bc73598a" },
                    { "XhAuvS9J4ex4hNyuYa1U", "3qGrKAnyJ2rmHlevXb8c", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(772), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All", "71fad8f1-e32c-4227-9cb8-19103ef41aed" },
                    { "xjIQygXEvMhLQkql9xRx", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "159 SW", "8ea1a34d-6a58-47fc-a773-fcc1db8b0985" },
                    { "XKKHUH0279Y5D8XFACe1", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1853), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "All 6-series", "5e02b885-50e7-4123-80e1-9d9aa81cbc13" },
                    { "xMnFdvUDhopN5z14lQcf", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2014), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Alpina D4", "bf6a36f7-e245-4ed4-9bfe-d6fc26c386b4" },
                    { "XN9zq1BFSI1vqDB2eRqU", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(378), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Slx", "150e484a-0325-4f75-bbe7-f4dbfe8922f0" },
                    { "xTIX1sxSbtnGvrmySvdG", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(524), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "166", "559f0f4d-9d41-4431-a8ca-23ec1d812b6e" },
                    { "xTkI2gDGFl1aA1ENXsuq", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1002), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A7", "be0b9a53-a67a-41ea-811a-d7845089bd12" },
                    { "xwC5lGbm8U33vWFXFMX8", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1705), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "428", "d188090a-1081-436e-86ae-24ea45b1ef7f" },
                    { "yjalz5m0pIpKz41RutE5", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(710), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C1", "7f69c7e2-452b-4873-a70c-863721ff0490" },
                    { "YSjIgnEQbustjnqRoh3b", "3yTpJND7nxjtqoDcuc5M", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(778), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Rocsta", "7867ac1e-e055-4bec-8594-796fe5420891" },
                    { "YTlhu1oYNkfsuJLfo1Gu", "470SJrcKER8YaPHSS0br", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(796), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Db7", "0412405a-b4a8-45ee-b0ba-aae0740a9bed" },
                    { "yu4PFVap2DNsoxEUR7eo", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1882), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "640", "0fb2b596-786d-42d1-8296-cd6622d8228e" },
                    { "YUAAoQeYo3RCyAzXGbYg", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(553), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "Crosswagon", "5ce63893-ca18-4bba-bb14-e1173c60544f" },
                    { "YvC7IvXTQPHawmrGQAH4", "2FEzeyYHYe3zlhjMeaEF", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "ILX", "6d308ec5-532d-44a4-9dca-d0b45fcc4250" },
                    { "YYbvpxmHrc7dztxQk1xx", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(1167), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "RS6 Avant", "8a670e29-ea6e-4d98-a9a2-92e6af890abe" },
                    { "z1IRf9dFn5Dl3JX0efqd", "2VS5yLgAuj7VmYeRVxTD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(454), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "146", "9a692962-927f-4522-baf4-cf531b7c3e5a" },
                    { "z1w8vxWxM44aBuCklX2I", "48xSUCHrRIfABkLmGHxD", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "A3 Sportback", "e5326178-05ac-4ac7-844a-8f119e492c02" },
                    { "z5rtukgN6Bxee1dwwQmI", "2xSRLgR4QgzYhDLjfgAM", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "C2", "c8f8f2b1-7e7b-4344-a0a6-a60c22d617e3" },
                    { "z7a2yDtmusb0MxBbWFCb", "5kDhCqXf6JTAIvz61oEz", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(2119), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "M3", "5e07a3bb-96e0-47de-9b06-3a527e95c9e1" },
                    { "zfT8y7XlysCPAszz4RTh", "2SBENlnqR76XRNAjbAs3", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 25, 20, 319, DateTimeKind.Unspecified).AddTicks(412), new TimeSpan(0, 0, 0, 0, 0)), null, null, false, "505", "a9837b95-f2e4-437b-a301-02fff1ba667e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_BrandId",
                schema: "Cars",
                table: "CarOffers",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_CoupeId",
                schema: "Cars",
                table: "CarOffers",
                column: "CoupeId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_CurrencyId",
                schema: "Cars",
                table: "CarOffers",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_EngineId",
                schema: "Cars",
                table: "CarOffers",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_EuroStandardId",
                schema: "Cars",
                table: "CarOffers",
                column: "EuroStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_LocationId",
                schema: "Cars",
                table: "CarOffers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_MaterialId",
                schema: "Cars",
                table: "CarOffers",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_ModelId",
                schema: "Cars",
                table: "CarOffers",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_RegionId",
                schema: "Cars",
                table: "CarOffers",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_CarOffers_TransmissionId",
                schema: "Cars",
                table: "CarOffers",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RegionId",
                schema: "Troshka",
                table: "Locations",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_CarBrandId",
                schema: "Cars",
                table: "Models",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferImages_OfferId",
                schema: "Troshka",
                table: "OfferImages",
                column: "OfferId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "OfferImages",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "CarOffers",
                schema: "Cars");

            migrationBuilder.DropTable(
                name: "Coupe",
                schema: "Cars");

            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "Engines",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "EuroStandards",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "Models",
                schema: "Cars");

            migrationBuilder.DropTable(
                name: "Transmissions",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "Regions",
                schema: "Troshka");

            migrationBuilder.DropTable(
                name: "Brands",
                schema: "Cars");
        }
    }
}
