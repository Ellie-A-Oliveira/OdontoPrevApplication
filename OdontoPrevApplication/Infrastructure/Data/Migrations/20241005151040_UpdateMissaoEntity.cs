using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdontoPrevApplication.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMissaoEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeneficiarioId",
                table: "tb_missao",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_missao_BeneficiarioId",
                table: "tb_missao",
                column: "BeneficiarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_missao_tb_beneficiario_BeneficiarioId",
                table: "tb_missao",
                column: "BeneficiarioId",
                principalTable: "tb_beneficiario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_missao_tb_beneficiario_BeneficiarioId",
                table: "tb_missao");

            migrationBuilder.DropIndex(
                name: "IX_tb_missao_BeneficiarioId",
                table: "tb_missao");

            migrationBuilder.DropColumn(
                name: "BeneficiarioId",
                table: "tb_missao");
        }
    }
}
