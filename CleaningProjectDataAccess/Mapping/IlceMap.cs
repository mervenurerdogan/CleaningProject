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
    public class IlceMap : IEntityTypeConfiguration<Ilce>
    {
        public void Configure(EntityTypeBuilder<Ilce> builder)
        {
            builder.HasKey(i => i.IlceID);
            builder.Property(i => i.IlceID).ValueGeneratedOnAdd();
            builder.Property(i => i.Name).HasMaxLength(60);
            builder.ToTable("Ilces");

            builder.HasData(new Ilce
            {
                IlceID = 1,
                Name = "Merkez",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now

            });
        }
    }
}
