using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class ere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cercania = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    situacion_laboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Necesidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Salud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alimentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Alimentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Empleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alojamiento_temporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Alojamiento_temporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alojamiento_permanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Alojamiento_permanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Educacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Educacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ayuda_legal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion_Ayuda_legal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necesidades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Migrantes");

            migrationBuilder.DropTable(
                name: "Necesidades");
        }
    }
}
