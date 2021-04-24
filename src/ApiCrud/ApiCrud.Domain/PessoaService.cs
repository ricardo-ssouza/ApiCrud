using ApiCrud.Common.Interfaces.Signature;
using ApiCrud.Domain.Interfaces.Repository;
using ApiCrud.Domain.Interfaces.Service;
using System.Threading.Tasks;

namespace ApiCrud.Domain
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public async Task InserirPessoa(IInserirPessoaSignature signature)
        {
            await _pessoaRepository.InserirPessoa(signature);
        }
    }
}
