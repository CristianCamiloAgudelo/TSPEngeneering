using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftMan_TSPEnginner.Migrations
{
    public partial class MigracionPlanGrupalActualizacion7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_PlanGrupal_planGrupalId",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "IdPlanGrupalId",
                table: "Tareas");

            migrationBuilder.RenameColumn(
                name: "planGrupalId",
                table: "Tareas",
                newName: "PlanGrupalId");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_planGrupalId",
                table: "Tareas",
                newName: "IX_Tareas_PlanGrupalId");

            migrationBuilder.AlterColumn<int>(
                name: "PlanGrupalId",
                table: "Tareas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_PlanGrupal_PlanGrupalId",
                table: "Tareas",
                column: "PlanGrupalId",
                principalTable: "PlanGrupal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_PlanGrupal_PlanGrupalId",
                table: "Tareas");

            migrationBuilder.RenameColumn(
                name: "PlanGrupalId",
                table: "Tareas",
                newName: "planGrupalId");

            migrationBuilder.RenameIndex(
                name: "IX_Tareas_PlanGrupalId",
                table: "Tareas",
                newName: "IX_Tareas_planGrupalId");

            migrationBuilder.AlterColumn<int>(
                name: "planGrupalId",
                table: "Tareas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdPlanGrupalId",
                table: "Tareas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_PlanGrupal_planGrupalId",
                table: "Tareas",
                column: "planGrupalId",
                principalTable: "PlanGrupal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
