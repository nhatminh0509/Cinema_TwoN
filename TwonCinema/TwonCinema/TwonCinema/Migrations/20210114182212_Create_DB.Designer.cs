﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwonCinema.Areas.Admin.Data;

namespace TwonCinema.Migrations
{
    [DbContext(typeof(DPContext))]
    [Migration("20210114182212_Create_DB")]
    partial class Create_DB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<int>("Show_ID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Total_Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Customer_ID");

                    b.HasIndex("Show_ID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.BookingDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Booking_ID")
                        .HasColumnType("int");

                    b.Property<int>("Seat_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Booking_ID");

                    b.HasIndex("Seat_ID");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Category_Equipment", b =>
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

                    b.ToTable("Category_Equipment");
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

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Total_Spending")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Equipment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Col_ID")
                        .HasColumnType("int");

                    b.Property<int>("Equipment_Level_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Room_ID")
                        .HasColumnType("int");

                    b.Property<int>("Row_ID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Equipment_Level_ID");

                    b.HasIndex("Room_ID");

                    b.ToTable("Equipments");
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

                    b.Property<string>("Image_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keyword")
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

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Booking", b =>
                {
                    b.HasOne("TwonCinema.Areas.Admin.Models.Customer", "Customer")
                        .WithMany("listBooking")
                        .HasForeignKey("Customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TwonCinema.Areas.Admin.Models.Movie_Show", "Movie_Show")
                        .WithMany("listBooking")
                        .HasForeignKey("Show_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Movie_Show");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.BookingDetail", b =>
                {
                    b.HasOne("TwonCinema.Areas.Admin.Models.Booking", "Booking")
                        .WithMany("listBookingDetail")
                        .HasForeignKey("Booking_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TwonCinema.Areas.Admin.Models.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("Seat_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Equipment");
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

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Equipment", b =>
                {
                    b.HasOne("TwonCinema.Areas.Admin.Models.Category_Equipment", "Category_Equipment")
                        .WithMany("listEquipment")
                        .HasForeignKey("Equipment_Level_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TwonCinema.Areas.Admin.Models.Room", "Room")
                        .WithMany("listMaterials")
                        .HasForeignKey("Room_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category_Equipment");

                    b.Navigation("Room");
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

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Booking", b =>
                {
                    b.Navigation("listBookingDetail");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Category_Equipment", b =>
                {
                    b.Navigation("listEquipment");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Cinema", b =>
                {
                    b.Navigation("listRoom");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Customer", b =>
                {
                    b.Navigation("listBooking");
                });

            modelBuilder.Entity("TwonCinema.Areas.Admin.Models.Movie_Show", b =>
                {
                    b.Navigation("listBooking");
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