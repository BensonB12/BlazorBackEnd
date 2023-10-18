using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class OutcomesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "outcome",
                schema: "game234",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    floor_padlock_id = table.Column<int>(type: "integer", nullable: true),
                    floor_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("outcome_pkey", x => x.id);
                    table.ForeignKey(
                        name: "outcome_floor_id_fkey",
                        column: x => x.floor_id,
                        principalSchema: "game234",
                        principalTable: "floor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "outcome_floor_padlock_id_fkey",
                        column: x => x.floor_padlock_id,
                        principalSchema: "game234",
                        principalTable: "floor_padlock",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_outcome_floor_id",
                schema: "game234",
                table: "outcome",
                column: "floor_id");

            migrationBuilder.CreateIndex(
                name: "IX_outcome_floor_padlock_id",
                schema: "game234",
                table: "outcome",
                column: "floor_padlock_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "outcome",
                schema: "game234");
        }
    }
}
