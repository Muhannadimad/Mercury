﻿// <auto-generated />
using Mercury.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Mercury.Migrations
{
    [DbContext(typeof(MercuryContext))]
    [Migration("20200916205819_addcolumn")]
    partial class addcolumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Mercury.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Mercury.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("Image");

                    b.Property<int>("Price");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Mercury.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}