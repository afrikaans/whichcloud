﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WhichCloud.Web.data;

namespace WhichCloud.Web.Migrations
{
    [DbContext(typeof(ResourceContext))]
    [Migration("20200805093117_source-entity")]
    partial class sourceentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WhichCloud.Web.Models.Source", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("WhichCloud.Web.Models.VM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Bandwidth")
                        .HasColumnType("double precision");

                    b.Property<int>("CPU")
                        .HasColumnType("integer");

                    b.Property<string>("Link")
                        .HasColumnType("text");

                    b.Property<int>("Memory")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.Property<int>("Storage")
                        .HasColumnType("integer");

                    b.Property<int?>("VMTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VMTypeId");

                    b.ToTable("VMs");
                });

            modelBuilder.Entity("WhichCloud.Web.Models.VMType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VMTypes");
                });

            modelBuilder.Entity("WhichCloud.Web.Models.VM", b =>
                {
                    b.HasOne("WhichCloud.Web.Models.VMType", "VMType")
                        .WithMany()
                        .HasForeignKey("VMTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}