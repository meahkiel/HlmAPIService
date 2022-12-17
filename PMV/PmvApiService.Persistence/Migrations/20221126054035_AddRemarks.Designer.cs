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
    [Migration("20221126054035_AddRemarks")]
    partial class AddRemarks
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
                            Id = new Guid("6b1c6fe6-973a-4aed-be18-71906b347e27"),
                            Active = true,
                            DepartmentName = "D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("74fc020e-0b0f-432b-8aaa-f56e3c9b4e17"),
                            Active = true,
                            DepartmentName = "D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("1e64f038-9e66-4609-9d11-b4f4e8605349"),
                            Active = true,
                            DepartmentName = "D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("f56b6cad-ef2d-4832-a5b9-39242c75fba9"),
                            Active = true,
                            DepartmentName = "D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7d8ff28f-8e72-41a0-bfd4-62d9a0cfd9ae"),
                            Active = true,
                            DepartmentName = "D171",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7d1e4235-2a0c-414c-97cc-3b87e5ce16e0"),
                            Active = true,
                            DepartmentName = "D183",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("eb1ace3b-c529-4d8e-a6f4-cd136d2d3d1d"),
                            Active = true,
                            DepartmentName = "I201",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("f7f64ecb-16a0-4954-ae69-6507529257bd"),
                            Active = true,
                            DepartmentName = "FULLBORE D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("cad62b72-8adc-4c3e-99a3-a8e0507e7170"),
                            Active = true,
                            DepartmentName = "FULLBORE D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("4fa55934-52b3-4c94-b9c0-a4749ec49eb6"),
                            Active = true,
                            DepartmentName = "FULLBORE D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("fea3a730-6490-4f7a-8898-db9ed55de83b"),
                            Active = true,
                            DepartmentName = "FULLBORE OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("6faee263-f02b-474d-9128-023a17afffdc"),
                            Active = true,
                            DepartmentName = "POLARIS D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("88d81946-dbe2-4eee-bd84-9836e27d92ad"),
                            Active = true,
                            DepartmentName = "UEG D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8cc4c23a-4bc5-492f-9346-82a1463f2d6f"),
                            Active = true,
                            DepartmentName = "UEG D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("2e1348b8-5115-4b24-a126-e25f1e5df283"),
                            Active = true,
                            DepartmentName = "UEG D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8f27bcab-0e37-48b2-808b-60cc2c5cad65"),
                            Active = true,
                            DepartmentName = "TOPROK MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("0b74ad77-e23d-4ec4-a2c4-ca53f040d92a"),
                            Active = true,
                            DepartmentName = "TOPROK WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("22422a6f-9670-4cb9-b280-42b9797028c2"),
                            Active = true,
                            DepartmentName = "TOPROK SHAHANIYA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("727067c1-9c68-4886-aea2-ada4ccad8f20"),
                            Active = true,
                            DepartmentName = "TOPROK OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("078ed4b0-cf87-442d-ac79-a682612a53e0"),
                            Active = true,
                            DepartmentName = "QONCRETE WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("4f5290b3-b462-4371-8d74-c901897b4dd7"),
                            Active = true,
                            DepartmentName = "QONCRETE MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("35cb38a1-7bdb-4231-a2a0-1cdb1f67459c"),
                            Active = true,
                            DepartmentName = "QAP PLANT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("fd3e5a97-7037-44f5-bbbf-286e1cbeed3c"),
                            Active = true,
                            DepartmentName = "ASPHALT CREW",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("aad766da-093c-4480-b96a-7322dcc633b2"),
                            Active = true,
                            DepartmentName = "PMV",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("d755ec95-e734-4f00-9fa3-373e3ad43a0e"),
                            Active = true,
                            DepartmentName = "BRU",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("f9f500db-e0da-440d-837a-d64b4f78850d"),
                            Active = true,
                            DepartmentName = "TRANSPORT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("31dd6507-3780-41f7-b7aa-da07ca59cda1"),
                            Active = true,
                            DepartmentName = "LOGISTICS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("3c94ede4-a799-48f6-9fdb-52f9f9670f6e"),
                            Active = true,
                            DepartmentName = "JERRY CAN/ PROJECT/DEPT.",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("55d54d56-c7f3-4c47-b127-e537f5fa9c5f"),
                            Active = true,
                            DepartmentName = "GAP Plant",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("4132d0d8-0e7d-4c21-973c-c6827c8984f4"),
                            Active = true,
                            DepartmentName = "I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("11dc8bc8-8920-470d-9400-fdcb933dc7e5"),
                            Active = true,
                            DepartmentName = "LUSAIL",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("738faa27-dcda-4a0b-972d-c6d014d9f33f"),
                            Active = true,
                            DepartmentName = "AL THAKIRA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("c510ce54-58bc-4cf4-b552-3f1424128678"),
                            Active = true,
                            DepartmentName = "TOPROK I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("70c3b251-9eda-4579-8e13-6236a02d4b24"),
                            Active = true,
                            DepartmentName = "D211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("d5dfe2ce-ece7-411f-b96e-e02e51605664"),
                            Active = true,
                            DepartmentName = "I203",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9df00ca3-3f44-4bc5-99db-47f86ad5467b"),
                            Active = true,
                            DepartmentName = "Helm Holding W.L.L",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("81338c9d-d25b-4367-b65b-0e430424f45e"),
                            Active = true,
                            DepartmentName = "I216",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9cf0b13b-184b-4c9e-ac06-43dd30dfbb0b"),
                            Active = true,
                            DepartmentName = "I214",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("37b140e9-af59-4a87-84f4-76578b1ed45c"),
                            Active = true,
                            DepartmentName = "I212",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("88e3aaa3-ceb9-4e04-8606-0eb0d1e74e5a"),
                            Active = true,
                            DepartmentName = "I215",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("c238170f-da08-4b5a-9f98-2392037039c1"),
                            Active = true,
                            DepartmentName = "Precast D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("cfe579f2-5b45-4ee0-8387-3f44d78dd8eb"),
                            Active = true,
                            DepartmentName = "I222",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8886c9a8-bfa5-46e4-b3ac-f55cee4bf2c1"),
                            Active = true,
                            DepartmentName = "I224",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("4ab9b492-b0ea-49a5-a7ed-887b1811bf24"),
                            Active = true,
                            DepartmentName = "D211-Wakra",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("cef6333c-3c57-4307-ab40-1ffc3c2e7206"),
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
                            Id = new Guid("3647ac4c-d767-44af-84a3-4ffe015dfdd0"),
                            Active = true,
                            Code = "LV375",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6402),
                            FuelStation = "LV375",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("e2f7aad0-be27-4ceb-be2e-c910db263730"),
                            Active = true,
                            Code = "LV253",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6413),
                            FuelStation = "LV253",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("dbd21c36-5573-4ff9-939b-7aed4c369a3b"),
                            Active = true,
                            Code = "LV215",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6414),
                            FuelStation = "LV215",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("011c5a7b-1ac9-4eca-bbfb-078d3d6c3dc0"),
                            Active = true,
                            Code = "LLV463",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6417),
                            FuelStation = "LLV463",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("34a8dffe-9c48-4557-b5ed-dc24d43b871f"),
                            Active = true,
                            Code = "LLV478",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6418),
                            FuelStation = "LLV478",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("84656cb8-3326-4efa-8333-97e4e3e36709"),
                            Active = true,
                            Code = "LV310",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6419),
                            FuelStation = "LV310",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("20c58f02-d7cb-4a13-8b16-fd647f2725d2"),
                            Active = true,
                            Code = "LV512",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6420),
                            FuelStation = "LV512",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("83bed38e-1116-4631-8b47-6e5cc4bc70fd"),
                            Active = true,
                            Code = "D182Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6421),
                            FuelStation = "D182Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("ae7b8f50-7ee8-4801-8bc3-1bbd41b831cf"),
                            Active = true,
                            Code = "D192Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6423),
                            FuelStation = "D192Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("994c31f0-2b93-4469-9e38-3fb092582114"),
                            Active = true,
                            Code = "QAPMSDStation",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 26, 8, 40, 35, 518, DateTimeKind.Local).AddTicks(6424),
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
                            Id = new Guid("1e82795f-4a48-473f-a740-1dd3b7049736"),
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

            modelBuilder.Entity("PmvApiService.Core.FuelLogs.FuelLogSheet", b =>
                {
                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
