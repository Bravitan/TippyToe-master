﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TippyToe.Models;

namespace TippyToe.Migrations
{
    [DbContext(typeof(TippyToeContext))]
    partial class TippyToeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TippyToe.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColorName");

                    b.Property<int?>("ShoesId");

                    b.HasKey("Id");

                    b.HasIndex("ShoesId");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("TippyToe.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("TippyToe.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerId");

                    b.Property<int>("OrderDate");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TippyToe.Models.OrderShoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrdersId");

                    b.Property<int>("Quantity");

                    b.Property<int?>("ShoesId");

                    b.HasKey("Id");

                    b.HasIndex("OrdersId");

                    b.HasIndex("ShoesId");

                    b.ToTable("OrderShoes");
                });

            modelBuilder.Entity("TippyToe.Models.Shoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Gender");

                    b.Property<double>("Price");

                    b.Property<string>("Style");

                    b.HasKey("Id");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("TippyToe.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ShoesId");

                    b.Property<string>("SizeNumber");

                    b.HasKey("Id");

                    b.HasIndex("ShoesId");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("TippyToe.Models.Color", b =>
                {
                    b.HasOne("TippyToe.Models.Shoes")
                        .WithMany("Color")
                        .HasForeignKey("ShoesId");
                });

            modelBuilder.Entity("TippyToe.Models.Orders", b =>
                {
                    b.HasOne("TippyToe.Models.Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("TippyToe.Models.OrderShoes", b =>
                {
                    b.HasOne("TippyToe.Models.Orders")
                        .WithMany("OrderShoes")
                        .HasForeignKey("OrdersId");

                    b.HasOne("TippyToe.Models.Shoes")
                        .WithMany("OrderShoes")
                        .HasForeignKey("ShoesId");
                });

            modelBuilder.Entity("TippyToe.Models.Size", b =>
                {
                    b.HasOne("TippyToe.Models.Shoes")
                        .WithMany("Size")
                        .HasForeignKey("ShoesId");
                });
#pragma warning restore 612, 618
        }
    }
}
