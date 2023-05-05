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
    public class HizmetMap : IEntityTypeConfiguration<Hizmet>
    {
        public void Configure(EntityTypeBuilder<Hizmet> builder)
        {
            builder.HasKey(h => h.HizmetID);
            builder.Property(h => h.HizmetID).ValueGeneratedOnAdd();
            builder.Property(h => h.Name).HasMaxLength(250);
            builder.Property(h => h.Desciption).HasMaxLength(1000);
            builder.ToTable("Hizmets");

            builder.HasData(new Hizmet
            {
                HizmetID=1,
                Name="Ev Temziliği",
                Desciption="Açıklama hizmet detayları ",
                img_path="img.png",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                IsActive=true,
                
            });
        }
    }
}
