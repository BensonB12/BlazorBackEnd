﻿// <auto-generated />
using System;
using BlazorApp.Data.DbModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorApp.Migrations
{
    [DbContext(typeof(DbBensonbird25Context))]
    partial class DbBensonbird25ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp.Data.DbModel.Button", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ColorId")
                        .HasColumnType("integer")
                        .HasColumnName("color_id");

                    b.Property<int>("FontId")
                        .HasColumnType("integer")
                        .HasColumnName("font_id");

                    b.Property<int>("Proportion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("proportion")
                        .HasDefaultValueSql("1");

                    b.Property<int>("ShapeId")
                        .HasColumnType("integer")
                        .HasColumnName("shape_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("title")
                        .HasDefaultValueSql("''::character varying");

                    b.HasKey("Id")
                        .HasName("button_pkey");

                    b.HasIndex("ColorId");

                    b.HasIndex("FontId");

                    b.HasIndex("ShapeId");

                    b.ToTable("button", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("HexValue")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("character(6)")
                        .HasColumnName("hex_value")
                        .IsFixedLength();

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title")
                        .HasDefaultValueSql("''::character varying");

                    b.HasKey("Id")
                        .HasName("color_pkey");

                    b.ToTable("color", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Display", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int?>("ColorId")
                        .HasColumnType("integer")
                        .HasColumnName("color_id");

                    b.Property<int?>("FontId")
                        .HasColumnType("integer")
                        .HasColumnName("font_id");

                    b.Property<int?>("Proportion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("proportion")
                        .HasDefaultValueSql("1");

                    b.Property<int?>("ShapeId")
                        .HasColumnType("integer")
                        .HasColumnName("shape_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("display_pkey");

                    b.HasIndex("ColorId");

                    b.HasIndex("FontId");

                    b.HasIndex("ShapeId");

                    b.ToTable("display", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.DisplayBtn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BtnId")
                        .HasColumnType("integer")
                        .HasColumnName("btn_id");

                    b.Property<int>("DisplayId")
                        .HasColumnType("integer")
                        .HasColumnName("display_id");

                    b.HasKey("Id")
                        .HasName("padlock_pkey");

                    b.HasIndex("BtnId");

                    b.HasIndex("DisplayId");

                    b.ToTable("display_btn", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id")
                        .HasName("level_pkey");

                    b.ToTable("floor", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.FloorKeypad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('game234.floor_padlock_id_seq'::regclass)");

                    b.Property<int>("FloorId")
                        .HasColumnType("integer")
                        .HasColumnName("floor_id");

                    b.Property<int>("KeypadId")
                        .HasColumnType("integer")
                        .HasColumnName("keypad_id");

                    b.HasKey("Id")
                        .HasName("floor_padlock_pkey");

                    b.HasIndex("FloorId");

                    b.HasIndex("KeypadId");

                    b.ToTable("floor_keypad", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Font", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("font_pkey");

                    b.ToTable("font", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Gamer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Startdate")
                        .HasColumnType("date")
                        .HasColumnName("startdate");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("gamer_pkey");

                    b.ToTable("gamer", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.GamerLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FloorKeypadId")
                        .HasColumnType("integer")
                        .HasColumnName("floor_keypad_id");

                    b.Property<int>("GamerId")
                        .HasColumnType("integer")
                        .HasColumnName("gamer_id");

                    b.HasKey("Id")
                        .HasName("gamer_log_pkey");

                    b.HasIndex("FloorKeypadId");

                    b.HasIndex("GamerId");

                    b.ToTable("gamer_log", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Keypad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('game234.padlock_id_seq'::regclass)");

                    b.Property<int>("DisplayId")
                        .HasColumnType("integer")
                        .HasColumnName("display_id");

                    b.Property<int>("PassId")
                        .HasColumnType("integer")
                        .HasColumnName("pass_id");

                    b.HasKey("Id")
                        .HasName("pad_pass_pkey");

                    b.HasIndex("DisplayId");

                    b.HasIndex("PassId");

                    b.ToTable("keypad", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Outcome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FloorId")
                        .HasColumnType("integer")
                        .HasColumnName("floor_id");

                    b.Property<int>("FloorKeypadId")
                        .HasColumnType("integer")
                        .HasColumnName("floor_keypad_id");

                    b.HasKey("Id")
                        .HasName("outcome_pkey");

                    b.HasIndex(new[] { "FloorId" }, "IX_outcome_floor_id");

                    b.HasIndex(new[] { "FloorKeypadId" }, "IX_outcome_floor_padlock_id");

                    b.ToTable("outcome", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Passkey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Keystring")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("keystring");

                    b.HasKey("Id")
                        .HasName("passkey_pkey");

                    b.ToTable("passkey", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Requiredfloor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ChosenfloorId")
                        .HasColumnType("integer")
                        .HasColumnName("chosenfloor_id");

                    b.Property<int>("RequiredfloorId")
                        .HasColumnType("integer")
                        .HasColumnName("requiredfloor_id");

                    b.HasKey("Id")
                        .HasName("requiredfloor_pkey");

                    b.HasIndex("ChosenfloorId");

                    b.HasIndex("RequiredfloorId");

                    b.ToTable("requiredfloor", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Shape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Numsides")
                        .HasColumnType("integer")
                        .HasColumnName("numsides");

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("title")
                        .HasDefaultValueSql("''::character varying");

                    b.HasKey("Id")
                        .HasName("shape_pkey");

                    b.ToTable("shape", "game234");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Button", b =>
                {
                    b.HasOne("BlazorApp.Data.DbModel.Color", "Color")
                        .WithMany("Buttons")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("button_color_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Font", "Font")
                        .WithMany("Buttons")
                        .HasForeignKey("FontId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("button_font_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Shape", "Shape")
                        .WithMany("Buttons")
                        .HasForeignKey("ShapeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("button_shape_id_fkey");

                    b.Navigation("Color");

                    b.Navigation("Font");

                    b.Navigation("Shape");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Display", b =>
                {
                    b.HasOne("BlazorApp.Data.DbModel.Color", "Color")
                        .WithMany("Displays")
                        .HasForeignKey("ColorId")
                        .HasConstraintName("display_color_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Font", "Font")
                        .WithMany("Displays")
                        .HasForeignKey("FontId")
                        .HasConstraintName("display_font_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Shape", "Shape")
                        .WithMany("Displays")
                        .HasForeignKey("ShapeId")
                        .HasConstraintName("display_shape_id_fkey");

                    b.Navigation("Color");

                    b.Navigation("Font");

                    b.Navigation("Shape");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.DisplayBtn", b =>
                {
                    b.HasOne("BlazorApp.Data.DbModel.Button", "Btn")
                        .WithMany("DisplayBtns")
                        .HasForeignKey("BtnId")
                        .IsRequired()
                        .HasConstraintName("display_btn_btn_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Display", "Display")
                        .WithMany("DisplayBtns")
                        .HasForeignKey("DisplayId")
                        .IsRequired()
                        .HasConstraintName("display_btn_display_id_fkey");

                    b.Navigation("Btn");

                    b.Navigation("Display");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.FloorKeypad", b =>
                {
                    b.HasOne("BlazorApp.Data.DbModel.Floor", "Floor")
                        .WithMany("FloorKeypads")
                        .HasForeignKey("FloorId")
                        .IsRequired()
                        .HasConstraintName("floor_padlock_floor_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Keypad", "Keypad")
                        .WithMany("FloorKeypads")
                        .HasForeignKey("KeypadId")
                        .IsRequired()
                        .HasConstraintName("floor_padlock_padlock_id_fkey");

                    b.Navigation("Floor");

                    b.Navigation("Keypad");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.GamerLog", b =>
                {
                    b.HasOne("BlazorApp.Data.DbModel.FloorKeypad", "FloorKeypad")
                        .WithMany("GamerLogs")
                        .HasForeignKey("FloorKeypadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("gamer_log_floor_padlock_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Gamer", "Gamer")
                        .WithMany("GamerLogs")
                        .HasForeignKey("GamerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("gamer_log_gamer_id_fkey");

                    b.Navigation("FloorKeypad");

                    b.Navigation("Gamer");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Keypad", b =>
                {
                    b.HasOne("BlazorApp.Data.DbModel.Display", "Display")
                        .WithMany("Keypads")
                        .HasForeignKey("DisplayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("padlock_display_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Passkey", "Pass")
                        .WithMany("Keypads")
                        .HasForeignKey("PassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("padlock_pass_id_fkey");

                    b.Navigation("Display");

                    b.Navigation("Pass");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Outcome", b =>
                {
                    b.HasOne("BlazorApp.Data.DbModel.Floor", "Floor")
                        .WithMany("Outcomes")
                        .HasForeignKey("FloorId")
                        .IsRequired()
                        .HasConstraintName("outcome_floor_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.FloorKeypad", "FloorKeypad")
                        .WithMany("Outcomes")
                        .HasForeignKey("FloorKeypadId")
                        .IsRequired()
                        .HasConstraintName("outcome_floor_padlock_id_fkey");

                    b.Navigation("Floor");

                    b.Navigation("FloorKeypad");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Requiredfloor", b =>
                {
                    b.HasOne("BlazorApp.Data.DbModel.Floor", "Chosenfloor")
                        .WithMany("RequiredfloorChosenfloors")
                        .HasForeignKey("ChosenfloorId")
                        .IsRequired()
                        .HasConstraintName("requiredfloor_chosenfloor_id_fkey");

                    b.HasOne("BlazorApp.Data.DbModel.Floor", "RequiredfloorNavigation")
                        .WithMany("RequiredfloorRequiredfloorNavigations")
                        .HasForeignKey("RequiredfloorId")
                        .IsRequired()
                        .HasConstraintName("requiredfloor_requiredfloor_id_fkey");

                    b.Navigation("Chosenfloor");

                    b.Navigation("RequiredfloorNavigation");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Button", b =>
                {
                    b.Navigation("DisplayBtns");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Color", b =>
                {
                    b.Navigation("Buttons");

                    b.Navigation("Displays");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Display", b =>
                {
                    b.Navigation("DisplayBtns");

                    b.Navigation("Keypads");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Floor", b =>
                {
                    b.Navigation("FloorKeypads");

                    b.Navigation("Outcomes");

                    b.Navigation("RequiredfloorChosenfloors");

                    b.Navigation("RequiredfloorRequiredfloorNavigations");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.FloorKeypad", b =>
                {
                    b.Navigation("GamerLogs");

                    b.Navigation("Outcomes");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Font", b =>
                {
                    b.Navigation("Buttons");

                    b.Navigation("Displays");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Gamer", b =>
                {
                    b.Navigation("GamerLogs");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Keypad", b =>
                {
                    b.Navigation("FloorKeypads");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Passkey", b =>
                {
                    b.Navigation("Keypads");
                });

            modelBuilder.Entity("BlazorApp.Data.DbModel.Shape", b =>
                {
                    b.Navigation("Buttons");

                    b.Navigation("Displays");
                });
#pragma warning restore 612, 618
        }
    }
}
