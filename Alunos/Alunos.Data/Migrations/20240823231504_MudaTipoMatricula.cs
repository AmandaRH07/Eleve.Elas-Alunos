using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alunos.Data.Migrations
{
    /// <inheritdoc />
    public partial class MudaTipoMatricula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataMatricula",
                table: "Matricula",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataMatricula",
                table: "Matricula",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
