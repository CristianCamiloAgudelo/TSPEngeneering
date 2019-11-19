using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftMan_TSPEnginner.Migrations
{
    public partial class MigracionPlanGrupalActualizacion5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_PlanGrupal_PlanGrupal",
                table: "Tareas");

            migrationBuilder.RenameColumn(
                name: "PlanGrupal",
                table: "Tareas",
                newName: "planGrupalId");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_PlanGrupal",
                table: "Tareas",
                newName: "IX_Tareas_planGrupalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_PlanGrupal_planGrupalId",
                table: "Tareas",
                column: "planGrupalId",
                principalTable: "PlanGrupal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_PlanGrupal_planGrupalId",
                table: "Tareas");

            migrationBuilder.RenameColumn(
                name: "planGrupalId",
                table: "Tareas",
                newName: "PlanGrupal");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_planGrupalId",
                table: "Tareas",
                newName: "IX_Tareas_PlanGrupal");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_PlanGrupal_PlanGrupal",
                table: "Tareas",
                column: "PlanGrupal",
                principalTable: "PlanGrupal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
