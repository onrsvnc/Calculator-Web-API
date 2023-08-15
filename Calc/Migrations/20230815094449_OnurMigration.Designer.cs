﻿// <auto-generated />
using Calc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Calc.Migrations
{
    [DbContext(typeof(CalculatorDBContext))]
    [Migration("20230815094449_OnurMigration")]
    partial class OnurMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Calc.Models.Calculation", b =>
                {
                    b.Property<int>("CalculationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalculationID"));

                    b.Property<decimal>("A")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("B")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Operation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Result")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CalculationID");

                    b.ToTable("CalculationHistory");
                });
#pragma warning restore 612, 618
        }
    }
}