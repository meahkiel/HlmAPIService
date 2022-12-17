using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    public partial class ChangeFuelLogDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("0d7ffbc2-501b-417f-8d1f-f795172f676c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("269f082a-bfc3-4959-94e4-68b26d1034fa"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("2b21914d-b966-43ca-81c3-e7e33c75fd3f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("376bb4f0-b0cc-4a8e-9040-a050608e0142"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("37880b04-a8bc-4e8e-a164-292168d45e38"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("47d3df4b-9540-4230-a2a0-3d26d13731fe"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("6fc63965-bf69-471f-935c-77cf3b12fde0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("8dbffaba-6502-41a9-9f41-ddb8cb0cb5b3"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("a18b0aef-071c-4254-b849-924c116e9347"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("a3cba807-41a3-49c9-adb7-58a2bc1168fc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("03345c39-f665-4c88-8d98-18d89606d0eb"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("098a5f22-631d-4687-b4f2-eb6ea4c142c9"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("09f86c7c-fbdb-4957-b70b-276f644a5292"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0a5edaaa-92ff-4d76-b996-7a08b325c167"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0f8c018c-dc1a-4327-a5a2-a67cea40ed77"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("180950a0-a9e7-477c-9ac9-040e279cc6fc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1b4f76b1-57d0-47df-a78b-5b7387901235"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1cafa43c-69ba-4b96-8ff9-2cbffa9918fc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("211488bc-323a-452a-919e-12350488db4f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2391deda-40aa-4396-8daf-fb3d869789fe"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("28bccc8c-608b-4298-b51d-39ae0f445b4b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3335bf9d-7a44-4045-ba22-50d95e9ce092"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3812c188-a968-4329-83da-2fc54ac0a614"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3fb382cd-cc33-4aae-9ccd-c5d89ceb1cd0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3fb9afcc-68b1-4e07-9ace-5b8a860cdb43"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("49f80524-cff2-454f-9b89-773bda8a5fd1"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4a0882f7-7001-4209-a5ab-3b4b22e454b0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("50310599-e2de-4b7c-a375-9081fd3213a6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("516be93d-09bc-4b9e-a9c3-7880904f0780"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6d92c2fd-9c98-4c39-b4d3-9a4d5f08a530"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6de2be83-c07b-4501-87a8-26e399219f2f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("70250b54-4783-4cee-adbb-44d3a3488fd4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("72b00707-3d95-44d0-bd2f-7dff2f293907"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("812c983f-9485-4211-ae50-64faf518ec18"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("832b9b9b-12db-4180-afe1-35742e08d727"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8b31326f-b2c6-4dd7-b075-227ffed24910"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9a4ae777-0866-4aaa-a4d3-08500bda678c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9aebfcc7-b509-4411-bacf-7b00705db93e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9ff47b3f-e3bd-4038-a643-024f48bdefc5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a5e4d1f0-2829-43a5-98af-b0edf835953d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("adf06c77-9461-48df-912d-bc39daf4dd70"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ae844fe5-64e4-43d6-82b2-816c1b64466c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b4133cac-c970-489b-8372-27a667482aaa"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("bdda40ae-ac10-4348-a667-7ffc53876d42"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c1805cb1-005f-4b92-aa96-5f2de2ac1718"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d5cd9e4c-e3d2-42ad-88d1-d5021e62371e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d8f05b98-3797-42c5-9ba8-b03065189a4d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("db3840a8-2ebf-49be-a3e3-db9346ed696c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e08c50a3-0cfe-4ca6-be42-3f9ef59bcdb8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e6e95a5d-0fd5-4d1d-a4d7-772000461535"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e7e72039-49d4-49e3-9172-5825d03a5d90"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f2c55e2c-2e29-4c2e-a5a2-e36fd6c459f3"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f8a82a18-25cc-4bee-ad1a-d52d3d4da76f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f98aa388-d480-480b-b280-14465f3bcab8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("fc58813e-da84-4b28-9300-8af928d27e5d"));

            migrationBuilder.AlterColumn<int>(
                name: "Reading",
                schema: "PMV",
                table: "FuelLogSheets",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "LVStations",
                columns: new[] { "Id", "Active", "Code", "CreateBy", "CreatedAt", "CurrentFuelQuantity", "FuelDate", "FuelStation", "FueledTo", "Operator", "PreviousFuelQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1f6b36ea-19b6-4e96-a349-6e9dc94154ca"), true, "D192Station", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7847), "D192Station", "", "", 0f, null, null },
                    { new Guid("660497ab-c3f8-4564-9637-40a1727f7e29"), true, "LV253", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7835), "LV253", "", "", 0f, null, null },
                    { new Guid("707f0ab9-401f-42dd-9cdf-c00033231002"), true, "D182Station", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7846), "D182Station", "", "", 0f, null, null },
                    { new Guid("a3bc339f-51ac-409c-8002-9404df0ad67c"), true, "LV215", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7840), "LV215", "", "", 0f, null, null },
                    { new Guid("b3429266-ad89-44ba-b85a-cc5ba27950d4"), true, "LLV478", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7842), "LLV478", "", "", 0f, null, null },
                    { new Guid("d2666bfa-5d3b-4da2-ae15-0cba32f57b8b"), true, "LLV463", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7841), "LLV463", "", "", 0f, null, null },
                    { new Guid("d3fe25c2-5e15-4356-9256-6ff8bfe167a8"), true, "LV375", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7822), "LV375", "", "", 0f, null, null },
                    { new Guid("de61093e-b11c-4166-bb03-4d5253461b27"), true, "QAPMSDStation", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7848), "QAPMSDStation", "", "", 0f, null, null },
                    { new Guid("dfd04c30-48e2-4020-a7a7-a0229a0106c5"), true, "LV310", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7843), "LV310", "", "", 0f, null, null },
                    { new Guid("e43d8ee2-85e6-4237-aef4-fe07ca3c3183"), true, "LV512", null, null, 0f, new DateTime(2022, 11, 15, 16, 42, 51, 902, DateTimeKind.Local).AddTicks(7844), "LV512", "", "", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreateBy", "CreatedAt", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("06d93292-a578-44d9-98f6-3583fd910b96"), true, null, null, "BRU", 0f, null, null },
                    { new Guid("07307340-4f6c-48bd-9a19-925daad5f96a"), true, null, null, "AL THAKIRA", 0f, null, null },
                    { new Guid("0a9366f6-e21a-4f88-89e9-eb53e85f675a"), true, null, null, "I212", 0f, null, null },
                    { new Guid("0b9ae18c-7213-42f4-8297-e905684cb0bb"), true, null, null, "I224", 0f, null, null },
                    { new Guid("0eec1b29-2a92-4e5d-8ab8-b0112bb66994"), true, null, null, "LOGISTICS", 0f, null, null },
                    { new Guid("1e6f1874-9799-4586-aaf6-f8cceb1d3eb7"), true, null, null, "FULLBORE D191", 0f, null, null },
                    { new Guid("1f098e57-cede-4e3a-9525-aa4400bc46a6"), true, null, null, "D171", 0f, null, null },
                    { new Guid("1fcb46b6-4b40-40e2-a543-35774f797fd5"), true, null, null, "I201", 0f, null, null },
                    { new Guid("239fe14d-03e5-4708-a272-7c713ec244b2"), true, null, null, "POLARIS D172", 0f, null, null },
                    { new Guid("311a9f98-886c-47de-98f8-278091d1dfd2"), true, null, null, "D183", 0f, null, null },
                    { new Guid("31e525d1-a0ac-44dc-817e-3e1256cb2dbc"), true, null, null, "I222", 0f, null, null },
                    { new Guid("3ff5f1a7-3adc-47f9-9e20-29533988fd81"), true, null, null, "I211", 0f, null, null },
                    { new Guid("460594cd-1bbe-420d-8142-f0f6cf4f895a"), true, null, null, "D182", 0f, null, null },
                    { new Guid("4895e5a1-adb2-46c0-b502-94eba33f4db7"), true, null, null, "I215", 0f, null, null },
                    { new Guid("4e74ecc4-cb1b-42db-86a8-5f6cff4b5bc5"), true, null, null, "TOPROK MAZRUA", 0f, null, null },
                    { new Guid("51e18818-1b50-475b-abaa-502fafbb9007"), true, null, null, "D191", 0f, null, null },
                    { new Guid("579dac66-d27b-40d9-8fac-be08cb801a66"), true, null, null, "D192", 0f, null, null },
                    { new Guid("58985baa-a999-44ec-8db9-1b8759d966d7"), true, null, null, "QAP PLANT", 0f, null, null },
                    { new Guid("58d2e49e-ecb6-4dc6-81f9-61175d749c6c"), true, null, null, "PMV", 0f, null, null },
                    { new Guid("5e199233-678e-4ffa-bfd7-96c5876a9153"), true, null, null, "FULLBORE OTHERS", 0f, null, null },
                    { new Guid("5eee8a0f-0ac4-4425-a54a-af0f6390779d"), true, null, null, "TOPROK WUKAIR", 0f, null, null },
                    { new Guid("6c16f0f4-95e2-4da3-9c17-079e19da1f8d"), true, null, null, "TOPROK I211", 0f, null, null },
                    { new Guid("70b3abf0-acf4-4f35-b12a-6fdbea229f02"), true, null, null, "TOPROK OTHERS", 0f, null, null },
                    { new Guid("7d249c37-39ab-4e28-8851-589995d455ee"), true, null, null, "UEG D192", 0f, null, null },
                    { new Guid("7df6fa9d-f005-441a-8b20-677acb3a673b"), true, null, null, "D211-Wakra", 0f, null, null },
                    { new Guid("7e3430d7-334b-4684-bf12-0b2211ea4999"), true, null, null, "D211", 0f, null, null },
                    { new Guid("82ea8802-347b-40fc-8d25-54b3e9781c0f"), true, null, null, "D172", 0f, null, null },
                    { new Guid("936ab992-96ea-42cf-aaec-2cfac50457f8"), true, null, null, "UEG D191", 0f, null, null },
                    { new Guid("9404acde-45b0-4c4d-99da-1e2990e17078"), true, null, null, "I214", 0f, null, null },
                    { new Guid("96d9f563-6ba8-4e5b-a996-11a44498b3d5"), true, null, null, "JERRY CAN/ PROJECT/DEPT.", 0f, null, null },
                    { new Guid("9d7574f7-ec8c-487b-9bae-84bf8f98bb74"), true, null, null, "FULLBORE D192", 0f, null, null },
                    { new Guid("a2579c72-8e00-4ee4-9ac9-1b2e030569b0"), true, null, null, "FULLBORE D182", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreateBy", "CreatedAt", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("ad67577b-2411-4c72-93c5-253c8832f992"), true, null, null, "I203", 0f, null, null },
                    { new Guid("aeee55c7-bd49-4419-875d-63fe2c6b2e35"), true, null, null, "I216", 0f, null, null },
                    { new Guid("c3689ae5-186b-4f16-9d92-003259f11bd2"), true, null, null, "I227_Fullbore", 0f, null, null },
                    { new Guid("cc91d9e5-dc19-4371-9f95-43a6e02a725e"), true, null, null, "UEG D182", 0f, null, null },
                    { new Guid("ce0bf5e2-63d1-4d47-9a5c-0f289c9be72d"), true, null, null, "GAP Plant", 0f, null, null },
                    { new Guid("ce83f7cb-43ee-4fa2-972e-1adaa8700b4f"), true, null, null, "QONCRETE MAZRUA", 0f, null, null },
                    { new Guid("d5f10334-b1ab-44b3-af0f-ab4220123a46"), true, null, null, "QONCRETE WUKAIR", 0f, null, null },
                    { new Guid("d8cc53ad-7807-48a0-ad77-b776c8fbfe62"), true, null, null, "LUSAIL", 0f, null, null },
                    { new Guid("ddd7ee0b-b99b-44f0-969b-0d42532d2bce"), true, null, null, "TRANSPORT", 0f, null, null },
                    { new Guid("efbe1f1e-8f61-4db2-b12c-2bb28364b7ad"), true, null, null, "Precast D192", 0f, null, null },
                    { new Guid("f2b91509-9bbf-48a3-9c4f-62a0f199541f"), true, null, null, "TOPROK SHAHANIYA", 0f, null, null },
                    { new Guid("f5e1b520-76de-409c-af80-73fc0fcdc11e"), true, null, null, "Helm Holding W.L.L", 0f, null, null },
                    { new Guid("f71c0983-7621-4ddb-ab47-39eaeeee992f"), true, null, null, "ASPHALT CREW", 0f, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("1f6b36ea-19b6-4e96-a349-6e9dc94154ca"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("660497ab-c3f8-4564-9637-40a1727f7e29"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("707f0ab9-401f-42dd-9cdf-c00033231002"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("a3bc339f-51ac-409c-8002-9404df0ad67c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("b3429266-ad89-44ba-b85a-cc5ba27950d4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("d2666bfa-5d3b-4da2-ae15-0cba32f57b8b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("d3fe25c2-5e15-4356-9256-6ff8bfe167a8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("de61093e-b11c-4166-bb03-4d5253461b27"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("dfd04c30-48e2-4020-a7a7-a0229a0106c5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("e43d8ee2-85e6-4237-aef4-fe07ca3c3183"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("06d93292-a578-44d9-98f6-3583fd910b96"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("07307340-4f6c-48bd-9a19-925daad5f96a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0a9366f6-e21a-4f88-89e9-eb53e85f675a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0b9ae18c-7213-42f4-8297-e905684cb0bb"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0eec1b29-2a92-4e5d-8ab8-b0112bb66994"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1e6f1874-9799-4586-aaf6-f8cceb1d3eb7"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1f098e57-cede-4e3a-9525-aa4400bc46a6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1fcb46b6-4b40-40e2-a543-35774f797fd5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("239fe14d-03e5-4708-a272-7c713ec244b2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("311a9f98-886c-47de-98f8-278091d1dfd2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("31e525d1-a0ac-44dc-817e-3e1256cb2dbc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3ff5f1a7-3adc-47f9-9e20-29533988fd81"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("460594cd-1bbe-420d-8142-f0f6cf4f895a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4895e5a1-adb2-46c0-b502-94eba33f4db7"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4e74ecc4-cb1b-42db-86a8-5f6cff4b5bc5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("51e18818-1b50-475b-abaa-502fafbb9007"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("579dac66-d27b-40d9-8fac-be08cb801a66"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("58985baa-a999-44ec-8db9-1b8759d966d7"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("58d2e49e-ecb6-4dc6-81f9-61175d749c6c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5e199233-678e-4ffa-bfd7-96c5876a9153"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5eee8a0f-0ac4-4425-a54a-af0f6390779d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6c16f0f4-95e2-4da3-9c17-079e19da1f8d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("70b3abf0-acf4-4f35-b12a-6fdbea229f02"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7d249c37-39ab-4e28-8851-589995d455ee"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7df6fa9d-f005-441a-8b20-677acb3a673b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7e3430d7-334b-4684-bf12-0b2211ea4999"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("82ea8802-347b-40fc-8d25-54b3e9781c0f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("936ab992-96ea-42cf-aaec-2cfac50457f8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9404acde-45b0-4c4d-99da-1e2990e17078"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("96d9f563-6ba8-4e5b-a996-11a44498b3d5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9d7574f7-ec8c-487b-9bae-84bf8f98bb74"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a2579c72-8e00-4ee4-9ac9-1b2e030569b0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ad67577b-2411-4c72-93c5-253c8832f992"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("aeee55c7-bd49-4419-875d-63fe2c6b2e35"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c3689ae5-186b-4f16-9d92-003259f11bd2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cc91d9e5-dc19-4371-9f95-43a6e02a725e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ce0bf5e2-63d1-4d47-9a5c-0f289c9be72d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ce83f7cb-43ee-4fa2-972e-1adaa8700b4f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d5f10334-b1ab-44b3-af0f-ab4220123a46"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d8cc53ad-7807-48a0-ad77-b776c8fbfe62"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ddd7ee0b-b99b-44f0-969b-0d42532d2bce"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("efbe1f1e-8f61-4db2-b12c-2bb28364b7ad"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f2b91509-9bbf-48a3-9c4f-62a0f199541f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f5e1b520-76de-409c-af80-73fc0fcdc11e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f71c0983-7621-4ddb-ab47-39eaeeee992f"));

            migrationBuilder.AlterColumn<float>(
                name: "Reading",
                schema: "PMV",
                table: "FuelLogSheets",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
        }
    }
}
