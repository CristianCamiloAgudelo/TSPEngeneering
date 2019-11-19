using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftMan_TSPEnginner.Migrations
{
    public partial class MigracionPlanGrupalActualizacion6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPlanGrupal",
                table: "Tareas",
                newName: "IdPlanGrupalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPlanGrupalId",
                table: "Tareas",
                newName: "IdPlanGrupal");
        }
    }
}
