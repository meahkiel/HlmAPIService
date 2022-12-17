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
    [Migration("20221122130220_SeedDataAll")]
    partial class SeedDataAll
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
                            Id = new Guid("c22ffc4a-5284-4eaa-b5aa-2012cc32a1ad"),
                            Active = true,
                            DepartmentName = "D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8754d162-bd94-4017-9f41-0feeca6f7711"),
                            Active = true,
                            DepartmentName = "D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8b7d20f1-5d97-44bd-b408-962b8ae9cbbe"),
                            Active = true,
                            DepartmentName = "D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("095845fa-0074-4e53-af16-cd1c68baa5c6"),
                            Active = true,
                            DepartmentName = "D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("63f1d2e3-f696-4169-8bad-e201fa739ce9"),
                            Active = true,
                            DepartmentName = "D171",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("2b8e25c0-243e-49bd-b962-24db4bacb2a1"),
                            Active = true,
                            DepartmentName = "D183",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("20f4d2c1-7d2f-48c1-b72a-0851c5b65fa0"),
                            Active = true,
                            DepartmentName = "I201",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("191d443c-06c3-4ec0-9960-887efb59e98a"),
                            Active = true,
                            DepartmentName = "FULLBORE D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("127c92eb-a519-4ab4-9959-0ea999ba8a15"),
                            Active = true,
                            DepartmentName = "FULLBORE D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("750f54f5-856b-43a7-8bb4-8fc59afe35d5"),
                            Active = true,
                            DepartmentName = "FULLBORE D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("c270021b-a849-4808-8d6c-b6ca20155a9b"),
                            Active = true,
                            DepartmentName = "FULLBORE OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("b7f4ec3f-d865-41c0-b055-a52ca03bedfa"),
                            Active = true,
                            DepartmentName = "POLARIS D172",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("d7a3d44f-747f-40fb-a131-c25c557837b7"),
                            Active = true,
                            DepartmentName = "UEG D191",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("cd246411-df2d-4aaf-a351-86d17fb5e603"),
                            Active = true,
                            DepartmentName = "UEG D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("a5dcd5a9-3883-4731-b99b-4323cf0acfcc"),
                            Active = true,
                            DepartmentName = "UEG D182",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("cf79ca30-5cb1-4652-81a9-7ec0bebdae4e"),
                            Active = true,
                            DepartmentName = "TOPROK MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("2f8650ef-f783-4dda-83a3-7e16191b8fff"),
                            Active = true,
                            DepartmentName = "TOPROK WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("95bae152-5169-4aea-a936-588f23b87006"),
                            Active = true,
                            DepartmentName = "TOPROK SHAHANIYA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("4b47d9a1-9286-43f8-8352-d2bcdec7bc67"),
                            Active = true,
                            DepartmentName = "TOPROK OTHERS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("225da246-3f17-4f29-a441-91324112f580"),
                            Active = true,
                            DepartmentName = "QONCRETE WUKAIR",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("434fde8c-b690-4ae0-b770-011409385f6d"),
                            Active = true,
                            DepartmentName = "QONCRETE MAZRUA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("8123a56c-7bc9-44c5-9fe9-fafe8f59b9f2"),
                            Active = true,
                            DepartmentName = "QAP PLANT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9bd1ab1e-9271-477a-8dfb-ba194a752846"),
                            Active = true,
                            DepartmentName = "ASPHALT CREW",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("1c70c610-d044-4b77-9095-f8acf92a1c5f"),
                            Active = true,
                            DepartmentName = "PMV",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("59706bcf-8bb4-46af-b968-df0d0f993160"),
                            Active = true,
                            DepartmentName = "BRU",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("6ad5f720-2732-4cf9-9104-c0bac42162ab"),
                            Active = true,
                            DepartmentName = "TRANSPORT",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("99a22481-0636-4dbe-9910-20c79215d9b7"),
                            Active = true,
                            DepartmentName = "LOGISTICS",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("582f2a9b-1e66-4303-9da5-e401ae66d233"),
                            Active = true,
                            DepartmentName = "JERRY CAN/ PROJECT/DEPT.",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("d89ed786-b64d-4845-862c-0527363aeb27"),
                            Active = true,
                            DepartmentName = "GAP Plant",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("b2125c65-1c1a-43ac-9a92-da45d7cc9493"),
                            Active = true,
                            DepartmentName = "I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("a776cefc-06fe-4929-93d8-7791e896cb52"),
                            Active = true,
                            DepartmentName = "LUSAIL",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e4ae159e-4471-4824-a43a-5550d67d22f8"),
                            Active = true,
                            DepartmentName = "AL THAKIRA",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("dd69f33f-b3e9-4b8d-8b3b-805e3c43b980"),
                            Active = true,
                            DepartmentName = "TOPROK I211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("9440b735-c9db-47a1-9080-11f23451fbf0"),
                            Active = true,
                            DepartmentName = "D211",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("01870d6e-5c3c-44bf-bfa4-72af14d7995a"),
                            Active = true,
                            DepartmentName = "I203",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("35c06064-4a02-42d4-b725-3187106811ea"),
                            Active = true,
                            DepartmentName = "Helm Holding W.L.L",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("01e06275-b2c5-4a1c-9def-f8ea8ba642d5"),
                            Active = true,
                            DepartmentName = "I216",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("0860c3f4-f8ba-4879-a7ba-7e2d55602893"),
                            Active = true,
                            DepartmentName = "I214",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("5db6778c-9cbb-4aef-b14b-f1bd03c37dc6"),
                            Active = true,
                            DepartmentName = "I212",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("3d0e35ab-d7d8-44bb-92b4-ed9144c6b23f"),
                            Active = true,
                            DepartmentName = "I215",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("e394480f-ed9d-45a7-a6bf-7f5cda7bee73"),
                            Active = true,
                            DepartmentName = "Precast D192",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("a4c0a445-5f8f-4171-af27-38f9aa95e3e1"),
                            Active = true,
                            DepartmentName = "I222",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("bcca1b2e-bd90-4434-ba71-d335491cc1fe"),
                            Active = true,
                            DepartmentName = "I224",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("0913c186-38c6-46f1-bbb5-f4de344e190a"),
                            Active = true,
                            DepartmentName = "D211-Wakra",
                            SurCharge = 0f
                        },
                        new
                        {
                            Id = new Guid("874c1cc7-e479-4a8d-b7d6-be5230228d1b"),
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
                            Id = new Guid("005cc361-9dd0-43ac-a1c7-533b00083af3"),
                            Active = true,
                            Code = "LV375",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(253),
                            FuelStation = "LV375",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("a929c822-c3d0-47fe-b311-6b6d7b1e359a"),
                            Active = true,
                            Code = "LV253",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(264),
                            FuelStation = "LV253",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("0087173b-cdcf-4a57-a85c-73e87cd3262e"),
                            Active = true,
                            Code = "LV215",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(266),
                            FuelStation = "LV215",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("69621414-3f75-4426-9f0d-45f422c135b0"),
                            Active = true,
                            Code = "LLV463",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(267),
                            FuelStation = "LLV463",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("cad09149-3c99-4cd3-a880-32c2015398b2"),
                            Active = true,
                            Code = "LLV478",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(270),
                            FuelStation = "LLV478",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("b201d60f-fa68-4c8f-a606-49379f6c544f"),
                            Active = true,
                            Code = "LV310",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(272),
                            FuelStation = "LV310",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("6d6c62dd-5173-4f9b-b0fb-c4c17962fbb6"),
                            Active = true,
                            Code = "LV512",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(273),
                            FuelStation = "LV512",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("27accaba-9fa5-43cc-a1e0-09a529c2e568"),
                            Active = true,
                            Code = "D182Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(274),
                            FuelStation = "D182Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("1d2d38da-436a-4be4-933d-fd0d67f13cf2"),
                            Active = true,
                            Code = "D192Station",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(275),
                            FuelStation = "D192Station",
                            FueledTo = "",
                            Operator = "",
                            PreviousFuelQuantity = 0f
                        },
                        new
                        {
                            Id = new Guid("28eb0ef7-dba7-4523-b85c-167d84ad8707"),
                            Active = true,
                            Code = "QAPMSDStation",
                            CurrentFuelQuantity = 0f,
                            FuelDate = new DateTime(2022, 11, 22, 16, 2, 20, 7, DateTimeKind.Local).AddTicks(276),
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
                            Id = new Guid("8d898198-22fe-493d-9f3b-33155a9e68a1"),
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