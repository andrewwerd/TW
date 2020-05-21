﻿// <auto-generated />
using System;
using DbCard.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbCard.Context.Migrations
{
    [DbContext(typeof(DbCardContext))]
    [Migration("20200515130933_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DbCard.Domain.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FilialId")
                        .HasColumnType("bigint");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilialId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DbCard.Domain.Auth.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles","Auth");
                });

            modelBuilder.Entity("DbCard.Domain.Auth.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims","Auth");
                });

            modelBuilder.Entity("DbCard.Domain.Auth.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users","Auth");
                });

            modelBuilder.Entity("DbCard.Domain.Auth.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims","Auth");
                });

            modelBuilder.Entity("DbCard.Domain.Auth.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins","Auth");
                });

            modelBuilder.Entity("DbCard.Domain.Auth.UserRole", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole","Auth");
                });

            modelBuilder.Entity("DbCard.Domain.Auth.UserToken", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserRoles","Auth");
                });

            modelBuilder.Entity("DbCard.Domain.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DbCard.Domain.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateOfRegistration")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DbCard.Domain.CustomersBalance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("bit");

                    b.Property<long>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ResetDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PartnerId");

                    b.ToTable("CustomersBalances");
                });

            modelBuilder.Entity("DbCard.Domain.FavoritePartners", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PartnerId");

                    b.ToTable("FavoritePartners");
                });

            modelBuilder.Entity("DbCard.Domain.Filial", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsMainOffice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<long>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Filials");
                });

            modelBuilder.Entity("DbCard.Domain.News", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<DateTime>("DateOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<long>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("ShortBody")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("DbCard.Domain.Partner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BirthdayDiscount")
                        .HasColumnType("decimal(3, 2)");

                    b.Property<DateTime>("DateOfRegistration")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(2, 2)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("DbCard.Domain.PartnerSubcategories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<long>("SubcategoryId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("PartnerSubcategories");
                });

            modelBuilder.Entity("DbCard.Domain.PremiumDiscount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AccumulatingPercent")
                        .HasColumnType("decimal(2, 2)");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(2, 2)");

                    b.Property<long>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("PriceOfDiscount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.ToTable("PremiumDiscounts");
                });

            modelBuilder.Entity("DbCard.Domain.Review", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AnswerReview")
                        .HasColumnType("bigint");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumbersOfDislike")
                        .HasColumnType("int");

                    b.Property<int>("NumbersOfLike")
                        .HasColumnType("int");

                    b.Property<long?>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("AnswerReview");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PartnerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("DbCard.Domain.Schedule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("FilialId")
                        .HasColumnType("bigint");

                    b.Property<string>("Friday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Monday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Saturday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sunday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thursday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tuesday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wednesday")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilialId")
                        .IsUnique();

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("DbCard.Domain.StandartDiscount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountOfDiscount")
                        .HasColumnType("decimal(4, 2)");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(2, 2)");

                    b.Property<long>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.ToTable("StandartDiscounts");
                });

            modelBuilder.Entity("DbCard.Domain.Subcategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("DbCard.Domain.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AccumulationAmount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("AllAmount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("AmountForPay")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("FilialAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<long?>("FilialId")
                        .HasColumnType("bigint");

                    b.Property<string>("PartnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FilialId");

                    b.ToTable("TransactionHistory");
                });

            modelBuilder.Entity("DbCard.Domain.Address", b =>
                {
                    b.HasOne("DbCard.Domain.Filial", "Filial")
                        .WithOne("Address")
                        .HasForeignKey("DbCard.Domain.Address", "FilialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Auth.RoleClaim", b =>
                {
                    b.HasOne("DbCard.Domain.Auth.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Auth.UserClaim", b =>
                {
                    b.HasOne("DbCard.Domain.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Auth.UserLogin", b =>
                {
                    b.HasOne("DbCard.Domain.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Auth.UserRole", b =>
                {
                    b.HasOne("DbCard.Domain.Auth.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCard.Domain.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Auth.UserToken", b =>
                {
                    b.HasOne("DbCard.Domain.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Customer", b =>
                {
                    b.HasOne("DbCard.Domain.Auth.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("DbCard.Domain.Customer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.CustomersBalance", b =>
                {
                    b.HasOne("DbCard.Domain.Customer", "Customer")
                        .WithMany("CustomersBalances")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCard.Domain.Partner", "Partner")
                        .WithMany("CustomersBalances")
                        .HasForeignKey("PartnerId")
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.FavoritePartners", b =>
                {
                    b.HasOne("DbCard.Domain.Customer", "Customer")
                        .WithMany("FavoritePartners")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCard.Domain.Partner", "Partner")
                        .WithMany("MyCustomers")
                        .HasForeignKey("PartnerId");
                });

            modelBuilder.Entity("DbCard.Domain.Filial", b =>
                {
                    b.HasOne("DbCard.Domain.Partner", "Partner")
                        .WithMany("Filials")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.News", b =>
                {
                    b.HasOne("DbCard.Domain.Partner", "Partner")
                        .WithMany("News")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Partner", b =>
                {
                    b.HasOne("DbCard.Domain.Auth.User", "User")
                        .WithOne("Partner")
                        .HasForeignKey("DbCard.Domain.Partner", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.PartnerSubcategories", b =>
                {
                    b.HasOne("DbCard.Domain.Partner", "Partner")
                        .WithMany("PartnerSubcategories")
                        .HasForeignKey("PartnerId")
                        .IsRequired();

                    b.HasOne("DbCard.Domain.Subcategory", "Subcategory")
                        .WithMany("Partners")
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.PremiumDiscount", b =>
                {
                    b.HasOne("DbCard.Domain.Partner", "Partner")
                        .WithMany("PremiumDiscount")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Review", b =>
                {
                    b.HasOne("DbCard.Domain.Review", "AnswerReviewNavigation")
                        .WithMany("InverseAnswerReviewNavigation")
                        .HasForeignKey("AnswerReview");

                    b.HasOne("DbCard.Domain.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCard.Domain.Partner", "Partner")
                        .WithMany("Reviews")
                        .HasForeignKey("PartnerId");
                });

            modelBuilder.Entity("DbCard.Domain.Schedule", b =>
                {
                    b.HasOne("DbCard.Domain.Filial", "Filial")
                        .WithOne("Schedule")
                        .HasForeignKey("DbCard.Domain.Schedule", "FilialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.StandartDiscount", b =>
                {
                    b.HasOne("DbCard.Domain.Partner", "Partner")
                        .WithMany("StandartDiscounts")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Subcategory", b =>
                {
                    b.HasOne("DbCard.Domain.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbCard.Domain.Transaction", b =>
                {
                    b.HasOne("DbCard.Domain.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCard.Domain.Filial", "Filial")
                        .WithMany("Transactions")
                        .HasForeignKey("FilialId");
                });
#pragma warning restore 612, 618
        }
    }
}
