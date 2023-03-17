﻿// <auto-generated />
using System;
using Factory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Factory.Migrations
{
    [DbContext(typeof(FactoryContext))]
    partial class FactoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("MachineId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("EngineerId");

                    b.HasIndex("MachineId");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("Factory.Models.EngineerLiscence", b =>
                {
                    b.Property<int>("EngineerLiscenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EngineerId")
                        .HasColumnType("int");

                    b.Property<int>("LiscenceId")
                        .HasColumnType("int");

                    b.HasKey("EngineerLiscenceId");

                    b.HasIndex("EngineerId");

                    b.HasIndex("LiscenceId");

                    b.ToTable("EngineerLiscences");
                });

            modelBuilder.Entity("Factory.Models.Liscence", b =>
                {
                    b.Property<int>("LiscenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LiscenceDetail")
                        .HasColumnType("longtext");

                    b.HasKey("LiscenceId");

                    b.ToTable("Liscences");
                });

            modelBuilder.Entity("Factory.Models.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("longtext");

                    b.HasKey("MachineId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Factory.Models.Engineer", b =>
                {
                    b.HasOne("Factory.Models.Machine", null)
                        .WithMany("Engineers")
                        .HasForeignKey("MachineId");
                });

            modelBuilder.Entity("Factory.Models.EngineerLiscence", b =>
                {
                    b.HasOne("Factory.Models.Engineer", "Engineer")
                        .WithMany()
                        .HasForeignKey("EngineerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Factory.Models.Liscence", "Liscence")
                        .WithMany("JoinEntities")
                        .HasForeignKey("LiscenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("Liscence");
                });

            modelBuilder.Entity("Factory.Models.Liscence", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Factory.Models.Machine", b =>
                {
                    b.Navigation("Engineers");
                });
#pragma warning restore 612, 618
        }
    }
}
