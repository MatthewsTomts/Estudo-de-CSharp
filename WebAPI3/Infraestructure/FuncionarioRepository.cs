using WebAPI3.Model;

namespace WebAPI3.Infraestructure;
public class FuncionarioRepository : IFuncionarioRepository
{
    private readonly Connection _connection = new Connection();
    public void Add(Funcionario funcionario)
    {
        _connection.Funcionarios.Add(funcionario);
        _connection.SaveChanges();
    }

    public List<Funcionario> Get()
    {
        return _connection.Funcionarios.ToList();
    }
}
