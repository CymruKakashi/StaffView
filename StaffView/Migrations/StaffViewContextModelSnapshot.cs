﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StaffView.Data;

namespace StaffView.Migrations
{
    [DbContext(typeof(StaffViewContext))]
    partial class StaffViewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StaffView.Data.Models.Employee", b =>
                {
                    b.Property<int>("Nodeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeskNumber")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OutOfOffice")
                        .HasColumnType("bit");

                    b.Property<int?>("Parent")
                        .HasColumnType("int");

                    b.HasKey("Nodeid");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}