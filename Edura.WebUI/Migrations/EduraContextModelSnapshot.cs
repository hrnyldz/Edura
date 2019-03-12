﻿// <auto-generated />
using Edura.WebUI.Repository.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Edura.WebUI.Migrations
{
    [DbContext(typeof(EduraContext))]
    partial class EduraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Edura.WebUI.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Edura.WebUI.Entity.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageName");

                    b.Property<int>("ProductId");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Edura.WebUI.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<string>("HtmlContent");

                    b.Property<string>("Image");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsFeatured");

                    b.Property<bool>("IsHome");

                    b.Property<double>("Price");

                    b.Property<string>("ProductName");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Edura.WebUI.Entity.ProductAttribute", b =>
                {
                    b.Property<int>("ProductAttributeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attribute");

                    b.Property<int>("ProductId");

                    b.Property<string>("Value");

                    b.HasKey("ProductAttributeId");

                    b.HasIndex("ProductId");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("Edura.WebUI.Entity.ProductCategory", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("CategoryId");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Edura.WebUI.Entity.Image", b =>
                {
                    b.HasOne("Edura.WebUI.Entity.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Edura.WebUI.Entity.ProductAttribute", b =>
                {
                    b.HasOne("Edura.WebUI.Entity.Product", "Product")
                        .WithMany("Attributes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Edura.WebUI.Entity.ProductCategory", b =>
                {
                    b.HasOne("Edura.WebUI.Entity.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Edura.WebUI.Entity.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
