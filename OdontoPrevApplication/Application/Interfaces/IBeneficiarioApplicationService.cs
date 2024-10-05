using OdontoPrevApplication.Application.Dtos;
using OdontoPrevApplication.Domain.Entities;

namespace OdontoPrevApplication.Application.Interfaces
{
    public interface IBeneficiarioApplicationService
    {
        IEnumerable<BeneficiarioEntity>? ObterTodos();
        BeneficiarioEntity? ObterPorId(int id);
        BeneficiarioEntity? SalvarDados(BeneficiarioDto entidadeDto);
        BeneficiarioEntity? EditarDados(int id, BeneficiarioDto entidadeDto);
        BeneficiarioEntity? DeletarDados(int id);

    }
}
