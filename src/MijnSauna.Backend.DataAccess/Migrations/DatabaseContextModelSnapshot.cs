﻿// <auto-generated />
using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MijnSauna.Backend.DataAccess.Migrations
{
    [ExcludeFromCodeCoverage]
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MijnSauna.Backend.Model.Sample", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsInfraredPowered");

                    b.Property<bool>("IsSaunaPowered");

                    b.Property<Guid?>("SessionId");

                    b.Property<int>("SysId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Temperature");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("SessionId");

                    b.HasIndex("SysId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("SAMPLES");
                });

            modelBuilder.Entity("MijnSauna.Backend.Model.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ActualEnd");

                    b.Property<DateTime>("End");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsCancelled");

                    b.Property<bool>("IsInfrared");

                    b.Property<bool>("IsSauna");

                    b.Property<DateTime>("Start");

                    b.Property<int>("SysId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("TemperatureGoal");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("SysId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("SESSIONS");
                });

            modelBuilder.Entity("MijnSauna.Backend.Model.Sample", b =>
                {
                    b.HasOne("MijnSauna.Backend.Model.Session", "Session")
                        .WithMany("Samples")
                        .HasForeignKey("SessionId");
                });
#pragma warning restore 612, 618
        }
    }
}