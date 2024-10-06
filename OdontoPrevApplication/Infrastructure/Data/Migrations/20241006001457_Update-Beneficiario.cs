using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdontoPrevApplication.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBeneficiario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_beneficiario_tb_endereco_EnderecoId",
                table: "tb_beneficiario");

            migrationBuilder.DropIndex(
                name: "IX_tb_beneficiario_EnderecoId",
                table: "tb_beneficiario");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "tb_beneficiario",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.CreateIndex(
                name: "IX_tb_beneficiario_EnderecoId",
                table: "tb_beneficiario",
                column: "EnderecoId",
                unique: true,
                filter: "\"EnderecoId\" IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_beneficiario_tb_endereco_EnderecoId",
                table: "tb_beneficiario",
                column: "EnderecoId",
                principalTable: "tb_endereco",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_beneficiario_tb_endereco_EnderecoId",
                table: "tb_beneficiario");

            migrationBuilder.DropIndex(
                name: "IX_tb_beneficiario_EnderecoId",
                table: "tb_beneficiario");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "tb_beneficiario",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_beneficiario_EnderecoId",
                table: "tb_beneficiario",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_beneficiario_tb_endereco_EnderecoId",
                table: "tb_beneficiario",
                column: "EnderecoId",
                principalTable: "tb_endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
