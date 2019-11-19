using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftMan_TSPEnginner.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    MinutosLiderProyecto = table.Column<string>(nullable: false),
                    MinutosLiderPlaneacion = table.Column<string>(nullable: false),
                    MinutosLiderDesarrollo = table.Column<string>(nullable: false),
                    MinutosLiderCalidad = table.Column<string>(nullable: false),
                    MinutosLiderSoporte = table.Column<string>(nullable: false),
                    MinutosTotales = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
