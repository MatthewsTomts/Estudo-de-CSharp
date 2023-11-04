using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI3.Domain.Model.CompaniaAggregate;

[Table("Companhia")]
public class Companhia
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
}
