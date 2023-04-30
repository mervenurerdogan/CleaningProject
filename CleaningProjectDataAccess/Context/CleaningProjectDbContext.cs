using CleaningProjectDataAccess.Mapping;
using CleaningProjectModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectDataAccess.Context
{
    public class CleaningProjectDbContext:DbContext
    {
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Hizmet> Hizmets { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<IsBasvuru> IsBasvurus { get; set; }
        public DbSet<PersonnelHizmet> PersonnelHizmets { get; set; }
        public DbSet<TeklifAl> TeklifAls { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<SosyalMedya> SosyalMedyas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QUGP58L\SQLEXPRESS;Database=CleaningCompanyProjectDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminMap());
            modelBuilder.ApplyConfiguration(new HizmetMap());
            modelBuilder.ApplyConfiguration(new IlceMap());
            modelBuilder.ApplyConfiguration(new IsBasvuruMap());
            modelBuilder.ApplyConfiguration(new PersonnelMap());
            modelBuilder.ApplyConfiguration(new PersonnelHizmetMap());
            modelBuilder.ApplyConfiguration(new TeklifAlMap());
            modelBuilder.ApplyConfiguration(new HakkimizdaMap());
            modelBuilder.ApplyConfiguration(new SosyalMedyaMap());
            modelBuilder.ApplyConfiguration(new IletisimMap());
        }
    }
}
