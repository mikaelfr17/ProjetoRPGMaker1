﻿// <auto-generated />
using System;
using DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAO.Migrations
{
    [DbContext(typeof(RPGContext))]
    [Migration("20200326005914_RPGMakerUpdate1")]
    partial class RPGMakerUpdate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DTO.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RPGCreatedID")
                        .HasColumnType("int");

                    b.Property<int>("RaceID")
                        .HasColumnType("int");

                    b.Property<int>("TerritoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClassID");

                    b.HasIndex("ItemID");

                    b.HasIndex("RPGCreatedID");

                    b.HasIndex("RaceID");

                    b.HasIndex("TerritoryID");

                    b.ToTable("CHARACTERS");
                });

            modelBuilder.Entity("DTO.Class", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RPGCreatedID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RPGCreatedID");

                    b.ToTable("CLASSES");
                });

            modelBuilder.Entity("DTO.Creature", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<int>("CreatureType")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RPGCreatedID")
                        .HasColumnType("int");

                    b.Property<int>("RaceID")
                        .HasColumnType("int");

                    b.Property<int>("TerritoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClassID");

                    b.HasIndex("ItemID");

                    b.HasIndex("RPGCreatedID");

                    b.HasIndex("RaceID");

                    b.HasIndex("TerritoryID");

                    b.ToTable("CREATURES");
                });

            modelBuilder.Entity("DTO.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Effect")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RPGCreatedID")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RPGCreatedID");

                    b.ToTable("ITEMS");
                });

            modelBuilder.Entity("DTO.RPGCreated", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RPGS");
                });

            modelBuilder.Entity("DTO.Race", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RPGCreatedID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RPGCreatedID");

                    b.ToTable("RACES");
                });

            modelBuilder.Entity("DTO.Territory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RPGCreatedID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RPGCreatedID");

                    b.ToTable("TERRITORIES");
                });

            modelBuilder.Entity("DTO.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("DTO.Character", b =>
                {
                    b.HasOne("DTO.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.RPGCreated", null)
                        .WithMany("Character")
                        .HasForeignKey("RPGCreatedID");

                    b.HasOne("DTO.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.Territory", "HomeTerritory")
                        .WithMany()
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.Class", b =>
                {
                    b.HasOne("DTO.RPGCreated", null)
                        .WithMany("Classes")
                        .HasForeignKey("RPGCreatedID");
                });

            modelBuilder.Entity("DTO.Creature", b =>
                {
                    b.HasOne("DTO.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.RPGCreated", null)
                        .WithMany("Creature")
                        .HasForeignKey("RPGCreatedID");

                    b.HasOne("DTO.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.Territory", "HomeTerritory")
                        .WithMany()
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DTO.Item", b =>
                {
                    b.HasOne("DTO.RPGCreated", null)
                        .WithMany("Item")
                        .HasForeignKey("RPGCreatedID");
                });

            modelBuilder.Entity("DTO.Race", b =>
                {
                    b.HasOne("DTO.RPGCreated", null)
                        .WithMany("Race")
                        .HasForeignKey("RPGCreatedID");
                });

            modelBuilder.Entity("DTO.Territory", b =>
                {
                    b.HasOne("DTO.RPGCreated", null)
                        .WithMany("Territory")
                        .HasForeignKey("RPGCreatedID");
                });
#pragma warning restore 612, 618
        }
    }
}