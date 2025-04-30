using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 165, 47, 131, 85, 148, 85, 78, 84, 207, 238, 128, 84, 135, 211, 13, 130, 18, 70, 107, 82, 112, 80, 190, 226, 54, 63, 255, 48, 125, 238, 42, 168, 105, 219, 127, 63, 79, 149, 91, 30, 142, 11, 166, 221, 106, 146, 169, 254, 10, 26, 174, 128, 237, 57, 204, 242, 198, 57, 99, 158, 145, 240, 245, 14 }, new byte[] { 184, 44, 47, 104, 65, 185, 110, 161, 76, 83, 118, 98, 197, 201, 196, 191, 107, 239, 105, 74, 230, 221, 17, 85, 103, 199, 13, 95, 11, 5, 71, 36, 235, 162, 204, 220, 218, 91, 202, 31, 17, 87, 18, 75, 162, 250, 2, 179, 62, 194, 99, 54, 222, 222, 15, 98, 202, 243, 83, 65, 76, 134, 210, 252, 40, 118, 121, 76, 3, 213, 117, 59, 22, 61, 77, 66, 25, 111, 119, 213, 135, 187, 30, 22, 145, 141, 44, 227, 55, 27, 159, 253, 138, 167, 48, 65, 113, 235, 198, 208, 230, 206, 248, 70, 81, 246, 231, 17, 69, 0, 62, 108, 42, 190, 69, 10, 44, 109, 122, 66, 144, 70, 104, 234, 123, 247, 239, 79 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 20, 78, 111, 211, 184, 189, 251, 71, 110, 182, 199, 71, 64, 199, 178, 159, 233, 105, 241, 3, 141, 24, 241, 27, 189, 231, 214, 240, 46, 127, 91, 140, 240, 81, 230, 164, 123, 251, 49, 185, 227, 104, 207, 194, 4, 142, 176, 47, 36, 243, 63, 165, 181, 121, 74, 197, 142, 247, 243, 58, 208, 252, 78 }, new byte[] { 62, 49, 91, 19, 137, 64, 169, 245, 6, 167, 36, 86, 69, 120, 175, 209, 170, 51, 4, 188, 79, 115, 83, 89, 129, 54, 174, 34, 133, 217, 95, 231, 12, 140, 168, 242, 136, 234, 254, 53, 35, 30, 211, 78, 129, 122, 235, 9, 132, 111, 147, 188, 51, 248, 98, 159, 46, 85, 24, 5, 31, 110, 9, 147, 94, 130, 228, 32, 130, 58, 87, 19, 83, 14, 163, 10, 110, 16, 132, 53, 127, 138, 96, 40, 198, 192, 88, 236, 251, 222, 221, 163, 181, 15, 121, 177, 57, 197, 220, 6, 118, 57, 249, 121, 235, 252, 205, 194, 221, 245, 29, 29, 221, 230, 6, 95, 87, 114, 93, 145, 24, 0, 151, 130, 212, 206, 79, 244 } });
        }
    }
}
