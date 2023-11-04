using WebAPI3.Domain.DTOs;
namespace WebAPI3.Domain.Model;

public interface IFuncionarioRepository
{
    void Add(Funcionario funcionario);
    List<FuncionarioDTO> Get(int pageNumber, int pageQuantity);
    Funcionario? Get(int id);
}
