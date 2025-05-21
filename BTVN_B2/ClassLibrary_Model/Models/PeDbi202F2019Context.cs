using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClassLibrary_Model.Models;

public partial class PeDbi202F2019Context : DbContext
{
    public PeDbi202F2019Context()
    {
    }

    public PeDbi202F2019Context(DbContextOptions<PeDbi202F2019Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobHistory> JobHistories { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

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
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Countrie__10D160BFE55E7847");

            entity.Property(e => e.CountryId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CountryID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.Region).WithMany(p => p.Countries)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__Countries__Regio__4222D4EF");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BCD5E60A3C8");

            entity.Property(e => e.DepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocationId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LocationID");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

            entity.HasOne(d => d.Location).WithMany(p => p.Departments)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__Departmen__Locat__4316F928");

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__Departmen__Manag__440B1D61");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF1B8DB2441");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.CommissionPct).HasColumnName("Commission_pct");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.JobId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JobID");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Employees__Depar__44FF419A");

            entity.HasOne(d => d.Job).WithMany(p => p.Employees)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Employees__JobID__45F365D3");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__Employees__Manag__46E78A0C");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__Jobs__056690E261FB5A35");

            entity.Property(e => e.JobId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JobID");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaxSalary).HasColumnName("max_salary");
            entity.Property(e => e.MinSalary).HasColumnName("min_salary");
        });

        modelBuilder.Entity<JobHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JobHistory");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EndDate).HasColumnName("End_date");
            entity.Property(e => e.JobId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JobID");
            entity.Property(e => e.StartDate).HasColumnName("Start_date");

            entity.HasOne(d => d.Department).WithMany()
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__JobHistor__Depar__47DBAE45");

            entity.HasOne(d => d.Employee).WithMany()
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__JobHistor__Emplo__48CFD27E");

            entity.HasOne(d => d.Job).WithMany()
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__JobHistor__JobID__49C3F6B7");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Location__E7FEA477B2C7E0F2");

            entity.Property(e => e.LocationId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LocationID");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CountryId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CountryID");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StateProvince)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Country).WithMany(p => p.Locations)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__Locations__Count__4AB81AF0");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Regions__ACD84443B55A9613");

            entity.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("RegionID");
            entity.Property(e => e.RegionName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
