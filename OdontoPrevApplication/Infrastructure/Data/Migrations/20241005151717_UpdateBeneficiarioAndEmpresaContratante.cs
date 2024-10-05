using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdontoPrevApplication.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBeneficiarioAndEmpresaContratante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaContratanteId",
                table: "tb_beneficiario",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_beneficiario_EmpresaContratanteId",
                table: "tb_beneficiario",
                column: "EmpresaContratanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_beneficiario_tb_empresa_contratante_EmpresaContratanteId",
                table: "tb_beneficiario",
                column: "EmpresaContratanteId",
                principalTable: "tb_empresa_contratante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_beneficiario_tb_empresa_contratante_EmpresaContratanteId",
                table: "tb_beneficiario");

            migrationBuilder.DropIndex(
                name: "IX_tb_beneficiario_EmpresaContratanteId",
                table: "tb_beneficiario");

            migrationBuilder.DropColumn(
                name: "EmpresaContratanteId",
                table: "tb_beneficiario");
        }
    }
}
