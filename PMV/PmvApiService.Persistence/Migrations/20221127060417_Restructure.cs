using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    public partial class Restructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("011c5a7b-1ac9-4eca-bbfb-078d3d6c3dc0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("20c58f02-d7cb-4a13-8b16-fd647f2725d2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("34a8dffe-9c48-4557-b5ed-dc24d43b871f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("3647ac4c-d767-44af-84a3-4ffe015dfdd0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("83bed38e-1116-4631-8b47-6e5cc4bc70fd"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("84656cb8-3326-4efa-8333-97e4e3e36709"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("994c31f0-2b93-4469-9e38-3fb092582114"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("ae7b8f50-7ee8-4801-8bc3-1bbd41b831cf"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("dbd21c36-5573-4ff9-939b-7aed4c369a3b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("e2f7aad0-be27-4ceb-be2e-c910db263730"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("078ed4b0-cf87-442d-ac79-a682612a53e0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0b74ad77-e23d-4ec4-a2c4-ca53f040d92a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("11dc8bc8-8920-470d-9400-fdcb933dc7e5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1e64f038-9e66-4609-9d11-b4f4e8605349"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("22422a6f-9670-4cb9-b280-42b9797028c2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2e1348b8-5115-4b24-a126-e25f1e5df283"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("31dd6507-3780-41f7-b7aa-da07ca59cda1"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("35cb38a1-7bdb-4231-a2a0-1cdb1f67459c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("37b140e9-af59-4a87-84f4-76578b1ed45c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3c94ede4-a799-48f6-9fdb-52f9f9670f6e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4132d0d8-0e7d-4c21-973c-c6827c8984f4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4ab9b492-b0ea-49a5-a7ed-887b1811bf24"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4f5290b3-b462-4371-8d74-c901897b4dd7"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4fa55934-52b3-4c94-b9c0-a4749ec49eb6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("55d54d56-c7f3-4c47-b127-e537f5fa9c5f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6b1c6fe6-973a-4aed-be18-71906b347e27"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6faee263-f02b-474d-9128-023a17afffdc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("70c3b251-9eda-4579-8e13-6236a02d4b24"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("727067c1-9c68-4886-aea2-ada4ccad8f20"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("738faa27-dcda-4a0b-972d-c6d014d9f33f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("74fc020e-0b0f-432b-8aaa-f56e3c9b4e17"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7d1e4235-2a0c-414c-97cc-3b87e5ce16e0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7d8ff28f-8e72-41a0-bfd4-62d9a0cfd9ae"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("81338c9d-d25b-4367-b65b-0e430424f45e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8886c9a8-bfa5-46e4-b3ac-f55cee4bf2c1"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("88d81946-dbe2-4eee-bd84-9836e27d92ad"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("88e3aaa3-ceb9-4e04-8606-0eb0d1e74e5a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8cc4c23a-4bc5-492f-9346-82a1463f2d6f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8f27bcab-0e37-48b2-808b-60cc2c5cad65"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9cf0b13b-184b-4c9e-ac06-43dd30dfbb0b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9df00ca3-3f44-4bc5-99db-47f86ad5467b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("aad766da-093c-4480-b96a-7322dcc633b2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c238170f-da08-4b5a-9f98-2392037039c1"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c510ce54-58bc-4cf4-b552-3f1424128678"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cad62b72-8adc-4c3e-99a3-a8e0507e7170"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cef6333c-3c57-4307-ab40-1ffc3c2e7206"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cfe579f2-5b45-4ee0-8387-3f44d78dd8eb"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d5dfe2ce-ece7-411f-b96e-e02e51605664"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d755ec95-e734-4f00-9fa3-373e3ad43a0e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("eb1ace3b-c529-4d8e-a6f4-cd136d2d3d1d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f56b6cad-ef2d-4832-a5b9-39242c75fba9"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f7f64ecb-16a0-4954-ae69-6507529257bd"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f9f500db-e0da-440d-837a-d64b4f78850d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("fd3e5a97-7037-44f5-bbbf-286e1cbeed3c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("fea3a730-6490-4f7a-8898-db9ed55de83b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e82795f-4a48-473f-a740-1dd3b7049736"));

            migrationBuilder.CreateTable(
                name: "LogSheets",
                schema: "PMV",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReferenceNo = table.Column<int>(type: "int", nullable: false),
                    FueledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartShiftTankerKm = table.Column<int>(type: "int", nullable: false),
                    EndShiftTankerKm = table.Column<int>(type: "int", nullable: false),
                    StartShiftMeterReading = table.Column<int>(type: "int", nullable: false),
                    EndShiftMeterReading = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post_IsPosted = table.Column<bool>(type: "bit", nullable: false),
                    Post_PostedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogSheets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogSheetDetails",
                schema: "PMV",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperatorDriver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reading = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousReading = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    LogSheetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogSheetDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogSheetDetails_LogSheets_LogSheetId",
                        column: x => x.LogSheetId,
                        principalSchema: "PMV",
                        principalTable: "LogSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "LVStations",
                columns: new[] { "Id", "Active", "Code", "CreatedAt", "CreatedBy", "CurrentFuelQuantity", "FuelDate", "FuelStation", "FueledTo", "Operator", "PreviousFuelQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("224b66cb-4ae6-417a-b813-6cf9238494ae"), true, "LV310", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3677), "LV310", "", "", 0f, null, null },
                    { new Guid("44d153cd-4044-4e93-ac2d-627c43b2c6ed"), true, "LV253", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3670), "LV253", "", "", 0f, null, null },
                    { new Guid("6bf283a7-3ea8-494a-bc2f-3775f80f27b4"), true, "LLV478", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3676), "LLV478", "", "", 0f, null, null },
                    { new Guid("7f5847e9-eba7-48f5-98da-4d486d927604"), true, "QAPMSDStation", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3682), "QAPMSDStation", "", "", 0f, null, null },
                    { new Guid("8884230d-d1e1-4222-acf1-7a388c927b34"), true, "LV512", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3678), "LV512", "", "", 0f, null, null },
                    { new Guid("c45cbb10-3f1d-4590-a5eb-f885bb159ebc"), true, "D182Station", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3679), "D182Station", "", "", 0f, null, null },
                    { new Guid("cc6ba07a-9016-459f-91b2-30a6fbb561a6"), true, "LLV463", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3675), "LLV463", "", "", 0f, null, null },
                    { new Guid("e69fb7f1-bd87-48e3-86fd-005fd74909a5"), true, "LV215", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3671), "LV215", "", "", 0f, null, null },
                    { new Guid("f6751be6-c443-457c-8e58-e4c261f42367"), true, "LV375", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3658), "LV375", "", "", 0f, null, null },
                    { new Guid("ff97203b-6cbe-42ca-9629-da1b580301cc"), true, "D192Station", null, null, 0f, new DateTime(2022, 11, 27, 9, 4, 16, 994, DateTimeKind.Local).AddTicks(3681), "D192Station", "", "", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00d140e6-b0ce-434b-af3a-d4a3c664529a"), true, null, null, "I222", 0f, null, null },
                    { new Guid("05c165ed-0483-4e2c-93e4-2b8e1f523337"), true, null, null, "I216", 0f, null, null },
                    { new Guid("05fecd16-83c8-4abd-92e7-2f9b7323edc4"), true, null, null, "FULLBORE OTHERS", 0f, null, null },
                    { new Guid("0a24568c-2bea-4922-8094-acf4cbf79ba2"), true, null, null, "D192", 0f, null, null },
                    { new Guid("0d5a80d6-bdf9-4f9a-bbf1-8353fffbdc6e"), true, null, null, "TOPROK MAZRUA", 0f, null, null },
                    { new Guid("10b6c7fd-9e8d-406d-b24a-cbc7752eec6f"), true, null, null, "I215", 0f, null, null },
                    { new Guid("1ddcc325-8448-41d5-9b23-4eb6f90d4da0"), true, null, null, "I203", 0f, null, null },
                    { new Guid("218b2a76-2945-424e-bfef-1e4834042afd"), true, null, null, "TOPROK I211", 0f, null, null },
                    { new Guid("30338a66-e3aa-46d0-ad5f-15325dec7584"), true, null, null, "ASPHALT CREW", 0f, null, null },
                    { new Guid("307b9d15-5c4b-480f-8138-89ef21516ed6"), true, null, null, "QAP PLANT", 0f, null, null },
                    { new Guid("32bf2a93-d94d-48e5-a3bb-4d508854d39d"), true, null, null, "TOPROK WUKAIR", 0f, null, null },
                    { new Guid("383d7370-25d7-4ce3-88fa-88e2b93ce6d0"), true, null, null, "POLARIS D172", 0f, null, null },
                    { new Guid("3b002db7-0c39-45b6-aa38-d12f6b5ad45a"), true, null, null, "TOPROK OTHERS", 0f, null, null },
                    { new Guid("4c492111-aab1-4425-9bfb-e2a0e8eaa80e"), true, null, null, "Precast D192", 0f, null, null },
                    { new Guid("4e171fcb-7d2d-4979-ad41-cd7e7a4150f0"), true, null, null, "D182", 0f, null, null },
                    { new Guid("5824ff8d-447a-4ab1-838a-463b850e5d2f"), true, null, null, "PMV", 0f, null, null },
                    { new Guid("5941c428-5bbb-411b-9b54-5e3e8cd5892b"), true, null, null, "LOGISTICS", 0f, null, null },
                    { new Guid("5e061ebe-b31c-4988-b1ef-2df5cc46476f"), true, null, null, "AL THAKIRA", 0f, null, null },
                    { new Guid("5ff83438-9f71-4c31-a406-380c5de6f62d"), true, null, null, "QONCRETE MAZRUA", 0f, null, null },
                    { new Guid("60e191fe-ace3-4b22-a006-aa173ca29244"), true, null, null, "I224", 0f, null, null },
                    { new Guid("62fb2513-8e3a-4ac7-af5c-4b25fa67410e"), true, null, null, "D183", 0f, null, null },
                    { new Guid("65ce1641-4202-4d63-b9de-abd58d1733cc"), true, null, null, "D211-Wakra", 0f, null, null },
                    { new Guid("66ac6fa5-f72e-4a5e-9182-791465c95071"), true, null, null, "UEG D191", 0f, null, null },
                    { new Guid("6c6c1731-f4a0-48a9-890c-31ce544fe2b0"), true, null, null, "I201", 0f, null, null },
                    { new Guid("77498c5c-8f01-4a3e-9c27-ab8dbd7dd843"), true, null, null, "BRU", 0f, null, null },
                    { new Guid("8318294d-752a-4501-98d4-179461583f45"), true, null, null, "UEG D192", 0f, null, null },
                    { new Guid("85da4c58-0ece-4572-8ffe-27d3838e198c"), true, null, null, "TRANSPORT", 0f, null, null },
                    { new Guid("8f84e46d-fd48-48b0-ad3c-d553aeecf5ee"), true, null, null, "I227_Fullbore", 0f, null, null },
                    { new Guid("9beee72c-07f8-448d-9560-6ec86abfc1cf"), true, null, null, "I212", 0f, null, null },
                    { new Guid("a3fbc86a-b75a-45d7-986a-980b78b2b533"), true, null, null, "JERRY CAN/ PROJECT/DEPT.", 0f, null, null },
                    { new Guid("af60eb56-b126-4213-8b74-f616ce6c54fa"), true, null, null, "I214", 0f, null, null },
                    { new Guid("b3708d92-a70a-4a9a-81dd-7a7735de5b4e"), true, null, null, "FULLBORE D192", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("b78a3020-1ee3-452f-9b18-af5e29ce616b"), true, null, null, "LUSAIL", 0f, null, null },
                    { new Guid("c46aa2d9-d85b-474c-bb73-52ff7bbb3a98"), true, null, null, "GAP Plant", 0f, null, null },
                    { new Guid("cc8740d3-ab5e-4cd9-affb-cbb1ab44cf9c"), true, null, null, "D172", 0f, null, null },
                    { new Guid("cd75b337-13a1-4e25-b751-9c5a7354ebbb"), true, null, null, "UEG D182", 0f, null, null },
                    { new Guid("d9827874-b42e-4927-a264-5376fb143ba8"), true, null, null, "FULLBORE D191", 0f, null, null },
                    { new Guid("da918ec0-a859-47f9-bf63-ab3d82c991eb"), true, null, null, "D171", 0f, null, null },
                    { new Guid("da93e69a-3903-46e4-9c59-c16f1fa51f34"), true, null, null, "TOPROK SHAHANIYA", 0f, null, null },
                    { new Guid("e3d689df-ab61-45e5-916d-dfe9a223f205"), true, null, null, "D211", 0f, null, null },
                    { new Guid("e931f545-21e5-455c-a1ee-3a2520a24375"), true, null, null, "QONCRETE WUKAIR", 0f, null, null },
                    { new Guid("ebad9d43-c351-4c66-9d44-e7428fa03f01"), true, null, null, "FULLBORE D182", 0f, null, null },
                    { new Guid("ee1e03c7-010f-48ef-99dc-6f9b214b456f"), true, null, null, "I211", 0f, null, null },
                    { new Guid("eff87ff5-c94b-4106-969b-c07174e90bb0"), true, null, null, "D191", 0f, null, null },
                    { new Guid("f3a2fa23-13be-446c-9cdd-d258314ed32c"), true, null, null, "Helm Holding W.L.L", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "Users",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Department", "EmailAddress", "EmployeeCode", "FullName", "Section", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("1e169f94-eca6-4a90-a257-69b768ff27a7"), true, null, null, "PMV", "amercado@helm.qa", "H22095411", "Arnold Mercado", "LV253", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_LogSheetDetails_LogSheetId",
                schema: "PMV",
                table: "LogSheetDetails",
                column: "LogSheetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogSheetDetails",
                schema: "PMV");

            migrationBuilder.DropTable(
                name: "LogSheets",
                schema: "PMV");

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("224b66cb-4ae6-417a-b813-6cf9238494ae"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("44d153cd-4044-4e93-ac2d-627c43b2c6ed"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("6bf283a7-3ea8-494a-bc2f-3775f80f27b4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("7f5847e9-eba7-48f5-98da-4d486d927604"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("8884230d-d1e1-4222-acf1-7a388c927b34"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("c45cbb10-3f1d-4590-a5eb-f885bb159ebc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("cc6ba07a-9016-459f-91b2-30a6fbb561a6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("e69fb7f1-bd87-48e3-86fd-005fd74909a5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("f6751be6-c443-457c-8e58-e4c261f42367"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("ff97203b-6cbe-42ca-9629-da1b580301cc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("00d140e6-b0ce-434b-af3a-d4a3c664529a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("05c165ed-0483-4e2c-93e4-2b8e1f523337"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("05fecd16-83c8-4abd-92e7-2f9b7323edc4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0a24568c-2bea-4922-8094-acf4cbf79ba2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0d5a80d6-bdf9-4f9a-bbf1-8353fffbdc6e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("10b6c7fd-9e8d-406d-b24a-cbc7752eec6f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1ddcc325-8448-41d5-9b23-4eb6f90d4da0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("218b2a76-2945-424e-bfef-1e4834042afd"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("30338a66-e3aa-46d0-ad5f-15325dec7584"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("307b9d15-5c4b-480f-8138-89ef21516ed6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("32bf2a93-d94d-48e5-a3bb-4d508854d39d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("383d7370-25d7-4ce3-88fa-88e2b93ce6d0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3b002db7-0c39-45b6-aa38-d12f6b5ad45a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4c492111-aab1-4425-9bfb-e2a0e8eaa80e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4e171fcb-7d2d-4979-ad41-cd7e7a4150f0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5824ff8d-447a-4ab1-838a-463b850e5d2f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5941c428-5bbb-411b-9b54-5e3e8cd5892b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5e061ebe-b31c-4988-b1ef-2df5cc46476f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5ff83438-9f71-4c31-a406-380c5de6f62d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("60e191fe-ace3-4b22-a006-aa173ca29244"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("62fb2513-8e3a-4ac7-af5c-4b25fa67410e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("65ce1641-4202-4d63-b9de-abd58d1733cc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("66ac6fa5-f72e-4a5e-9182-791465c95071"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6c6c1731-f4a0-48a9-890c-31ce544fe2b0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("77498c5c-8f01-4a3e-9c27-ab8dbd7dd843"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8318294d-752a-4501-98d4-179461583f45"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("85da4c58-0ece-4572-8ffe-27d3838e198c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8f84e46d-fd48-48b0-ad3c-d553aeecf5ee"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9beee72c-07f8-448d-9560-6ec86abfc1cf"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a3fbc86a-b75a-45d7-986a-980b78b2b533"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("af60eb56-b126-4213-8b74-f616ce6c54fa"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b3708d92-a70a-4a9a-81dd-7a7735de5b4e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b78a3020-1ee3-452f-9b18-af5e29ce616b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c46aa2d9-d85b-474c-bb73-52ff7bbb3a98"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cc8740d3-ab5e-4cd9-affb-cbb1ab44cf9c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cd75b337-13a1-4e25-b751-9c5a7354ebbb"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d9827874-b42e-4927-a264-5376fb143ba8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("da918ec0-a859-47f9-bf63-ab3d82c991eb"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("da93e69a-3903-46e4-9c59-c16f1fa51f34"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e3d689df-ab61-45e5-916d-dfe9a223f205"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e931f545-21e5-455c-a1ee-3a2520a24375"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ebad9d43-c351-4c66-9d44-e7428fa03f01"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ee1e03c7-010f-48ef-99dc-6f9b214b456f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("eff87ff5-c94b-4106-969b-c07174e90bb0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f3a2fa23-13be-446c-9cdd-d258314ed32c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e169f94-eca6-4a90-a257-69b768ff27a7"));

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "LVStations",
                columns: new[] { "Id", "Active", "Code", "CreatedAt", "CreatedBy", "CurrentFuelQuantity", "FuelDate", "FuelStation", "FueledTo", "Operator", "PreviousFuelQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("011c5a7b-1ac9-4eca-bbfb-078d3d6c3dc0"), true, "LLV463", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6417), "LLV463", "", "", 0f, null, null },
                    { new Guid("20c58f02-d7cb-4a13-8b16-fd647f2725d2"), true, "LV512", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6420), "LV512", "", "", 0f, null, null },
                    { new Guid("34a8dffe-9c48-4557-b5ed-dc24d43b871f"), true, "LLV478", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6418), "LLV478", "", "", 0f, null, null },
                    { new Guid("3647ac4c-d767-44af-84a3-4ffe015dfdd0"), true, "LV375", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6402), "LV375", "", "", 0f, null, null },
                    { new Guid("83bed38e-1116-4631-8b47-6e5cc4bc70fd"), true, "D182Station", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6421), "D182Station", "", "", 0f, null, null },
                    { new Guid("84656cb8-3326-4efa-8333-97e4e3e36709"), true, "LV310", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6419), "LV310", "", "", 0f, null, null },
                    { new Guid("994c31f0-2b93-4469-9e38-3fb092582114"), true, "QAPMSDStation", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6424), "QAPMSDStation", "", "", 0f, null, null },
                    { new Guid("ae7b8f50-7ee8-4801-8bc3-1bbd41b831cf"), true, "D192Station", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6423), "D192Station", "", "", 0f, null, null },
                    { new Guid("dbd21c36-5573-4ff9-939b-7aed4c369a3b"), true, "LV215", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6414), "LV215", "", "", 0f, null, null },
                    { new Guid("e2f7aad0-be27-4ceb-be2e-c910db263730"), true, "LV253", null, null, 0f, new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6413), "LV253", "", "", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("078ed4b0-cf87-442d-ac79-a682612a53e0"), true, null, null, "QONCRETE WUKAIR", 0f, null, null },
                    { new Guid("0b74ad77-e23d-4ec4-a2c4-ca53f040d92a"), true, null, null, "TOPROK WUKAIR", 0f, null, null },
                    { new Guid("11dc8bc8-8920-470d-9400-fdcb933dc7e5"), true, null, null, "LUSAIL", 0f, null, null },
                    { new Guid("1e64f038-9e66-4609-9d11-b4f4e8605349"), true, null, null, "D182", 0f, null, null },
                    { new Guid("22422a6f-9670-4cb9-b280-42b9797028c2"), true, null, null, "TOPROK SHAHANIYA", 0f, null, null },
                    { new Guid("2e1348b8-5115-4b24-a126-e25f1e5df283"), true, null, null, "UEG D182", 0f, null, null },
                    { new Guid("31dd6507-3780-41f7-b7aa-da07ca59cda1"), true, null, null, "LOGISTICS", 0f, null, null },
                    { new Guid("35cb38a1-7bdb-4231-a2a0-1cdb1f67459c"), true, null, null, "QAP PLANT", 0f, null, null },
                    { new Guid("37b140e9-af59-4a87-84f4-76578b1ed45c"), true, null, null, "I212", 0f, null, null },
                    { new Guid("3c94ede4-a799-48f6-9fdb-52f9f9670f6e"), true, null, null, "JERRY CAN/ PROJECT/DEPT.", 0f, null, null },
                    { new Guid("4132d0d8-0e7d-4c21-973c-c6827c8984f4"), true, null, null, "I211", 0f, null, null },
                    { new Guid("4ab9b492-b0ea-49a5-a7ed-887b1811bf24"), true, null, null, "D211-Wakra", 0f, null, null },
                    { new Guid("4f5290b3-b462-4371-8d74-c901897b4dd7"), true, null, null, "QONCRETE MAZRUA", 0f, null, null },
                    { new Guid("4fa55934-52b3-4c94-b9c0-a4749ec49eb6"), true, null, null, "FULLBORE D182", 0f, null, null },
                    { new Guid("55d54d56-c7f3-4c47-b127-e537f5fa9c5f"), true, null, null, "GAP Plant", 0f, null, null },
                    { new Guid("6b1c6fe6-973a-4aed-be18-71906b347e27"), true, null, null, "D191", 0f, null, null },
                    { new Guid("6faee263-f02b-474d-9128-023a17afffdc"), true, null, null, "POLARIS D172", 0f, null, null },
                    { new Guid("70c3b251-9eda-4579-8e13-6236a02d4b24"), true, null, null, "D211", 0f, null, null },
                    { new Guid("727067c1-9c68-4886-aea2-ada4ccad8f20"), true, null, null, "TOPROK OTHERS", 0f, null, null },
                    { new Guid("738faa27-dcda-4a0b-972d-c6d014d9f33f"), true, null, null, "AL THAKIRA", 0f, null, null },
                    { new Guid("74fc020e-0b0f-432b-8aaa-f56e3c9b4e17"), true, null, null, "D192", 0f, null, null },
                    { new Guid("7d1e4235-2a0c-414c-97cc-3b87e5ce16e0"), true, null, null, "D183", 0f, null, null },
                    { new Guid("7d8ff28f-8e72-41a0-bfd4-62d9a0cfd9ae"), true, null, null, "D171", 0f, null, null },
                    { new Guid("81338c9d-d25b-4367-b65b-0e430424f45e"), true, null, null, "I216", 0f, null, null },
                    { new Guid("8886c9a8-bfa5-46e4-b3ac-f55cee4bf2c1"), true, null, null, "I224", 0f, null, null },
                    { new Guid("88d81946-dbe2-4eee-bd84-9836e27d92ad"), true, null, null, "UEG D191", 0f, null, null },
                    { new Guid("88e3aaa3-ceb9-4e04-8606-0eb0d1e74e5a"), true, null, null, "I215", 0f, null, null },
                    { new Guid("8cc4c23a-4bc5-492f-9346-82a1463f2d6f"), true, null, null, "UEG D192", 0f, null, null },
                    { new Guid("8f27bcab-0e37-48b2-808b-60cc2c5cad65"), true, null, null, "TOPROK MAZRUA", 0f, null, null },
                    { new Guid("9cf0b13b-184b-4c9e-ac06-43dd30dfbb0b"), true, null, null, "I214", 0f, null, null },
                    { new Guid("9df00ca3-3f44-4bc5-99db-47f86ad5467b"), true, null, null, "Helm Holding W.L.L", 0f, null, null },
                    { new Guid("aad766da-093c-4480-b96a-7322dcc633b2"), true, null, null, "PMV", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("c238170f-da08-4b5a-9f98-2392037039c1"), true, null, null, "Precast D192", 0f, null, null },
                    { new Guid("c510ce54-58bc-4cf4-b552-3f1424128678"), true, null, null, "TOPROK I211", 0f, null, null },
                    { new Guid("cad62b72-8adc-4c3e-99a3-a8e0507e7170"), true, null, null, "FULLBORE D192", 0f, null, null },
                    { new Guid("cef6333c-3c57-4307-ab40-1ffc3c2e7206"), true, null, null, "I227_Fullbore", 0f, null, null },
                    { new Guid("cfe579f2-5b45-4ee0-8387-3f44d78dd8eb"), true, null, null, "I222", 0f, null, null },
                    { new Guid("d5dfe2ce-ece7-411f-b96e-e02e51605664"), true, null, null, "I203", 0f, null, null },
                    { new Guid("d755ec95-e734-4f00-9fa3-373e3ad43a0e"), true, null, null, "BRU", 0f, null, null },
                    { new Guid("eb1ace3b-c529-4d8e-a6f4-cd136d2d3d1d"), true, null, null, "I201", 0f, null, null },
                    { new Guid("f56b6cad-ef2d-4832-a5b9-39242c75fba9"), true, null, null, "D172", 0f, null, null },
                    { new Guid("f7f64ecb-16a0-4954-ae69-6507529257bd"), true, null, null, "FULLBORE D191", 0f, null, null },
                    { new Guid("f9f500db-e0da-440d-837a-d64b4f78850d"), true, null, null, "TRANSPORT", 0f, null, null },
                    { new Guid("fd3e5a97-7037-44f5-bbbf-286e1cbeed3c"), true, null, null, "ASPHALT CREW", 0f, null, null },
                    { new Guid("fea3a730-6490-4f7a-8898-db9ed55de83b"), true, null, null, "FULLBORE OTHERS", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "Users",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Department", "EmailAddress", "EmployeeCode", "FullName", "Section", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("1e82795f-4a48-473f-a740-1dd3b7049736"), true, null, null, "PMV", "amercado@helm.qa", "H22095411", "Arnold Mercado", "LV253", null, null });
        }
    }
}
