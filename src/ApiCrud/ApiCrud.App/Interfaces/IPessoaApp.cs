using ApiCrud.Common.Interfaces.Signature;
using System.Threading.Tasks;

namespace ApiCrud.App.Interfaces
{
    public interface IPessoaApp
    {
        Task InserirPessoa(IInserirPessoaSignature signature);
    }
}
