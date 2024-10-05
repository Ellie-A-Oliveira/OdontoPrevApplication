﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OdontoPrevApplication.Infrastructure.Data.AppData;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace OdontoPrevApplication.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20241005145817_AddEntities")]
    partial class AddEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeneficiarioEntityPlanoEntity", b =>
                {
                    b.Property<int>("BeneficiariosId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("PlanosId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("BeneficiariosId", "PlanosId");

                    b.HasIndex("PlanosId");

                    b.ToTable("BeneficiarioEntityPlanoEntity");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.BeneficiarioEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("DataAdesao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("FotoUrl")
                        .HasMaxLength(300)
                        .HasColumnType("NVARCHAR2(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("NumeroContrato")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Tipo")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("tb_beneficiario");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.EmpresaContratanteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("NumeroContrato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("Id");

                    b.ToTable("tb_empresa_contratante");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.EnderecoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Complemento")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Numero")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("RedeCredenciadaId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.HasKey("Id");

                    b.HasIndex("RedeCredenciadaId");

                    b.ToTable("tb_endereco");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.MissaoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Concluido")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("ExpiraEm")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("RecompensaRecebida")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("TipoMissaoId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("TipoMissaoId");

                    b.ToTable("tb_missao");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.PlanoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("DataFinalCarencia")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("EmpresaContratanteId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<double>("PrecoCobrado")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<int>("TipoPlanoId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaContratanteId");

                    b.HasIndex("TipoPlanoId");

                    b.ToTable("tb_plano");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.PrestadorServicoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Avaliacao")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Especialidade")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("NumeroContrato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<int>("NumeroCro")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("RedeCredenciadaId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("RedeCredenciadaId");

                    b.ToTable("tb_prestador_servico");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.ProgramaRelacionamentoStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiarioId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("DataAdesao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("QtdePontos")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("BeneficiarioId")
                        .IsUnique();

                    b.ToTable("tb_programa_relacionamento_status");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.RecompensaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiarioId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("ExpiraEm")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("ResgatadoEm")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("TipoRecompensaId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("BeneficiarioId");

                    b.HasIndex("TipoRecompensaId");

                    b.ToTable("tb_recompensa");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.RedeCredenciadaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("Id");

                    b.ToTable("tb_rede_credenciada");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.ServicoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SinistroId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("TipoServicoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<double>("ValorPago")
                        .HasColumnType("BINARY_DOUBLE");

                    b.HasKey("Id");

                    b.HasIndex("SinistroId");

                    b.HasIndex("TipoServicoId");

                    b.ToTable("tb_servico");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.SinistroEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiarioId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("DataAutorizacao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("DataSolicitacao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("PrestadorServicoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<double?>("ValorPagoParaPrestador")
                        .HasColumnType("BINARY_DOUBLE");

                    b.HasKey("Id");

                    b.HasIndex("BeneficiarioId");

                    b.HasIndex("PrestadorServicoId");

                    b.ToTable("tb_sinistro");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.TipoMissaoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DuracaoPadraoDias")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Frequencia")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("RecompensaPadrao")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.HasKey("Id");

                    b.ToTable("tb_tipo_missao");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.TipoPlanoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarenciaDias")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ValidadeDias")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("tb_tipo_plano");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.TipoRecompensaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Aplicacao")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ExpiracaoDias")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("Id");

                    b.ToTable("tb_tipo_recompensa");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.TipoServicoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<double>("ValorReais")
                        .HasColumnType("BINARY_DOUBLE");

                    b.HasKey("Id");

                    b.ToTable("tb_tipo_servico");
                });

            modelBuilder.Entity("PrestadorServicoEntityTipoServicoEntity", b =>
                {
                    b.Property<int>("PrestadorServicosId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("TipoServicosId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("PrestadorServicosId", "TipoServicosId");

                    b.HasIndex("TipoServicosId");

                    b.ToTable("PrestadorServicoEntityTipoServicoEntity");
                });

            modelBuilder.Entity("TipoPlanoEntityTipoServicoEntity", b =>
                {
                    b.Property<int>("TipoPlanosId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("TipoServicosId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("TipoPlanosId", "TipoServicosId");

                    b.HasIndex("TipoServicosId");

                    b.ToTable("TipoPlanoEntityTipoServicoEntity");
                });

            modelBuilder.Entity("BeneficiarioEntityPlanoEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.BeneficiarioEntity", null)
                        .WithMany()
                        .HasForeignKey("BeneficiariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OdontoPrevApplication.Domain.Entities.PlanoEntity", null)
                        .WithMany()
                        .HasForeignKey("PlanosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.BeneficiarioEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.EnderecoEntity", "Endereco")
                        .WithOne("Beneficiario")
                        .HasForeignKey("OdontoPrevApplication.Domain.Entities.BeneficiarioEntity", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.EnderecoEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.RedeCredenciadaEntity", "RedeCredenciada")
                        .WithMany("Enderecos")
                        .HasForeignKey("RedeCredenciadaId");

                    b.Navigation("RedeCredenciada");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.MissaoEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.TipoMissaoEntity", "TipoMissao")
                        .WithMany("Missoes")
                        .HasForeignKey("TipoMissaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMissao");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.PlanoEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.EmpresaContratanteEntity", "EmpresaContratante")
                        .WithMany("Planos")
                        .HasForeignKey("EmpresaContratanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OdontoPrevApplication.Domain.Entities.TipoPlanoEntity", "TipoPlano")
                        .WithMany("Planos")
                        .HasForeignKey("TipoPlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpresaContratante");

                    b.Navigation("TipoPlano");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.PrestadorServicoEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.RedeCredenciadaEntity", "RedeCredenciada")
                        .WithMany("PrestadorServicos")
                        .HasForeignKey("RedeCredenciadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RedeCredenciada");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.ProgramaRelacionamentoStatusEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.BeneficiarioEntity", "Beneficiario")
                        .WithOne("ProgramaRelacionamentoStatus")
                        .HasForeignKey("OdontoPrevApplication.Domain.Entities.ProgramaRelacionamentoStatusEntity", "BeneficiarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beneficiario");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.RecompensaEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.BeneficiarioEntity", "Beneficiario")
                        .WithMany("Recompensas")
                        .HasForeignKey("BeneficiarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OdontoPrevApplication.Domain.Entities.TipoRecompensaEntity", "TipoRecompensa")
                        .WithMany("Recompensas")
                        .HasForeignKey("TipoRecompensaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beneficiario");

                    b.Navigation("TipoRecompensa");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.ServicoEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.SinistroEntity", "Sinistro")
                        .WithMany("Servicos")
                        .HasForeignKey("SinistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OdontoPrevApplication.Domain.Entities.TipoServicoEntity", "TipoServico")
                        .WithMany("Servicos")
                        .HasForeignKey("TipoServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinistro");

                    b.Navigation("TipoServico");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.SinistroEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.BeneficiarioEntity", "Beneficiario")
                        .WithMany("Sinistros")
                        .HasForeignKey("BeneficiarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OdontoPrevApplication.Domain.Entities.PrestadorServicoEntity", "PrestadorServico")
                        .WithMany("Sinistros")
                        .HasForeignKey("PrestadorServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beneficiario");

                    b.Navigation("PrestadorServico");
                });

            modelBuilder.Entity("PrestadorServicoEntityTipoServicoEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.PrestadorServicoEntity", null)
                        .WithMany()
                        .HasForeignKey("PrestadorServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OdontoPrevApplication.Domain.Entities.TipoServicoEntity", null)
                        .WithMany()
                        .HasForeignKey("TipoServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TipoPlanoEntityTipoServicoEntity", b =>
                {
                    b.HasOne("OdontoPrevApplication.Domain.Entities.TipoPlanoEntity", null)
                        .WithMany()
                        .HasForeignKey("TipoPlanosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OdontoPrevApplication.Domain.Entities.TipoServicoEntity", null)
                        .WithMany()
                        .HasForeignKey("TipoServicosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.BeneficiarioEntity", b =>
                {
                    b.Navigation("ProgramaRelacionamentoStatus");

                    b.Navigation("Recompensas");

                    b.Navigation("Sinistros");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.EmpresaContratanteEntity", b =>
                {
                    b.Navigation("Planos");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.EnderecoEntity", b =>
                {
                    b.Navigation("Beneficiario");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.PrestadorServicoEntity", b =>
                {
                    b.Navigation("Sinistros");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.RedeCredenciadaEntity", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("PrestadorServicos");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.SinistroEntity", b =>
                {
                    b.Navigation("Servicos");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.TipoMissaoEntity", b =>
                {
                    b.Navigation("Missoes");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.TipoPlanoEntity", b =>
                {
                    b.Navigation("Planos");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.TipoRecompensaEntity", b =>
                {
                    b.Navigation("Recompensas");
                });

            modelBuilder.Entity("OdontoPrevApplication.Domain.Entities.TipoServicoEntity", b =>
                {
                    b.Navigation("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
