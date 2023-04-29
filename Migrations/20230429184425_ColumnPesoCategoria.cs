using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Platzi___EntityFramework.Migrations
{
    public partial class ColumnPesoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_Categorias_CategoriaId",
                table: "Tareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Tareas",
                newName: "Tarea");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_CategoriaId",
                table: "Tarea",
                newName: "IX_Tarea_CategoriaId");

            migrationBuilder.AddColumn<int>(
                name: "Peso",
                table: "Categoria",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea",
                column: "TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Categoria_CategoriaId",
                table: "Tarea",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Categoria_CategoriaId",
                table: "Tarea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarea",
                table: "Tarea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Tarea",
                newName: "Tareas");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_CategoriaId",
                table: "Tareas",
                newName: "IX_Tareas_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas",
                column: "TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_Categorias_CategoriaId",
                table: "Tareas",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
