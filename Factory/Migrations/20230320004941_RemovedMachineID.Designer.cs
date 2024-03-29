﻿// <auto-generated />
using Factory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Factory.Migrations
{
    [DbContext(typeof(FactoryContext))]
    [Migration("20230320004941_RemovedMachineID")]
    partial class RemovedMachineID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Factory.Models.Engineer", b =>
                {
                    b.Property<int>("EngineerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("EngineerId");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("Factory.Models.EngineerLicense", b =>
                {
                    b.Property<int>("EngineerLicenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EngineerId")
                        .HasColumnType("int");

                    b.Property<int>("LicenseId")
                        .HasColumnType("int");

                    b.HasKey("EngineerLicenseId");

                    b.HasIndex("EngineerId");

                    b.HasIndex("LicenseId");

                    b.ToTable("EngineerLicenses");
                });

            modelBuilder.Entity("Factory.Models.License", b =>
                {
                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LicenseDetail")
                        .HasColumnType("longtext");

                    b.HasKey("LicenseId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("Factory.Models.EngineerLicense", b =>
                {
                    b.HasOne("Factory.Models.Engineer", "Engineer")
                        .WithMany("JoinEntities")
                        .HasForeignKey("EngineerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Models.License", "License")
                        .WithMany("JoinEntities")
                        .HasForeignKey("LicenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("License");
                });

            modelBuilder.Entity("Factory.Models.Engineer", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Factory.Models.License", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
