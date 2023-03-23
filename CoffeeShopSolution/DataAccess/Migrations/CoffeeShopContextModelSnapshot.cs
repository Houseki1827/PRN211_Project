﻿// <auto-generated />
using System;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations {
    [DbContext(typeof(CoffeeShopContext))]
    partial class CoffeeShopContextModelSnapshot : ModelSnapshot {
        protected override void BuildModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObject.Models.Cart", b => {
                b.Property<int?>("Amount")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("((1))");

                b.Property<int?>("ItemId")
                    .HasColumnType("int")
                    .HasColumnName("iid");

                b.Property<string>("Note")
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)")
                    .HasColumnName("note");

                b.Property<int?>("UserId")
                    .HasColumnType("int")
                    .HasColumnName("uid");

                b.HasIndex("ItemId");

                b.HasIndex("UserId");

                b.ToTable("Cart", (string)null);
            });

            modelBuilder.Entity("BusinessObject.Models.Item", b => {
                b.Property<int>("ItemId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("id");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                b.Property<string>("Descr")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)")
                    .HasColumnName("descr");

                b.Property<string>("ItemName")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("nvarchar(40)")
                    .HasColumnName("name");

                b.Property<string>("ItemType")
                    .HasMaxLength(40)
                    .HasColumnType("nvarchar(40)")
                    .HasColumnName("type");

                b.Property<decimal?>("Price")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price")
                    .HasDefaultValueSql("((0))");

                b.Property<int?>("Stock")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("stock")
                    .HasDefaultValueSql("((1))");

                b.HasKey("ItemId")
                    .HasName("PK__Item__3213E83FBE4CE8D1");

                b.ToTable("Item", (string)null);
            });

            modelBuilder.Entity("BusinessObject.Models.Order", b => {
                b.Property<int>("OrderId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("oid");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                b.Property<decimal?>("Total")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("decimal(13, 2)")
                    .HasColumnName("total")
                    .HasDefaultValueSql("((0))");

                b.Property<int?>("UserId")
                    .HasColumnType("int")
                    .HasColumnName("uid");

                b.HasKey("OrderId")
                    .HasName("PK__Orders__C2FFCF13CB1E6200");

                b.HasIndex("UserId");

                b.ToTable("Orders");
            });

            modelBuilder.Entity("BusinessObject.Models.OrderDetail", b => {
                b.Property<int?>("Amount")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("((1))");

                b.Property<int?>("ItemId")
                    .HasColumnType("int")
                    .HasColumnName("iid");

                b.Property<string>("Note")
                    .ValueGeneratedOnAdd()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)")
                    .HasColumnName("note")
                    .HasDefaultValueSql("('')");

                b.Property<DateTime?>("OrderDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                b.Property<int?>("OrderId")
                    .HasColumnType("int")
                    .HasColumnName("oid");

                b.HasIndex("ItemId");

                b.HasIndex("OrderId");

                b.ToTable("OrderDetails");
            });

            modelBuilder.Entity("BusinessObject.Models.User", b => {
                b.Property<int>("UserId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("id");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("nvarchar(40)")
                    .HasColumnName("email");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("nvarchar(40)")
                    .HasColumnName("pass");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnType("nvarchar(40)")
                    .HasColumnName("name");

                b.HasKey("UserId")
                    .HasName("PK__Users__3213E83F63B8DC84");

                b.ToTable("Users");
            });

            modelBuilder.Entity("BusinessObject.Models.Cart", b => {
                b.HasOne("BusinessObject.Models.Item", "ItemIdNavigation")
                    .WithMany()
                    .HasForeignKey("ItemId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Cart__iid__72C60C4A");

                b.HasOne("BusinessObject.Models.User", "UserIdNavigation")
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Cart__uid__71D1E811");

                b.Navigation("ItemIdNavigation");

                b.Navigation("UserIdNavigation");
            });

            modelBuilder.Entity("BusinessObject.Models.Order", b => {
                b.HasOne("BusinessObject.Models.User", "UserIdNavigation")
                    .WithMany("Orders")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Orders__uid__76969D2E");

                b.Navigation("UserIdNavigation");
            });

            modelBuilder.Entity("BusinessObject.Models.OrderDetail", b => {
                b.HasOne("BusinessObject.Models.Item", "ItemIdNavigation")
                    .WithMany()
                    .HasForeignKey("ItemId")
                    .HasConstraintName("FK__OrderDetail__iid__7A672E12");

                b.HasOne("BusinessObject.Models.Order", "OrderIdNavigation")
                    .WithMany()
                    .HasForeignKey("OrderId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__OrderDetail__oid__797309D9");

                b.Navigation("ItemIdNavigation");

                b.Navigation("OrderIdNavigation");
            });

            modelBuilder.Entity("BusinessObject.Models.User", b => {
                b.Navigation("Orders");
            });
#pragma warning restore 612, 618
        }
    }
}
