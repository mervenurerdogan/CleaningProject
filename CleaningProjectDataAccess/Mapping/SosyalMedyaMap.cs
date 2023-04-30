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
    public class SosyalMedyaMap : IEntityTypeConfiguration<SosyalMedya>
    {
        public void Configure(EntityTypeBuilder<SosyalMedya> builder)
        {
            builder.HasKey(s => s.SocialID);
            builder.Property(s => s.SocialID).ValueGeneratedOnAdd();
            builder.ToTable("SosyalMedyas");

            builder.HasData(new SosyalMedya
            {
                SocialID = 1,
                HesapFA = "<i class=\"fa-brands fa-instagram\"></i>",
                HesapURL = "https://z-p42.www.instagram.com/reytemizlik/",
                IsDeleted = false,
                IsActive = true,
                CreatedDate = DateTime.Now
            });

        }
    }
}
