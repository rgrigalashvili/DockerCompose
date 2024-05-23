﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebService.Entities;

namespace WebService.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240522172110_dbInit")]
    partial class dbInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebService.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}
