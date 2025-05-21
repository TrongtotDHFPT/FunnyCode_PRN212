using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Model.Models;

public partial class FuhCompanyContext : DbContext
{
    public FuhCompanyContext()
    {
    }

    public FuhCompanyContext(DbContextOptions<FuhCompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblDepartment> TblDepartments { get; set; }

    public virtual DbSet<TblDependent> TblDependents { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblLocation> TblLocations { get; set; }

    public virtual DbSet<TblProject> TblProjects { get; set; }

    public virtual DbSet<TblWorksOn> TblWorksOns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DBDefault");
        optionsBuilder.UseSqlServer(connectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblDepartment>(entity =>
        {
            entity.HasKey(e => e.DepNum);

            entity.ToTable("tblDepartment");

            entity.Property(e => e.DepNum)
                .ValueGeneratedNever()
                .HasColumnName("depNum");
            entity.Property(e => e.DepName)
                .HasMaxLength(50)
                .HasColumnName("depName");
            entity.Property(e => e.MgrAssDate)
                .HasColumnType("datetime")
                .HasColumnName("mgrAssDate");
            entity.Property(e => e.MgrSsn)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("mgrSSN");

            entity.HasOne(d => d.MgrSsnNavigation).WithMany(p => p.TblDepartments)
                .HasForeignKey(d => d.MgrSsn)
                .HasConstraintName("FK_tblDepartment_tblEmployee");

            entity.HasMany(d => d.LocNums).WithMany(p => p.DepNums)
                .UsingEntity<Dictionary<string, object>>(
                    "TblDepLocation",
                    r => r.HasOne<TblLocation>().WithMany()
                        .HasForeignKey("LocNum")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_tblDepLocation_tblLocation"),
                    l => l.HasOne<TblDepartment>().WithMany()
                        .HasForeignKey("DepNum")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_tblDepLocation_tblDepartment"),
                    j =>
                    {
                        j.HasKey("DepNum", "LocNum");
                        j.ToTable("tblDepLocation");
                        j.IndexerProperty<int>("DepNum").HasColumnName("depNum");
                        j.IndexerProperty<int>("LocNum").HasColumnName("locNum");
                    });
        });

        modelBuilder.Entity<TblDependent>(entity =>
        {
            entity.HasKey(e => new { e.DepName, e.EmpSsn });

            entity.ToTable("tblDependent");

            entity.Property(e => e.DepName)
                .HasMaxLength(50)
                .HasColumnName("depName");
            entity.Property(e => e.EmpSsn)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("empSSN");
            entity.Property(e => e.DepBirthdate)
                .HasColumnType("datetime")
                .HasColumnName("depBirthdate");
            entity.Property(e => e.DepRelationship)
                .HasMaxLength(50)
                .HasColumnName("depRelationship");
            entity.Property(e => e.DepSex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("depSex");

            entity.HasOne(d => d.EmpSsnNavigation).WithMany(p => p.TblDependents)
                .HasForeignKey(d => d.EmpSsn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDependent_tblEmployee");
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.HasKey(e => e.EmpSsn);

            entity.ToTable("tblEmployee", tb => tb.HasTrigger("CheckAgeOnInsert"));

            entity.Property(e => e.EmpSsn)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("empSSN");
            entity.Property(e => e.DepNum).HasColumnName("depNum");
            entity.Property(e => e.EmpAddress)
                .HasMaxLength(50)
                .HasColumnName("empAddress");
            entity.Property(e => e.EmpBirthdate)
                .HasColumnType("datetime")
                .HasColumnName("empBirthdate");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .HasColumnName("empName");
            entity.Property(e => e.EmpSalary)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("empSalary");
            entity.Property(e => e.EmpSex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("empSex");
            entity.Property(e => e.EmpStartdate)
                .HasColumnType("datetime")
                .HasColumnName("empStartdate");
            entity.Property(e => e.SupervisorSsn)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("supervisorSSN");

            entity.HasOne(d => d.DepNumNavigation).WithMany(p => p.TblEmployees)
                .HasForeignKey(d => d.DepNum)
                .HasConstraintName("FK_tblEmployee_tblDepartment");

            entity.HasOne(d => d.SupervisorSsnNavigation).WithMany(p => p.InverseSupervisorSsnNavigation)
                .HasForeignKey(d => d.SupervisorSsn)
                .HasConstraintName("FK_tblEmployee_tblEmployee");
        });

        modelBuilder.Entity<TblLocation>(entity =>
        {
            entity.HasKey(e => e.LocNum);

            entity.ToTable("tblLocation");

            entity.Property(e => e.LocNum).HasColumnName("locNum");
            entity.Property(e => e.LocName)
                .HasMaxLength(50)
                .HasColumnName("locName");
        });

        modelBuilder.Entity<TblProject>(entity =>
        {
            entity.HasKey(e => e.ProNum);

            entity.ToTable("tblProject");

            entity.Property(e => e.ProNum)
                .ValueGeneratedNever()
                .HasColumnName("proNum");
            entity.Property(e => e.DepNum).HasColumnName("depNum");
            entity.Property(e => e.LocNum).HasColumnName("locNum");
            entity.Property(e => e.ProName)
                .HasMaxLength(50)
                .HasColumnName("proName");

            entity.HasOne(d => d.DepNumNavigation).WithMany(p => p.TblProjects)
                .HasForeignKey(d => d.DepNum)
                .HasConstraintName("FK_tblProject_tblDepartment");

            entity.HasOne(d => d.LocNumNavigation).WithMany(p => p.TblProjects)
                .HasForeignKey(d => d.LocNum)
                .HasConstraintName("FK_tblProject_tblLocation");
        });

        modelBuilder.Entity<TblWorksOn>(entity =>
        {
            entity.HasKey(e => new { e.EmpSsn, e.ProNum });

            entity.ToTable("tblWorksOn");

            entity.Property(e => e.EmpSsn)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("empSSN");
            entity.Property(e => e.ProNum).HasColumnName("proNum");
            entity.Property(e => e.WorkHours).HasColumnName("workHours");

            entity.HasOne(d => d.ProNumNavigation).WithMany(p => p.TblWorksOns)
                .HasForeignKey(d => d.ProNum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblWorksOn_tblProject");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
