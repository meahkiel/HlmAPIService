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
    [Migration("20221120062517_AddFuelResoucesClassification")]
    partial class AddFuelResoucesClassification
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
                            Id = new Guid("a4554e6a-4f33-4406-b4f5-dacf8f087ab3"),
                            Active = true,
                            DepartmentName = "D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("63da48df-953b-43d0-b889-5c99efda93ba"),
                            Active = true,
                            DepartmentName = "D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("07dbca7c-f741-4ef9-9895-de18fec6fa94"),
                            Active = true,
                            DepartmentName = "D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7461c005-20e7-4847-b5db-ba4bc9d6874b"),
                            Active = true,
                            DepartmentName = "D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e7ec8415-46fb-4add-b4bc-c64681246090"),
                            Active = true,
                            DepartmentName = "D171",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e8f32910-1816-4a9f-9a26-df784c2ed842"),
                            Active = true,
                            DepartmentName = "D183",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9aae1748-c736-411b-8f76-fda46d848044"),
                            Active = true,
                            DepartmentName = "I201",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("f3ff55ae-d624-4e57-9129-9cb67fa9c06e"),
                            Active = true,
                            DepartmentName = "FULLBORE D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("ba0fd7d0-aa68-40db-8646-bbd0c095c255"),
                            Active = true,
                            DepartmentName = "FULLBORE D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("25ad51d9-d4d1-4cb7-87bc-f66d9417e717"),
                            Active = true,
                            DepartmentName = "FULLBORE D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("ea406ee5-af53-4d1d-aec9-9059d9a937e0"),
                            Active = true,
                            DepartmentName = "FULLBORE OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("eeb99e21-ffff-4ce6-ab70-39458423cbbc"),
                            Active = true,
                            DepartmentName = "POLARIS D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("bd1e4b78-e8d4-4234-a56d-b13770a683f5"),
                            Active = true,
                            DepartmentName = "UEG D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("af25e87d-41fd-4962-be3e-671d949ea206"),
                            Active = true,
                            DepartmentName = "UEG D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9d5c1004-6447-4cc4-9041-c5a14e7f9cc5"),
                            Active = true,
                            DepartmentName = "UEG D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("322e4f05-8ea0-47c6-a388-5af25502ced2"),
                            Active = true,
                            DepartmentName = "TOPROK MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("11060cc2-7dbd-4223-a751-3dd7cb41118d"),
                            Active = true,
                            DepartmentName = "TOPROK WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("65c38742-1e23-4a11-a35b-dec40f6e8356"),
                            Active = true,
                            DepartmentName = "TOPROK SHAHANIYA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("aa0baa7a-946d-4f92-b296-2f7f4ddde015"),
                            Active = true,
                            DepartmentName = "TOPROK OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("a13da5e7-d079-470d-a414-6b1d781e5e31"),
                            Active = true,
                            DepartmentName = "QONCRETE WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("d5548c71-3ec2-4cb7-b13d-3a37bdb685cd"),
                            Active = true,
                            DepartmentName = "QONCRETE MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("fc5cc894-f484-4954-930e-cd1e70017b2f"),
                            Active = true,
                            DepartmentName = "QAP PLANT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("2bff9001-3e24-4b18-a78b-938fc47cb95f"),
                            Active = true,
                            DepartmentName = "ASPHALT CREW",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("b93bed1d-989a-464c-9471-c780932d844e"),
                            Active = true,
                            DepartmentName = "PMV",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("882f009a-58c0-4488-956e-e3b722c07c72"),
                            Active = true,
                            DepartmentName = "BRU",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("f583a112-3605-4a33-94c0-7d48e4d499fd"),
                            Active = true,
                            DepartmentName = "TRANSPORT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("88dfa9b8-c846-4f18-be60-b0e1876d72cf"),
                            Active = true,
                            DepartmentName = "LOGISTICS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e3942e75-1d4d-423f-8cbe-8b72017251fe"),
                            Active = true,
                            DepartmentName = "JERRY CAN/ PROJECT/DEPT.",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("81dacd2d-0c1a-4b33-880f-869e77f59fa7"),
                            Active = true,
                            DepartmentName = "GAP Plant",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9a165568-f04e-4f3c-a7a6-4e3d7e14b765"),
                            Active = true,
                            DepartmentName = "I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("90b52aa3-173e-4394-a440-debfcdc80270"),
                            Active = true,
                            DepartmentName = "LUSAIL",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("34bc7845-8844-492d-99ae-7ec0342185bf"),
                            Active = true,
                            DepartmentName = "AL THAKIRA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9aa67252-43e3-4d55-8726-4dd0689923a1"),
                            Active = true,
                            DepartmentName = "TOPROK I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("fb37a908-3182-45ff-8e83-1a362a29ee97"),
                            Active = true,
                            DepartmentName = "D211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("503a63ff-ea35-471a-99b4-656c7cac908e"),
                            Active = true,
                            DepartmentName = "I203",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("00712e66-0800-4a77-8271-ebaf25720adb"),
                            Active = true,
                            DepartmentName = "Helm Holding W.L.L",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7f31d8cc-7aea-4fff-b865-3939d1ba1f06"),
                            Active = true,
                            DepartmentName = "I216",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("7721fc01-32ac-484b-bccd-07f81bebcae3"),
                            Active = true,
                            DepartmentName = "I214",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("79c63ebc-2791-484e-9f07-9be83feb906a"),
                            Active = true,
                            DepartmentName = "I212",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("de230386-55bc-4d40-afdb-fb5f65f7aaf3"),
                            Active = true,
                            DepartmentName = "I215",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("d8036e55-58e8-4f45-9622-3d8df99cb1ec"),
                            Active = true,
                            DepartmentName = "Precast D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("f9f9d6c6-eac7-48f9-8c12-a3d227396c65"),
                            Active = true,
                            DepartmentName = "I222",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("3f2576af-7070-41b3-9927-26ef1012ae2d"),
                            Active = true,
                            DepartmentName = "I224",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("3b6a9dd8-62e5-4253-8435-910e184735ee"),
                            Active = true,
                            DepartmentName = "D211-Wakra",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("bf6aa1d3-d9c7-48dc-ad4d-494aa9bdb5f7"),
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
                            Id = new Guid("fe7738cd-09bf-4245-8242-600c0a36cb56"),
                            Active = true,
                            Code = "LV375",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6788),
                            FuelStation = "LV375",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("614877ba-50a3-4dba-a873-c6328d3f2fb0"),
                            Active = true,
                            Code = "LV253",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6804),
                            FuelStation = "LV253",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("42570324-c924-4d2a-a166-89ec5fc0e3f9"),
                            Active = true,
                            Code = "LV215",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6809),
                            FuelStation = "LV215",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("8f47b054-5ac5-421d-b709-81f30e61899a"),
                            Active = true,
                            Code = "LLV463",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6810),
                            FuelStation = "LLV463",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("c0575051-70cd-4e23-a457-836facad1736"),
                            Active = true,
                            Code = "LLV478",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6811),
                            FuelStation = "LLV478",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("47152183-13b9-4d5f-a341-5a0894ee5677"),
                            Active = true,
                            Code = "LV310",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6812),
                            FuelStation = "LV310",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("9019db24-ec15-4e8d-9c63-b26f413854e6"),
                            Active = true,
                            Code = "LV512",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6813),
                            FuelStation = "LV512",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("c2cde0e5-ddd2-41c7-b0d6-7674c9c95d50"),
                            Active = true,
                            Code = "D182Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6814),
                            FuelStation = "D182Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("27a4ded8-d9d2-4f00-8c6e-cba03df5f8dd"),
                            Active = true,
                            Code = "D192Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6815),
                            FuelStation = "D192Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("025646c0-7a75-4ca1-a0a8-6f4fdd305e18"),
                            Active = true,
                            Code = "QAPMSDStation",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 20, 9, 25, 17, 501, DateTimeKind.Local).AddTicks(6817),
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
