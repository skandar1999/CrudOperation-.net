﻿// <auto-generated />
using System;
using CrudOperation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudOperation.Migrations
{
    [DbContext(typeof(ArticleContext))]
    [Migration("20240626161242_ArticleTable")]
    partial class ArticleTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudOperation.Models.Article", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArticleGroup1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleGroup2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleGroup3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleGroup4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleGroup5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guarantee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ItemNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductFamily")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchasePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qtystep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Warranty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
