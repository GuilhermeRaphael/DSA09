using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 20, 78, 111, 211, 184, 189, 251, 71, 110, 182, 199, 71, 64, 199, 178, 159, 233, 105, 241, 3, 141, 24, 241, 27, 189, 231, 214, 240, 46, 127, 91, 140, 240, 81, 230, 164, 123, 251, 49, 185, 227, 104, 207, 194, 4, 142, 176, 47, 36, 243, 63, 165, 181, 121, 74, 197, 142, 247, 243, 58, 208, 252, 78 }, new byte[] { 62, 49, 91, 19, 137, 64, 169, 245, 6, 167, 36, 86, 69, 120, 175, 209, 170, 51, 4, 188, 79, 115, 83, 89, 129, 54, 174, 34, 133, 217, 95, 231, 12, 140, 168, 242, 136, 234, 254, 53, 35, 30, 211, 78, 129, 122, 235, 9, 132, 111, 147, 188, 51, 248, 98, 159, 46, 85, 24, 5, 31, 110, 9, 147, 94, 130, 228, 32, 130, 58, 87, 19, 83, 14, 163, 10, 110, 16, 132, 53, 127, 138, 96, 40, 198, 192, 88, 236, 251, 222, 221, 163, 181, 15, 121, 177, 57, 197, 220, 6, 118, 57, 249, 121, 235, 252, 205, 194, 221, 245, 29, 29, 221, 230, 6, 95, 87, 114, 93, 145, 24, 0, 151, 130, 212, 206, 79, 244 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 99, 206, 7, 29, 177, 253, 122, 204, 88, 150, 196, 17, 66, 199, 6, 240, 167, 49, 205, 217, 95, 56, 28, 156, 212, 183, 32, 213, 69, 82, 150, 48, 182, 219, 175, 49, 87, 235, 59, 117, 219, 164, 42, 31, 23, 117, 238, 232, 133, 185, 12, 251, 239, 223, 15, 123, 145, 164, 210, 125, 239, 28, 86, 37 }, new byte[] { 46, 42, 21, 73, 17, 225, 195, 198, 113, 229, 192, 49, 143, 35, 190, 111, 242, 178, 186, 175, 202, 251, 237, 252, 209, 188, 125, 28, 170, 151, 5, 187, 13, 84, 20, 235, 245, 100, 83, 47, 162, 9, 120, 165, 252, 205, 174, 227, 40, 204, 32, 195, 156, 192, 229, 199, 184, 29, 214, 162, 169, 231, 8, 253, 36, 216, 59, 160, 148, 120, 17, 238, 253, 59, 87, 76, 56, 155, 221, 20, 215, 254, 220, 5, 49, 168, 29, 92, 73, 213, 91, 48, 180, 181, 70, 100, 80, 234, 124, 14, 49, 79, 92, 64, 169, 32, 195, 182, 250, 140, 139, 250, 250, 187, 112, 56, 225, 154, 255, 78, 128, 253, 178, 133, 102, 68, 179, 211 } });
        }
    }
}
