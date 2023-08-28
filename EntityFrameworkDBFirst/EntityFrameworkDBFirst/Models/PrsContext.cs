using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDBFirst.Models;

public partial class PrsContext : DbContext
{
    public PrsContext()
    {
    }

    public PrsContext(DbContextOptions<PrsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestLine> RequestLines { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlServer("server=localhost\\sqlexpress;database=PRS;trusted_connection=true;trustServerCertificate=true;");

    // defines how to configure columns for entity framework
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__products__3214EC079208A4DD");

            entity.ToTable("products");

            entity.HasIndex(e => e.PartNbr, "UQ__products__DAFC0C1EB363CBB6").IsUnique();

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PartNbr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PhotoPath)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Price)
                .HasDefaultValueSql("((10))")
                .HasColumnType("decimal(11, 2)");
            entity.Property(e => e.Unit)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('Each')");

            entity.HasOne(d => d.Vendor).WithMany(p => p.Products)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__products__Vendor__2B3F6F97");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requests__3214EC07C7FABEC2");

            entity.ToTable("requests");

            entity.Property(e => e.DeliveryMode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('Pickup')");
            entity.Property(e => e.Description)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Justification)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('NEW')");
            entity.Property(e => e.Total)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(11, 2)");

            entity.HasOne(d => d.User).WithMany(p => p.Requests)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__requests__UserId__31EC6D26");
        });

        modelBuilder.Entity<RequestLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RequestL__3214EC079534BDD4");

            entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Product).WithMany(p => p.RequestLines)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RequestLi__Produ__3A81B327");

            entity.HasOne(d => d.Request).WithMany(p => p.RequestLines)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK__RequestLi__Reque__398D8EEE");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3214EC0711872CF3");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "UQ__users__536C85E4768BDE0F").IsUnique();

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Firstname)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Lastname)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vendors__3214EC073C9A51FA");

            entity.ToTable("vendors");

            entity.HasIndex(e => e.Code, "UQ__vendors__A25C5AA7F0695B45").IsUnique();

            entity.Property(e => e.Address)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
