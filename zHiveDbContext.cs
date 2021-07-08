using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class zHiveDbContext : DbContext
    {
        public zHiveDbContext()
        {
        }

        public zHiveDbContext(DbContextOptions<zHiveDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SonarAnalysis> SonarAnalysis { get; set; }
        public virtual DbSet<SonarIssue> SonarIssue { get; set; }
        public virtual DbSet<SonarProjectDetail> SonarProjectDetail { get; set; }
        public virtual DbSet<SonarStatus> SonarStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.windows.net;Database=common;User Id= one; Password=1233;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SonarAnalysis>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastAnalysisDttm)
                    .HasColumnName("LastAnalysisDTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SonarProjectDetailId).HasColumnName("SonarProjectDetailID");

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SonarProjectDetail)
                    .WithMany(p => p.SonarAnalysis)
                    .HasForeignKey(d => d.SonarProjectDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SonarAnal__Sonar__29AC2CE0");
            });

            modelBuilder.Entity<SonarIssue>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Line)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Severity)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SonarProjectDetailId).HasColumnName("SonarProjectDetailID");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SonarProjectDetail)
                    .WithMany(p => p.SonarIssue)
                    .HasForeignKey(d => d.SonarProjectDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SonarIssu__Sonar__2C88998B");
            });

            modelBuilder.Entity<SonarProjectDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SonarStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SonarProjectDetailId).HasColumnName("SonarProjectDetailID");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasColumnName("UpdatedBY");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SonarProjectDetail)
                    .WithMany(p => p.SonarStatus)
                    .HasForeignKey(d => d.SonarProjectDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SonarStat__Sonar__2F650636");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
