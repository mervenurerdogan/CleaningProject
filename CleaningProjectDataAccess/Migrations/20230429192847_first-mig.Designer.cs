﻿// <auto-generated />
using System;
using CleaningProjectDataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleaningProjectDataAccess.Migrations
{
    [DbContext(typeof(CleaningProjectDbContext))]
    [Migration("20230429192847_first-mig")]
    partial class firstmig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleaningProjectModel.Entities.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("MaxValue", 10)
                        .HasAnnotation("MinValue", 5);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins", (string)null);

                    b.HasData(
                        new
                        {
                            AdminID = 1,
                            CreatedDate = new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(4204),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Ramazan",
                            Password = "E68r68.",
                            Surname = "Erdoğan",
                            UserName = "Erdogan68"
                        });
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.Hizmet", b =>
                {
                    b.Property<int>("HizmetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HizmetID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desciption")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("HizmetID");

                    b.ToTable("Hizmets", (string)null);

                    b.HasData(
                        new
                        {
                            HizmetID = 1,
                            CreatedDate = new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(4682),
                            Desciption = "Açıklama hizmet detayları ",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Ev Temziliği"
                        });
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.Ilce", b =>
                {
                    b.Property<int>("IlceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlceID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("IlceID");

                    b.ToTable("Ilces", (string)null);

                    b.HasData(
                        new
                        {
                            IlceID = 1,
                            CreatedDate = new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(5293),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Merkez"
                        });
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.IsBasvuru", b =>
                {
                    b.Property<int>("IsBasvuruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IsBasvuruID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FinishEmployed")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastEmployedCompany")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("MaxValue", 11)
                        .HasAnnotation("MinValue", 11);

                    b.Property<DateTime>("StartEmployed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("IsBasvuruID");

                    b.ToTable("IsBasvurus", (string)null);

                    b.HasData(
                        new
                        {
                            IsBasvuruID = 1,
                            Address = "Aksaray/Merkez",
                            CV = "blala bala blaaa",
                            CreatedDate = new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(5810),
                            FinishEmployed = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LastEmployedCompany = "",
                            Mail = "ayse@gmail.com",
                            Name = "Ayşe",
                            PhoneNumber = "05966665214",
                            StartEmployed = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Surname = "Dumankaya"
                        });
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.Personnel", b =>
                {
                    b.Property<int>("PersonnelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonnelID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasAnnotation("MaxValue", 11)
                        .HasAnnotation("MinValue", 11);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasAnnotation("MaxValue", 11)
                        .HasAnnotation("MinValue", 11);

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonnelID");

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Personnels", (string)null);

                    b.HasData(
                        new
                        {
                            PersonnelID = 1,
                            Address = "Aksaray",
                            CreatedDate = new DateTime(2023, 4, 29, 22, 28, 47, 100, DateTimeKind.Local).AddTicks(6916),
                            Email = "anakiz@gmail.com",
                            IdentityNumber = "99966655599",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Anakız",
                            PhoneNumber = "99966633322",
                            SurName = "Soyad"
                        });
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.PersonnelHizmet", b =>
                {
                    b.Property<int>("HizmetID")
                        .HasColumnType("int");

                    b.Property<int>("TeklifID")
                        .HasColumnType("int");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("WorkDate")
                        .HasColumnType("datetime2");

                    b.HasKey("HizmetID", "TeklifID", "PersonelID");

                    b.HasIndex("PersonelID");

                    b.HasIndex("TeklifID");

                    b.ToTable("PersonnelHizmets", (string)null);

                    b.HasData(
                        new
                        {
                            HizmetID = 1,
                            TeklifID = 1,
                            PersonelID = 1,
                            CreatedDate = new DateTime(2023, 4, 29, 22, 28, 47, 101, DateTimeKind.Local).AddTicks(3823),
                            IsActive = true,
                            IsDeleted = false,
                            Price = 5,
                            WorkDate = new DateTime(2022, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.TeklifAl", b =>
                {
                    b.Property<int>("TeklifID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeklifID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HizmetID")
                        .HasColumnType("int");

                    b.Property<int>("IlceID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasAnnotation("MaxValue", 11)
                        .HasAnnotation("MinValue", 11);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TeklifDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TeklifID");

                    b.HasIndex("HizmetID");

                    b.HasIndex("IlceID");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("TeklifAls", (string)null);

                    b.HasData(
                        new
                        {
                            TeklifID = 1,
                            Address = "adress",
                            CreatedDate = new DateTime(2023, 4, 29, 22, 28, 47, 101, DateTimeKind.Local).AddTicks(7082),
                            HizmetID = 1,
                            IlceID = 1,
                            IsActive = true,
                            IsDeleted = false,
                            Mail = "nur@gmail.com",
                            Name = "Nur",
                            Note = "istenilen hizmet detayları örn m^2 vs vs yazılır",
                            PhoneNumber = "33322211144",
                            Surname = "Al",
                            TeklifDate = new DateTime(2023, 6, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.PersonnelHizmet", b =>
                {
                    b.HasOne("CleaningProjectModel.Entities.Hizmet", "Hizmet")
                        .WithMany("PersonnelHizmets")
                        .HasForeignKey("HizmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleaningProjectModel.Entities.Personnel", "Personnel")
                        .WithMany("PersonnelHizmets")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleaningProjectModel.Entities.TeklifAl", "TeklifAl")
                        .WithMany("PersonnelHizmets")
                        .HasForeignKey("TeklifID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hizmet");

                    b.Navigation("Personnel");

                    b.Navigation("TeklifAl");
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.TeklifAl", b =>
                {
                    b.HasOne("CleaningProjectModel.Entities.Hizmet", "Hizmet")
                        .WithMany("TeklifAls")
                        .HasForeignKey("HizmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleaningProjectModel.Entities.Ilce", "Ilce")
                        .WithMany("TeklifAls")
                        .HasForeignKey("IlceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hizmet");

                    b.Navigation("Ilce");
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.Hizmet", b =>
                {
                    b.Navigation("PersonnelHizmets");

                    b.Navigation("TeklifAls");
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.Ilce", b =>
                {
                    b.Navigation("TeklifAls");
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.Personnel", b =>
                {
                    b.Navigation("PersonnelHizmets");
                });

            modelBuilder.Entity("CleaningProjectModel.Entities.TeklifAl", b =>
                {
                    b.Navigation("PersonnelHizmets");
                });
#pragma warning restore 612, 618
        }
    }
}
