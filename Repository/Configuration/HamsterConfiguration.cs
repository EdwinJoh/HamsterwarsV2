using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class HamsterConfiguration : IEntityTypeConfiguration<Hamster>
    {
        public void Configure(EntityTypeBuilder<Hamster> builder)
        {
            builder.HasData
                (
                new Hamster
                {
                    Id = 1,
                    Name = "Arvy",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-1.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 2,
                    Name = "Unexpected",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-2.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 3,
                    Name = "Sonny",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-3.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 4,
                    Name = "Atlanta",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-4.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 5,
                    Name = "Galaxy",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-5.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 6,
                    Name = "Piper",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-6.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 7,
                    Name = "Bliss",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-7.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 8,
                    Name = "Tyson",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-8.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 9,
                    Name = "Hugh Heifer",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-9.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 10,
                    Name = "Fury",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-10.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 11,
                    Name = "Duke",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-11.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 12,
                    Name = "Marvin",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-12.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 13,
                    Name = "Nexus",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-13.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 14,
                    Name = "Cherry",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-14.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 15,
                    Name = "Lollipop",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-15.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 16,
                    Name = "Olive",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-16.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 17,
                    Name = "Spiral",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-17.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 18,
                    Name = "Pulsar",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-18.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 19,
                    Name = "Cartman",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-19.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 20,
                    Name = "Keroppi",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-20.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 21,
                    Name = "Froggo",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-21.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 22,
                    Name = "Big Daddy",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-22.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 23,
                    Name = "Bubbles",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-23.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 24,
                    Name = "Captain Hook",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-24.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 25,
                    Name = "Harry",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-25.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 26,
                    Name = "Shelldon",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-26.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 27,
                    Name = "Bob",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-27.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 28,
                    Name = "Molly",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-28.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 29,
                    Name = "Shelly",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-29.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 30,
                    Name = "Claude",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-30.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 31,
                    Name = "Backspace",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-31.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 32,
                    Name = "Big Mac",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-32.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 33,
                    Name = "Goody",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-33.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 34,
                    Name = "Alie",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-34.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 35,
                    Name = "Ninja",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-35.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 36,
                    Name = "Lucifer",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-36.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 37,
                    Name = "God",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-37.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 38,
                    Name = "Casper",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-38.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 39,
                    Name = "Kevin",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-39.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }, new Hamster
                {
                    Id = 40,
                    Name = "Lucifer",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-40.jpg",
                    Wins = 0,
                    Defeats = 0,
                    Games = 0
                }

                );

        }
    }
}
