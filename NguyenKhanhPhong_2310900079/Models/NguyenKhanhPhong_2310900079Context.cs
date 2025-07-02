using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace NguyenKhanhPhong2310900079Context.Models;

public partial class NguyenKhanhPhong_2310900079Context : DbContext
{
    public NguyenKhanhPhong_2310900079Context()
    {
    }

    public NguyenKhanhPhong_2310900079Context(DbContextOptions<NguyenTrongHung2310900039Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NkpEmployee> NkpEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TRONGNHAT\\HUNG;Database=NguyenTrongHung_2310900039;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NkpEmployee>(entity =>
        {
            entity.HasKey(e => e.NkpEmpId).HasName("PK__NkpEmplo__A5E453C6F8ED62CD");

            entity.ToTable("NkpEmployee");

            entity.Property(e => e.NkpEmpId).HasColumnName("NkpEmpId");
            entity.Property(e => e.NkpEmpLevel)
                .HasMaxLength(50)
                .HasColumnName("NkpEmpLevel");
            entity.Property(e => e.NkpEmpName)
                .HasMaxLength(100)
                .HasColumnName("NkpEmpName");
            entity.Property(e => e.NkpEmpStartDate).HasColumnName("NkpEmpStartDate");
            entity.Property(e => e.NkpEmpStatus).HasColumnName("NkpEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}