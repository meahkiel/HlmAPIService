﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMV.PmvApiService.Persistence.Context;

#nullable disable

namespace PmvApiService.Persistence.Migrations
{
    [DbContext(typeof(PMVDataContext))]
    [Migration("20221116075433_SubmissionAndPostingOnLog")]
    partial class SubmissionAndPostingOnLog
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

                    b.Property<Guid>("LogSheetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreviousReading")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("Reading")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FueledById");

                    b.HasIndex("LocationId");

                    b.ToTable("FuelLogSheets", "PMV");
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
                            Id = new Guid("04cb10a4-8a21-4f08-ba53-1beded340f3a"),
                            Active = true,
                            DepartmentName = "D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8b4e2329-f426-4c60-b88c-05a4f26a18a9"),
                            Active = true,
                            DepartmentName = "D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("c96860b2-408a-4aff-984c-975a1f42b333"),
                            Active = true,
                            DepartmentName = "D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e77679e3-07d1-42fc-9bef-a71033e4b7f8"),
                            Active = true,
                            DepartmentName = "D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("1ffcea0a-96ce-4c11-8a4b-5beeb139e5ea"),
                            Active = true,
                            DepartmentName = "D171",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("5189bd7b-da80-459e-be0c-eff189e7cabc"),
                            Active = true,
                            DepartmentName = "D183",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e17a66fb-acbd-4685-91a8-132bc1519683"),
                            Active = true,
                            DepartmentName = "I201",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("47b0adf8-d5dd-4b54-b9de-4203dbfe4780"),
                            Active = true,
                            DepartmentName = "FULLBORE D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("0d54e4fd-0292-4f8f-acd9-50f85e3b7859"),
                            Active = true,
                            DepartmentName = "FULLBORE D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("10fdda15-1a17-41f4-b5fc-ec0acf5fdb0d"),
                            Active = true,
                            DepartmentName = "FULLBORE D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("1fc13a38-015a-4631-878e-50094f07a049"),
                            Active = true,
                            DepartmentName = "FULLBORE OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("911fd193-0807-4560-a9f9-d9e36224d6ce"),
                            Active = true,
                            DepartmentName = "POLARIS D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("dad8237e-e525-4b68-b329-457b5027d792"),
                            Active = true,
                            DepartmentName = "UEG D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("993c1df8-b49a-43f8-b01e-df3f433d5360"),
                            Active = true,
                            DepartmentName = "UEG D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("3047a4b4-62d6-436f-97d9-01860fad7db0"),
                            Active = true,
                            DepartmentName = "UEG D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e3388ea4-8d1f-44c8-95d4-254cb22d2357"),
                            Active = true,
                            DepartmentName = "TOPROK MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("80ac6696-9cc0-4e00-bc1b-4cf14bd40053"),
                            Active = true,
                            DepartmentName = "TOPROK WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("4d66b0ac-6beb-4b2c-b9ae-e6e7a28e11c8"),
                            Active = true,
                            DepartmentName = "TOPROK SHAHANIYA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("1b179382-cb2a-4027-b488-7bc501be1e23"),
                            Active = true,
                            DepartmentName = "TOPROK OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("f6547168-b30d-43c1-b6ce-3d4dbc0bc542"),
                            Active = true,
                            DepartmentName = "QONCRETE WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("6cbad646-732b-4108-9d3d-0f61d92d68f8"),
                            Active = true,
                            DepartmentName = "QONCRETE MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("f4f82689-baff-4819-9aef-086b5bd8b599"),
                            Active = true,
                            DepartmentName = "QAP PLANT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("98be4e7e-c81d-4a2d-b6b3-c27f1decf95b"),
                            Active = true,
                            DepartmentName = "ASPHALT CREW",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("5d889586-6860-40a5-a353-4ccf02af7db2"),
                            Active = true,
                            DepartmentName = "PMV",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("364406f2-4ce2-4e84-b1c4-36b17bcc048e"),
                            Active = true,
                            DepartmentName = "BRU",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9e4cbebe-dea9-435a-bdab-8012c4b3dc86"),
                            Active = true,
                            DepartmentName = "TRANSPORT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("ac4c434b-799f-47b8-8ba3-8c301a7b36f6"),
                            Active = true,
                            DepartmentName = "LOGISTICS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7ad5034d-e42b-4c2a-a180-8c1272db6f86"),
                            Active = true,
                            DepartmentName = "JERRY CAN/ PROJECT/DEPT.",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("83a45449-4740-4fe9-8d6e-783960d49afe"),
                            Active = true,
                            DepartmentName = "GAP Plant",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("458fb753-0edd-4663-9884-4ced1b1192aa"),
                            Active = true,
                            DepartmentName = "I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("21ea367f-ec81-4c1f-b612-b679e369d1c6"),
                            Active = true,
                            DepartmentName = "LUSAIL",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("eedffd3c-aa8a-44d8-a020-e52ce387ab2b"),
                            Active = true,
                            DepartmentName = "AL THAKIRA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("2b749702-45ac-4dcb-95b9-c09e2c0f3976"),
                            Active = true,
                            DepartmentName = "TOPROK I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("74310441-d1e8-4cf6-a5f0-f5ac4989692c"),
                            Active = true,
                            DepartmentName = "D211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9c755790-4fcf-44cb-8d6c-8e791844d372"),
                            Active = true,
                            DepartmentName = "I203",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("fa6941fe-f09d-4bdb-a297-aebddb736149"),
                            Active = true,
                            DepartmentName = "Helm Holding W.L.L",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7f5dff28-3831-43ef-8bf0-d3e9bc73b1cd"),
                            Active = true,
                            DepartmentName = "I216",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("c56a1f15-b4ff-45c5-bb48-d5f3a80ecb2c"),
                            Active = true,
                            DepartmentName = "I214",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7d108d52-e293-4170-88a7-afdb2271bbbd"),
                            Active = true,
                            DepartmentName = "I212",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("dd6a1700-a351-4d75-8433-74b8fd248b42"),
                            Active = true,
                            DepartmentName = "I215",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("c30e6fad-a174-46c4-9655-8a6eb840d5e6"),
                            Active = true,
                            DepartmentName = "Precast D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("5093c9f9-7147-44cc-9df4-3fafdccb484f"),
                            Active = true,
                            DepartmentName = "I222",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("afa0aaef-938e-43e4-ab9b-94f26deb777c"),
                            Active = true,
                            DepartmentName = "I224",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("782333d7-0cb5-4a70-9fda-b60dd40f30a5"),
                            Active = true,
                            DepartmentName = "D211-Wakra",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("0e2bf227-3dee-4bdd-bdb6-02fd6dc9f5d4"),
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
                            Id = new Guid("83f91663-825a-442c-9133-87243f8c3a7c"),
                            Active = true,
                            Code = "LV375",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7883),
                            FuelStation = "LV375",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("8b1a0cf9-2003-4052-bc22-9eff1eaef9aa"),
                            Active = true,
                            Code = "LV253",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7899),
                            FuelStation = "LV253",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("fa5dbeec-eb3e-4267-8db3-a4a297921256"),
                            Active = true,
                            Code = "LV215",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7901),
                            FuelStation = "LV215",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("66d5e35e-2af6-40f3-ab6e-f93efa89c3f5"),
                            Active = true,
                            Code = "LLV463",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7902),
                            FuelStation = "LLV463",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("595d9ac1-4f2c-41c5-a470-6b63deff9c30"),
                            Active = true,
                            Code = "LLV478",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7903),
                            FuelStation = "LLV478",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("76cc699e-51a7-4efb-a1b4-9b26a0a79058"),
                            Active = true,
                            Code = "LV310",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7904),
                            FuelStation = "LV310",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("40fd3fae-07ab-4e56-a741-172bee8bef40"),
                            Active = true,
                            Code = "LV512",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7905),
                            FuelStation = "LV512",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("eb0724d7-4e45-467a-8324-ec6e824090c5"),
                            Active = true,
                            Code = "D182Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7907),
                            FuelStation = "D182Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("7ddfa50b-ea1c-4b2b-a01e-bb0968b761f8"),
                            Active = true,
                            Code = "D192Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7911),
                            FuelStation = "D192Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("8fe43225-e2a2-43af-a274-2a43424ea84e"),
                            Active = true,
                            Code = "QAPMSDStation",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 16, 10, 54, 33, 630, DateTimeKind.Local).AddTicks(7912),
                            FuelStation = "QAPMSDStation",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
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

                    b.Navigation("FueledBy");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.FuelLogSheet", b =>
                {
                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}