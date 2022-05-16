using Liste.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste.DataAccess.Mapping
{
    public class SinifListesiMap : IEntityTypeConfiguration<SinifListesi>
    {
        public void Configure(EntityTypeBuilder<SinifListesi> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Ad).HasMaxLength(100);
            builder.Property(a => a.Soyad).HasMaxLength(100);
            builder.Property(a => a.Yas).HasColumnType("INTEGER");
            builder.Property(a => a.Okulu).HasMaxLength(100);
            builder.Property(a => a.Alani).HasMaxLength(100);
            builder.HasData(
                new SinifListesi
                {
                    Id = 1,
                    Ad = "ömer",
                    Soyad = "faruk",
                    Yas = 12,
                    Okulu = "ilkokul",
                    Alani = "matematik",

                },
                new SinifListesi
                {
                    Id = 2,
                    Ad = "ahmet",
                    Soyad = "veli",
                    Yas = 20,
                    Okulu = "lise",
                    Alani = "türkçe",

                },
                new SinifListesi
                {
                    Id = 3,
                    Ad = "erman",
                    Soyad = "ataş",
                    Yas = 16,
                    Okulu = "lise",
                    Alani = "türkçe",

                }
                );
        }
    }
}
