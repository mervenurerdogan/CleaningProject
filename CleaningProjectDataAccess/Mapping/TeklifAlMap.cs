using CleaningProjectModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectDataAccess.Mapping
{
    public class TeklifAlMap : IEntityTypeConfiguration<TeklifAl>
    {
        public void Configure(EntityTypeBuilder<TeklifAl> builder)
        {
            builder.HasKey(t => t.TeklifID);
            builder.Property(t => t.TeklifID).ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Surname).IsRequired();
            builder.Property(t => t.PhoneNumber).IsRequired().HasAnnotation("MinValue", 11).HasAnnotation("MaxValue", 11);
            builder.HasIndex(t => t.PhoneNumber).IsUnique();
            builder.Property(t => t.Note).IsRequired().HasMaxLength(500);
            builder.Property(t => t.Address).IsRequired();
            builder.ToTable("TeklifAls");

            //foreing key
            builder.HasOne<Hizmet>(h => h.Hizmet).WithMany(t => t.TeklifAls).HasForeignKey(t => t.TeklifHizmetID);
            builder.HasOne<Ilce>(i => i.Ilce).WithMany(t => t.TeklifAls).HasForeignKey(t => t.TeklifIlceID);

            builder.HasData(new TeklifAl
            {
                TeklifID = 1,
                TeklifHizmetID = 1,
                TeklifIlceID = 1,
                IsActive = true,
                IsDeleted = false,
                Name = "Nur",
                Surname = "Al",
                PhoneNumber = "33322211144",
                Address="adress",
                Mail = "nur@gmail.com",
                Note = "istenilen hizmet detayları örn m^2 vs vs yazılır",
                TeklifDate= new DateTime(2023, 6, 1, 8, 0, 0),
                CreatedDate= DateTime.Now,

            });

        }
    }
}
