﻿// <auto-generated />
using System;
using ConverterAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConverterAPI.Migrations
{
    [DbContext(typeof(AuditContext))]
    [Migration("20190611165048_MyCoreAPIDemo.Entities.AuditContextSeed")]
    partial class MyCoreAPIDemoEntitiesAuditContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConverterAPI.Entities.UserActions", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTimeStamp")
                        .HasMaxLength(50);

                    b.Property<string>("FromUnit")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("Initial")
                        .HasMaxLength(50);

                    b.Property<string>("ToUnit")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("Value")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("UserAction","dbo");

                    b.HasData(
                        new
                        {
                            ID = new Guid("76b1faa0-77f5-4e0a-b7fb-159a53697ce1"),
                            DateTimeStamp = new DateTime(2019, 6, 11, 18, 50, 47, 535, DateTimeKind.Local).AddTicks(8575),
                            FromUnit = "KM",
                            Initial = 0.0,
                            ToUnit = "Mile",
                            Username = "Bob",
                            Value = 0.0
                        },
                        new
                        {
                            ID = new Guid("f8dae740-71c9-4edd-807e-279210ff958e"),
                            DateTimeStamp = new DateTime(2019, 6, 11, 18, 50, 47, 540, DateTimeKind.Local).AddTicks(3520),
                            FromUnit = "Mile",
                            Initial = 0.0,
                            ToUnit = "KM",
                            Username = "John",
                            Value = 0.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
