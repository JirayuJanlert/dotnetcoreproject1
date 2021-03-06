﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using authproject.Data;

namespace authproject.Migrations.ProductDb
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20201026091438_product db")]
    partial class productdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("authproject.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("category")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("pic")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("price")
                        .HasColumnType("double");

                    b.Property<string>("size")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("ProductsTb");
                });
#pragma warning restore 612, 618
        }
    }
}
