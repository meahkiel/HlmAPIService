using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    public partial class AddRemarks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                schema: "PMV",
                table: "FuelLogSheets",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Remarks",
                schema: "PMV",
                table: "FuelLogSheets");

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
    }
}
