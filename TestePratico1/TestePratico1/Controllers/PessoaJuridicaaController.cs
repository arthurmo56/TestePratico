using Microsoft.AspNetCore.Mvc;
using TestePratico1.Infrastructure;
using TestePratico1.Model;

namespace TestePratico1.Controllers
{
    [ApiController]
    [Route("api/pessoajuridica")]
    public class PessoaJuridicaaController : Controller
    {
        private readonly IPessoaJuridicaRepository _pessoajuridicarepository;

        public PessoaJuridicaaController(IPessoaJuridicaRepository pessoajuridicarepository)
        {
            _pessoajuridicarepository = pessoajuridicarepository ?? throw new ArgumentNullException(nameof(pessoajuridicarepository));
        }

        [HttpPost]
        public IActionResult Add(string nome, string data_nascimento, string endereco, string telefone, string cnpj, string razao_social)
        {
            var pessoajuridica = new PessoaJuridica(nome,data_nascimento,endereco,telefone,cnpj,razao_social);
            
            _pessoajuridicarepository.Add(pessoajuridica);
            
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pessoasjuridicas = _pessoajuridicarepository.get();

            return Ok(pessoasjuridicas);
        }
    }
}
