﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntelliEdu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class aboutmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Abouts");
        }
    }
}
