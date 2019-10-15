﻿// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191015033432_RefactorDatabaseWithDTO")]
    partial class RefactorDatabaseWithDTO
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Data.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Editor");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BackEnd.Data.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("CustomerId");

                    b.HasIndex("FirstName")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BackEnd.Data.CustomerOrder", b =>
                {
                    b.Property<int>("CustomerId");

                    b.Property<int>("OrderId");

                    b.Property<int?>("BookId");

                    b.HasKey("CustomerId", "OrderId");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("CustomerOrder");
                });

            modelBuilder.Entity("BackEnd.Data.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<int>("BookId");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Editor");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BackEnd.Data.OrderBook", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<int>("BookId");

                    b.HasKey("OrderId", "BookId");

                    b.ToTable("OrderBook");
                });

            modelBuilder.Entity("BackEnd.Data.CustomerOrder", b =>
                {
                    b.HasOne("BackEnd.Data.Book")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("BookId");

                    b.HasOne("BackEnd.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BackEnd.Data.Order", "Order")
                        .WithMany("CustomerOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BackEnd.Data.Order", b =>
                {
                    b.HasOne("BackEnd.Data.Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BackEnd.Data.OrderBook", b =>
                {
                    b.HasOne("BackEnd.Data.Order", "Order")
                        .WithMany("OrderBooks")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}