﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeManagement.Models.Context;

namespace RecipeManagement.Migrations
{
    [DbContext(typeof(RecipeManagingContext))]
    partial class RecipeManagingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecipeManagement.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RecipeManagement.Models.Chef", b =>
                {
                    b.Property<int>("ChefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChefId");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("RecipeManagement.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RecipeManagement.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChefId")
                        .HasColumnType("int");

                    b.Property<string>("CookingTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreparationTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Servings")
                        .HasColumnType("int");

                    b.HasKey("RecipeId");

                    b.HasIndex("ChefId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipeManagement.Models.RecipeCategory", b =>
                {
                    b.Property<int>("RecipeCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("RecipeCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeCategories");
                });

            modelBuilder.Entity("RecipeManagement.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("RecipeIngredientId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("RecipeManagement.Models.Recipe", b =>
                {
                    b.HasOne("RecipeManagement.Models.Chef", "Chef")
                        .WithMany("Recipes")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeManagement.Models.RecipeCategory", b =>
                {
                    b.HasOne("RecipeManagement.Models.Category", "Category")
                        .WithMany("RecipeCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeManagement.Models.Recipe", "Recipe")
                        .WithMany("RecipeCategories")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeManagement.Models.RecipeIngredient", b =>
                {
                    b.HasOne("RecipeManagement.Models.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeManagement.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}