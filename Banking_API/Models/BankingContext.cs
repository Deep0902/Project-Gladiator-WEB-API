using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Banking_API.Models
{
    public partial class BankingContext : DbContext
    {
        public BankingContext()
        {
        }

        public BankingContext(DbContextOptions<BankingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<PayeeDetails> PayeeDetails { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<UserAccountDetails> UserAccountDetails { get; set; }
        public virtual DbSet<UserLogIn> UserLogIn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=VIVOBOOKX543U\\SQLEXPRESS ; initial catalog=Banking; trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.Aadhar)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Addressline1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Addressline2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossAnnualIncome).HasColumnType("money");

                entity.Property(e => e.Landmark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentCity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentLandmark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentState)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOfIncome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayeeDetails>(entity =>
            {
                entity.HasKey(e => e.PayeeId);

                entity.Property(e => e.BeneficiaryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.PayeeDetails)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayeeDetails_UserAccountDetails");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_UserAccountDetails1");
            });

            modelBuilder.Entity<UserAccountDetails>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.Property(e => e.AccOpDate).HasColumnType("datetime");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UserAccountDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAccountDetails_Customers");
            });

            modelBuilder.Entity<UserLogIn>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.Property(e => e.LogInPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.UserLogIn)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLogIn_UserAccountDetails");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
