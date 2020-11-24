﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwonCinema.Areas.Admin.Data;

namespace TwonCinema.Migrations
{
    [DbContext(typeof(DPContext))]
    partial class DPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Category_Materials", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count_Cell")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_Checked")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_Selected")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Category_Materials");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Cinema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Manager_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Manager_ID");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Materials", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Col_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Room_ID")
                        .HasColumnType("int");

                    b.Property<int>("Row_ID")
                        .HasColumnType("int");

                    b.Property<int>("Seat_Level_ID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Room_ID");

                    b.HasIndex("Seat_Level_ID");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Directors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Running_Time")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Movie_Show", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Movie_ID")
                        .HasColumnType("int");

                    b.Property<int>("Room_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_Show")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Movie_ID");

                    b.HasIndex("Room_ID");

                    b.ToTable("Movie_Shows");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("Cinema_ID")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Cinema_ID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Staf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Stafs");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Cinema", b =>
                {
                    b.HasOne("TwonCinema.Areas.Admin.Models.Staf", "Staf")
                        .WithMany("listCinema")
                        .HasForeignKey("Manager_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staf");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Materials", b =>
                {
                    b.HasOne("TwonCinema.Areas.Admin.Models.Room", "Room")
                        .WithMany("listMaterials")
                        .HasForeignKey("Room_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TwonCinema.Areas.Admin.Models.Category_Materials", "Seat_Level")
                        .WithMany("listMaterials")
                        .HasForeignKey("Seat_Level_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("Seat_Level");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Movie_Show", b =>
                {
                    b.HasOne("TwonCinema.Areas.Admin.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("Movie_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TwonCinema.Areas.Admin.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("Room_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Room", b =>
                {
                    b.HasOne("TwonCinema.Areas.Admin.Models.Cinema", "Cinema")
                        .WithMany("listRoom")
                        .HasForeignKey("Cinema_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Category_Materials", b =>
                {
                    b.Navigation("listMaterials");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Cinema", b =>
                {
                    b.Navigation("listRoom");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Room", b =>
                {
                    b.Navigation("listMaterials");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Staf", b =>
                {
                    b.Navigation("listCinema");
                });
#pragma warning restore 612, 618
        }
    }
}
