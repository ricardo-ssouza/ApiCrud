using ApiCrud.App.Interfaces;
using ApiCrud.Common.Interfaces.Signature;
using ApiCrud.Domain.Interfaces.Service;
using System.Threading.Tasks;

namespace ApiCrud.App
{
    public class PessoaApp : IPessoaApp
    {
        private readonly IPessoaService _pessoaService;

        public PessoaApp(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public async Task InserirPessoa(IInserirPessoaSignature signature)
        {
            await _pessoaService.InserirPessoa(signature);
        }
    }
}
