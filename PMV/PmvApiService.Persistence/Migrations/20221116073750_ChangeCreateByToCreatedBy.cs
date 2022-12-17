using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    public partial class ChangeCreateByToCreatedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "PMV",
                table: "ProjectLocations",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "PMV",
                table: "LVStations",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "PMV",
                table: "FuelLogSheets",
                newName: "CreatedBy");

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "LVStations",
                columns: new[] { "Id", "Active", "Code", "CreatedAt", "CreatedBy", "CurrentFuelQuantity", "FuelDate", "FuelStation", "FueledTo", "Operator", "PreviousFuelQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("237dae87-b571-4b44-a6a8-575714a7c380"), true, "LV215", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2048), "LV215", "", "", 0f, null, null },
                    { new Guid("34cb6725-c10d-4cf0-b226-92c1994423a3"), true, "QAPMSDStation", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2060), "QAPMSDStation", "", "", 0f, null, null },
                    { new Guid("42c520fa-6a5e-4cde-9304-a3d3621baa26"), true, "LLV463", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2050), "LLV463", "", "", 0f, null, null },
                    { new Guid("614454df-6949-444f-b4a9-06f7c6355e9a"), true, "LV375", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2032), "LV375", "", "", 0f, null, null },
                    { new Guid("8e7b8d44-95a3-41ae-94cc-33edc8e372f8"), true, "D182Station", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2058), "D182Station", "", "", 0f, null, null },
                    { new Guid("bbc0fb42-00fa-4df4-927e-47176e0f5ae3"), true, "LV253", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2047), "LV253", "", "", 0f, null, null },
                    { new Guid("bedb5d70-c085-42de-9018-408b9e23ca12"), true, "LV512", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2056), "LV512", "", "", 0f, null, null },
                    { new Guid("d0e533e3-61e2-4950-b2bf-4337a08f2cc4"), true, "LV310", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2055), "LV310", "", "", 0f, null, null },
                    { new Guid("d37ffbe9-22e4-423b-bf9b-1f8818612067"), true, "LLV478", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2054), "LLV478", "", "", 0f, null, null },
                    { new Guid("ffd0d7c7-df8e-4719-bb7b-aef6673589db"), true, "D192Station", null, null, 0f, new DateTime(2022, 11, 16, 10, 37, 49, 661, DateTimeKind.Local).AddTicks(2059), "D192Station", "", "", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("00e36b10-f0e8-4973-b033-a92c5280a23b"), true, null, null, "POLARIS D172", 0f, null, null },
                    { new Guid("0bc56a87-fa51-4dc6-8278-630c289db80a"), true, null, null, "I227_Fullbore", 0f, null, null },
                    { new Guid("0f364b9b-1ea2-4c06-bf0e-417ea094fdd6"), true, null, null, "QONCRETE WUKAIR", 0f, null, null },
                    { new Guid("1a6dc5af-c9f6-43a8-b5ac-828bd63274ee"), true, null, null, "TRANSPORT", 0f, null, null },
                    { new Guid("1c65c130-cba1-4fe7-8348-282e8be5f103"), true, null, null, "UEG D192", 0f, null, null },
                    { new Guid("1ee356e3-68dd-4d09-b673-31b57786a67e"), true, null, null, "TOPROK I211", 0f, null, null },
                    { new Guid("20c8fde9-22e8-4d88-8a0d-35a0c1524190"), true, null, null, "I201", 0f, null, null },
                    { new Guid("21f0fdde-921d-4814-87a0-fc4b4fa29b62"), true, null, null, "JERRY CAN/ PROJECT/DEPT.", 0f, null, null },
                    { new Guid("249ea666-012c-4e60-bfa9-14070147ecf8"), true, null, null, "PMV", 0f, null, null },
                    { new Guid("31092e19-a22e-4914-b58d-4fb6536ce4e2"), true, null, null, "I203", 0f, null, null },
                    { new Guid("31cc37ea-5772-4d5d-932c-64ffd33f0b46"), true, null, null, "TOPROK WUKAIR", 0f, null, null },
                    { new Guid("394fa5e0-94c0-4ecc-81c0-c22fba3f6f08"), true, null, null, "I216", 0f, null, null },
                    { new Guid("3c14e7ac-5368-49f4-8463-7353cc1f8686"), true, null, null, "I215", 0f, null, null },
                    { new Guid("3d3f7058-d754-404f-b143-3a9b98082d48"), true, null, null, "TOPROK OTHERS", 0f, null, null },
                    { new Guid("55aadf3f-3812-43dd-8bea-49218ea50da3"), true, null, null, "LUSAIL", 0f, null, null },
                    { new Guid("5724e8c2-d8b0-4827-97b5-a3941249a294"), true, null, null, "D171", 0f, null, null },
                    { new Guid("5ed5a35a-3a2e-4d82-b62d-f40499c2693c"), true, null, null, "D191", 0f, null, null },
                    { new Guid("6280894b-3e59-4abe-bfdb-caee2c9a08e4"), true, null, null, "UEG D191", 0f, null, null },
                    { new Guid("637fdaa0-904b-48fa-84a0-69640cae4fab"), true, null, null, "I224", 0f, null, null },
                    { new Guid("66aea4a7-5ffa-4b90-a0df-a51a74ca485a"), true, null, null, "QONCRETE MAZRUA", 0f, null, null },
                    { new Guid("7185af01-1d28-4ea1-aef9-7d213e897bba"), true, null, null, "D211", 0f, null, null },
                    { new Guid("72c54244-0c9a-4e2b-918c-fc80b34128d7"), true, null, null, "I222", 0f, null, null },
                    { new Guid("73f796dc-1835-4e35-bd49-ee0d16330e06"), true, null, null, "QAP PLANT", 0f, null, null },
                    { new Guid("76fe2097-eeb2-491c-8c35-fc6deaf9e817"), true, null, null, "D211-Wakra", 0f, null, null },
                    { new Guid("8665a505-81b7-4065-85e4-035e3fe4f65f"), true, null, null, "ASPHALT CREW", 0f, null, null },
                    { new Guid("8973db07-7bdb-45ea-89b5-c7ef49adf8c4"), true, null, null, "AL THAKIRA", 0f, null, null },
                    { new Guid("9bbf5201-de76-49ec-a552-5cf28f72c126"), true, null, null, "I212", 0f, null, null },
                    { new Guid("9cafad71-b415-4a18-af62-c69647e6cdea"), true, null, null, "FULLBORE D191", 0f, null, null },
                    { new Guid("a9142ea6-285a-41aa-94a3-83f60320477d"), true, null, null, "LOGISTICS", 0f, null, null },
                    { new Guid("b0d55602-b96f-4610-9e62-64b635223842"), true, null, null, "D183", 0f, null, null },
                    { new Guid("b5996b35-165b-438a-a5b2-344018914dae"), true, null, null, "D192", 0f, null, null },
                    { new Guid("bcd2aa7f-afdc-42e3-8611-001dd1b576fd"), true, null, null, "D172", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("c1c10ff5-f2a1-43a8-b6d5-1fd3c2b46be2"), true, null, null, "TOPROK MAZRUA", 0f, null, null },
                    { new Guid("c49ba940-d9c4-4260-b039-d42cf43237c6"), true, null, null, "TOPROK SHAHANIYA", 0f, null, null },
                    { new Guid("c8f84011-2ff3-45a2-9385-2f83cbf17346"), true, null, null, "UEG D182", 0f, null, null },
                    { new Guid("cd9a8e8b-de54-4d95-8f8d-e2537c10a55e"), true, null, null, "I211", 0f, null, null },
                    { new Guid("ce5034b7-2c83-4b03-9895-039591c81a55"), true, null, null, "I214", 0f, null, null },
                    { new Guid("d331928b-b099-4dd0-90ad-eaccdbb5ee30"), true, null, null, "Helm Holding W.L.L", 0f, null, null },
                    { new Guid("d4a37c6a-c856-4c79-b3ce-8871383f2e90"), true, null, null, "FULLBORE D192", 0f, null, null },
                    { new Guid("d96db0ad-2909-4bc2-904c-2371d8ea8647"), true, null, null, "GAP Plant", 0f, null, null },
                    { new Guid("f232bb27-f569-494c-bbce-1889ddec7931"), true, null, null, "D182", 0f, null, null },
                    { new Guid("f287eea2-641d-4ee6-8d7c-abc035af9f1c"), true, null, null, "FULLBORE D182", 0f, null, null },
                    { new Guid("f3e4b365-32b7-459d-97ad-b6a0e4ab1168"), true, null, null, "Precast D192", 0f, null, null },
                    { new Guid("f64a890d-e970-4dd2-86e0-51ff473174be"), true, null, null, "FULLBORE OTHERS", 0f, null, null },
                    { new Guid("fe04b36c-3358-4cf8-a12b-09b3fcebf654"), true, null, null, "BRU", 0f, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("237dae87-b571-4b44-a6a8-575714a7c380"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("34cb6725-c10d-4cf0-b226-92c1994423a3"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("42c520fa-6a5e-4cde-9304-a3d3621baa26"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("614454df-6949-444f-b4a9-06f7c6355e9a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("8e7b8d44-95a3-41ae-94cc-33edc8e372f8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("bbc0fb42-00fa-4df4-927e-47176e0f5ae3"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("bedb5d70-c085-42de-9018-408b9e23ca12"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("d0e533e3-61e2-4950-b2bf-4337a08f2cc4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("d37ffbe9-22e4-423b-bf9b-1f8818612067"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("ffd0d7c7-df8e-4719-bb7b-aef6673589db"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("00e36b10-f0e8-4973-b033-a92c5280a23b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0bc56a87-fa51-4dc6-8278-630c289db80a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0f364b9b-1ea2-4c06-bf0e-417ea094fdd6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1a6dc5af-c9f6-43a8-b5ac-828bd63274ee"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1c65c130-cba1-4fe7-8348-282e8be5f103"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1ee356e3-68dd-4d09-b673-31b57786a67e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("20c8fde9-22e8-4d88-8a0d-35a0c1524190"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("21f0fdde-921d-4814-87a0-fc4b4fa29b62"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("249ea666-012c-4e60-bfa9-14070147ecf8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("31092e19-a22e-4914-b58d-4fb6536ce4e2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("31cc37ea-5772-4d5d-932c-64ffd33f0b46"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("394fa5e0-94c0-4ecc-81c0-c22fba3f6f08"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3c14e7ac-5368-49f4-8463-7353cc1f8686"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("3d3f7058-d754-404f-b143-3a9b98082d48"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("55aadf3f-3812-43dd-8bea-49218ea50da3"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5724e8c2-d8b0-4827-97b5-a3941249a294"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5ed5a35a-3a2e-4d82-b62d-f40499c2693c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6280894b-3e59-4abe-bfdb-caee2c9a08e4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("637fdaa0-904b-48fa-84a0-69640cae4fab"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("66aea4a7-5ffa-4b90-a0df-a51a74ca485a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7185af01-1d28-4ea1-aef9-7d213e897bba"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("72c54244-0c9a-4e2b-918c-fc80b34128d7"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("73f796dc-1835-4e35-bd49-ee0d16330e06"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("76fe2097-eeb2-491c-8c35-fc6deaf9e817"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8665a505-81b7-4065-85e4-035e3fe4f65f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8973db07-7bdb-45ea-89b5-c7ef49adf8c4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9bbf5201-de76-49ec-a552-5cf28f72c126"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9cafad71-b415-4a18-af62-c69647e6cdea"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a9142ea6-285a-41aa-94a3-83f60320477d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b0d55602-b96f-4610-9e62-64b635223842"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b5996b35-165b-438a-a5b2-344018914dae"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("bcd2aa7f-afdc-42e3-8611-001dd1b576fd"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c1c10ff5-f2a1-43a8-b6d5-1fd3c2b46be2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c49ba940-d9c4-4260-b039-d42cf43237c6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c8f84011-2ff3-45a2-9385-2f83cbf17346"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cd9a8e8b-de54-4d95-8f8d-e2537c10a55e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ce5034b7-2c83-4b03-9895-039591c81a55"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d331928b-b099-4dd0-90ad-eaccdbb5ee30"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d4a37c6a-c856-4c79-b3ce-8871383f2e90"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d96db0ad-2909-4bc2-904c-2371d8ea8647"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f232bb27-f569-494c-bbce-1889ddec7931"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f287eea2-641d-4ee6-8d7c-abc035af9f1c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f3e4b365-32b7-459d-97ad-b6a0e4ab1168"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f64a890d-e970-4dd2-86e0-51ff473174be"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("fe04b36c-3358-4cf8-a12b-09b3fcebf654"));

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "PMV",
                table: "ProjectLocations",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "PMV",
                table: "LVStations",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "PMV",
                table: "FuelLogSheets",
                newName: "CreateBy");

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
    }
}
