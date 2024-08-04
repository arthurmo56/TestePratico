using Microsoft.AspNetCore.Mvc;
using TestePratico1.Model;

namespace TestePratico1.Controllers
{
    [ApiController]
    [Route("api/pessoafisica")]
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaController(IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository ?? throw new ArgumentNullException(nameof(pessoaFisicaRepository));
        }
        [HttpPost]
        public IActionResult Add(string nome, string data_nascimento, string endereco, string telefone, string cpf)
        {
            var pessoafisica = new PessoaFisica(nome, data_nascimento,endereco, telefone,cpf);
            
            _pessoaFisicaRepository.Add(pessoafisica);
            
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pessoasfisicas = _pessoaFisicaRepository.get();

            return Ok(pessoasfisicas);
        }
    }
}
