﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValhallaVaultCyberGroup.Ui.Data;

#nullable disable

namespace ValhallaVaultCyberGroup.Ui.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240304185940_testMigration")]
    partial class testMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("ResultId")
                        .HasColumnType("int");

                    b.Property<int?>("ResultModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResultModelId");

                    b.ToTable("ResultCategories");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultQuestionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionNumber")
                        .HasColumnType("int");

                    b.Property<int>("ResultSubCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ResultSubCategoryModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResultSubCategoryModelId");

                    b.ToTable("ResultQuestions");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultSegmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("ResultCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ResultCategoryModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResultCategoryModelId");

                    b.ToTable("ResultSegments");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultSubCategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("ResultSegmentId")
                        .HasColumnType("int");

                    b.Property<int?>("ResultSegmentModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResultSegmentModelId");

                    b.ToTable("ResultSubCategories");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("Results");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Ui.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ValhallaVaultCyberGroup.Ui.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ValhallaVaultCyberGroup.Ui.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ValhallaVaultCyberGroup.Ui.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ValhallaVaultCyberGroup.Ui.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel", b =>
                {
                    b.HasOne("ValhallaVaultCyberGroup.Data.Models.Result.ResultModel", null)
                        .WithMany("ResultsCategories")
                        .HasForeignKey("ResultModelId");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultQuestionModel", b =>
                {
                    b.HasOne("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultSubCategoryModel", null)
                        .WithMany("ResultQuestions")
                        .HasForeignKey("ResultSubCategoryModelId");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultSegmentModel", b =>
                {
                    b.HasOne("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel", null)
                        .WithMany("ResultSegments")
                        .HasForeignKey("ResultCategoryModelId");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultSubCategoryModel", b =>
                {
                    b.HasOne("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultSegmentModel", null)
                        .WithMany("ResultSubCategories")
                        .HasForeignKey("ResultSegmentModelId");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultModel", b =>
                {
                    b.HasOne("ValhallaVaultCyberGroup.Ui.Data.ApplicationUser", "User")
                        .WithOne("Result")
                        .HasForeignKey("ValhallaVaultCyberGroup.Data.Models.Result.ResultModel", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel", b =>
                {
                    b.Navigation("ResultSegments");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultSegmentModel", b =>
                {
                    b.Navigation("ResultSubCategories");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultCategoryModel+ResultSubCategoryModel", b =>
                {
                    b.Navigation("ResultQuestions");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Data.Models.Result.ResultModel", b =>
                {
                    b.Navigation("ResultsCategories");
                });

            modelBuilder.Entity("ValhallaVaultCyberGroup.Ui.Data.ApplicationUser", b =>
                {
                    b.Navigation("Result")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
