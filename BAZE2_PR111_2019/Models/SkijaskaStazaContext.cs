using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BAZE2_PR111_2019.Models;

public partial class SkijaskaStazaContext : DbContext
{
    public SkijaskaStazaContext()
    {
    }

    public SkijaskaStazaContext(DbContextOptions<SkijaskaStazaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Drzava1> Drzava1s { get; set; }

    public virtual DbSet<Licenca1> Licenca1s { get; set; }

    public virtual DbSet<Oprema1> Oprema1s { get; set; }

    public virtual DbSet<ProizvodjacOpreme1> ProizvodjacOpreme1s { get; set; }

    public virtual DbSet<Skijas1> Skijas1s { get; set; }

    public virtual DbSet<Staza1> Staza1s { get; set; }

    public virtual DbSet<Sudija3> Sudija3s { get; set; }

    public virtual DbSet<Trka1> Trka1s { get; set; }

    public virtual DbSet<Ucestvuje1> Ucestvuje1s { get; set; }

    public virtual DbSet<ZaStazu1> ZaStazu1s { get; set; }

    public virtual DbSet<ZaTakmicare1> ZaTakmicare1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SKIJASKA_STAZAConnectionString"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Drzava1>(entity =>
        {
            entity.HasKey(e => e.IdDrz1).HasName("PK__Drzava1__F6D95006DDE8F07B");

            entity.ToTable("Drzava1");

            entity.Property(e => e.IdDrz1).ValueGeneratedNever();
            entity.Property(e => e.NazDrz1)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Licenca1>(entity =>
        {
            entity.HasKey(e => e.IdLic1).HasName("PK__Licenca1__31D90F47DA5BAA08");

            entity.ToTable("Licenca1");

            entity.Property(e => e.IdLic1).ValueGeneratedNever();
            entity.Property(e => e.DatIstk1).HasColumnType("date");
            entity.Property(e => e.DatIzdv1).HasColumnType("date");
            entity.Property(e => e.NazLic1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSud2Navigation).WithMany(p => p.Licenca1s)
                .HasForeignKey(d => d.IdSud2)
                .HasConstraintName("FK__Licenca1__IdSud2__5535A963");
        });

        modelBuilder.Entity<Oprema1>(entity =>
        {
            entity.HasKey(e => new { e.IdOp1, e.IdProiz1 }).HasName("PK__Oprema1__9D202970CAF4F58B");

            entity.ToTable("Oprema1");

            entity.Property(e => e.VelOp1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.VrstOp1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProiz1Navigation).WithMany(p => p.Oprema1s)
                .HasForeignKey(d => d.IdProiz1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Oprema1__IdProiz__3E52440B");
        });

        modelBuilder.Entity<ProizvodjacOpreme1>(entity =>
        {
            entity.HasKey(e => e.IdProiz1).HasName("PK__Proizvod__72B930BA418CF267");

            entity.ToTable("ProizvodjacOpreme1");

            entity.Property(e => e.IdProiz1).ValueGeneratedNever();
            entity.Property(e => e.NazProiz1)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Skijas1>(entity =>
        {
            entity.HasKey(e => e.IdSk1).HasName("PK__Skijas1__2B04563CAE9D67D7");

            entity.ToTable("Skijas1");

            entity.Property(e => e.IdSk1).ValueGeneratedNever();
            entity.Property(e => e.BrSkiPas1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ImeSk1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrzSk1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RezSk1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDrz1Navigation).WithMany(p => p.Skijas1s)
                .HasForeignKey(d => d.IdDrz1)
                .HasConstraintName("FK__Skijas1__IdDrz1__4316F928");
        });

        modelBuilder.Entity<Staza1>(entity =>
        {
            entity.HasKey(e => new { e.IdSt1, e.IdTrk1 }).HasName("PK__Staza1__42B6EC8D476E004F");

            entity.ToTable("Staza1");

            entity.Property(e => e.DuzinaSt1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NazSt1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTrk1Navigation).WithMany(p => p.Staza1s)
                .HasForeignKey(d => d.IdTrk1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Staza1__IdTrk1__48CFD27E");
        });

        modelBuilder.Entity<Sudija3>(entity =>
        {
            entity.HasKey(e => e.IdSud2).HasName("Sudija2");

            entity.ToTable("SUDIJA3");

            entity.Property(e => e.IdSud2).ValueGeneratedNever();
            entity.Property(e => e.ImeSud2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrzSud2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipSud2)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Trka1>(entity =>
        {
            entity.HasKey(e => e.IdTrk1).HasName("PK__Trka1__9B5543D7A1051BFA");

            entity.ToTable("Trka1");

            entity.Property(e => e.IdTrk1).ValueGeneratedNever();
            entity.Property(e => e.DatTrk1).HasColumnType("date");
            entity.Property(e => e.KatTrk1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NazTrke1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.VrTrk1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDrz1Navigation).WithMany(p => p.Trka1s)
                .HasForeignKey(d => d.IdDrz1)
                .HasConstraintName("FK__Trka1__IdDrz1__45F365D3");
        });

        modelBuilder.Entity<Ucestvuje1>(entity =>
        {
            entity.HasKey(e => new { e.IdSk1, e.IdTrk1, e.IdSud2 }).HasName("PK__Ucestvuj__84123A8822CB63EF");

            entity.ToTable("Ucestvuje1");

            entity.HasOne(d => d.IdSk1Navigation).WithMany(p => p.Ucestvuje1s)
                .HasForeignKey(d => d.IdSk1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ucestvuje__IdSk1__5DCAEF64");

            entity.HasOne(d => d.IdSud2Navigation).WithMany(p => p.Ucestvuje1s)
                .HasForeignKey(d => d.IdSud2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ucestvuje__IdSud__5FB337D6");

            entity.HasOne(d => d.IdTrk1Navigation).WithMany(p => p.Ucestvuje1s)
                .HasForeignKey(d => d.IdTrk1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ucestvuje__IdTrk__5EBF139D");
        });

        modelBuilder.Entity<ZaStazu1>(entity =>
        {
            entity.HasKey(e => e.IdSud2).HasName("PK__ZaStazu1__A33889C7AE05B73C");

            entity.ToTable("ZaStazu1");

            entity.Property(e => e.IdSud2).ValueGeneratedNever();

            entity.HasOne(d => d.IdSud2Navigation).WithOne(p => p.ZaStazu1)
                .HasForeignKey<ZaStazu1>(d => d.IdSud2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZaStazu1__IdSud2__5AEE82B9");
        });

        modelBuilder.Entity<ZaTakmicare1>(entity =>
        {
            entity.HasKey(e => e.IdSud2).HasName("PK__ZaTakmic__A33889C72CC8AF36");

            entity.ToTable("ZaTakmicare1");

            entity.Property(e => e.IdSud2).ValueGeneratedNever();

            entity.HasOne(d => d.IdSud2Navigation).WithOne(p => p.ZaTakmicare1)
                .HasForeignKey<ZaTakmicare1>(d => d.IdSud2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZaTakmica__IdSud__5812160E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
