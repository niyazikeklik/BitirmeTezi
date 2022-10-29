﻿// <auto-generated />
using System;
using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DTO.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Entity.Conc.Haber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Kategori")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Kaynak")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Haberler");
                });
#pragma warning restore 612, 618
        }
    }
}