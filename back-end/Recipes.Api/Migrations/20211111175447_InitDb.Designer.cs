﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipes.Repository.Context;

namespace Recipes.Api.Migrations
{
    [DbContext(typeof(RecipesContext))]
    [Migration("20211111175447_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("IngredientDomainRecipesDomain", b =>
                {
                    b.Property<long>("Ingredientsid")
                        .HasColumnType("bigint");

                    b.Property<long>("Recipesid")
                        .HasColumnType("bigint");

                    b.HasKey("Ingredientsid", "Recipesid");

                    b.HasIndex("Recipesid");

                    b.ToTable("IngredientDomainRecipesDomain");
                });

            modelBuilder.Entity("Recipes.Repository.Domain.IngredientDomain", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<string>("Unit")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Recipes.Repository.Domain.RecipesDomain", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Instructions")
                        .HasColumnType("longtext");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Recipes.Repository.Domain.RecipesIngredientDomain", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("IngredientId")
                        .HasColumnType("bigint");

                    b.Property<long>("RecipesId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipesId");

                    b.ToTable("RecipesIngredients");
                });

            modelBuilder.Entity("IngredientDomainRecipesDomain", b =>
                {
                    b.HasOne("Recipes.Repository.Domain.IngredientDomain", null)
                        .WithMany()
                        .HasForeignKey("Ingredientsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipes.Repository.Domain.RecipesDomain", null)
                        .WithMany()
                        .HasForeignKey("Recipesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recipes.Repository.Domain.RecipesIngredientDomain", b =>
                {
                    b.HasOne("Recipes.Repository.Domain.IngredientDomain", "Ingredient")
                        .WithMany("RecipesIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recipes.Repository.Domain.RecipesDomain", "Recipes")
                        .WithMany("RecipesIngredients")
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Recipes.Repository.Domain.IngredientDomain", b =>
                {
                    b.Navigation("RecipesIngredients");
                });

            modelBuilder.Entity("Recipes.Repository.Domain.RecipesDomain", b =>
                {
                    b.Navigation("RecipesIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
