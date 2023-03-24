using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject.Models;

public partial class CoffeeShopContext : DbContext
{
    public CoffeeShopContext()
    {
    }

    public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public User admin = getAdmin();
    public static User getAdmin() {
        User admin = new User();
        IConfiguration configuration = new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", true, true).Build();
        admin = new User {
            Username = configuration[key: "account:admin:username"],
            Password = configuration["account:admin:password"]
        };
        return admin;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        IConfiguration configuration = new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", true, true).Build();
        optionsBuilder.UseSqlServer(configuration["ConnectionStrings:CoffeeShopDB"]);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Cart>(entity => {
            entity
                .HasNoKey()
                .ToTable("Cart");

            entity.Property(e => e.ItemId)
                .HasMaxLength(5)
                .HasColumnName("itemId");
            entity.Property(e => e.ItemName)
                .HasMaxLength(150)
                .HasColumnName("itemName");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("orderDate");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Item).WithMany()
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_Cart_Item");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Cart_User");
        });

        modelBuilder.Entity<Category>(entity => {
            entity.ToTable("Category");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(150)
                .HasColumnName("categoryName");
        });

        modelBuilder.Entity<Item>(entity => {
            entity.HasKey(e => e.ItemId).HasName("PK_Item_1");

            entity.ToTable("Item");

            entity.Property(e => e.ItemId)
                .HasMaxLength(5)
                .HasColumnName("itemId");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.ItemName)
                .HasMaxLength(150)
                .HasColumnName("itemName");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");

            entity.HasOne(d => d.Category).WithMany(p => p.Items)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Item_Category");
        });

        modelBuilder.Entity<Order>(entity => {
            entity.HasKey(e => e.OrderId).HasName("PK_Order_1");

            entity.ToTable("Order");

            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasMaxLength(150)
                .HasColumnName("status");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Order_User1");
        });

        modelBuilder.Entity<OrderDetail>(entity => {
            entity
                .HasNoKey()
                .ToTable("OrderDetail");

            entity.Property(e => e.ItemId)
                .HasMaxLength(5)
                .HasColumnName("itemId");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("orderDate");
            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Item).WithMany()
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_OrderDetail_Item");

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderDetail_Order");
        });

        modelBuilder.Entity<User>(entity => {
            entity.HasKey(e => e.UserId).HasName("PK_Table_1");

            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
