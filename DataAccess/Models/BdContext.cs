using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public partial class BdContext : DbContext
{
    public BdContext()
    {
    }

    public BdContext(DbContextOptions<BdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Cuentum> Cuenta { get; set; }

    public virtual DbSet<Multimedium> Multimedia { get; set; }

    public virtual DbSet<PagoCuentum> PagoCuenta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cuentum>(entity =>
        {
            entity.HasKey(e => e.IdCuenta).HasName("PK_Cuenta_1");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Cuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cuotas_Cliente");
        });

        modelBuilder.Entity<Multimedium>(entity =>
        {
            entity.Property(e => e.IdMultimedia).ValueGeneratedOnAdd();
            entity.Property(e => e.Extension).HasDefaultValue(".png");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Multimedia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Multimedia_Cliente");
        });

        modelBuilder.Entity<PagoCuentum>(entity =>
        {
            entity.HasKey(e => new { e.IdCuenta, e.IdPago }).HasName("PK_PagoCuenta_1");

            entity.Property(e => e.IdPago).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdCuentaNavigation).WithMany(p => p.PagoCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagoCuenta_Cuenta");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
