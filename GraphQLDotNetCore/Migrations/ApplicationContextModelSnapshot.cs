﻿// <auto-generated />
using System;
using GraphQLDotNetCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphQLDotNetCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20728d8a-b136-4018-930a-0055942b09cb"),
                            Description = "Cash account for our users",
                            OwnerId = new Guid("dbbd615e-1c09-448c-8700-59713eae9c5e"),
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("a12e7b01-f7b0-4f15-935b-291c97987bac"),
                            Description = "Savings account for our users",
                            OwnerId = new Guid("d3360781-bb78-4a52-a18a-fabf08f0572e"),
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("8c43e0c1-4f2e-4b3c-b37a-4de3016bb78d"),
                            Description = "Income account for our users",
                            OwnerId = new Guid("d3360781-bb78-4a52-a18a-fabf08f0572e"),
                            Type = 3
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dbbd615e-1c09-448c-8700-59713eae9c5e"),
                            Address = "John Doe's address",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("d3360781-bb78-4a52-a18a-fabf08f0572e"),
                            Address = "Jane Doe's address",
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Account", b =>
                {
                    b.HasOne("GraphQLDotNetCore.Entities.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Owner", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
