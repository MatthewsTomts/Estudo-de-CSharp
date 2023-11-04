using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI3.Model;
using WebAPI3.ViewModel;

namespace WebAPI3.Controllers;

[ApiController]
[Route("api/v1/funcionario")]
public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioRepository _funcionarioRepository;

    public FuncionarioController(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository ?? throw new ArgumentNullException(nameof(funcionarioRepository));
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
    public IActionResult Get()
    {
        var funcionarios = _funcionarioRepository.Get();

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
