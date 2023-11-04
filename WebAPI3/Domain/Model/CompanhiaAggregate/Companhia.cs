using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI3.Domain.Model.CompaniaAggregate;

[Table("Companhia")]
public class Companhia
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
}
