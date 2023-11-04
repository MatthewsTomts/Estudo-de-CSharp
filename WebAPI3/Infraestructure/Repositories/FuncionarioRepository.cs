using WebAPI3.Domain.DTOs;
using WebAPI3.Domain.Model;

namespace WebAPI3.Infraestructure.Repositories;
public class FuncionarioRepository : IFuncionarioRepository
{
    private readonly Connection _connection = new Connection();
    public void Add(Funcionario funcionario)
    {
        _connection.Funcionarios.Add(funcionario);
        _connection.SaveChanges();
    }

    public List<FuncionarioDTO> Get(int pageNumber, int pageQuantity)
    {
        return _connection.Funcionarios.Skip(pageNumber * pageQuantity)
            .Take(pageQuantity)
            .Select( b =>
            new FuncionarioDTO()
            {
                Id = b.id,
                Nome = b.nome,
                Foto = b.foto
            })
            .ToList();
    }

    public Funcionario? Get(int id)
    {
        return _connection.Funcionarios.Find(id);
    }
}
