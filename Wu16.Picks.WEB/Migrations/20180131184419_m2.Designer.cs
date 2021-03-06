﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using Wu16.Picks.WEB.DataAccess;

namespace Wu16.Picks.WEB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180131184419_m2")]
    partial class m2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wu16.Picks.WEB.Controllers.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Wu16.Picks.WEB.Controllers.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("ContentType");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("FileName");

                    b.Property<double>("Ratio");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Wu16.Picks.WEB.Controllers.Image", b =>
                {
                    b.HasOne("Wu16.Picks.WEB.Controllers.Category", "Category")
                        .WithMany("Images")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
