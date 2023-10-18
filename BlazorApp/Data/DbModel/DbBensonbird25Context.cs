﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data.DbModel;

public partial class DbBensonbird25Context : DbContext
{
    public DbBensonbird25Context()
    {
    }

    public DbBensonbird25Context(DbContextOptions<DbBensonbird25Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Button> Buttons { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Display> Displays { get; set; }

    public virtual DbSet<DisplayBtn> DisplayBtns { get; set; }

    public virtual DbSet<Floor> Floors { get; set; }

    public virtual DbSet<FloorKeypad> FloorKeypads { get; set; }

    public virtual DbSet<Font> Fonts { get; set; }

    public virtual DbSet<Gamer> Gamers { get; set; }

    public virtual DbSet<GamerLog> GamerLogs { get; set; }

    public virtual DbSet<Keypad> Keypads { get; set; }

    public virtual DbSet<Outcome> Outcomes { get; set; }

    public virtual DbSet<Passkey> Passkeys { get; set; }

    public virtual DbSet<Requiredfloor> Requiredfloors { get; set; }

    public virtual DbSet<Shape> Shapes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:db_string");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Button>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("button_pkey");

            entity.ToTable("button", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ColorId).HasColumnName("color_id");
            entity.Property(e => e.FontId).HasColumnName("font_id");
            entity.Property(e => e.Proportion)
                .HasDefaultValueSql("1")
                .HasColumnName("proportion");
            entity.Property(e => e.ShapeId).HasColumnName("shape_id");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");

            entity.HasOne(d => d.Color).WithMany(p => p.Buttons)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("button_color_id_fkey");

            entity.HasOne(d => d.Font).WithMany(p => p.Buttons)
                .HasForeignKey(d => d.FontId)
                .HasConstraintName("button_font_id_fkey");

            entity.HasOne(d => d.Shape).WithMany(p => p.Buttons)
                .HasForeignKey(d => d.ShapeId)
                .HasConstraintName("button_shape_id_fkey");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("color_pkey");

            entity.ToTable("color", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HexValue)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("hex_value");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
        });

        modelBuilder.Entity<Display>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("display_pkey");

            entity.ToTable("display", "game234");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ColorId).HasColumnName("color_id");
            entity.Property(e => e.FontId).HasColumnName("font_id");
            entity.Property(e => e.Proportion)
                .HasDefaultValueSql("1")
                .HasColumnName("proportion");
            entity.Property(e => e.ShapeId).HasColumnName("shape_id");
            entity.Property(e => e.Title).HasColumnName("title");

            entity.HasOne(d => d.Color).WithMany(p => p.Displays)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("display_color_id_fkey");

            entity.HasOne(d => d.Font).WithMany(p => p.Displays)
                .HasForeignKey(d => d.FontId)
                .HasConstraintName("display_font_id_fkey");

            entity.HasOne(d => d.Shape).WithMany(p => p.Displays)
                .HasForeignKey(d => d.ShapeId)
                .HasConstraintName("display_shape_id_fkey");
        });

        modelBuilder.Entity<DisplayBtn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("padlock_pkey");

            entity.ToTable("display_btn", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BtnId).HasColumnName("btn_id");
            entity.Property(e => e.DisplayId).HasColumnName("display_id");

            entity.HasOne(d => d.Btn).WithMany(p => p.DisplayBtns)
                .HasForeignKey(d => d.BtnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("display_btn_btn_id_fkey");

            entity.HasOne(d => d.Display).WithMany(p => p.DisplayBtns)
                .HasForeignKey(d => d.DisplayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("display_btn_display_id_fkey");
        });

        modelBuilder.Entity<Floor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("level_pkey");

            entity.ToTable("floor", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<FloorKeypad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("floor_padlock_pkey");

            entity.ToTable("floor_keypad", "game234");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('game234.floor_padlock_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.FloorId).HasColumnName("floor_id");
            entity.Property(e => e.KeypadId).HasColumnName("keypad_id");

            entity.HasOne(d => d.Floor).WithMany(p => p.FloorKeypads)
                .HasForeignKey(d => d.FloorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("floor_padlock_floor_id_fkey");

            entity.HasOne(d => d.Keypad).WithMany(p => p.FloorKeypads)
                .HasForeignKey(d => d.KeypadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("floor_padlock_padlock_id_fkey");
        });

        modelBuilder.Entity<Font>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("font_pkey");

            entity.ToTable("font", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Gamer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gamer_pkey");

            entity.ToTable("gamer", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<GamerLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gamer_log_pkey");

            entity.ToTable("gamer_log", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FloorKeypadId).HasColumnName("floor_keypad_id");
            entity.Property(e => e.GamerId).HasColumnName("gamer_id");

            entity.HasOne(d => d.FloorKeypad).WithMany(p => p.GamerLogs)
                .HasForeignKey(d => d.FloorKeypadId)
                .HasConstraintName("gamer_log_floor_padlock_id_fkey");

            entity.HasOne(d => d.Gamer).WithMany(p => p.GamerLogs)
                .HasForeignKey(d => d.GamerId)
                .HasConstraintName("gamer_log_gamer_id_fkey");
        });

        modelBuilder.Entity<Keypad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pad_pass_pkey");

            entity.ToTable("keypad", "game234");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('game234.padlock_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.DisplayId).HasColumnName("display_id");
            entity.Property(e => e.PassId).HasColumnName("pass_id");

            entity.HasOne(d => d.Display).WithMany(p => p.Keypads)
                .HasForeignKey(d => d.DisplayId)
                .HasConstraintName("padlock_display_id_fkey");

            entity.HasOne(d => d.Pass).WithMany(p => p.Keypads)
                .HasForeignKey(d => d.PassId)
                .HasConstraintName("padlock_pass_id_fkey");
        });

        modelBuilder.Entity<Outcome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("outcome_pkey");

            entity.ToTable("outcome", "game234");

            entity.HasIndex(e => e.FloorId, "IX_outcome_floor_id");

            entity.HasIndex(e => e.FloorKeypadId, "IX_outcome_floor_padlock_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FloorId).HasColumnName("floor_id");
            entity.Property(e => e.FloorKeypadId).HasColumnName("floor_keypad_id");

            entity.HasOne(d => d.Floor).WithMany(p => p.Outcomes)
                .HasForeignKey(d => d.FloorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("outcome_floor_id_fkey");

            entity.HasOne(d => d.FloorKeypad).WithMany(p => p.Outcomes)
                .HasForeignKey(d => d.FloorKeypadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("outcome_floor_padlock_id_fkey");
        });

        modelBuilder.Entity<Passkey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("passkey_pkey");

            entity.ToTable("passkey", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Keystring).HasColumnName("keystring");
        });

        modelBuilder.Entity<Requiredfloor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("requiredfloor_pkey");

            entity.ToTable("requiredfloor", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChosenfloorId).HasColumnName("chosenfloor_id");
            entity.Property(e => e.RequiredfloorId).HasColumnName("requiredfloor_id");

            entity.HasOne(d => d.Chosenfloor).WithMany(p => p.RequiredfloorChosenfloors)
                .HasForeignKey(d => d.ChosenfloorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("requiredfloor_chosenfloor_id_fkey");

            entity.HasOne(d => d.RequiredfloorNavigation).WithMany(p => p.RequiredfloorRequiredfloorNavigations)
                .HasForeignKey(d => d.RequiredfloorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("requiredfloor_requiredfloor_id_fkey");
        });

        modelBuilder.Entity<Shape>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("shape_pkey");

            entity.ToTable("shape", "game234");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Numsides).HasColumnName("numsides");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
