﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(LotteryAppContext))]
    [Migration("20201123065601_AnotherTest")]
    partial class AnotherTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Permission", b =>
                {
                    b.Property<long>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionId");

                    b.HasIndex("CodeName")
                        .IsUnique()
                        .HasFilter("[CodeName] IS NOT NULL");

                    b.ToTable("Permission");

                    b.HasData(
                        new
                        {
                            PermissionId = 1L,
                            CodeName = "user.add",
                            Name = "Add User"
                        },
                        new
                        {
                            PermissionId = 2L,
                            CodeName = "user.edit",
                            Name = "Edit User"
                        },
                        new
                        {
                            PermissionId = 3L,
                            CodeName = "user.modify",
                            Name = "Modify User"
                        },
                        new
                        {
                            PermissionId = 4L,
                            CodeName = "user.delete",
                            Name = "Delete User"
                        },
                        new
                        {
                            PermissionId = 5L,
                            CodeName = "user.list",
                            Name = "List Users"
                        },
                        new
                        {
                            PermissionId = 6L,
                            CodeName = "role.add",
                            Name = "Add Role"
                        },
                        new
                        {
                            PermissionId = 7L,
                            CodeName = "role.edit",
                            Name = "Modify Role"
                        },
                        new
                        {
                            PermissionId = 8L,
                            CodeName = "role.list",
                            Name = "List Role"
                        },
                        new
                        {
                            PermissionId = 9L,
                            CodeName = "role.permission.list",
                            Name = "List Permissions in Role"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Identification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Domain.Entities.PlayerRaffle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BetAmount")
                        .HasColumnType("int");

                    b.Property<long>("PlayerId")
                        .HasColumnType("bigint");

                    b.Property<long>("RaffleId")
                        .HasColumnType("bigint");

                    b.Property<int>("SelectedNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("RaffleId");

                    b.ToTable("PlayerRaffle");
                });

            modelBuilder.Entity("Domain.Entities.Raffle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WinMultiplier")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Raffles");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Player"
                        });
                });

            modelBuilder.Entity("Domain.Entities.RolePermission", b =>
                {
                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("PermissionID")
                        .HasColumnType("bigint");

                    b.HasKey("RoleId", "PermissionID");

                    b.HasIndex("PermissionID");

                    b.ToTable("RolePermission");

                    b.HasData(
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 1L
                        },
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 2L
                        },
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 3L
                        },
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 4L
                        },
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 5L
                        },
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 6L
                        },
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 7L
                        },
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 8L
                        },
                        new
                        {
                            RoleId = 1L,
                            PermissionID = 9L
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Domain.Entities.Winner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountEarned")
                        .HasColumnType("int");

                    b.Property<long?>("PlayerId")
                        .HasColumnType("bigint");

                    b.Property<long>("PlayerRaffleId")
                        .HasColumnType("bigint");

                    b.Property<long?>("RaffleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("PlayerRaffleId")
                        .IsUnique();

                    b.HasIndex("RaffleId");

                    b.ToTable("Winner");
                });

            modelBuilder.Entity("Domain.Entities.Player", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithOne("Player")
                        .HasForeignKey("Domain.Entities.Player", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.PlayerRaffle", b =>
                {
                    b.HasOne("Domain.Entities.Player", "Player")
                        .WithMany("RaffleTickets")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Raffle", "Raffle")
                        .WithMany("PlayerRaffles")
                        .HasForeignKey("RaffleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.RolePermission", b =>
                {
                    b.HasOne("Domain.Entities.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.HasOne("Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Winner", b =>
                {
                    b.HasOne("Domain.Entities.Player", null)
                        .WithMany("Win")
                        .HasForeignKey("PlayerId");

                    b.HasOne("Domain.Entities.PlayerRaffle", "PlayerRaffle")
                        .WithOne("Winner")
                        .HasForeignKey("Domain.Entities.Winner", "PlayerRaffleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Raffle", null)
                        .WithMany("Winners")
                        .HasForeignKey("RaffleId");
                });
#pragma warning restore 612, 618
        }
    }
}
