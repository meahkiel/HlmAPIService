using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PMV");

            migrationBuilder.CreateTable(
                name: "LVStations",
                schema: "PMV",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FuelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FuelStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FueledTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentFuelQuantity = table.Column<float>(type: "real", nullable: false),
                    PreviousFuelQuantity = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LVStations", x => x.Id);
                    table.UniqueConstraint("AK_LVStations_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ProjectLocations",
                schema: "PMV",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SurCharge = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectLocations", x => x.Id);
                    table.UniqueConstraint("AK_ProjectLocations_DepartmentName", x => x.DepartmentName);
                });

            migrationBuilder.CreateTable(
                name: "FuelLogSheets",
                schema: "PMV",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperatorDriver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reading = table.Column<float>(type: "real", nullable: false),
                    PreviousReading = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    FueledById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelLogSheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelLogSheets_LVStations_FueledById",
                        column: x => x.FueledById,
                        principalSchema: "PMV",
                        principalTable: "LVStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FuelLogSheets_ProjectLocations_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "PMV",
                        principalTable: "ProjectLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuelResource",
                schema: "PMV",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogSheetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelResource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelResource_FuelLogSheets_LogSheetId",
                        column: x => x.LogSheetId,
                        principalSchema: "PMV",
                        principalTable: "FuelLogSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "LVStations",
                columns: new[] { "Id", "Active", "Code", "CreateBy", "CreatedAt", "CurrentFuelQuantity", "FuelDate", "FuelStation", "FueledTo", "Operator", "PreviousFuelQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0d7ffbc2-501b-417f-8d1f-f795172f676c"), true, "QAPMSDStation", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5791), "QAPMSDStation", "", "", 0f, null, null },
                    { new Guid("269f082a-bfc3-4959-94e4-68b26d1034fa"), true, "D192Station", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5790), "D192Station", "", "", 0f, null, null },
                    { new Guid("2b21914d-b966-43ca-81c3-e7e33c75fd3f"), true, "LV375", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5766), "LV375", "", "", 0f, null, null },
                    { new Guid("376bb4f0-b0cc-4a8e-9040-a050608e0142"), true, "LV253", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5779), "LV253", "", "", 0f, null, null },
                    { new Guid("37880b04-a8bc-4e8e-a164-292168d45e38"), true, "LLV463", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5782), "LLV463", "", "", 0f, null, null },
                    { new Guid("47d3df4b-9540-4230-a2a0-3d26d13731fe"), true, "LLV478", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5786), "LLV478", "", "", 0f, null, null },
                    { new Guid("6fc63965-bf69-471f-935c-77cf3b12fde0"), true, "LV310", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5787), "LV310", "", "", 0f, null, null },
                    { new Guid("8dbffaba-6502-41a9-9f41-ddb8cb0cb5b3"), true, "LV215", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5781), "LV215", "", "", 0f, null, null },
                    { new Guid("a18b0aef-071c-4254-b849-924c116e9347"), true, "LV512", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5788), "LV512", "", "", 0f, null, null },
                    { new Guid("a3cba807-41a3-49c9-adb7-58a2bc1168fc"), true, "D182Station", null, null, 0f, new DateTime(2022, 11, 15, 15, 11, 57, 222, DateTimeKind.Local).AddTicks(5789), "D182Station", "", "", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreateBy", "CreatedAt", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("03345c39-f665-4c88-8d98-18d89606d0eb"), true, null, null, "D172", 0f, null, null },
                    { new Guid("098a5f22-631d-4687-b4f2-eb6ea4c142c9"), true, null, null, "BRU", 0f, null, null },
                    { new Guid("09f86c7c-fbdb-4957-b70b-276f644a5292"), true, null, null, "I201", 0f, null, null },
                    { new Guid("0a5edaaa-92ff-4d76-b996-7a08b325c167"), true, null, null, "FULLBORE D182", 0f, null, null },
                    { new Guid("0f8c018c-dc1a-4327-a5a2-a67cea40ed77"), true, null, null, "ASPHALT CREW", 0f, null, null },
                    { new Guid("180950a0-a9e7-477c-9ac9-040e279cc6fc"), true, null, null, "GAP Plant", 0f, null, null },
                    { new Guid("1b4f76b1-57d0-47df-a78b-5b7387901235"), true, null, null, "I227_Fullbore", 0f, null, null },
                    { new Guid("1cafa43c-69ba-4b96-8ff9-2cbffa9918fc"), true, null, null, "TOPROK MAZRUA", 0f, null, null },
                    { new Guid("211488bc-323a-452a-919e-12350488db4f"), true, null, null, "QONCRETE MAZRUA", 0f, null, null },
                    { new Guid("2391deda-40aa-4396-8daf-fb3d869789fe"), true, null, null, "TOPROK OTHERS", 0f, null, null },
                    { new Guid("28bccc8c-608b-4298-b51d-39ae0f445b4b"), true, null, null, "TOPROK WUKAIR", 0f, null, null },
                    { new Guid("3335bf9d-7a44-4045-ba22-50d95e9ce092"), true, null, null, "LUSAIL", 0f, null, null },
                    { new Guid("3812c188-a968-4329-83da-2fc54ac0a614"), true, null, null, "I203", 0f, null, null },
                    { new Guid("3fb382cd-cc33-4aae-9ccd-c5d89ceb1cd0"), true, null, null, "AL THAKIRA", 0f, null, null },
                    { new Guid("3fb9afcc-68b1-4e07-9ace-5b8a860cdb43"), true, null, null, "FULLBORE OTHERS", 0f, null, null },
                    { new Guid("49f80524-cff2-454f-9b89-773bda8a5fd1"), true, null, null, "D191", 0f, null, null },
                    { new Guid("4a0882f7-7001-4209-a5ab-3b4b22e454b0"), true, null, null, "D211", 0f, null, null },
                    { new Guid("50310599-e2de-4b7c-a375-9081fd3213a6"), true, null, null, "FULLBORE D192", 0f, null, null },
                    { new Guid("516be93d-09bc-4b9e-a9c3-7880904f0780"), true, null, null, "PMV", 0f, null, null },
                    { new Guid("6d92c2fd-9c98-4c39-b4d3-9a4d5f08a530"), true, null, null, "TOPROK I211", 0f, null, null },
                    { new Guid("6de2be83-c07b-4501-87a8-26e399219f2f"), true, null, null, "Precast D192", 0f, null, null },
                    { new Guid("70250b54-4783-4cee-adbb-44d3a3488fd4"), true, null, null, "JERRY CAN/ PROJECT/DEPT.", 0f, null, null },
                    { new Guid("72b00707-3d95-44d0-bd2f-7dff2f293907"), true, null, null, "I211", 0f, null, null },
                    { new Guid("812c983f-9485-4211-ae50-64faf518ec18"), true, null, null, "UEG D191", 0f, null, null },
                    { new Guid("832b9b9b-12db-4180-afe1-35742e08d727"), true, null, null, "D192", 0f, null, null },
                    { new Guid("8b31326f-b2c6-4dd7-b075-227ffed24910"), true, null, null, "D171", 0f, null, null },
                    { new Guid("9a4ae777-0866-4aaa-a4d3-08500bda678c"), true, null, null, "I215", 0f, null, null },
                    { new Guid("9aebfcc7-b509-4411-bacf-7b00705db93e"), true, null, null, "TOPROK SHAHANIYA", 0f, null, null },
                    { new Guid("9ff47b3f-e3bd-4038-a643-024f48bdefc5"), true, null, null, "QAP PLANT", 0f, null, null },
                    { new Guid("a5e4d1f0-2829-43a5-98af-b0edf835953d"), true, null, null, "QONCRETE WUKAIR", 0f, null, null },
                    { new Guid("adf06c77-9461-48df-912d-bc39daf4dd70"), true, null, null, "I222", 0f, null, null },
                    { new Guid("ae844fe5-64e4-43d6-82b2-816c1b64466c"), true, null, null, "UEG D192", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreateBy", "CreatedAt", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("b4133cac-c970-489b-8372-27a667482aaa"), true, null, null, "POLARIS D172", 0f, null, null },
                    { new Guid("bdda40ae-ac10-4348-a667-7ffc53876d42"), true, null, null, "Helm Holding W.L.L", 0f, null, null },
                    { new Guid("c1805cb1-005f-4b92-aa96-5f2de2ac1718"), true, null, null, "LOGISTICS", 0f, null, null },
                    { new Guid("d5cd9e4c-e3d2-42ad-88d1-d5021e62371e"), true, null, null, "D183", 0f, null, null },
                    { new Guid("d8f05b98-3797-42c5-9ba8-b03065189a4d"), true, null, null, "I224", 0f, null, null },
                    { new Guid("db3840a8-2ebf-49be-a3e3-db9346ed696c"), true, null, null, "D211-Wakra", 0f, null, null },
                    { new Guid("e08c50a3-0cfe-4ca6-be42-3f9ef59bcdb8"), true, null, null, "TRANSPORT", 0f, null, null },
                    { new Guid("e6e95a5d-0fd5-4d1d-a4d7-772000461535"), true, null, null, "I212", 0f, null, null },
                    { new Guid("e7e72039-49d4-49e3-9172-5825d03a5d90"), true, null, null, "I214", 0f, null, null },
                    { new Guid("f2c55e2c-2e29-4c2e-a5a2-e36fd6c459f3"), true, null, null, "D182", 0f, null, null },
                    { new Guid("f8a82a18-25cc-4bee-ad1a-d52d3d4da76f"), true, null, null, "UEG D182", 0f, null, null },
                    { new Guid("f98aa388-d480-480b-b280-14465f3bcab8"), true, null, null, "I216", 0f, null, null },
                    { new Guid("fc58813e-da84-4b28-9300-8af928d27e5d"), true, null, null, "FULLBORE D191", 0f, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FuelLogSheets_FueledById",
                schema: "PMV",
                table: "FuelLogSheets",
                column: "FueledById");

            migrationBuilder.CreateIndex(
                name: "IX_FuelLogSheets_LocationId",
                schema: "PMV",
                table: "FuelLogSheets",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelResource_LogSheetId",
                schema: "PMV",
                table: "FuelResource",
                column: "LogSheetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelResource",
                schema: "PMV");

            migrationBuilder.DropTable(
                name: "FuelLogSheets",
                schema: "PMV");

            migrationBuilder.DropTable(
                name: "LVStations",
                schema: "PMV");

            migrationBuilder.DropTable(
                name: "ProjectLocations",
                schema: "PMV");
        }
    }
}
