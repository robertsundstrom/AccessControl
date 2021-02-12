﻿// <auto-generated />
using System;
using AppService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppService.Persistence.Migrations
{
    [DbContext(typeof(AccessControlContext))]
    [Migration("20190713220906_AddItemEntity")]
    partial class AddItemEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("AppService.Domain.Entities.AccessList", b =>
                {
                    b.Property<Guid>("AccessListId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AccessListId");

                    b.ToTable("AccessLists");
                });

            modelBuilder.Entity("AppService.Domain.Entities.AccessLog", b =>
                {
                    b.Property<Guid>("AccessLogId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AccessZoneId");

                    b.Property<string>("Name");

                    b.HasKey("AccessLogId");

                    b.HasIndex("AccessZoneId")
                        .IsUnique();

                    b.ToTable("AccessLogs");
                });

            modelBuilder.Entity("AppService.Domain.Entities.AccessLogEntry", b =>
                {
                    b.Property<Guid>("AccessLogEntryId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AccessLogId");

                    b.Property<Guid?>("AccessPointId");

                    b.Property<int>("Event");

                    b.Property<Guid?>("IdentityId");

                    b.Property<string>("Message");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("AccessLogEntryId");

                    b.HasIndex("AccessLogId");

                    b.HasIndex("AccessPointId");

                    b.HasIndex("IdentityId");

                    b.ToTable("AccessLogEntries");
                });

            modelBuilder.Entity("AppService.Domain.Entities.AccessPoint", b =>
                {
                    b.Property<Guid>("AccessPointId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AccessListId");

                    b.Property<TimeSpan>("AccessTime");

                    b.Property<Guid?>("AccessZoneId");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Name");

                    b.HasKey("AccessPointId");

                    b.HasIndex("AccessListId");

                    b.HasIndex("AccessZoneId");

                    b.ToTable("AccessPoints");
                });

            modelBuilder.Entity("AppService.Domain.Entities.AccessZone", b =>
                {
                    b.Property<Guid>("AccessZoneId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AccessZoneId");

                    b.ToTable("AccessZones");
                });

            modelBuilder.Entity("AppService.Domain.Entities.Credential", b =>
                {
                    b.Property<Guid>("CredentialId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<Guid?>("IdentityId");

                    b.HasKey("CredentialId");

                    b.HasIndex("IdentityId");

                    b.ToTable("Credentials");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Credential");
                });

            modelBuilder.Entity("AppService.Domain.Entities.Identity", b =>
                {
                    b.Property<Guid>("IdentityId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsInactive");

                    b.Property<string>("Name");

                    b.Property<TimeSpan?>("ValidFrom");

                    b.Property<TimeSpan?>("ValidThru");

                    b.HasKey("IdentityId");

                    b.ToTable("Identitiets");
                });

            modelBuilder.Entity("AppService.Domain.Entities.IdentityAccessList", b =>
                {
                    b.Property<Guid>("IdentityId");

                    b.Property<Guid>("AccessListId");

                    b.HasKey("IdentityId", "AccessListId");

                    b.HasIndex("AccessListId");

                    b.ToTable("IdentityAccessList");
                });

            modelBuilder.Entity("AppService.Domain.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("AppService.Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("RefreshToken");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AppService.Domain.Entities.CardCredential", b =>
                {
                    b.HasBaseType("AppService.Domain.Entities.Credential");

                    b.Property<int>("CardType");

                    b.Property<byte[]>("Data");

                    b.Property<string>("Pin");

                    b.HasDiscriminator().HasValue("CardCredential");
                });

            modelBuilder.Entity("AppService.Domain.Entities.AccessLog", b =>
                {
                    b.HasOne("AppService.Domain.Entities.AccessZone", "AccessZone")
                        .WithOne("AccessLog")
                        .HasForeignKey("AppService.Domain.Entities.AccessLog", "AccessZoneId");
                });

            modelBuilder.Entity("AppService.Domain.Entities.AccessLogEntry", b =>
                {
                    b.HasOne("AppService.Domain.Entities.AccessLog", "AccessLog")
                        .WithMany("Entries")
                        .HasForeignKey("AccessLogId");

                    b.HasOne("AppService.Domain.Entities.AccessPoint", "AccessPoint")
                        .WithMany()
                        .HasForeignKey("AccessPointId");

                    b.HasOne("AppService.Domain.Entities.Identity", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId");
                });

            modelBuilder.Entity("AppService.Domain.Entities.AccessPoint", b =>
                {
                    b.HasOne("AppService.Domain.Entities.AccessList", "AccessList")
                        .WithMany()
                        .HasForeignKey("AccessListId");

                    b.HasOne("AppService.Domain.Entities.AccessZone")
                        .WithMany("AccessPoints")
                        .HasForeignKey("AccessZoneId");
                });

            modelBuilder.Entity("AppService.Domain.Entities.Credential", b =>
                {
                    b.HasOne("AppService.Domain.Entities.Identity", "Identity")
                        .WithMany("Credentials")
                        .HasForeignKey("IdentityId");
                });

            modelBuilder.Entity("AppService.Domain.Entities.IdentityAccessList", b =>
                {
                    b.HasOne("AppService.Domain.Entities.AccessList", "AccessList")
                        .WithMany("IdentityAccessList")
                        .HasForeignKey("AccessListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppService.Domain.Entities.Identity", "Identity")
                        .WithMany("IdentityAccessList")
                        .HasForeignKey("IdentityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AppService.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AppService.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppService.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AppService.Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
