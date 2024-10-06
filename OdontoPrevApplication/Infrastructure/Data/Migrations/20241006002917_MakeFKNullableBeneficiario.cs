using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdontoPrevApplication.Migrations
{
    /// <inheritdoc />
    public partial class MakeFKNullableBeneficiario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_beneficiario_tb_empresa_contratante_EmpresaContratanteId",
                table: "tb_beneficiario");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaContratanteId",
                table: "tb_beneficiario",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_beneficiario_tb_empresa_contratante_EmpresaContratanteId",
                table: "tb_beneficiario",
                column: "EmpresaContratanteId",
                principalTable: "tb_empresa_contratante",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_beneficiario_tb_empresa_contratante_EmpresaContratanteId",
                table: "tb_beneficiario");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaContratanteId",
                table: "tb_beneficiario",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_beneficiario_tb_empresa_contratante_EmpresaContratanteId",
                table: "tb_beneficiario",
                column: "EmpresaContratanteId",
                principalTable: "tb_empresa_contratante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
