using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Budget.Api.Entities;

public partial class BudgetContext : DbContext
{
    public BudgetContext()
    {
    }

    public BudgetContext(DbContextOptions<BudgetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Budget> Budgets { get; set; }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Budget>(entity =>
        {
            entity.HasKey(e => e.IdBudget).HasName("PRIMARY");

            entity.ToTable("budgets");

            entity.Property(e => e.IdBudget).HasColumnName("id_budget");
            entity.Property(e => e.MonthlyAllocatedAmount).HasColumnName("monthly_allocated_amount");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.SpentAmount).HasColumnName("spent_amount");
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.IdExpense).HasName("PRIMARY");

            entity.ToTable("expenses");

            entity.HasIndex(e => e.FkIdBudget, "fk_budget");

            entity.HasIndex(e => e.FkIdUser, "fk_user");

            entity.Property(e => e.IdExpense).HasColumnName("id_expense");
            entity.Property(e => e.Description)
                .HasMaxLength(45)
                .HasColumnName("description");
            entity.Property(e => e.FkIdBudget).HasColumnName("fk_id_budget");
            entity.Property(e => e.FkIdUser).HasColumnName("fk_id_user");

            entity.HasOne(d => d.FkIdBudgetNavigation).WithMany(p => p.Expenses)
                .HasForeignKey(d => d.FkIdBudget)
                .HasConstraintName("fk_budget");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.HasIndex(e => e.IdRole, "role_idx");

            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.RoleName)
                .HasMaxLength(16)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => new { e.IdUser, e.FkRoleId }).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.FkRoleId, "user_role_idx");

            entity.Property(e => e.IdUser)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_user");
            entity.Property(e => e.FkRoleId).HasColumnName("fk_role_id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.UserRole)
                .HasMaxLength(16)
                .HasColumnName("user_role");

            entity.HasOne(d => d.FkRole).WithMany(p => p.Users)
                .HasForeignKey(d => d.FkRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
