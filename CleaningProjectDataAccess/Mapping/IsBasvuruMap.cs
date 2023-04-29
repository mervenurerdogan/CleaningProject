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
    public class IsBasvuruMap : IEntityTypeConfiguration<IsBasvuru>
    {
        public void Configure(EntityTypeBuilder<IsBasvuru> builder)
        {
            builder.HasKey(i => i.IsBasvuruID);
            builder.Property(i => i.IsBasvuruID).ValueGeneratedOnAdd();
            builder.Property(i => i.Name).HasMaxLength(50).IsRequired();
            builder.Property(i => i.Surname).HasMaxLength(60).IsRequired();
            builder.Property(i => i.PhoneNumber).IsRequired().HasAnnotation("MaxValue",11).HasAnnotation("MinValue",11);
            builder.Property(i => i.Mail).IsRequired();
            builder.Property(i => i.Address).IsRequired();
            builder.Property(i => i.LastEmployedCompany).HasMaxLength(300);
            builder.Property(i => i.CV).IsRequired();
            builder.ToTable("IsBasvurus");

            builder.HasData(new IsBasvuru
            {
                IsBasvuruID = 1,
                Name = "Ayşe",
                Surname = "Dumankaya",
                PhoneNumber = "05966665214",
                Mail = "ayse@gmail.com",
                Address = "Aksaray/Merkez",
                LastEmployedCompany = "",
                CV = "blala bala blaaa",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now


            });
        }
    }
}
