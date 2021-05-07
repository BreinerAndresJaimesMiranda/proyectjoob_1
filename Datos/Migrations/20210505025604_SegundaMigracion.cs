using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojasDeVida_Aspirantes_AspiranteCorreo",
                table: "HojasDeVida");

            migrationBuilder.DropIndex(
                name: "IX_HojasDeVida_AspiranteCorreo",
                table: "HojasDeVida");

            migrationBuilder.DropColumn(
                name: "AspiranteCorreo",
                table: "HojasDeVida");

            migrationBuilder.AlterColumn<string>(
                name: "AspiranteId",
                table: "HojasDeVida",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Edad",
                table: "Aspirantes",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_HojasDeVida_AspiranteId",
                table: "HojasDeVida",
                column: "AspiranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_HojasDeVida_Aspirantes_AspiranteId",
                table: "HojasDeVida",
                column: "AspiranteId",
                principalTable: "Aspirantes",
                principalColumn: "Correo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HojasDeVida_Aspirantes_AspiranteId",
                table: "HojasDeVida");

            migrationBuilder.DropIndex(
                name: "IX_HojasDeVida_AspiranteId",
                table: "HojasDeVida");

            migrationBuilder.AlterColumn<int>(
                name: "AspiranteId",
                table: "HojasDeVida",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspiranteCorreo",
                table: "HojasDeVida",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Edad",
                table: "Aspirantes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_HojasDeVida_AspiranteCorreo",
                table: "HojasDeVida",
                column: "AspiranteCorreo");

            migrationBuilder.AddForeignKey(
                name: "FK_HojasDeVida_Aspirantes_AspiranteCorreo",
                table: "HojasDeVida",
                column: "AspiranteCorreo",
                principalTable: "Aspirantes",
                principalColumn: "Correo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
