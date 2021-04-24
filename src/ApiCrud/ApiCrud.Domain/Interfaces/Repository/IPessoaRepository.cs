using ApiCrud.Common.Interfaces.Signature;
using System.Threading.Tasks;

namespace ApiCrud.Domain.Interfaces.Repository
{
    public interface IPessoaRepository
    {
        Task InserirPessoa(IInserirPessoaSignature signature);
    }
}
