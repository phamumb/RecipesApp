﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipes.Repository.Context;

namespace Recipes.Api.Migrations
{
    [DbContext(typeof(Repository.Context.AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Recipes.Repository.Domain.IngredientDomain", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<byte[]>("FileContent")
                        .HasColumnType("longblob");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<long?>("RecipeDomainid")
                        .HasColumnType("bigint");

                    b.Property<string>("Unit")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("RecipeDomainid");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Recipes.Repository.Domain.RecipeDomain", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Instructions")
                        .HasColumnType("longtext");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Recipes.Repository.Domain.IngredientDomain", b =>
                {
                    b.HasOne("Recipes.Repository.Domain.RecipeDomain", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeDomainid");
                });

            modelBuilder.Entity("Recipes.Repository.Domain.RecipeDomain", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}