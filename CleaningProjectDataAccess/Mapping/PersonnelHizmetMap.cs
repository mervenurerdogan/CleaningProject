using CleaningProjectModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectDataAccess.Mapping
{
    public class PersonnelHizmetMap : IEntityTypeConfiguration<PersonnelHizmet>
    {
        public void Configure(EntityTypeBuilder<PersonnelHizmet> builder)
        {
           
            builder.HasKey(ph => new { ph.HizmetID, ph.TeklifID, ph.PersonelID });
            builder.HasOne<Hizmet>(ph => ph.Hizmet).WithMany(h => h.PersonnelHizmets).HasForeignKey(ph => ph.HizmetID);
            builder.HasOne<TeklifAl>(ph => ph.TeklifAl).WithMany(t=>t.PersonnelHizmets).HasForeignKey(ph=>ph.TeklifID);
            builder.HasOne<Personnel>(p=>p.Personnel).WithMany(p=>p.PersonnelHizmets).HasForeignKey(ph=>ph.PersonelID);
            builder.ToTable("PersonnelHizmets");

            builder.HasData(new PersonnelHizmet
            {
                HizmetID=1,
                TeklifID=1,
                PersonelID=1,
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                IsActive=true,
                WorkDate= new DateTime(2022, 2, 1, 8, 0, 0),
                Price=5


            });




           
        

    }
    }
}
