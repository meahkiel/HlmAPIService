using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    public partial class SeedDataAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ffcb576-9c96-4a8a-b64f-11902dd68757"));

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "LVStations",
                columns: new[] { "Id", "Active", "Code", "CreatedAt", "CreatedBy", "CurrentFuelQuantity", "FuelDate", "FuelStation", "FueledTo", "Operator", "PreviousFuelQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("005cc361-9dd0-43ac-a1c7-533b00083af3"), true, "LV375", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(253), "LV375", "", "", 0f, null, null },
                    { new Guid("0087173b-cdcf-4a57-a85c-73e87cd3262e"), true, "LV215", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(266), "LV215", "", "", 0f, null, null },
                    { new Guid("1d2d38da-436a-4be4-933d-fd0d67f13cf2"), true, "D192Station", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(275), "D192Station", "", "", 0f, null, null },
                    { new Guid("27accaba-9fa5-43cc-a1e0-09a529c2e568"), true, "D182Station", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(274), "D182Station", "", "", 0f, null, null },
                    { new Guid("28eb0ef7-dba7-4523-b85c-167d84ad8707"), true, "QAPMSDStation", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(276), "QAPMSDStation", "", "", 0f, null, null },
                    { new Guid("69621414-3f75-4426-9f0d-45f422c135b0"), true, "LLV463", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(267), "LLV463", "", "", 0f, null, null },
                    { new Guid("6d6c62dd-5173-4f9b-b0fb-c4c17962fbb6"), true, "LV512", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(273), "LV512", "", "", 0f, null, null },
                    { new Guid("a929c822-c3d0-47fe-b311-6b6d7b1e359a"), true, "LV253", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(264), "LV253", "", "", 0f, null, null },
                    { new Guid("b201d60f-fa68-4c8f-a606-49379f6c544f"), true, "LV310", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(272), "LV310", "", "", 0f, null, null },
                    { new Guid("cad09149-3c99-4cd3-a880-32c2015398b2"), true, "LLV478", null, null, 0f, new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(270), "LLV478", "", "", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("01870d6e-5c3c-44bf-bfa4-72af14d7995a"), true, null, null, "I203", 0f, null, null },
                    { new Guid("01e06275-b2c5-4a1c-9def-f8ea8ba642d5"), true, null, null, "I216", 0f, null, null },
                    { new Guid("0860c3f4-f8ba-4879-a7ba-7e2d55602893"), true, null, null, "I214", 0f, null, null },
                    { new Guid("0913c186-38c6-46f1-bbb5-f4de344e190a"), true, null, null, "D211-Wakra", 0f, null, null },
                    { new Guid("095845fa-0074-4e53-af16-cd1c68baa5c6"), true, null, null, "D172", 0f, null, null },
                    { new Guid("127c92eb-a519-4ab4-9959-0ea999ba8a15"), true, null, null, "FULLBORE D192", 0f, null, null },
                    { new Guid("191d443c-06c3-4ec0-9960-887efb59e98a"), true, null, null, "FULLBORE D191", 0f, null, null },
                    { new Guid("1c70c610-d044-4b77-9095-f8acf92a1c5f"), true, null, null, "PMV", 0f, null, null },
                    { new Guid("20f4d2c1-7d2f-48c1-b72a-0851c5b65fa0"), true, null, null, "I201", 0f, null, null },
                    { new Guid("225da246-3f17-4f29-a441-91324112f580"), true, null, null, "QONCRETE WUKAIR", 0f, null, null },
                    { new Guid("2b8e25c0-243e-49bd-b962-24db4bacb2a1"), true, null, null, "D183", 0f, null, null },
                    { new Guid("2f8650ef-f783-4dda-83a3-7e16191b8fff"), true, null, null, "TOPROK WUKAIR", 0f, null, null },
                    { new Guid("35c06064-4a02-42d4-b725-3187106811ea"), true, null, null, "Helm Holding W.L.L", 0f, null, null },
                    { new Guid("3d0e35ab-d7d8-44bb-92b4-ed9144c6b23f"), true, null, null, "I215", 0f, null, null },
                    { new Guid("434fde8c-b690-4ae0-b770-011409385f6d"), true, null, null, "QONCRETE MAZRUA", 0f, null, null },
                    { new Guid("4b47d9a1-9286-43f8-8352-d2bcdec7bc67"), true, null, null, "TOPROK OTHERS", 0f, null, null },
                    { new Guid("582f2a9b-1e66-4303-9da5-e401ae66d233"), true, null, null, "JERRY CAN/ PROJECT/DEPT.", 0f, null, null },
                    { new Guid("59706bcf-8bb4-46af-b968-df0d0f993160"), true, null, null, "BRU", 0f, null, null },
                    { new Guid("5db6778c-9cbb-4aef-b14b-f1bd03c37dc6"), true, null, null, "I212", 0f, null, null },
                    { new Guid("63f1d2e3-f696-4169-8bad-e201fa739ce9"), true, null, null, "D171", 0f, null, null },
                    { new Guid("6ad5f720-2732-4cf9-9104-c0bac42162ab"), true, null, null, "TRANSPORT", 0f, null, null },
                    { new Guid("750f54f5-856b-43a7-8bb4-8fc59afe35d5"), true, null, null, "FULLBORE D182", 0f, null, null },
                    { new Guid("8123a56c-7bc9-44c5-9fe9-fafe8f59b9f2"), true, null, null, "QAP PLANT", 0f, null, null },
                    { new Guid("874c1cc7-e479-4a8d-b7d6-be5230228d1b"), true, null, null, "I227_Fullbore", 0f, null, null },
                    { new Guid("8754d162-bd94-4017-9f41-0feeca6f7711"), true, null, null, "D192", 0f, null, null },
                    { new Guid("8b7d20f1-5d97-44bd-b408-962b8ae9cbbe"), true, null, null, "D182", 0f, null, null },
                    { new Guid("9440b735-c9db-47a1-9080-11f23451fbf0"), true, null, null, "D211", 0f, null, null },
                    { new Guid("95bae152-5169-4aea-a936-588f23b87006"), true, null, null, "TOPROK SHAHANIYA", 0f, null, null },
                    { new Guid("99a22481-0636-4dbe-9910-20c79215d9b7"), true, null, null, "LOGISTICS", 0f, null, null },
                    { new Guid("9bd1ab1e-9271-477a-8dfb-ba194a752846"), true, null, null, "ASPHALT CREW", 0f, null, null },
                    { new Guid("a4c0a445-5f8f-4171-af27-38f9aa95e3e1"), true, null, null, "I222", 0f, null, null },
                    { new Guid("a5dcd5a9-3883-4731-b99b-4323cf0acfcc"), true, null, null, "UEG D182", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a776cefc-06fe-4929-93d8-7791e896cb52"), true, null, null, "LUSAIL", 0f, null, null },
                    { new Guid("b2125c65-1c1a-43ac-9a92-da45d7cc9493"), true, null, null, "I211", 0f, null, null },
                    { new Guid("b7f4ec3f-d865-41c0-b055-a52ca03bedfa"), true, null, null, "POLARIS D172", 0f, null, null },
                    { new Guid("bcca1b2e-bd90-4434-ba71-d335491cc1fe"), true, null, null, "I224", 0f, null, null },
                    { new Guid("c22ffc4a-5284-4eaa-b5aa-2012cc32a1ad"), true, null, null, "D191", 0f, null, null },
                    { new Guid("c270021b-a849-4808-8d6c-b6ca20155a9b"), true, null, null, "FULLBORE OTHERS", 0f, null, null },
                    { new Guid("cd246411-df2d-4aaf-a351-86d17fb5e603"), true, null, null, "UEG D192", 0f, null, null },
                    { new Guid("cf79ca30-5cb1-4652-81a9-7ec0bebdae4e"), true, null, null, "TOPROK MAZRUA", 0f, null, null },
                    { new Guid("d7a3d44f-747f-40fb-a131-c25c557837b7"), true, null, null, "UEG D191", 0f, null, null },
                    { new Guid("d89ed786-b64d-4845-862c-0527363aeb27"), true, null, null, "GAP Plant", 0f, null, null },
                    { new Guid("dd69f33f-b3e9-4b8d-8b3b-805e3c43b980"), true, null, null, "TOPROK I211", 0f, null, null },
                    { new Guid("e394480f-ed9d-45a7-a6bf-7f5cda7bee73"), true, null, null, "Precast D192", 0f, null, null },
                    { new Guid("e4ae159e-4471-4824-a43a-5550d67d22f8"), true, null, null, "AL THAKIRA", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "Users",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Department", "EmailAddress", "EmployeeCode", "FullName", "Section", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("8d898198-22fe-493d-9f3b-33155a9e68a1"), true, null, null, "PMV", "amercado@helm.qa", "H22095411", "Arnold Mercado", "LV253", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("005cc361-9dd0-43ac-a1c7-533b00083af3"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("0087173b-cdcf-4a57-a85c-73e87cd3262e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("1d2d38da-436a-4be4-933d-fd0d67f13cf2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("27accaba-9fa5-43cc-a1e0-09a529c2e568"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("28eb0ef7-dba7-4523-b85c-167d84ad8707"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("69621414-3f75-4426-9f0d-45f422c135b0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("6d6c62dd-5173-4f9b-b0fb-c4c17962fbb6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("a929c822-c3d0-47fe-b311-6b6d7b1e359a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("b201d60f-fa68-4c8f-a606-49379f6c544f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("cad09149-3c99-4cd3-a880-32c2015398b2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("01870d6e-5c3c-44bf-bfa4-72af14d7995a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("01e06275-b2c5-4a1c-9def-f8ea8ba642d5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0860c3f4-f8ba-4879-a7ba-7e2d55602893"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0913c186-38c6-46f1-bbb5-f4de344e190a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("095845fa-0074-4e53-af16-cd1c68baa5c6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("127c92eb-a519-4ab4-9959-0ea999ba8a15"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("191d443c-06c3-4ec0-9960-887efb59e98a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1c70c610-d044-4b77-9095-f8acf92a1c5f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("20f4d2c1-7d2f-48c1-b72a-0851c5b65fa0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("225da246-3f17-4f29-a441-91324112f580"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2b8e25c0-243e-49bd-b962-24db4bacb2a1"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2f8650ef-f783-4dda-83a3-7e16191b8fff"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("35c06064-4a02-42d4-b725-3187106811ea"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3d0e35ab-d7d8-44bb-92b4-ed9144c6b23f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("434fde8c-b690-4ae0-b770-011409385f6d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4b47d9a1-9286-43f8-8352-d2bcdec7bc67"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("582f2a9b-1e66-4303-9da5-e401ae66d233"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("59706bcf-8bb4-46af-b968-df0d0f993160"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5db6778c-9cbb-4aef-b14b-f1bd03c37dc6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("63f1d2e3-f696-4169-8bad-e201fa739ce9"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6ad5f720-2732-4cf9-9104-c0bac42162ab"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("750f54f5-856b-43a7-8bb4-8fc59afe35d5"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8123a56c-7bc9-44c5-9fe9-fafe8f59b9f2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("874c1cc7-e479-4a8d-b7d6-be5230228d1b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8754d162-bd94-4017-9f41-0feeca6f7711"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8b7d20f1-5d97-44bd-b408-962b8ae9cbbe"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9440b735-c9db-47a1-9080-11f23451fbf0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("95bae152-5169-4aea-a936-588f23b87006"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("99a22481-0636-4dbe-9910-20c79215d9b7"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9bd1ab1e-9271-477a-8dfb-ba194a752846"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a4c0a445-5f8f-4171-af27-38f9aa95e3e1"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a5dcd5a9-3883-4731-b99b-4323cf0acfcc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a776cefc-06fe-4929-93d8-7791e896cb52"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b2125c65-1c1a-43ac-9a92-da45d7cc9493"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b7f4ec3f-d865-41c0-b055-a52ca03bedfa"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("bcca1b2e-bd90-4434-ba71-d335491cc1fe"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c22ffc4a-5284-4eaa-b5aa-2012cc32a1ad"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c270021b-a849-4808-8d6c-b6ca20155a9b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cd246411-df2d-4aaf-a351-86d17fb5e603"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cf79ca30-5cb1-4652-81a9-7ec0bebdae4e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d7a3d44f-747f-40fb-a131-c25c557837b7"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d89ed786-b64d-4845-862c-0527363aeb27"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("dd69f33f-b3e9-4b8d-8b3b-805e3c43b980"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e394480f-ed9d-45a7-a6bf-7f5cda7bee73"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e4ae159e-4471-4824-a43a-5550d67d22f8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d898198-22fe-493d-9f3b-33155a9e68a1"));

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "Users",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Department", "EmailAddress", "EmployeeCode", "FullName", "Section", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("0ffcb576-9c96-4a8a-b64f-11902dd68757"), true, null, null, "PMV", "amercado@helm.qa", "H22095411", "Arnold Mercado", "LV253", null, null });
        }
    }
}
