using OdontoPrevApplication.Application.Dtos;
using OdontoPrevApplication.Domain.Entities;

namespace OdontoPrevApplication.Application.Interfaces
{
    public interface IEnderecoApplicationService
    {
        IEnumerable<EnderecoEntity>? ObterTodos();
        EnderecoEntity? ObterPorId(int id);
        EnderecoEntity? SalvarDados(EnderecoDto entidadeDto);
        EnderecoEntity? EditarDados(int id, EnderecoDto entidadeDto);
        EnderecoEntity? DeletarDados(int id);
    }
}
