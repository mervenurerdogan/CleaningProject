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
    public class IletisimMap : IEntityTypeConfiguration<Iletisim>
    {
        public void Configure(EntityTypeBuilder<Iletisim> builder)
        {
            builder.HasKey(i => i.IletisimID);
            builder.Property(i => i.IletisimID).ValueGeneratedOnAdd();
            builder.Property(i => i.PhoneNumber).HasAnnotation("MinValue", 11).HasAnnotation("MaxValue", 11);


            builder.ToTable("Iletisims");

            builder.HasData(new Iletisim
            {
                IletisimID = 1,
                Address = "uzun adress",
                ShortAddress = "Aksaray/Merkez TÜRKİYE",
                PhoneNumber = "96321456999",
                Mail = "rey@gmail.com",
                IsDeleted = false,
                IsActive = true,
                CreatedDate = DateTime.Now,

            });
        }
    }
}
