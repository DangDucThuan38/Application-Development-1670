﻿// <auto-generated />
using System;
using KTBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KTBook.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FPTBookStore.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WaitCart_ID")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("productId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("FPTBookStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "ok",
                            Name = "Book",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Description = "good",
                            Name = "Learning tool",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Fantasy",
                            Name = "Manga",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 4,
                            Description = "good",
                            Name = "Comic",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Magic",
                            Name = "Magic",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Drama",
                            Name = "Drama",
                            Status = "Active"
                        });
                });

            modelBuilder.Entity("FPTBookStore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FPTBookStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            Description = "Very funny for children.",
                            Image = "conan100.png",
                            Name = "Conan Chapter 100",
                            Price = 100m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 4,
                            Description = "Good",
                            Image = "shin7.png",
                            Name = "Shin chapter 7",
                            Price = 99m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Greate for children study VietNamese.",
                            Image = "tiengviet2.png",
                            Name = "Tiếng Việt lớp 2",
                            Price = 20m,
                            Quantity = 70
                        });
                });

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

                    b.HasData(
                        new
                        {
                            Id = "A",
                            ConcurrencyStamp = "255bde9b-4fa1-4611-96ff-d984c8f35537",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "B",
                            ConcurrencyStamp = "2a9774c2-3141-434b-acaa-f1d1691155aa",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "S",
                            ConcurrencyStamp = "5b971da2-7efa-43b5-94c3-d3128057adb6",
                            Name = "Staff",
                            NormalizedName = "Staff"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "A"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "A"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "B"
                        },
                        new
                        {
                            UserId = "5",
                            RoleId = "S"
                        },
                        new
                        {
                            UserId = "6",
                            RoleId = "S"
                        },
                        new
                        {
                            UserId = "4",
                            RoleId = "A"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FPTBookStore.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cdfb9ef3-0877-4011-9696-15f0a76a4593",
                            Email = "thuanddgch200729@fpt.edu.vn",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "thuanddgch200729@fpt.edu.vn",
                            PasswordHash = "AQAAAAEAACcQAAAAEORLn3lZ/XKGm7bRY4Ulm5pZOgI8BJE93lSgVHhjRFdJDaOKhIklyZfGXdAMURmivw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b7fdbdb7-06c8-4be2-bc09-e5f9e5582419",
                            TwoFactorEnabled = false,
                            UserName = "thuanddgch200729@fpt.edu.vn",
                            Address = "Hà Nội",
                            DoB = "2000/08/03",
                            FullName = "Đặng Đức Thuần",
                            Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f2525c2d-d18d-4936-b766-a2f4de14383d",
                            Email = "customer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "customer@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAENRnfnQuicJ3EnQHAVXC1L2+AwJeebAnNjjlh6XqbiGNx1sw+QGdLwBOlcyv40aE1A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cd29b8d2-04b8-49ec-b213-9e6c6f909bbb",
                            TwoFactorEnabled = false,
                            UserName = "customer@gmail.com",
                            Address = "Hà Nội",
                            DoB = "2002/08/10",
                            FullName = "Nguyen Van A",
                            Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "76381e05-dea7-49f6-9557-e6e651f7aad6",
                            Email = "phamtrungkien@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "phamtrungkien@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAED++ex+kMXm+MmavCXoomU3YRL2pA0B8MN5kz2Q/tvDoir+2xWpEtKmy1OP3QKtgVw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e834f277-b643-42e9-ace0-bb197b41ea89",
                            TwoFactorEnabled = false,
                            UserName = "phamtrungkien@gmail.com",
                            Address = "Quảng Ninh",
                            DoB = "2002/08/10",
                            FullName = "Phạm Trung Kiên",
                            Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "93ea5355-2eb5-4c02-b12c-e615d3edec98",
                            Email = "staff1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "staff1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEBf3zW7OAUb1wx56JBsMBZLiYe7K4GvHqDH5V1cUSGfGaf1uokKa3oXHELABaURlJQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0fe153a6-043d-4074-8615-b1cf94e3f985",
                            TwoFactorEnabled = false,
                            UserName = "staff1@gmail.com",
                            Address = "Hà Nội",
                            DoB = "2002/08/10",
                            FullName = "Dang Duc Thuan",
                            Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg"
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "45f73ccb-ebd7-46fb-936e-ea8a205f4cd3",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "staff2@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAELJx7V7FGtTUkfyNBKKoacYhkHdq3LHivUg+YYYdXO4W8MEHPorlG1Lu9k22kACGPQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ef11881f-a23e-4efb-b74a-b25698c1837d",
                            TwoFactorEnabled = false,
                            UserName = "staff2@gmail.com",
                            Address = "Quang Ninh",
                            DoB = "2002/08/10",
                            FullName = "Pham Trung Kien",
                            Image = "https://toigingiuvedep.vn/wp-content/uploads/2021/05/hinh-anh-avatar-hai-doc.jpg"
                        });
                });

            modelBuilder.Entity("FPTBookStore.Models.CartItem", b =>
                {
                    b.HasOne("FPTBookStore.Models.Order", null)
                        .WithMany("cartItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("FPTBookStore.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("FPTBookStore.Models.Product", b =>
                {
                    b.HasOne("FPTBookStore.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FPTBookStore.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FPTBookStore.Models.Order", b =>
                {
                    b.Navigation("cartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
