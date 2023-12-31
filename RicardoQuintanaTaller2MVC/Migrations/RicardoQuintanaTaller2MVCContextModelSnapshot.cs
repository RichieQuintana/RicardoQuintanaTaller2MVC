﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RicardoQuintanaTaller2MVC.Data;

#nullable disable

namespace RicardoQuintanaTaller2MVC.Migrations
{
    [DbContext(typeof(RicardoQuintanaTaller2MVCContext))]
    partial class RicardoQuintanaTaller2MVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RicardoQuintanaTaller2MVC.Models.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithCheese")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Burger");
                });

            modelBuilder.Entity("RicardoQuintanaTaller2MVC.Models.Promo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("BurgerId")
                        .HasColumnType("int");

                    b.Property<string>("PromoDescripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PromoId")
                        .HasColumnType("int");

                    b.Property<string>("PromoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("BurgerId");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("RicardoQuintanaTaller2MVC.Models.Promo", b =>
                {
                    b.HasOne("RicardoQuintanaTaller2MVC.Models.Burger", "Burger")
                        .WithMany("Promo")
                        .HasForeignKey("BurgerId");

                    b.Navigation("Burger");
                });

            modelBuilder.Entity("RicardoQuintanaTaller2MVC.Models.Burger", b =>
                {
                    b.Navigation("Promo");
                });
#pragma warning restore 612, 618
        }
    }
}
