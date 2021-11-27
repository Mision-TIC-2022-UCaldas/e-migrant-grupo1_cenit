using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class dosEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_migrantes",
                table: "migrantes");

            migrationBuilder.RenameTable(
                name: "migrantes",
                newName: "Migrantes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Migrantes",
                table: "Migrantes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Necesidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alimentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alojamiento_temporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alojamiento_permanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Educacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ayuda_legal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necesidades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Necesidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Migrantes",
                table: "Migrantes");

            migrationBuilder.RenameTable(
                name: "Migrantes",
                newName: "migrantes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_migrantes",
                table: "migrantes",
                column: "Id");
        }
    }
}
