﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QTApi.DAL;

namespace QTApi.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20181116043913_AddKey")]
    partial class AddKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QTApi.Models.CatFact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Fact")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CatFacts");
                });
#pragma warning restore 612, 618
        }
    }
}
