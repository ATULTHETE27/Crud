﻿// <auto-generated />
using System;
using Asp.netCoreMVCIntro.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asp.netCoreMVCIntro.Migrations
{
    [DbContext(typeof(CollageDbContext))]
    [Migration("20231226173458_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asp.netCoreMVCIntro.Models.Collage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Collage_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Collages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Adgoan",
                            Code = 4047,
                            Collage_Name = "MET",
                            Grade = "B++"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Gangapur Road",
                            Code = 4039,
                            Collage_Name = "NDMVP",
                            Grade = "A++"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Amrutdham",
                            Code = 4043,
                            Collage_Name = "KKW",
                            Grade = "A++"
                        });
                });

            modelBuilder.Entity("Asp.netCoreMVCIntro.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CollageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollageId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CollageId = 1,
                            DOB = new DateTime(2003, 1, 27, 17, 20, 0, 0, DateTimeKind.Unspecified),
                            First_Name = "Atul",
                            Last_Name = "Thete",
                            Percentage = 90
                        },
                        new
                        {
                            Id = 2,
                            CollageId = 1,
                            DOB = new DateTime(2003, 1, 27, 17, 20, 0, 0, DateTimeKind.Unspecified),
                            First_Name = "Ankit",
                            Last_Name = "Sharma",
                            Percentage = 85
                        },
                        new
                        {
                            Id = 3,
                            CollageId = 2,
                            DOB = new DateTime(2002, 7, 2, 6, 50, 0, 0, DateTimeKind.Unspecified),
                            First_Name = "Pranjal",
                            Last_Name = "Thorat",
                            Percentage = 88
                        },
                        new
                        {
                            Id = 4,
                            CollageId = 2,
                            DOB = new DateTime(2002, 11, 6, 23, 20, 0, 0, DateTimeKind.Unspecified),
                            First_Name = "Aditi",
                            Last_Name = "Bhawsar",
                            Percentage = 82
                        },
                        new
                        {
                            Id = 5,
                            CollageId = 3,
                            DOB = new DateTime(2003, 2, 8, 9, 20, 0, 0, DateTimeKind.Unspecified),
                            First_Name = "Lalit",
                            Last_Name = "Pagar",
                            Percentage = 89
                        },
                        new
                        {
                            Id = 6,
                            CollageId = 3,
                            DOB = new DateTime(2002, 4, 6, 15, 20, 0, 0, DateTimeKind.Unspecified),
                            First_Name = "Abhijeet",
                            Last_Name = "Bhaskar",
                            Percentage = 84
                        });
                });

            modelBuilder.Entity("Asp.netCoreMVCIntro.Models.Student", b =>
                {
                    b.HasOne("Asp.netCoreMVCIntro.Models.Collage", "Collage")
                        .WithMany("Students")
                        .HasForeignKey("CollageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collage");
                });

            modelBuilder.Entity("Asp.netCoreMVCIntro.Models.Collage", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
