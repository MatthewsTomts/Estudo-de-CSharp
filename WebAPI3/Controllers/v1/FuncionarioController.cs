using WebAPI3.Domain.Model.FuncionarioAggregate;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Authorization;
using WebAPI3.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace WebAPI3.Controllers.v1;

[ApiController]
[Route("api/v1/funcionario")]
// This route doesn't work
//[Route("api/v{version:apiVersion}/funcionario")]
[ApiVersion("1.0")]
public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioRepository _funcionarioRepository;
    private readonly ILogger<FuncionarioController> _logger; //Used to create logs
    private readonly IMapper _mapper;

    public FuncionarioController(IFuncionarioRepository funcionarioRepository, ILogger<FuncionarioController> logger,
        IMapper mapper)
    {
        _funcionarioRepository = funcionarioRepository ?? throw new ArgumentNullException(nameof(funcionarioRepository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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
    [HttpGet]
    [Route("{id}")]
    public IActionResult Serach(int id)
    {
        //_logger.Log(LogLevel.Error, "Um Erro Ocorreu");

        var funcionarios = _funcionarioRepository.Get(id);
        var funcionariosDTO = _mapper.Map<Domain.DTOs.FuncionarioDTO>(funcionarios);

        //_logger.LogInformation("Teste");

        return Ok(funcionariosDTO);
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
        }
        else
        {
            return BadRequest("Usuário não cadastro ou não possui foto");
        }
    }
}
