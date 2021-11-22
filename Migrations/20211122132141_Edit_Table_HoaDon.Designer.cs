﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCORE.Data;

namespace DemoNetCore.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20211122132141_Edit_Table_HoaDon")]
    partial class Edit_Table_HoaDon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("NETCORE.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("NETCORE.Models.KetQua", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diem")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaMonHocID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("KetQuas");
                });

            modelBuilder.Entity("NETCORE.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("NETCORE.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("NETCORE.Models.PhieuXuat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgayXuat")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("PhieuXuats");
                });

            modelBuilder.Entity("NETCORE.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("NETCORE.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("NETCORE.Models.DonHang", b =>
                {
                    b.HasBaseType("NETCORE.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("DonHangID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.ToTable("Persons");

                    b.HasDiscriminator().HasValue("DonHang");
                });

            modelBuilder.Entity("NETCORE.Models.HoaDon", b =>
                {
                    b.HasBaseType("NETCORE.Models.Product");

                    b.Property<string>("IdHoaDon")
                        .HasColumnType("TEXT");

                    b.Property<string>("NhanVien")
                        .HasColumnType("TEXT");

                    b.ToTable("Products");

                    b.HasDiscriminator().HasValue("HoaDon");
                });

            modelBuilder.Entity("NETCORE.Models.KetQua", b =>
                {
                    b.HasOne("NETCORE.Models.Student", "Student")
                        .WithMany("KetQuas")
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("NETCORE.Models.PhieuXuat", b =>
                {
                    b.HasOne("NETCORE.Models.Product", "Product")
                        .WithMany("PhieuXuats")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NETCORE.Models.Product", b =>
                {
                    b.Navigation("PhieuXuats");
                });

            modelBuilder.Entity("NETCORE.Models.Student", b =>
                {
                    b.Navigation("KetQuas");
                });
#pragma warning restore 612, 618
        }
    }
}
