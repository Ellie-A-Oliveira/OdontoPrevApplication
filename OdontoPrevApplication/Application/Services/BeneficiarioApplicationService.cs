using OdontoPrevApplication.Application.Dtos;
using OdontoPrevApplication.Application.Interfaces;
using OdontoPrevApplication.Domain.Entities;
using OdontoPrevApplication.Domain.Interfaces;

namespace OdontoPrevApplication.Application.Services
{
    public class BeneficiarioApplicationService : IBeneficiarioApplicationService
    {
        private readonly IBeneficiarioRepository _beneficiarioRepository;
        private readonly IEnderecoApplicationService _enderecoApplicationService;

        public BeneficiarioApplicationService(
            IBeneficiarioRepository beneficiarioRepository,
            IEnderecoApplicationService enderecoApplicationService
        )
        {
            _beneficiarioRepository = beneficiarioRepository;
            _enderecoApplicationService = enderecoApplicationService;
        }

        IEnumerable<BeneficiarioEntity>? IBeneficiarioApplicationService.ObterTodos()
        {
            return _beneficiarioRepository.ObterTodos();
        }

        BeneficiarioEntity? IBeneficiarioApplicationService.ObterPorId(int id)
        {
            return _beneficiarioRepository.ObterPorId(id);
        }

        BeneficiarioEntity? IBeneficiarioApplicationService.SalvarDados(BeneficiarioDto entidadeDto)
        {
            var Endereco = new EnderecoDto
            {
                Rua = entidadeDto.Rua!,
                Numero = entidadeDto.Numero ?? default(int),
                Cidade = entidadeDto.Cidade!,
                Estado = entidadeDto.Estado!,
                Cep = entidadeDto.Cep!,
                Complemento = entidadeDto.Complemento,
            };

            var EnderecoCriado = _enderecoApplicationService.SalvarDados(Endereco);

            var Beneficiario = new BeneficiarioEntity
            {
                Nome = entidadeDto.Nome,
                Password = entidadeDto.Password, // Need to add crypto
                Cpf = entidadeDto.Cpf,
                Tipo = entidadeDto.Tipo,
                Telefone = entidadeDto.Telefone,
                DataAdesao = DateTime.Now,
                NumeroContrato = entidadeDto.NumeroContrato,
                EnderecoId = EnderecoCriado.Id
            };

            return _beneficiarioRepository.SalvarDados(Beneficiario);
        }

        BeneficiarioEntity? IBeneficiarioApplicationService.EditarDados(int id, BeneficiarioDto entidadeDto)
        {
            var Beneficiario = new BeneficiarioEntity
            {
                Nome = entidadeDto.Nome,
                Password = entidadeDto.Password, // Need to add crypto
                Cpf = entidadeDto.Cpf,
                Tipo = entidadeDto.Tipo,
                Telefone = entidadeDto.Telefone,
                DataAdesao = DateTime.Now,
                NumeroContrato = entidadeDto.NumeroContrato
            };

            return _beneficiarioRepository.EditarDados(id, Beneficiario);
        }

        BeneficiarioEntity? IBeneficiarioApplicationService.DeletarDados(int id)
        {
            return _beneficiarioRepository.DeletarDados(id);
        }
    }
}
