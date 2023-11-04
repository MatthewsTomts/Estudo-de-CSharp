using Microsoft.AspNetCore.Mvc;
using WebAPI3.Model;
using WebAPI3.ViewModel;

namespace WebAPI3.Controllers
{
    [ApiController]
    [Route("api/v1/funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository ?? throw new ArgumentNullException(nameof(funcionarioRepository));
        }

        [HttpPost]
        public IActionResult Add(FuncionarioViewModel funcionarioView)
        {
            var funcionario = new Funcionario(funcionarioView.Nome, funcionarioView.Idade, null);

            _funcionarioRepository.Add(funcionario);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var funcionarios = _funcionarioRepository.Get();

            return Ok(funcionarios);
        }
    }
}
