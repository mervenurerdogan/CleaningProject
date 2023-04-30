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
    public class HakkimizdaMap : IEntityTypeConfiguration<Hakkimizda>
    {
        public void Configure(EntityTypeBuilder<Hakkimizda> builder)
        {
            builder.HasKey(h => h.HakkimizdaID);
            builder.Property(h=>h.HakkimizdaID).ValueGeneratedOnAdd();
            builder.ToTable("Hakkimzdas");
            builder.HasData(new Hakkimizda
            {
                HakkimizdaID=1,
                Tanitim="Hakkmizda",
                Vizyonumuz="vizyon öenmli",
                Misyonumuz="misyon önemli",
                IsDeleted=false,
                ImagePath="path",
                IsActive=true,
                CreatedDate=DateTime.Now

            });

        }
    }
}
