using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI3.Domain.Model;

[Table("Funcionarios")]
public class Funcionario
{
    [Key]
    public int id { get; private set; }
    public string nome { get; private set; }
    public int idade { get; private set; }
    public string? foto { get; private set; }

    public Funcionario(string nome, int idade, string foto)
    {
        this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
        this.idade = idade;
        this.foto = foto;
    }
}
