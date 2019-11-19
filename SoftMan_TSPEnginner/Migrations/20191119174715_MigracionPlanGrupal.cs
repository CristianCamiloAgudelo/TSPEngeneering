using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftMan_TSPEnginner.Migrations
{
    public partial class MigracionPlanGrupal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPlanGrupal",
                table: "Tareas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "planGrupalId",
                table: "Tareas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlanGrupal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanGrupal", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_planGrupalId",
                table: "Tareas",
                column: "planGrupalId");

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

            migrationBuilder.DropTable(
                name: "PlanGrupal");

            migrationBuilder.DropIndex(
                name: "IX_Tareas_planGrupalId",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "IdPlanGrupal",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "planGrupalId",
                table: "Tareas");
        }
    }
}
