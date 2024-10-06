using OdontoPrevApplication.Application.Dtos;
using OdontoPrevApplication.Application.Interfaces;
using OdontoPrevApplication.Domain.Entities;
using OdontoPrevApplication.Domain.Interfaces;

namespace OdontoPrevApplication.Application.Services
{
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoApplicationService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public IEnumerable<EnderecoEntity>? ObterTodos()
        {
            return _enderecoRepository.ObterTodos();
        }

        public EnderecoEntity? ObterPorId(int id)
        {
            return _enderecoRepository.ObterPorId(id);
        }

        public EnderecoEntity? SalvarDados(EnderecoDto entidadeDto)
        {
            var Endereco = new EnderecoEntity
            {
                Rua = entidadeDto.Rua,
                Numero = entidadeDto.Numero,
                Cidade = entidadeDto.Cidade,
                Estado = entidadeDto.Estado,
                Cep = entidadeDto.Cep,
                Complemento = entidadeDto.Complemento,
            };

            return _enderecoRepository.SalvarDados(Endereco);
        }

        public EnderecoEntity? EditarDados(int id, EnderecoDto entidadeDto)
        {
            var Endereco = new EnderecoEntity
            {
                Id = id,
                Rua = entidadeDto.Rua,
                Numero = entidadeDto.Numero,
                Cidade = entidadeDto.Cidade,
                Estado = entidadeDto.Estado,
                Cep = entidadeDto.Cep,
                Complemento = entidadeDto.Complemento,
            };

            return _enderecoRepository.EditarDados(id, Endereco);
        }

        public EnderecoEntity? DeletarDados(int id)
        {
           return _enderecoRepository.DeletarDados(id);
        }
    }
}
