﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Products.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210830060033_LocationCoords")]
    partial class LocationCoords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId", "ProductId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Grocery"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Meat"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dairy Products"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Confectionery"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProviderId");

                    b.HasIndex("Name", "Description", "Cost", "CategoryId", "ProviderId")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL AND [Description] IS NOT NULL");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            Cost = 1.53,
                            Description = "Contains useful trace elements",
                            ImageUrl = "https://i.pinimg.com/564x/9f/19/09/9f19090f916c43dae8fa2d5e4f4298bd.jpg",
                            Name = "Yoghurt",
                            ProviderId = 4
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 5,
                            Cost = 2.25,
                            Description = "From the freshest milk",
                            ImageUrl = "https://i.pinimg.com/564x/d1/4a/ac/d14aac685c7d492d34d5b1c06f9e57ad.jpg",
                            Name = "Butter",
                            ProviderId = 4
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 5,
                            Cost = 1.1699999999999999,
                            Description = "From the healthiest cows",
                            ImageUrl = "https://i.pinimg.com/564x/11/37/9a/11379a0588f57f9e18f9e4fae9f3b6ed.jpg",
                            Name = "Milk",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 6,
                            Cost = 4.5,
                            Description = "Baked with love",
                            ImageUrl = "https://i.pinimg.com/564x/ec/5f/08/ec5f08f5c24077ba5a892e39105cc066.jpg",
                            Name = "Cake",
                            ProviderId = 5
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Cost = 3.8500000000000001,
                            Description = "Fresh",
                            ImageUrl = "https://i.pinimg.com/564x/99/ee/3c/99ee3cc80018401e8f92a794ce4d5102.jpg",
                            Name = "Sausage",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Cost = 2.5499999999999998,
                            Description = "The most delicious meat",
                            ImageUrl = "https://i.pinimg.com/564x/11/f3/03/11f303bbb87435d297b257ffeaee3f1e.jpg",
                            Name = "Meatballs",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Cost = 1.1299999999999999,
                            Description = "Only from the garden",
                            ImageUrl = "https://i.pinimg.com/564x/6d/b9/cc/6db9cc5ed7fc8ee8492dfb60b50cbf28.jpg",
                            Name = "Cabbage",
                            ProviderId = 6
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Cost = 1.0700000000000001,
                            Description = "Purple as a bruise",
                            ImageUrl = "https://i.pinimg.com/564x/98/3e/dd/983edd484bec3c19bbec13bf95ffb2c0.jpg",
                            Name = "Beetroot",
                            ProviderId = 6
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Cost = 1.78,
                            Description = "At a discount",
                            ImageUrl = "https://i.pinimg.com/564x/47/a8/ed/47a8edca3321c8282a6cd2af73f1400a.jpg",
                            Name = "Asparagus",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Cost = 1.1000000000000001,
                            Description = "Minions love them",
                            ImageUrl = "https://i.pinimg.com/564x/9c/e9/d5/9ce9d5b1f6c97f27d7b4f5a96d5ee6ab.jpg",
                            Name = "Banana",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Cost = 1.99,
                            Description = "Hairy",
                            ImageUrl = "https://i.pinimg.com/564x/15/b4/99/15b499819be25fa974752cce150c19c6.jpg",
                            Name = "Kivifruit",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Cost = 2.4199999999999999,
                            Description = "Sugar taste",
                            ImageUrl = "https://i.pinimg.com/564x/c5/10/6f/c5106f5fd0684b45f12c8517a47cff5c.jpg",
                            Name = "Melon",
                            ProviderId = 7
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Cost = 1.72,
                            Description = "Like an orange sunset",
                            ImageUrl = "https://i.pinimg.com/564x/e8/7a/07/e87a07cbdd1cc7d3638613e68db39a79.jpg",
                            Name = "Orange",
                            ProviderId = 7
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Cost = 3.1000000000000001,
                            Description = "Avocado colors",
                            ImageUrl = "https://i.pinimg.com/564x/ce/a8/f1/cea8f12d0dc21d5ba8ffa9af50ee8b47.jpg",
                            Name = "Avocado",
                            ProviderId = 3
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            Cost = 5.4900000000000002,
                            Description = "He can speak",
                            ImageUrl = "https://i.pinimg.com/564x/96/01/b3/9601b3603412852ef8fb8ccb940323ce.jpg",
                            Name = "Lamb",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            Cost = 4.0,
                            Description = "He was friends with a lamb",
                            ImageUrl = "https://i.pinimg.com/564x/15/0e/6b/150e6b8ac28a4ddbdc4640a9225b0712.jpg",
                            Name = "Veal",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Cost = 3.3500000000000001,
                            Description = "Of today's production",
                            ImageUrl = "https://i.pinimg.com/564x/54/30/14/543014bffb4aab8bfd5b3c169e7de841.jpg",
                            Name = "Chop",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Cost = 3.1000000000000001,
                            Description = "Out of the oven",
                            ImageUrl = "https://i.pinimg.com/564x/dd/c4/2e/ddc42ece75ab1489285b6c8b1f21773b.jpg",
                            Name = "Chicken",
                            ProviderId = 2
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 6,
                            Cost = 0.80000000000000004,
                            Description = "For tea",
                            ImageUrl = "https://i.pinimg.com/564x/73/cc/1d/73cc1d67358e6297f3eccbc797fa449b.jpg",
                            Name = "Biscuit",
                            ProviderId = 3
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 1,
                            Cost = 1.2,
                            Description = "From Belarusian fields",
                            ImageUrl = "https://i.pinimg.com/564x/da/6a/cf/da6acf414f983a50e0f836f2eabf43e7.jpg",
                            Name = "Potato",
                            ProviderId = 3
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 5,
                            Cost = 3.1200000000000001,
                            Description = "For cakes",
                            ImageUrl = "https://i.pinimg.com/564x/f4/30/7f/f4307f509a13125c657e882ae7ebb26a.jpg",
                            Name = "Cream",
                            ProviderId = 4
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            Cost = 4.3200000000000003,
                            Description = "Ratatouille near",
                            ImageUrl = "https://i.pinimg.com/564x/f4/54/c3/f454c30262fdbf92b128415b66f92794.jpg",
                            Name = "Cheese",
                            ProviderId = 4
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 2,
                            Cost = 2.1000000000000001,
                            Description = "Sour but expensive",
                            ImageUrl = "https://i.pinimg.com/564x/9c/cb/90/9ccb90064100431e87f0b593d31e21b3.jpg",
                            Name = "Cranberry",
                            ProviderId = 8
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 1,
                            Cost = 0.75,
                            Description = "Good for vision",
                            ImageUrl = "https://i.pinimg.com/564x/33/1b/e5/331be57b94b67ec8e145aafb382fe7a7.jpg",
                            Name = "Carrot",
                            ProviderId = 5
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 6,
                            Cost = 1.05,
                            Description = "In the shape of a fish",
                            ImageUrl = "https://i.pinimg.com/564x/61/64/99/616499b8d8bf55455880e89bc4eeb475.jpg",
                            Name = "Cookies",
                            ProviderId = 7
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 2,
                            Cost = 2.6299999999999999,
                            Description = "Like a bruise",
                            ImageUrl = "https://i.pinimg.com/564x/41/7e/b1/417eb1212f7a3713aec76a166f3cfd81.jpg",
                            Name = "Plum",
                            ProviderId = 5
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 4,
                            Cost = 5.0999999999999996,
                            Description = "Donald",
                            ImageUrl = "https://i.pinimg.com/564x/5a/90/ea/5a90eae4ae481f2d56f7fdd00110e85d.jpg",
                            Name = "Duck",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 1,
                            Cost = 2.6000000000000001,
                            Description = "On Halloween",
                            ImageUrl = "https://i.pinimg.com/564x/6f/bb/a7/6fbba70bc454a584a088386c23600d09.jpg",
                            Name = "Pumpkin",
                            ProviderId = 8
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 2,
                            Cost = 1.5900000000000001,
                            Description = "Which fell on newton",
                            ImageUrl = "https://i.pinimg.com/564x/89/88/91/89889125af33bf6483f58f4fa4d3d9ea.jpg",
                            Name = "Apple",
                            ProviderId = 8
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 6,
                            Cost = 0.45000000000000001,
                            Description = "From Belarus",
                            ImageUrl = "https://i.pinimg.com/564x/22/c2/a3/22c2a39a04e3a978997f6bbfceeb4b2c.jpg",
                            Name = "Bread",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 2,
                            Cost = 1.49,
                            Description = "From my garden",
                            ImageUrl = "https://i.pinimg.com/564x/e3/7f/54/e37f547f5cbfc397a7caf53a4fe87b51.jpg",
                            Name = "Raspberry",
                            ProviderId = 5
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 2,
                            Cost = 0.98999999999999999,
                            Description = "Sour like cranberries",
                            ImageUrl = "https://i.pinimg.com/564x/a5/58/fd/a558fdacb9b77ae1236dd0c24ae98c1c.jpg",
                            Name = "Lemon",
                            ProviderId = 6
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 3,
                            Cost = 1.2,
                            Description = "Student food",
                            ImageUrl = "https://i.pinimg.com/564x/b3/76/3f/b3763f5a0de60415d3fcfe6c741a15c0.jpg",
                            Name = "Cereals",
                            ProviderId = 5
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 6,
                            Cost = 0.80000000000000004,
                            Description = "For coffee",
                            ImageUrl = "https://i.pinimg.com/564x/ac/21/b0/ac21b0a905b1be5754a31bd82d1d89c4.jpg",
                            Name = "Wafer",
                            ProviderId = 3
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 2,
                            Cost = 1.8899999999999999,
                            Description = "With a leaf",
                            ImageUrl = "https://i.pinimg.com/564x/37/f1/ba/37f1ba10f0fd4687f136d7e8288ed8a0.jpg",
                            Name = "Apricot",
                            ProviderId = 6
                        },
                        new
                        {
                            Id = 36,
                            CategoryId = 4,
                            Cost = 7.0999999999999996,
                            Description = "Not for vegans",
                            ImageUrl = "https://i.pinimg.com/564x/7f/cb/fa/7fcbfab68d2148614fc39bee18a1fd55.jpg",
                            Name = "Beef",
                            ProviderId = 1
                        },
                        new
                        {
                            Id = 37,
                            CategoryId = 3,
                            Cost = 5.6900000000000004,
                            Description = "Delicious with stew",
                            ImageUrl = "https://i.pinimg.com/564x/7d/76/de/7d76de4679c2cd3992b24c796f821c40.jpg",
                            Name = "Buckwheat",
                            ProviderId = 8
                        },
                        new
                        {
                            Id = 38,
                            CategoryId = 3,
                            Cost = 1.1799999999999999,
                            Description = "Chinese delicacy",
                            ImageUrl = "https://i.pinimg.com/564x/a4/5b/00/a45b00ba09ce546c6a3843b413addbdc.jpg",
                            Name = "Rice",
                            ProviderId = 8
                        },
                        new
                        {
                            Id = 39,
                            CategoryId = 3,
                            Cost = 0.94999999999999996,
                            Description = "Ser",
                            ImageUrl = "https://i.pinimg.com/564x/b1/8c/ba/b18cba5f27ab4c7a2ec6dc8c117da2c2.jpg",
                            Name = "Oatmeal",
                            ProviderId = 8
                        },
                        new
                        {
                            Id = 40,
                            CategoryId = 6,
                            Cost = 4.9500000000000002,
                            Description = "In the form of a heart",
                            ImageUrl = "https://i.pinimg.com/564x/7e/31/1b/7e311b77e991407b30c5c4201fd76a40.jpg",
                            Name = "Pie",
                            ProviderId = 6
                        });
                });

            modelBuilder.Entity("Entities.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("LocationLat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LocationLong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Providers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LocationLat = 53.89019010647972m,
                            LocationLong = 27.575736202063215m,
                            Name = "Underdog"
                        },
                        new
                        {
                            Id = 2,
                            LocationLat = 38.54213540495325m,
                            LocationLong = 27.033468297986936m,
                            Name = "Atha Makina"
                        },
                        new
                        {
                            Id = 3,
                            LocationLat = 40.73105861912476m,
                            LocationLong = 46.27047156919906m,
                            Name = "Shirin Agro"
                        },
                        new
                        {
                            Id = 4,
                            LocationLat = 54.26659741177842m,
                            LocationLong = 30.98771355605172m,
                            Name = "Milk Gorki"
                        },
                        new
                        {
                            Id = 5,
                            LocationLat = 49.764727469041816m,
                            LocationLong = 43.65468679640968m,
                            Name = "Archeda"
                        },
                        new
                        {
                            Id = 6,
                            LocationLat = 47.46106041862809m,
                            LocationLong = -122.26236529486663m,
                            Name = "Pascual"
                        },
                        new
                        {
                            Id = 7,
                            LocationLat = 39.16566430628417m,
                            LocationLong = -0.2430474019997804m,
                            Name = "Javimar"
                        },
                        new
                        {
                            Id = 8,
                            LocationLat = 10.158678793639453m,
                            LocationLong = -10.753070951045318m,
                            Name = "MiLida"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
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

                    b.ToTable("AspNetUsers");
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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "0101f1d0-16a6-4885-b31f-882a55fabdc4",
                            ConcurrencyStamp = "3c4f6d71-4291-478f-be8a-cedcd82b0338",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "40918622-7cde-4017-a15b-5607c3b9b2c8",
                            ConcurrencyStamp = "ffcec8ec-ce0a-437d-9645-6b71eefd7b81",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "8d529479-9a47-4ea8-8639-7447a9f76694",
                            ConcurrencyStamp = "9d357a01-5c1c-4c92-8b68-52ace90a47ff",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Entities.Models.Cart", b =>
                {
                    b.HasOne("Entities.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Provider", "Provider")
                        .WithMany("Products")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Provider");
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
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
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

                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("Entities.Models.Provider", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
