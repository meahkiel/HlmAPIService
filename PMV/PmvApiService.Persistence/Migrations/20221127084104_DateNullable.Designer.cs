﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMV.Persistence.Context;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    [DbContext(typeof(PMVDataContext))]
    [Migration("20221127084104_DateNullable")]
    partial class DateNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("PMV")
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.Entities.FuelResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LogSheetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LogSheetId");

                    b.ToTable("FuelResource", "PMV");
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.FuelLogSheet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AssetCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FuelDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FueledById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OperatorDriver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreviousReading")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("Reading")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FueledById");

                    b.HasIndex("LocationId");

                    b.ToTable("FuelLogSheets", "PMV");
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.LogSheet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EndShiftMeterReading")
                        .HasColumnType("int");

                    b.Property<int?>("EndShiftTankerKm")
                        .HasColumnType("int");

                    b.Property<DateTime>("FueledDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LVStationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferenceNo")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ShiftEndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShiftStartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartShiftMeterReading")
                        .HasColumnType("int");

                    b.Property<int>("StartShiftTankerKm")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LVStationId");

                    b.ToTable("LogSheets", "PMV");
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.LogSheetDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssetCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentSMUUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverQatarIdUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FuelTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LogSheetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OperatorDriver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreviousReading")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("Reading")
                        .HasColumnType("int");

                    b.Property<string>("TankMeterUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LogSheetId");

                    b.ToTable("LogSheetDetails", "PMV");
                });

            modelBuilder.Entity("PmvApiService.Core.Locations.ProjectLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("SurCharge")
                        .HasColumnType("real");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("DepartmentName");

                    b.ToTable("ProjectLocations", "PMV");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fbc3c12d-7baf-4c18-a4bc-439ad5b2f471"),
                            Active = true,
                            DepartmentName = "D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("b0d506ea-becc-472d-ae7c-f2247e12f459"),
                            Active = true,
                            DepartmentName = "D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("31f053a1-78c2-4089-9330-b7ff792f91f6"),
                            Active = true,
                            DepartmentName = "D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("22bc601b-376f-462c-aa22-b978b5d45416"),
                            Active = true,
                            DepartmentName = "D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("0e596a6e-5b88-4e37-9ca9-2ce4c74437f8"),
                            Active = true,
                            DepartmentName = "D171",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("87526d5a-2670-41b7-8df9-75bcfa53072a"),
                            Active = true,
                            DepartmentName = "D183",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("34cec43e-401d-495d-8f5d-d1b67ebf5f0a"),
                            Active = true,
                            DepartmentName = "I201",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("bb5f75c9-2354-4c0d-8273-4cadcb74b40b"),
                            Active = true,
                            DepartmentName = "FULLBORE D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("285067ae-fbaa-4692-bed1-134f9a2627ac"),
                            Active = true,
                            DepartmentName = "FULLBORE D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("5f40ca6a-fb53-4b8f-abfd-0180c87a608b"),
                            Active = true,
                            DepartmentName = "FULLBORE D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("cdeaef7e-ab3c-408e-8431-742e14043818"),
                            Active = true,
                            DepartmentName = "FULLBORE OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("193bd1c3-373e-437c-b1e8-ebf3ad4642f9"),
                            Active = true,
                            DepartmentName = "POLARIS D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e1c86a4d-fcfd-4075-b844-9d6b6ac3384c"),
                            Active = true,
                            DepartmentName = "UEG D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("b81aa124-d821-4f4c-b619-ca85efaa3682"),
                            Active = true,
                            DepartmentName = "UEG D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("d3e61067-40b2-4c1f-96e3-9e0796b2cd6b"),
                            Active = true,
                            DepartmentName = "UEG D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("c9d7d5a2-0009-4355-9178-ccd982cb1992"),
                            Active = true,
                            DepartmentName = "TOPROK MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e5c8ab7e-a1d7-4cd2-a9b1-2c7e8228df0f"),
                            Active = true,
                            DepartmentName = "TOPROK WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("1b7cbf33-7ebc-48f4-9183-feec780574c8"),
                            Active = true,
                            DepartmentName = "TOPROK SHAHANIYA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8fabe48d-1999-424a-b005-12e740266cc6"),
                            Active = true,
                            DepartmentName = "TOPROK OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("506e8372-fbaf-49ee-a7ba-133021d2cf8b"),
                            Active = true,
                            DepartmentName = "QONCRETE WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("4abcd1bd-88b2-49b9-9ff7-fd6d470545b4"),
                            Active = true,
                            DepartmentName = "QONCRETE MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("fa558477-689b-4590-9ecc-d4aee07f9fc8"),
                            Active = true,
                            DepartmentName = "QAP PLANT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("268ed1f9-820f-4552-98a0-62b14e17bdd2"),
                            Active = true,
                            DepartmentName = "ASPHALT CREW",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("a8effbd8-078c-45ba-8282-31189659f0c6"),
                            Active = true,
                            DepartmentName = "PMV",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("178787fa-e14b-4766-b82a-495999fee927"),
                            Active = true,
                            DepartmentName = "BRU",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8cfae31a-b061-4c6e-8212-81d996efadd7"),
                            Active = true,
                            DepartmentName = "TRANSPORT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("3575528b-bc24-43bc-8316-5502339755eb"),
                            Active = true,
                            DepartmentName = "LOGISTICS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9b79b435-540c-4375-a90f-a6cb3cdb0ca2"),
                            Active = true,
                            DepartmentName = "JERRY CAN/ PROJECT/DEPT.",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9a96dd41-d9a2-4b0f-9990-aa1111637523"),
                            Active = true,
                            DepartmentName = "GAP Plant",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("2a988d82-9852-4918-aa95-fb1cb8e972b7"),
                            Active = true,
                            DepartmentName = "I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("be116714-6274-413a-84dd-2620acec97c9"),
                            Active = true,
                            DepartmentName = "LUSAIL",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("43ab397f-e85b-4b5d-a9d5-5dec954f9ac9"),
                            Active = true,
                            DepartmentName = "AL THAKIRA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e13d9040-81bd-48fc-bb2a-026fbaa0ad97"),
                            Active = true,
                            DepartmentName = "TOPROK I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("be9b2e23-50c3-449f-bfd4-9bf5fa8629c3"),
                            Active = true,
                            DepartmentName = "D211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8d72b06d-0626-48f0-ba04-24d7f355d95c"),
                            Active = true,
                            DepartmentName = "I203",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("70b4f373-9e26-496d-a2d5-2ad57fca01be"),
                            Active = true,
                            DepartmentName = "Helm Holding W.L.L",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("edcb00ae-b2ae-4ae0-9637-d33ba62a5e0e"),
                            Active = true,
                            DepartmentName = "I216",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("d006e23c-7f72-4f84-89f6-1df0fc7e8f52"),
                            Active = true,
                            DepartmentName = "I214",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9c6caa1d-da12-479f-86bd-bb1f71216cb8"),
                            Active = true,
                            DepartmentName = "I212",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7e42aa6f-e7bc-43b3-9863-df2c6ce4737e"),
                            Active = true,
                            DepartmentName = "I215",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("5928ff97-cbbc-4d85-a8e0-0b2aaa1d84f6"),
                            Active = true,
                            DepartmentName = "Precast D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("0c1ecd0e-69b2-4f0b-820e-266d482b3ac5"),
                            Active = true,
                            DepartmentName = "I222",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("459bacaf-7ea3-4875-87d5-304d584111d6"),
                            Active = true,
                            DepartmentName = "I224",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("1e0db2ff-5a26-4f7e-80e7-75364b77c7e1"),
                            Active = true,
                            DepartmentName = "D211-Wakra",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9e6c7e26-53cb-418d-9dc2-fc16241f9852"),
                            Active = true,
                            DepartmentName = "I227_Fullbore",
                            SurCharge = 0f
                        });
                });

            modelBuilder.Entity("PmvApiService.Core.LVStations.LVStation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("CurrentFuelQuantity")
                        .HasColumnType("real");

                    b.Property<DateTime>("FuelDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuelStation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FueledTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PreviousFuelQuantity")
                        .HasColumnType("real");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Code");

                    b.ToTable("LVStations", "PMV");

                    b.HasData(
                        new
                        {
                            Id = new Guid("60c6d1c3-4f35-4be9-bead-e7807b831acd"),
                            Active = true,
                            Code = "LV375",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5096),
                            FuelStation = "LV375",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("110b666d-c65d-4ca0-a6bd-68218322f5ee"),
                            Active = true,
                            Code = "LV253",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5107),
                            FuelStation = "LV253",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("ad3b3f19-14f8-4336-95b9-bd8b6e7d9989"),
                            Active = true,
                            Code = "LV215",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5110),
                            FuelStation = "LV215",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("2a1315a2-37dc-45ff-9850-1000716b03cd"),
                            Active = true,
                            Code = "LLV463",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5111),
                            FuelStation = "LLV463",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("841a04c3-7b51-4868-8811-65cff472768c"),
                            Active = true,
                            Code = "LLV478",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5112),
                            FuelStation = "LLV478",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("8776d8c2-11b3-41e6-b694-f4691254f2a4"),
                            Active = true,
                            Code = "LV310",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5113),
                            FuelStation = "LV310",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("31bb853b-8b7d-49cb-97ae-896dc93a87e4"),
                            Active = true,
                            Code = "LV512",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5114),
                            FuelStation = "LV512",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("78037c1c-82bf-41f1-bcff-742bd3c18016"),
                            Active = true,
                            Code = "D182Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5115),
                            FuelStation = "D182Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("45ad8700-c270-41c3-90d9-5efb1bff9b40"),
                            Active = true,
                            Code = "D192Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5116),
                            FuelStation = "D192Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("540495ff-2737-4da0-a9ec-a0d7901e200d"),
                            Active = true,
                            Code = "QAPMSDStation",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 27, 11, 41, 3, 662, DateTimeKind.Local).AddTicks(5118),
                            FuelStation = "QAPMSDStation",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        });
                });

            modelBuilder.Entity("PmvApiService.Core.User.PMVUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("EmployeeCode");

                    b.ToTable("Users", "PMV");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a07fe852-f5a3-4da7-83a0-f09b5154b8d9"),
                            Active = true,
                            Department = "PMV",
                            EmailAddress = "amercado@helm.qa",
                            EmployeeCode = "H22095411",
                            FullName = "Arnold Mercado",
                            Section = "LV253"
                        });
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.Entities.FuelResource", b =>
                {
                    b.HasOne("PmvApiService.Core.FuelLogs.FuelLogSheet", "LogSheet")
                        .WithMany("Resources")
                        .HasForeignKey("LogSheetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LogSheet");
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.FuelLogSheet", b =>
                {
                    b.HasOne("PmvApiService.Core.LVStations.LVStation", "FueledBy")
                        .WithMany()
                        .HasForeignKey("FueledById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PmvApiService.Core.Locations.ProjectLocation", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("PmvApiService.Core.Common.ValueObjects.PostingObject", "Submit", b1 =>
                        {
                            b1.Property<Guid>("FuelLogSheetId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<bool>("IsPosted")
                                .HasColumnType("bit");

                            b1.Property<DateTime?>("PostedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("FuelLogSheetId");

                            b1.ToTable("FuelLogSheets", "PMV");

                            b1.WithOwner()
                                .HasForeignKey("FuelLogSheetId");
                        });

                    b.OwnsOne("PmvApiService.Core.Common.ValueObjects.PostingObject", "Validate", b1 =>
                        {
                            b1.Property<Guid>("FuelLogSheetId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<bool>("IsPosted")
                                .HasColumnType("bit");

                            b1.Property<DateTime?>("PostedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("FuelLogSheetId");

                            b1.ToTable("FuelLogSheets", "PMV");

                            b1.WithOwner()
                                .HasForeignKey("FuelLogSheetId");
                        });

                    b.Navigation("FueledBy");

                    b.Navigation("Location");

                    b.Navigation("Submit")
                        .IsRequired();

                    b.Navigation("Validate")
                        .IsRequired();
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.LogSheet", b =>
                {
                    b.HasOne("PmvApiService.Core.LVStations.LVStation", "LVStation")
                        .WithMany()
                        .HasForeignKey("LVStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("PmvApiService.Core.Common.ValueObjects.PostingObject", "Post", b1 =>
                        {
                            b1.Property<Guid>("LogSheetId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<bool>("IsPosted")
                                .HasColumnType("bit");

                            b1.Property<DateTime?>("PostedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("LogSheetId");

                            b1.ToTable("LogSheets", "PMV");

                            b1.WithOwner()
                                .HasForeignKey("LogSheetId");
                        });

                    b.Navigation("LVStation");

                    b.Navigation("Post")
                        .IsRequired();
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.LogSheetDetail", b =>
                {
                    b.HasOne("PmvApiService.Core.FuelLogs.LogSheet", "LogSheet")
                        .WithMany("Details")
                        .HasForeignKey("LogSheetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LogSheet");
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.FuelLogSheet", b =>
                {
                    b.Navigation("Resources");
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.LogSheet", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
