﻿using Entities.Models;
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
                    Id =2,
                    Name = "Edwin",
                    Age = 2,
                    FavFood = "Kottleter",
                    Loves = "Inte mycket",
                    ImgName = "hamster-1.jpg",
                    Wins = 1,
                    Defeats =1,
                    Games =2
                });
        }
    }
}