﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webshop.Data;

#nullable disable

namespace Webshop.Migrations
{
    [DbContext(typeof(WebshopContext))]
    [Migration("20230320080442_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Webshop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Categorie")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Prijs")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Beschrijving = "PlayStation 5 + Sony PlayStation 5 DualSense draadloze controller. Aan een veel te hoge prijs, wegens overal uitverkocht.",
                            Categorie = 3,
                            Naam = "PS5",
                            Prijs = 799.99m
                        },
                        new
                        {
                            Id = 2,
                            Beschrijving = "Xbox Series X",
                            Categorie = 3,
                            Naam = "XBox",
                            Prijs = 499.99m
                        },
                        new
                        {
                            Id = 3,
                            Beschrijving = "Supermegasnelle console met graphics en hardware en meer van dat lekkers",
                            Categorie = 3,
                            Naam = "Console: The Console",
                            Prijs = 9999.99m
                        },
                        new
                        {
                            Id = 4,
                            Beschrijving = "Forged from the fires of the KFC ovens, there has never been a tastier way to experience the latest titles in stunning 4k, 240fps.",
                            Categorie = 3,
                            Naam = "KFConsole",
                            Prijs = 499.99m
                        },
                        new
                        {
                            Id = 5,
                            Beschrijving = "Super leuk spelletje",
                            Categorie = 0,
                            Naam = "Game: The Game",
                            Prijs = 999.99m
                        },
                        new
                        {
                            Id = 6,
                            Beschrijving = "Top 10 game of 2022",
                            Categorie = 0,
                            Naam = "Aging Wreath",
                            Prijs = 44.44m
                        },
                        new
                        {
                            Id = 7,
                            Beschrijving = "Top 10 game of 2022",
                            Categorie = 0,
                            Naam = "Deity of Strife Gotterdammerung",
                            Prijs = 55.55m
                        },
                        new
                        {
                            Id = 8,
                            Beschrijving = "Top 10 game of 2022",
                            Categorie = 0,
                            Naam = "Skyline Prohibited Occident",
                            Prijs = 33.33m
                        },
                        new
                        {
                            Id = 9,
                            Beschrijving = "Top 10 game of 2022",
                            Categorie = 0,
                            Naam = "Request of Assignment: Innovative Military Action",
                            Prijs = 66.66m
                        },
                        new
                        {
                            Id = 10,
                            Beschrijving = "The perfect gift for booze-loving Blade Runner fans",
                            Categorie = 1,
                            Naam = "Blade Runner Whiskey Glasses",
                            Prijs = 138.99m
                        },
                        new
                        {
                            Id = 11,
                            Beschrijving = "Alarm clock in the shape of a PS4 controller. Better then using your phone's alarm anyway...",
                            Categorie = 1,
                            Naam = "PlayStation Alarm Clock",
                            Prijs = 28.99m
                        },
                        new
                        {
                            Id = 12,
                            Beschrijving = "Multicoloured novelty lamp featuring seven different Tetromino shapes which light up once they come into contact with each other.",
                            Categorie = 1,
                            Naam = "Tetris Stackable Toy Light",
                            Prijs = 37.98m
                        },
                        new
                        {
                            Id = 13,
                            Beschrijving = "Look! Is it a headphone? Is it a microphone? Nope... it's BOTH!",
                            Categorie = 2,
                            Naam = "Gaming head set",
                            Prijs = 149.99m
                        },
                        new
                        {
                            Id = 14,
                            Beschrijving = "The keys are made of solid tritanium. Featuring a completely useless \"calculator\" button.",
                            Categorie = 2,
                            Naam = "HyperX Keyboard",
                            Prijs = 83.99m
                        },
                        new
                        {
                            Id = 15,
                            Beschrijving = "Featuring over 254 detachable buttons, it will turn (you) into the ultimate gaming tool.",
                            Categorie = 2,
                            Naam = "PDMLV55 Wireless Mouse",
                            Prijs = 255.99m
                        },
                        new
                        {
                            Id = 16,
                            Beschrijving = "A 65K 69inch 360° 5D monitor with a resolution up to 51000p and a 840hz refresh rate.  Will make your games come to life... literally. VGA cable included.",
                            Categorie = 2,
                            Naam = "Aceus HAL PG051651XXQ Monitor",
                            Prijs = 9999.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
