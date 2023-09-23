using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NWindApplication.Models;

public partial class HospitalDbContext : DbContext
{
    public HospitalDbContext()
    {
    }

    public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=200411LTP2786\\SQLEXPRESS; database=HospitalDB; integrated security=true;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Appointmentno);

            entity.Property(e => e.Appointmentno).HasColumnName("appointmentno");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Doctorno);

            entity.Property(e => e.Doctorno).HasColumnName("doctorno");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.PhoneNumber).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.VisitingFees).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Patientno).HasName("PK_Paitents");

            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.PhoneNumber).HasColumnType("numeric(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
