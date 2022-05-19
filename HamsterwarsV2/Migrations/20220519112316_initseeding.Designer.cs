﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace HamsterwarsV2.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220519112316_initseeding")]
    partial class initseeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Hamster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("HamsterId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Defeats")
                        .HasColumnType("int");

                    b.Property<string>("FavFood")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loves")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hamsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Arvy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Unexpected",
                            Wins = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Sonny",
                            Wins = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Atlanta",
                            Wins = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Galaxy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Piper",
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Bliss",
                            Wins = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Tyson",
                            Wins = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Hugh Heifer",
                            Wins = 0
                        },
                        new
                        {
                            Id = 10,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Fury",
                            Wins = 0
                        },
                        new
                        {
                            Id = 11,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Duke",
                            Wins = 0
                        },
                        new
                        {
                            Id = 12,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Marvin",
                            Wins = 0
                        },
                        new
                        {
                            Id = 13,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Nexus",
                            Wins = 0
                        },
                        new
                        {
                            Id = 14,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Cherry",
                            Wins = 0
                        },
                        new
                        {
                            Id = 15,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Lollipop",
                            Wins = 0
                        },
                        new
                        {
                            Id = 16,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Olive",
                            Wins = 0
                        },
                        new
                        {
                            Id = 17,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Spiral",
                            Wins = 0
                        },
                        new
                        {
                            Id = 18,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Pulsar",
                            Wins = 0
                        },
                        new
                        {
                            Id = 19,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Cartman",
                            Wins = 0
                        },
                        new
                        {
                            Id = 20,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Keroppi",
                            Wins = 0
                        },
                        new
                        {
                            Id = 21,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Froggo",
                            Wins = 0
                        },
                        new
                        {
                            Id = 22,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Big Daddy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 23,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Bubbles",
                            Wins = 0
                        },
                        new
                        {
                            Id = 24,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Captain Hook",
                            Wins = 0
                        },
                        new
                        {
                            Id = 25,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Harry",
                            Wins = 0
                        },
                        new
                        {
                            Id = 26,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Shelldon",
                            Wins = 0
                        },
                        new
                        {
                            Id = 27,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Bob",
                            Wins = 0
                        },
                        new
                        {
                            Id = 28,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Molly",
                            Wins = 0
                        },
                        new
                        {
                            Id = 29,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Shelly",
                            Wins = 0
                        },
                        new
                        {
                            Id = 30,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Claude",
                            Wins = 0
                        },
                        new
                        {
                            Id = 31,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Backspace",
                            Wins = 0
                        },
                        new
                        {
                            Id = 32,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Big Mac",
                            Wins = 0
                        },
                        new
                        {
                            Id = 33,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Goody",
                            Wins = 0
                        },
                        new
                        {
                            Id = 34,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Alie",
                            Wins = 0
                        },
                        new
                        {
                            Id = 35,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Ninja",
                            Wins = 0
                        },
                        new
                        {
                            Id = 36,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Lucifer",
                            Wins = 0
                        },
                        new
                        {
                            Id = 37,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "God",
                            Wins = 0
                        },
                        new
                        {
                            Id = 38,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Casper",
                            Wins = 0
                        },
                        new
                        {
                            Id = 39,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Kevin",
                            Wins = 0
                        },
                        new
                        {
                            Id = 40,
                            Age = 2,
                            Defeats = 0,
                            FavFood = "Kottleter",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Loves = "Inte mycket",
                            Name = "Lucifer",
                            Wins = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}