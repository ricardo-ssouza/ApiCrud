using ApiCrud.App.Interfaces;
using ApiCrud.Model.V1.Signature;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiCrud.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaApp _pessoaApp;

        public PessoaController(IPessoaApp pessoaApp)
        {
            _pessoaApp = pessoaApp;
        }

        [HttpPost]
        [Route("Inserir")]
        public async Task Inserir(InserirPessoaSignature signature)
        {
            await _pessoaApp.InserirPessoa(signature);
        }
    }
}
