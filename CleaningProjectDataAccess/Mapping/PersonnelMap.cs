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
    public class PersonnelMap : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.HasKey(p => p.PersonnelID);
            builder.Property(p => p.PersonnelID).ValueGeneratedOnAdd();
            builder.Property(p => p.IdentityNumber).IsRequired().HasAnnotation("MinValue", 11).HasAnnotation("MaxValue", 11);
            builder.HasIndex(p => p.IdentityNumber).IsUnique();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.SurName).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(300);
            builder.Property(p => p.PhoneNumber).IsRequired().HasAnnotation("MinValue", 11).HasAnnotation("MaxValue", 11);
            builder.HasIndex(p => p.PhoneNumber).IsUnique();
            builder.ToTable("Personnels");

            builder.HasData(new Personnel
            {
                PersonnelID = 1,
                IdentityNumber="99966655599",
                Name = "Anakız",
                SurName = "Soyad",
                Address = "Aksaray",
                PhoneNumber = "99966633322",
                Email = "anakiz@gmail.com",
                IsActive= true,
                IsDeleted=false,
                CreatedDate=DateTime.Now

            });
            
      
        }
    }
}
