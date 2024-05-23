﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelMapTurkey.Data.Context;

#nullable disable

namespace TravelMapTurkey.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240523081719_EntityBaseEditting")]
    partial class EntityBaseEditting
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "123123123",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "223123123",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            Biography = "Test biography",
                            ConcurrencyStamp = "f471c92d-4100-4c62-913f-5ea0a6de1c48",
                            Email = "test@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "User",
                            LastName = "Test",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@GMAIL.COM",
                            NormalizedUserName = "TEST@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIbDQkMK99smQB4glJV5oEyeUBmOmToKVgzH9bLTzV3zyQ4T7u9UDgmI5luaN9/IRw==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "12345678901",
                            TwoFactorEnabled = false,
                            UserName = "test@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            Biography = "Admin biography",
                            ConcurrencyStamp = "302c5445-365e-4aca-8205-44ec81f91810",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Test",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGN/yCrtFUQtCVMJEfcbKj/9icp8c2t8ZnwHtPVkFDYGZappgrfDKfUFiOiDBFhPSw==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "1234567890",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 2,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Ankara",
                            CreatedDate = new DateTime(2024, 5, 23, 11, 17, 18, 835, DateTimeKind.Local).AddTicks(7608),
                            IsDeleted = false,
                            Type = "Visit",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Antalya",
                            CreatedDate = new DateTime(2024, 5, 23, 11, 17, 18, 835, DateTimeKind.Local).AddTicks(7622),
                            IsDeleted = false,
                            Type = "Visit",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.CityReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.HasKey("Id");

                    b.HasIndex("CityId")
                        .IsUnique();

                    b.ToTable("CityReviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            CreatedDate = new DateTime(2024, 5, 23, 11, 17, 18, 835, DateTimeKind.Local).AddTicks(9453),
                            IsDeleted = false,
                            Review = "Kalabalık bir şehir"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            CreatedDate = new DateTime(2024, 5, 23, 11, 17, 18, 835, DateTimeKind.Local).AddTicks(9458),
                            IsDeleted = false,
                            Review = "Güzel bir şehir"
                        });
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityReviewId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CityReviewId")
                        .IsUnique();

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityReviewId = 1,
                            CreatedDate = new DateTime(2024, 5, 23, 11, 17, 18, 836, DateTimeKind.Local).AddTicks(960),
                            FileName = "post_images/image1",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CityReviewId = 2,
                            CreatedDate = new DateTime(2024, 5, 23, 11, 17, 18, 836, DateTimeKind.Local).AddTicks(962),
                            FileName = "post_images/image2",
                            FileType = "jpg",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("TravelMapTurkey.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("TravelMapTurkey.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("TravelMapTurkey.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("TravelMapTurkey.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelMapTurkey.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("TravelMapTurkey.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.City", b =>
                {
                    b.HasOne("TravelMapTurkey.Entity.Entities.AppUser", "User")
                        .WithMany("Cities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.CityReview", b =>
                {
                    b.HasOne("TravelMapTurkey.Entity.Entities.City", "City")
                        .WithOne("CityReview")
                        .HasForeignKey("TravelMapTurkey.Entity.Entities.CityReview", "CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.Image", b =>
                {
                    b.HasOne("TravelMapTurkey.Entity.Entities.CityReview", "CityReview")
                        .WithOne("Image")
                        .HasForeignKey("TravelMapTurkey.Entity.Entities.Image", "CityReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CityReview");
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.City", b =>
                {
                    b.Navigation("CityReview")
                        .IsRequired();
                });

            modelBuilder.Entity("TravelMapTurkey.Entity.Entities.CityReview", b =>
                {
                    b.Navigation("Image")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
