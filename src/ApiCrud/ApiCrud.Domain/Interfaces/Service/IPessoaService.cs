using ApiCrud.Common.Interfaces.Signature;
using System.Threading.Tasks;

namespace ApiCrud.Domain.Interfaces.Service
{
    public interface IPessoaService
    {
        Task InserirPessoa(IInserirPessoaSignature signature);
    }
}
