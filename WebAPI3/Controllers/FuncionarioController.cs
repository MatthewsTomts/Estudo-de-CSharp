using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI3.Application.ViewModel;
using WebAPI3.Domain.Model;

namespace WebAPI3.Controllers;

[ApiController]
[Route("api/v1/funcionario")]
public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioRepository _funcionarioRepository;
    private readonly ILogger<FuncionarioController> _logger; //Used to create logs

    public FuncionarioController(IFuncionarioRepository funcionarioRepository, ILogger<FuncionarioController> logger)
    {
        _funcionarioRepository = funcionarioRepository ?? throw new ArgumentNullException(nameof(funcionarioRepository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [Authorize]
    [HttpPost]
    public IActionResult Add([FromForm] FuncionarioViewModel funcionarioView)
    {
        var filePath = Path.Combine("Storage", funcionarioView.Foto.FileName);

        using Stream fileStream = new FileStream(filePath, FileMode.Create);
        funcionarioView.Foto.CopyTo(fileStream);

        var funcionario = new Funcionario(funcionarioView.Nome, funcionarioView.Idade, filePath);

        _funcionarioRepository.Add(funcionario);

        return Ok();
    }

    [Authorize]
    [HttpGet]
    public IActionResult Get(int pageNumber, int pageQuantity)
    {
        //_logger.Log(LogLevel.Error, "Um Erro Ocorreu");

        var funcionarios = _funcionarioRepository.Get(pageNumber, pageQuantity);

        //_logger.LogInformation("Teste");

        return Ok(funcionarios);
    }

    [Authorize]
    [HttpPost]
    [Route("{id}/download")]
    public IActionResult DownloadFoto(int id)
    {
        var funcionarios = _funcionarioRepository.Get(id);
        if (funcionarios != null && !string.IsNullOrEmpty(funcionarios.foto))
        {
            var dataBytes = System.IO.File.ReadAllBytes(funcionarios.foto);
            return File(dataBytes, "image/png");
        } else
        {
            return BadRequest("Usuário não cadastro ou não possui foto");
        }
    }
}
