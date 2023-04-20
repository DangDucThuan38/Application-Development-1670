﻿// <auto-generated />
using System;
using KTBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KTBook.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230420085255_updaterole")]
    partial class updaterole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
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

                    b.Property<int?>("WaitCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WaitCategoryId");

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

            modelBuilder.Entity("FPTBookStore.Models.WaitCategory", b =>
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

                    b.ToTable("WaitCategory");
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
                            ConcurrencyStamp = "1fd35b3f-8b1b-4f10-8567-317437450973",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "B",
                            ConcurrencyStamp = "ec92b446-7773-46a4-8618-f64a43e5ed4d",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "S",
                            ConcurrencyStamp = "583673c9-3c46-4602-9d20-3efc32fffee3",
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
                            ConcurrencyStamp = "b4eca54a-1d1d-4542-9e94-7584b251b391",
                            Email = "thuanddgch200729@fpt.edu.vn",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "thuanddgch200729@fpt.edu.vn",
                            PasswordHash = "AQAAAAEAACcQAAAAELEoMUZfb6EhWPu+c0fj7ykq0xmFH48sUv44PtkwJffusO3/XrBL2xP8hqvuc8U9tg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2dbf771c-ac96-477d-976f-296fd06dc6ed",
                            TwoFactorEnabled = false,
                            UserName = "thuanddgch200729@fpt.edu.vn",
                            Address = "Hà Nội",
                            DoB = "2000/08/03",
                            FullName = "Đặng Đức Thuần",
                            Image = "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d347d1a7-29c2-493a-a494-26409eab31da",
                            Email = "customer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "customer@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAED8r7JZYWnXCxsd/5HTfXa58JTyknn7Bvm/cE8tmVp8n/OYx0o/+G743us2o/9ANkw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "62d3704c-fcea-481a-b8cd-4e03bff6dbad",
                            TwoFactorEnabled = false,
                            UserName = "customer@gmail.com",
                            Address = "Hà Nội",
                            DoB = "2002/08/10",
                            FullName = "Nguyen Van A",
                            Image = "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1c701475-979a-4156-a813-d7f70fb361a6",
                            Email = "phamtrungkien@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "phamtrungkien@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAED9I7Ihhw2bRNA9RDw6Zom+9vjcR+q9HE3MsPhhorl2q9UeuOVZdBpj4BbH2IZvfSQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d1300726-a4d7-4dfe-97da-12b24b5a8f10",
                            TwoFactorEnabled = false,
                            UserName = "phamtrungkien@gmail.com",
                            Address = "Quảng Ninh",
                            DoB = "2002/08/10",
                            FullName = "Phạm Trung Kiên",
                            Image = "https://file.hstatic.net/200000122283/article/shin-cau-be-but-chi_4017a723e5df4b7d91524dc0bf656c27_1024x1024.jpg"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "362d9072-00cc-4d7d-8474-00aacd8cc416",
                            Email = "staff1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "staff1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEIm0l8CmCdo1dumztoOevX//CWi8mOttE3V/pKbmqhTXacrs1drEYzGTZytSmMQtlQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c3a148d0-3630-4ec6-8d34-f70e856023b9",
                            TwoFactorEnabled = false,
                            UserName = "staff1@gmail.com",
                            Address = "Hà Nội",
                            DoB = "2002/08/10",
                            FullName = "Dang Duc Thuan",
                            Image = "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png"
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6bb66525-6f70-4abf-abf0-2e27a458c779",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "staff2@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEBKYjyy9aTHuhz3fLzcB2FYM6/sLLZDfqlYTjfZ4uIxlHdDhJ1QOqovhngAox5NDMA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0d02ecfb-2de4-4902-8671-afe121ddd1e3",
                            TwoFactorEnabled = false,
                            UserName = "staff2@gmail.com",
                            Address = "Quang Ninh",
                            DoB = "2002/08/10",
                            FullName = "Pham Trung Kien",
                            Image = "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png"
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

                    b.HasOne("FPTBookStore.Models.WaitCategory", null)
                        .WithMany("Products")
                        .HasForeignKey("WaitCategoryId");

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

            modelBuilder.Entity("FPTBookStore.Models.WaitCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
