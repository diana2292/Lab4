﻿// <auto-generated />
using System;
using Lab1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab1.Migrations
{
    [DbContext(typeof(IntroDbContext))]
    [Migration("20190524064450_AddedComments")]
    partial class AddedComments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab1.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Important");

                    b.Property<int?>("MovieId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Lab1.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<string>("Director");

                    b.Property<int>("DurationInMinutes");

                    b.Property<int>("MovieGenre");

                    b.Property<double>("Rating");

                    b.Property<int>("ReleaseYear");

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.Property<int>("WasWatched");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Lab1.Models.Comment", b =>
                {
                    b.HasOne("Lab1.Models.Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId");
                });
#pragma warning restore 612, 618
        }
    }
}
