﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreapplication.Data;

#nullable disable

namespace coreapplication.Migrations
{
    [DbContext(typeof(walkDbContext))]
    [Migration("20240522172701_db entity")]
    partial class dbentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("coreapplication.Model.Domain.Dificulity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("difficulities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e976a513-58fd-4baf-8add-8f239685dc5e"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("eca63935-cee2-4219-924d-9786d4357956"),
                            Name = "difficult"
                        });
                });

            modelBuilder.Entity("coreapplication.Model.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regionimageurl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b15305fb-dded-4261-9530-a3dd6f2f5d43"),
                            Code = "def",
                            Name = "Easy",
                            Regionimageurl = "image/s.gif"
                        },
                        new
                        {
                            Id = new Guid("7662e6da-e2d8-4922-be8e-ee2f9229a433"),
                            Code = "ghi",
                            Name = "difficult",
                            Regionimageurl = "images/u.gif"
                        });
                });

            modelBuilder.Entity("coreapplication.Model.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DificulityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Lengthinkm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("walkimageurl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DificulityId");

                    b.HasIndex("RegionId");

                    b.ToTable("walks");
                });

            modelBuilder.Entity("coreapplication.Model.Domain.Walk", b =>
                {
                    b.HasOne("coreapplication.Model.Domain.Dificulity", "Dificulity")
                        .WithMany()
                        .HasForeignKey("DificulityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("coreapplication.Model.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dificulity");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
