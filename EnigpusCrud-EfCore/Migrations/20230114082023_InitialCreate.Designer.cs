﻿// <auto-generated />
using EnigpusCrud_EfCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnigpusCrudEfCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230114082023_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnigpusCrud_EfCore.Entities.Magazine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVarchar (12)")
                        .HasColumnName("id");

                    b.Property<string>("PublishPeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("publish_period");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVarchar (50)")
                        .HasColumnName("title");

                    b.Property<int>("YearPeriod")
                        .HasColumnType("int")
                        .HasColumnName("year_period");

                    b.HasKey("Id");

                    b.HasIndex("Title");

                    b.ToTable("magazine");
                });

            modelBuilder.Entity("EnigpusCrud_EfCore.Entities.Novel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVarchar(12)")
                        .HasColumnName("id");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int")
                        .HasColumnName("publish_year");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("publisher");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVarchar (50)")
                        .HasColumnName("name");

                    b.Property<string>("Writer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("writer");

                    b.HasKey("Id");

                    b.HasIndex("Title");

                    b.ToTable("novel");
                });
#pragma warning restore 612, 618
        }
    }
}