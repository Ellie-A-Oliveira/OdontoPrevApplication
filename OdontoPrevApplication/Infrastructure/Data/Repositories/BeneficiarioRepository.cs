using OdontoPrevApplication.Domain.Entities;
using OdontoPrevApplication.Domain.Interfaces;
using OdontoPrevApplication.Infrastructure.Data.AppData;

namespace OdontoPrevApplication.Infrastructure.Data.Repositories
{
    public class BeneficiarioRepository : IBeneficiarioRepository
    {
        private readonly ApplicationContext _context;

        public BeneficiarioRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<BeneficiarioEntity>? ObterTodos()
        {
            var beneficiarios = _context.Beneficiario.ToList();

            if (beneficiarios.Any()) return beneficiarios;

            return null;
        }

        public BeneficiarioEntity? ObterPorId(int id)
        {
            return _context.Beneficiario.Find(id);
        }

        public BeneficiarioEntity? SalvarDados(BeneficiarioEntity entidade)
        {
            try
            {
                _context.Add(entidade);
                _context.SaveChanges();

                return entidade;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar o beneficiário");
            }
        }

        public BeneficiarioEntity? EditarDados(int id, BeneficiarioEntity entidade)
        {
            try
            {
                var beneficiario = _context.Beneficiario.Find(entidade.Id);

                if (beneficiario is not null)
                {
                    beneficiario.Nome = entidade.Nome;
                    beneficiario.Password = entidade.Password;
                    beneficiario.Cpf = entidade.Cpf;
                    beneficiario.Tipo = entidade.Tipo;
                    beneficiario.Telefone = entidade.Telefone;
                    beneficiario.NumeroContrato = entidade.NumeroContrato;
                    beneficiario.EnderecoId = entidade.Id;

                    _context.Update(beneficiario);
                    _context.SaveChanges();

                    return beneficiario;
                }

                //Gera um excecão para informar que nao foi possivel localizar o cliente
                throw new Exception("Não foi possível localizar o beneficiário.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public BeneficiarioEntity? DeletarDados(int id)
        {
            try
            {
                var beneficiario = _context.Beneficiario.Find(id) ?? throw new Exception("Não foi possível localizar o beneficiário");
                _context.Remove(beneficiario);
                _context.SaveChanges();

                return beneficiario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
