using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CuentasApi.Entities;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Cuentum> Cuenta { get; set; }

    public virtual DbSet<Multimedium> Multimedia { get; set; }

    public virtual DbSet<PagoCuentum> PagoCuenta { get; set; }

    public virtual DbSet<TipoCuentum> TipoCuenta { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Apuntes).IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cuentum>(entity =>
        {
            entity.HasKey(e => e.IdCuenta).HasName("PK_Cuenta_1");

            entity.Property(e => e.IdCliente)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Monto).HasColumnType("numeric(10, 2)");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cuotas_Cliente");
        });

        modelBuilder.Entity<Multimedium>(entity =>
        {
            entity.HasKey(e => new { e.IdCliente, e.IdMultimedia });

            entity.Property(e => e.IdCliente)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdMultimedia).ValueGeneratedOnAdd();
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue(".png");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Multimedia)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Multimedia_Cliente");
        });

        modelBuilder.Entity<PagoCuentum>(entity =>
        {
            entity.HasKey(e => new { e.IdCuenta, e.IdPago }).HasName("PK_PagoCuenta_1");

            entity.Property(e => e.IdPago).ValueGeneratedOnAdd();
            entity.Property(e => e.Monto).HasColumnType("numeric(10, 2)");

            entity.HasOne(d => d.IdCuentaNavigation).WithMany(p => p.PagoCuenta)
                .HasForeignKey(d => d.IdCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagoCuenta_Cuenta");
        });

        modelBuilder.Entity<TipoCuentum>(entity =>
        {
            entity.HasKey(e => e.IdTipoCuenta);

            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.HasKey(e => e.IdTipoPago);

            entity.ToTable("TipoPago");

            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
