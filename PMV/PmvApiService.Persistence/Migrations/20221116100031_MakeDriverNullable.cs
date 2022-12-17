using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    public partial class MakeDriverNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("1a5e21c3-47c6-48f3-a15d-4303a38cacc9"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("4d4d11cb-1ee5-487a-83d0-54a4899e818d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("6c8c869e-23ea-452a-af40-93b7e45df04f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("6f7a9580-24d9-4c95-9f16-d337c376a8b8"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("87ef1825-c20f-4d4d-b9d2-c844bf350ec0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("a38e963c-65b4-4812-a728-799b5ad42739"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("a43821d5-0ab7-450b-9fff-74b075939afa"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("b601f766-134e-4d23-8a1f-91dd54044480"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("b975131b-2efc-4a0d-895c-996231ca1b89"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("ee0fee72-9601-47d7-9486-f046075906ee"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("057d1cb9-ce18-4f6a-b662-9f10112bd4fc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("10f86675-57e7-42e7-b253-a57719dfcbc6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1177f275-f97a-4b5f-ad6f-efe38a47b0c1"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1c98583b-a78e-4d6e-a862-9b6504ddfff4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1e57d66c-3fd5-4628-885a-f691b407a840"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1f5878b3-9ec5-4664-886f-70691945d5d3"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("256b62cc-84c5-415e-9e09-fe1f78c1c133"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("265f7abd-648b-4f8a-8ac8-ae2dca5a778c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2972690c-a24d-412d-853b-3a601069d2af"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2d5a3a5c-b88b-4727-bddc-e1e67f40b96b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4570ece8-8069-4744-ae47-649c3140deea"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("46810c7c-71d6-4116-986e-60d752c39f0c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("51ae94a4-4084-48b2-853c-e2a857905052"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("5241e038-ffbf-4515-a944-bcb709b83091"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("56d407a8-440d-46fb-8664-402e7af9d089"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6c10791c-7406-4d91-964e-76e48d85f316"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("727597bc-5408-4243-8794-d3cbb27aee4a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("75b75aaa-7c4e-4ebf-909b-769f2bdb9e0f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("769112f9-495c-45e9-a50b-3fee292d39cb"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("77ff5eb2-3c0f-427b-a348-610ee8343c3b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7cd6e968-7991-4d71-8ca7-48db989c784b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7eb3d9f2-9b1d-4f2d-95ba-9a749eead039"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("85d6288a-44f3-4055-a3ce-ea8dafe57566"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("89f8ba5e-8bb3-40b4-bca2-33c03bb8e6d7"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8bbd3c9e-e487-42c7-a329-df694bdafb23"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("962cbe16-ffdf-4d21-9ea3-cfa71375eb46"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9c256902-0c26-4489-acd7-dc5adc2d1fcd"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9c8f965c-dbb1-43b6-aa62-57eb66256457"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ae6a1c7f-8e1d-4ace-bb5d-d67fed28e859"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ae790c15-d171-41ed-b04a-85ed4f66c789"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b6a227e2-2294-4ff8-ad0e-50b888e47079"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b9de7a84-b840-4793-8e0d-a5226756e827"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("be0e56d6-1648-43c0-a2b5-e70d5f45e5fc"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c7622ae6-9add-4a60-b03c-f34dcca0ce6e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("c79536c2-aad5-4da3-af3c-1cb72e7b5164"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("cd7f83c5-a4ab-49be-8bea-6165b3a63d6b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d2ac89e3-9967-4294-a151-11fffa48dda0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d3ccb2a5-1729-4943-bf9f-1f9bffe9df80"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d43d92ce-d831-451f-afec-688b78df101e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("d5370357-2bb8-45f5-86d9-f1ebb2c9426a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("da7b09d6-3b5e-4e5f-8ad3-c81ae5536187"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("df600c5d-af77-45d7-b262-46df9c39e25b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e02fe04a-09c3-4a61-9669-a636639d4990"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ed753e5a-a350-49cb-8650-3af1977b44f0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f208f271-d2e3-4643-9662-a87953c73880"));

            migrationBuilder.AlterColumn<string>(
                name: "OperatorDriver",
                schema: "PMV",
                table: "FuelLogSheets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "LVStations",
                columns: new[] { "Id", "Active", "Code", "CreatedAt", "CreatedBy", "CurrentFuelQuantity", "FuelDate", "FuelStation", "FueledTo", "Operator", "PreviousFuelQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2a935100-43b2-4d31-af93-7603f2d3652f"), true, "LV375", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6355), "LV375", "", "", 0f, null, null },
                    { new Guid("50ac11e4-8ad7-445c-85f8-95256d85cb8c"), true, "LV253", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6370), "LV253", "", "", 0f, null, null },
                    { new Guid("71b07c27-78c2-4437-baa9-6d9d97c2268c"), true, "D182Station", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6382), "D182Station", "", "", 0f, null, null },
                    { new Guid("739150e5-f103-4d4d-9004-d2a9e1f13cab"), true, "LLV478", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6378), "LLV478", "", "", 0f, null, null },
                    { new Guid("818a055b-a920-4018-be50-d9f833307b11"), true, "QAPMSDStation", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6384), "QAPMSDStation", "", "", 0f, null, null },
                    { new Guid("9196d56b-f1a8-4d25-ac43-c317ba77be65"), true, "LV215", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6371), "LV215", "", "", 0f, null, null },
                    { new Guid("9968f20e-81a5-4fa2-bf9a-762269cd20c3"), true, "LLV463", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6373), "LLV463", "", "", 0f, null, null },
                    { new Guid("b7c6f856-6cf4-442b-995e-9a59f921ef41"), true, "LV512", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6381), "LV512", "", "", 0f, null, null },
                    { new Guid("e28db6d3-9b7c-4f80-aab6-07d4ed038c02"), true, "D192Station", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6383), "D192Station", "", "", 0f, null, null },
                    { new Guid("efa9b000-5096-4226-8f74-820f2fdd4b45"), true, "LV310", null, null, 0f, new DateTime(2022, 11, 16, 13, 0, 30, 765, DateTimeKind.Local).AddTicks(6379), "LV310", "", "", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0afce6e4-6699-4f57-94ad-8354731b3490"), true, null, null, "D211", 0f, null, null },
                    { new Guid("1153f95b-e558-4518-86a3-8fdac9721182"), true, null, null, "GAP Plant", 0f, null, null },
                    { new Guid("16f3ede9-fb71-4623-9768-8de2afd42eab"), true, null, null, "TOPROK I211", 0f, null, null },
                    { new Guid("19dc0950-59aa-4c01-b9ee-3577af63fe2e"), true, null, null, "I201", 0f, null, null },
                    { new Guid("1ad47d75-0f0f-433d-9103-cafe43149918"), true, null, null, "TOPROK SHAHANIYA", 0f, null, null },
                    { new Guid("228e4ec8-434c-4106-9ee5-c47fa38dc7bd"), true, null, null, "D192", 0f, null, null },
                    { new Guid("26100a3e-def8-44e1-9913-82bae8e156fa"), true, null, null, "I214", 0f, null, null },
                    { new Guid("2808af16-c673-4ca5-96f8-6b8cf00d5c02"), true, null, null, "D183", 0f, null, null },
                    { new Guid("2a47561f-b0f5-4e3c-a8af-0e39d26835de"), true, null, null, "I215", 0f, null, null },
                    { new Guid("2c66d61a-0d58-445c-aa7b-4ade686fe270"), true, null, null, "QAP PLANT", 0f, null, null },
                    { new Guid("311de093-6195-44e7-b293-4a0f76167f1f"), true, null, null, "UEG D182", 0f, null, null },
                    { new Guid("31a98e4e-71ca-4a36-99ef-1a45ddd81d46"), true, null, null, "UEG D191", 0f, null, null },
                    { new Guid("41eeddc6-1239-4848-a511-205924c85a01"), true, null, null, "FULLBORE OTHERS", 0f, null, null },
                    { new Guid("422669ae-0823-490a-bfc2-b3a997e5a883"), true, null, null, "D182", 0f, null, null },
                    { new Guid("4524e993-ee37-4253-b880-8b40cefcd6d0"), true, null, null, "LOGISTICS", 0f, null, null },
                    { new Guid("453024b2-5005-4d1c-b1cb-28fc56a504a2"), true, null, null, "AL THAKIRA", 0f, null, null },
                    { new Guid("4d8f718b-e05e-440b-b4cb-4c2bff8ddada"), true, null, null, "QONCRETE MAZRUA", 0f, null, null },
                    { new Guid("6542368a-da9b-4576-bc75-91900bb75614"), true, null, null, "D172", 0f, null, null },
                    { new Guid("685ecc61-431e-4d84-b855-05a99263e154"), true, null, null, "TRANSPORT", 0f, null, null },
                    { new Guid("71ab2092-46de-4e49-9cb9-0964782cdbee"), true, null, null, "FULLBORE D191", 0f, null, null },
                    { new Guid("72dcaf48-eee7-47bb-8075-101eb0d2ebf9"), true, null, null, "UEG D192", 0f, null, null },
                    { new Guid("7329f286-90ec-4daa-926d-512858b068e6"), true, null, null, "D171", 0f, null, null },
                    { new Guid("738d4ab4-6d11-46b6-9860-83dd8a38b5c4"), true, null, null, "FULLBORE D182", 0f, null, null },
                    { new Guid("79ab5af7-c7bb-4997-8da4-88d2620a1d72"), true, null, null, "Helm Holding W.L.L", 0f, null, null },
                    { new Guid("7dc1ad32-ba76-47f9-b4a8-3e46a8eae9fa"), true, null, null, "I222", 0f, null, null },
                    { new Guid("80aa085a-a85b-49f8-a13a-5c0979635f1b"), true, null, null, "I224", 0f, null, null },
                    { new Guid("8268e9c4-8ca1-41b3-8d23-42d27e3f3998"), true, null, null, "I203", 0f, null, null },
                    { new Guid("86a45b95-d820-4d33-9f22-91760598255a"), true, null, null, "FULLBORE D192", 0f, null, null },
                    { new Guid("8d0709a3-7213-47b6-b0d2-379c91f3ab9c"), true, null, null, "BRU", 0f, null, null },
                    { new Guid("92d9b623-cb18-4bf6-8489-40be44bd4c38"), true, null, null, "ASPHALT CREW", 0f, null, null },
                    { new Guid("9735e5ed-ef91-4e4e-abbe-96fa0e9d05f4"), true, null, null, "QONCRETE WUKAIR", 0f, null, null },
                    { new Guid("9a045601-f598-4cd8-b5b8-a12305a0591d"), true, null, null, "I216", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a0fa4252-aa98-477b-9d71-a3f926fde6f6"), true, null, null, "I211", 0f, null, null },
                    { new Guid("a49f26e0-ed6d-4dc5-9642-a9a22d2fc8eb"), true, null, null, "JERRY CAN/ PROJECT/DEPT.", 0f, null, null },
                    { new Guid("b3c2c436-efc0-47bd-920c-03a279ec5286"), true, null, null, "POLARIS D172", 0f, null, null },
                    { new Guid("b6d985bc-cd8c-41b3-a20f-4f94cfe18f0e"), true, null, null, "I212", 0f, null, null },
                    { new Guid("ce50a8ed-aecf-440f-b238-cb92bbb926b4"), true, null, null, "TOPROK OTHERS", 0f, null, null },
                    { new Guid("e058c07d-fa80-42b6-8492-3e4f66be801b"), true, null, null, "D191", 0f, null, null },
                    { new Guid("e104845f-452f-4fb6-a67d-628fc6e9da25"), true, null, null, "PMV", 0f, null, null },
                    { new Guid("e5b2bff4-9a35-49e7-8505-079406657e1a"), true, null, null, "D211-Wakra", 0f, null, null },
                    { new Guid("e9865116-9229-495e-8ba3-5f3e196d4d05"), true, null, null, "TOPROK MAZRUA", 0f, null, null },
                    { new Guid("ec44ca2c-6e16-427d-990a-42bda36bb8b9"), true, null, null, "I227_Fullbore", 0f, null, null },
                    { new Guid("ef1e74cd-77b1-43d7-93cc-309dbd2fa404"), true, null, null, "LUSAIL", 0f, null, null },
                    { new Guid("f61269c1-e948-490e-9770-bec7e6b25a70"), true, null, null, "TOPROK WUKAIR", 0f, null, null },
                    { new Guid("fbee0e7a-92da-43c6-9e7a-61358b5be9ba"), true, null, null, "Precast D192", 0f, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("2a935100-43b2-4d31-af93-7603f2d3652f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("50ac11e4-8ad7-445c-85f8-95256d85cb8c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("71b07c27-78c2-4437-baa9-6d9d97c2268c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("739150e5-f103-4d4d-9004-d2a9e1f13cab"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("818a055b-a920-4018-be50-d9f833307b11"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("9196d56b-f1a8-4d25-ac43-c317ba77be65"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("9968f20e-81a5-4fa2-bf9a-762269cd20c3"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("b7c6f856-6cf4-442b-995e-9a59f921ef41"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("e28db6d3-9b7c-4f80-aab6-07d4ed038c02"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "LVStations",
                keyColumn: "Id",
                keyValue: new Guid("efa9b000-5096-4226-8f74-820f2fdd4b45"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("0afce6e4-6699-4f57-94ad-8354731b3490"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1153f95b-e558-4518-86a3-8fdac9721182"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("16f3ede9-fb71-4623-9768-8de2afd42eab"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("19dc0950-59aa-4c01-b9ee-3577af63fe2e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("1ad47d75-0f0f-433d-9103-cafe43149918"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("228e4ec8-434c-4106-9ee5-c47fa38dc7bd"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("26100a3e-def8-44e1-9913-82bae8e156fa"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2808af16-c673-4ca5-96f8-6b8cf00d5c02"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2a47561f-b0f5-4e3c-a8af-0e39d26835de"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("2c66d61a-0d58-445c-aa7b-4ade686fe270"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("311de093-6195-44e7-b293-4a0f76167f1f"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("31a98e4e-71ca-4a36-99ef-1a45ddd81d46"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("41eeddc6-1239-4848-a511-205924c85a01"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("422669ae-0823-490a-bfc2-b3a997e5a883"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4524e993-ee37-4253-b880-8b40cefcd6d0"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("453024b2-5005-4d1c-b1cb-28fc56a504a2"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("4d8f718b-e05e-440b-b4cb-4c2bff8ddada"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("6542368a-da9b-4576-bc75-91900bb75614"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("685ecc61-431e-4d84-b855-05a99263e154"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("71ab2092-46de-4e49-9cb9-0964782cdbee"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("72dcaf48-eee7-47bb-8075-101eb0d2ebf9"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7329f286-90ec-4daa-926d-512858b068e6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("738d4ab4-6d11-46b6-9860-83dd8a38b5c4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("79ab5af7-c7bb-4997-8da4-88d2620a1d72"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("7dc1ad32-ba76-47f9-b4a8-3e46a8eae9fa"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("80aa085a-a85b-49f8-a13a-5c0979635f1b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8268e9c4-8ca1-41b3-8d23-42d27e3f3998"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("86a45b95-d820-4d33-9f22-91760598255a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("8d0709a3-7213-47b6-b0d2-379c91f3ab9c"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("92d9b623-cb18-4bf6-8489-40be44bd4c38"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9735e5ed-ef91-4e4e-abbe-96fa0e9d05f4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("9a045601-f598-4cd8-b5b8-a12305a0591d"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a0fa4252-aa98-477b-9d71-a3f926fde6f6"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("a49f26e0-ed6d-4dc5-9642-a9a22d2fc8eb"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b3c2c436-efc0-47bd-920c-03a279ec5286"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("b6d985bc-cd8c-41b3-a20f-4f94cfe18f0e"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ce50a8ed-aecf-440f-b238-cb92bbb926b4"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e058c07d-fa80-42b6-8492-3e4f66be801b"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e104845f-452f-4fb6-a67d-628fc6e9da25"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e5b2bff4-9a35-49e7-8505-079406657e1a"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("e9865116-9229-495e-8ba3-5f3e196d4d05"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ec44ca2c-6e16-427d-990a-42bda36bb8b9"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("ef1e74cd-77b1-43d7-93cc-309dbd2fa404"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("f61269c1-e948-490e-9770-bec7e6b25a70"));

            migrationBuilder.DeleteData(
                schema: "PMV",
                table: "ProjectLocations",
                keyColumn: "Id",
                keyValue: new Guid("fbee0e7a-92da-43c6-9e7a-61358b5be9ba"));

            migrationBuilder.AlterColumn<string>(
                name: "OperatorDriver",
                schema: "PMV",
                table: "FuelLogSheets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "LVStations",
                columns: new[] { "Id", "Active", "Code", "CreatedAt", "CreatedBy", "CurrentFuelQuantity", "FuelDate", "FuelStation", "FueledTo", "Operator", "PreviousFuelQuantity", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1a5e21c3-47c6-48f3-a15d-4303a38cacc9"), true, "LLV478", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(170), "LLV478", "", "", 0f, null, null },
                    { new Guid("4d4d11cb-1ee5-487a-83d0-54a4899e818d"), true, "D182Station", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(174), "D182Station", "", "", 0f, null, null },
                    { new Guid("6c8c869e-23ea-452a-af40-93b7e45df04f"), true, "D192Station", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(175), "D192Station", "", "", 0f, null, null },
                    { new Guid("6f7a9580-24d9-4c95-9f16-d337c376a8b8"), true, "QAPMSDStation", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(176), "QAPMSDStation", "", "", 0f, null, null },
                    { new Guid("87ef1825-c20f-4d4d-b9d2-c844bf350ec0"), true, "LV512", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(173), "LV512", "", "", 0f, null, null },
                    { new Guid("a38e963c-65b4-4812-a728-799b5ad42739"), true, "LV375", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(150), "LV375", "", "", 0f, null, null },
                    { new Guid("a43821d5-0ab7-450b-9fff-74b075939afa"), true, "LLV463", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(166), "LLV463", "", "", 0f, null, null },
                    { new Guid("b601f766-134e-4d23-8a1f-91dd54044480"), true, "LV310", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(172), "LV310", "", "", 0f, null, null },
                    { new Guid("b975131b-2efc-4a0d-895c-996231ca1b89"), true, "LV215", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(165), "LV215", "", "", 0f, null, null },
                    { new Guid("ee0fee72-9601-47d7-9486-f046075906ee"), true, "LV253", null, null, 0f, new DateTime(2022, 11, 16, 12, 55, 24, 312, DateTimeKind.Local).AddTicks(163), "LV253", "", "", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("057d1cb9-ce18-4f6a-b662-9f10112bd4fc"), true, null, null, "JERRY CAN/ PROJECT/DEPT.", 0f, null, null },
                    { new Guid("10f86675-57e7-42e7-b253-a57719dfcbc6"), true, null, null, "D172", 0f, null, null },
                    { new Guid("1177f275-f97a-4b5f-ad6f-efe38a47b0c1"), true, null, null, "Helm Holding W.L.L", 0f, null, null },
                    { new Guid("1c98583b-a78e-4d6e-a862-9b6504ddfff4"), true, null, null, "FULLBORE D192", 0f, null, null },
                    { new Guid("1e57d66c-3fd5-4628-885a-f691b407a840"), true, null, null, "I212", 0f, null, null },
                    { new Guid("1f5878b3-9ec5-4664-886f-70691945d5d3"), true, null, null, "FULLBORE D182", 0f, null, null },
                    { new Guid("256b62cc-84c5-415e-9e09-fe1f78c1c133"), true, null, null, "QONCRETE MAZRUA", 0f, null, null },
                    { new Guid("265f7abd-648b-4f8a-8ac8-ae2dca5a778c"), true, null, null, "UEG D182", 0f, null, null },
                    { new Guid("2972690c-a24d-412d-853b-3a601069d2af"), true, null, null, "I201", 0f, null, null },
                    { new Guid("2d5a3a5c-b88b-4727-bddc-e1e67f40b96b"), true, null, null, "UEG D191", 0f, null, null },
                    { new Guid("4570ece8-8069-4744-ae47-649c3140deea"), true, null, null, "BRU", 0f, null, null },
                    { new Guid("46810c7c-71d6-4116-986e-60d752c39f0c"), true, null, null, "D192", 0f, null, null },
                    { new Guid("51ae94a4-4084-48b2-853c-e2a857905052"), true, null, null, "I227_Fullbore", 0f, null, null },
                    { new Guid("5241e038-ffbf-4515-a944-bcb709b83091"), true, null, null, "FULLBORE OTHERS", 0f, null, null },
                    { new Guid("56d407a8-440d-46fb-8664-402e7af9d089"), true, null, null, "PMV", 0f, null, null },
                    { new Guid("6c10791c-7406-4d91-964e-76e48d85f316"), true, null, null, "D211", 0f, null, null },
                    { new Guid("727597bc-5408-4243-8794-d3cbb27aee4a"), true, null, null, "Precast D192", 0f, null, null },
                    { new Guid("75b75aaa-7c4e-4ebf-909b-769f2bdb9e0f"), true, null, null, "ASPHALT CREW", 0f, null, null },
                    { new Guid("769112f9-495c-45e9-a50b-3fee292d39cb"), true, null, null, "LOGISTICS", 0f, null, null },
                    { new Guid("77ff5eb2-3c0f-427b-a348-610ee8343c3b"), true, null, null, "QAP PLANT", 0f, null, null },
                    { new Guid("7cd6e968-7991-4d71-8ca7-48db989c784b"), true, null, null, "D171", 0f, null, null },
                    { new Guid("7eb3d9f2-9b1d-4f2d-95ba-9a749eead039"), true, null, null, "AL THAKIRA", 0f, null, null },
                    { new Guid("85d6288a-44f3-4055-a3ce-ea8dafe57566"), true, null, null, "UEG D192", 0f, null, null },
                    { new Guid("89f8ba5e-8bb3-40b4-bca2-33c03bb8e6d7"), true, null, null, "TOPROK OTHERS", 0f, null, null },
                    { new Guid("8bbd3c9e-e487-42c7-a329-df694bdafb23"), true, null, null, "TOPROK MAZRUA", 0f, null, null },
                    { new Guid("962cbe16-ffdf-4d21-9ea3-cfa71375eb46"), true, null, null, "I224", 0f, null, null },
                    { new Guid("9c256902-0c26-4489-acd7-dc5adc2d1fcd"), true, null, null, "QONCRETE WUKAIR", 0f, null, null },
                    { new Guid("9c8f965c-dbb1-43b6-aa62-57eb66256457"), true, null, null, "I203", 0f, null, null },
                    { new Guid("ae6a1c7f-8e1d-4ace-bb5d-d67fed28e859"), true, null, null, "TOPROK SHAHANIYA", 0f, null, null },
                    { new Guid("ae790c15-d171-41ed-b04a-85ed4f66c789"), true, null, null, "I216", 0f, null, null },
                    { new Guid("b6a227e2-2294-4ff8-ad0e-50b888e47079"), true, null, null, "I211", 0f, null, null },
                    { new Guid("b9de7a84-b840-4793-8e0d-a5226756e827"), true, null, null, "D191", 0f, null, null }
                });

            migrationBuilder.InsertData(
                schema: "PMV",
                table: "ProjectLocations",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DepartmentName", "SurCharge", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("be0e56d6-1648-43c0-a2b5-e70d5f45e5fc"), true, null, null, "LUSAIL", 0f, null, null },
                    { new Guid("c7622ae6-9add-4a60-b03c-f34dcca0ce6e"), true, null, null, "D211-Wakra", 0f, null, null },
                    { new Guid("c79536c2-aad5-4da3-af3c-1cb72e7b5164"), true, null, null, "TOPROK I211", 0f, null, null },
                    { new Guid("cd7f83c5-a4ab-49be-8bea-6165b3a63d6b"), true, null, null, "D182", 0f, null, null },
                    { new Guid("d2ac89e3-9967-4294-a151-11fffa48dda0"), true, null, null, "D183", 0f, null, null },
                    { new Guid("d3ccb2a5-1729-4943-bf9f-1f9bffe9df80"), true, null, null, "I222", 0f, null, null },
                    { new Guid("d43d92ce-d831-451f-afec-688b78df101e"), true, null, null, "I214", 0f, null, null },
                    { new Guid("d5370357-2bb8-45f5-86d9-f1ebb2c9426a"), true, null, null, "I215", 0f, null, null },
                    { new Guid("da7b09d6-3b5e-4e5f-8ad3-c81ae5536187"), true, null, null, "TRANSPORT", 0f, null, null },
                    { new Guid("df600c5d-af77-45d7-b262-46df9c39e25b"), true, null, null, "TOPROK WUKAIR", 0f, null, null },
                    { new Guid("e02fe04a-09c3-4a61-9669-a636639d4990"), true, null, null, "POLARIS D172", 0f, null, null },
                    { new Guid("ed753e5a-a350-49cb-8650-3af1977b44f0"), true, null, null, "FULLBORE D191", 0f, null, null },
                    { new Guid("f208f271-d2e3-4643-9662-a87953c73880"), true, null, null, "GAP Plant", 0f, null, null }
                });
        }
    }
}
