using OdontoPrevApplication.Domain.Entities;
using OdontoPrevApplication.Domain.Interfaces;
using OdontoPrevApplication.Infrastructure.Data.AppData;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace OdontoPrevApplication.Infrastructure.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly ApplicationContext _context;

        public EnderecoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<EnderecoEntity>? ObterTodos()
        {
            var enderecos = _context.Endereco.ToList();

            if (enderecos.Any()) return enderecos;

            return null;
        }

        public EnderecoEntity? ObterPorId(int id)
        {
            return _context.Endereco.Find(id);
        }

        public EnderecoEntity? SalvarDados(EnderecoEntity entidade)
        {
            try
            {
                _context.Add(entidade);
                _context.SaveChanges();

                return entidade;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível salvar o endereço", ex);
            }
        }

        public EnderecoEntity? EditarDados(int id, EnderecoEntity entidade)
        {
            try
            {
                var endereco = _context.Endereco.Find(entidade.Id);

                if (endereco is not null)
                {
                    endereco.Rua = entidade.Rua;
                    endereco.Numero = entidade.Numero;
                    endereco.Cidade = entidade.Cidade;
                    endereco.Estado = entidade.Estado;
                    endereco.Cep = entidade.Cep;
                    endereco.Complemento = entidade.Complemento;

                    _context.Update(endereco);
                    _context.SaveChanges();

                    return endereco;
                }

                //Gera um excecão para informar que nao foi possivel localizar o cliente
                throw new Exception("Não foi possível localizar o endereço");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public EnderecoEntity? DeletarDados(int id)
        {
            try
            {
                var endereco = _context.Endereco.Find(id) ?? throw new Exception("Não foi possível localizar o endereço");
                _context.Remove(endereco);
                _context.SaveChanges();

                return endereco;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
