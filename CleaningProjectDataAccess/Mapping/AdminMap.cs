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
    public class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(a => a.AdminID);
            builder.Property(a => a.AdminID).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).HasMaxLength(50);
            builder.Property(a => a.Surname).HasMaxLength(50);
            builder.Property(a => a.UserName).HasMaxLength(20);
            builder.Property(a=>a.Password).HasAnnotation("MinValue",5);
            builder.Property(a=>a.Password).HasAnnotation("MaxValue",10);
            builder.ToTable("Admins");

            builder.HasData(new Admin
            {
                AdminID=1,
                Name="admin",
                Surname="adminss",
                UserName="admin963",
                Password="96321.",
                IsActive=true,
                IsDeleted=false,
                CreatedDate=DateTime.Now,
            });
            
        }
    }
}
