using OdontoPrevApplication.Domain.Entities;

namespace OdontoPrevApplication.Domain.Interfaces
{
    public interface IBeneficiarioRepository
    {
        IEnumerable<BeneficiarioEntity>? ObterTodos();
        BeneficiarioEntity? ObterPorId(int id);
        BeneficiarioEntity? SalvarDados(BeneficiarioEntity entidade);
        BeneficiarioEntity? EditarDados(int id, BeneficiarioEntity entidade);
        BeneficiarioEntity? DeletarDados(int id);

    }
}
