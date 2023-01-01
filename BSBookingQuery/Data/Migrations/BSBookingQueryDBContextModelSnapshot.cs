﻿// <auto-generated />
using System;
using BSBookingQuery.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BSBookingQuery.Data.Migrations
{
    [DbContext(typeof(BSBookingQueryDBContext))]
    partial class BSBookingQueryDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.CommentHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("CommentHistories");
                });

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("HotelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LabelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ratings")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("LabelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.Label", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.CommentHistory", b =>
                {
                    b.HasOne("BSBookingQuery.Domain.Entities.Hotel", "Hotel")
                        .WithMany("CommentHistories")
                        .HasForeignKey("HotelId");

                    b.HasOne("BSBookingQuery.Domain.Entities.User", "User")
                        .WithMany("CommentHistories")
                        .HasForeignKey("UserId");

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.Hotel", b =>
                {
                    b.HasOne("BSBookingQuery.Domain.Entities.Label", "Label")
                        .WithMany("Hotels")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Label");
                });

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.Hotel", b =>
                {
                    b.Navigation("CommentHistories");
                });

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.Label", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("BSBookingQuery.Domain.Entities.User", b =>
                {
                    b.Navigation("CommentHistories");
                });
#pragma warning restore 612, 618
        }
    }
}