using System;
using System.Collections.Generic;
using ForumApiCNet.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace ForumApiCNet.Models
{
    public partial class ForumContext : DbContext
    {


        public ForumContext()
        {
        }

        public ForumContext(DbContextOptions<ForumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;


        public virtual DbSet<TblPosts> TblPosts { get; set; } = null!;

        public virtual DbSet<TblThread> TblThread { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=DESKTOP-1HLSFE4\\SQLEXPRESS;Database=Forum;Trusted_Connection=True;Encrypt=False;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<TblUser>(entity =>
            // {
            //     entity.ToTable("tblUser");

            //     entity.Property(e => e.Id).HasColumnName("id");

            //     entity.Property(e => e.Email)
            //         .IsRequired()
            //         .HasMaxLength(50)
            //         .IsUnicode(false)
            //         .HasColumnName("email");

            //     entity.Property(e => e.Password)
            //         .IsRequired()
            //         .HasMaxLength(50)
            //         .IsUnicode(false)
            //         .HasColumnName("password");

            //     entity.Property(e => e.Username)
            //         .IsRequired()
            //         .HasMaxLength(50)
            //         .IsUnicode(false)
            //         .HasColumnName("username");
            // });

            // modelBuilder.Entity<TblPosts>(entity =>
            // {
            //     entity.ToTable("tblPosts");

            //     entity.Property(e => e.Id).HasColumnName("id");

            //     entity.Property(e => e.Category)
            //         .HasColumnName("category");

            //     entity.Property(e => e.Content)
            //         .HasColumnName("content");

            //     entity.Property(e => e.Title)
            //         .IsRequired()
            //         .HasMaxLength(50)
            //         .IsUnicode(false)
            //         .HasColumnName("title");
            // });

            // modelBuilder.Entity<TblThread>(entity =>
            // {
            //     entity.ToTable("tblThread");

            //     entity.Property(e => e.Id).HasColumnName("id");

            //     entity.Property(e => e.Title)
            //         .IsRequired()
            //         .HasMaxLength(50)
            //         .IsUnicode(false)
            //         .HasColumnName("title");
            // });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}