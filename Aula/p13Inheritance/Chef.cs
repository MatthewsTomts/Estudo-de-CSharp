using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;
class Chef {
    private int idade;
    private string nome;

    public int Idade { 
        get { return idade; } 
        set { idade = value; } 
    }
    public string Nome
    {
        get { return nome; }
        set
        {
            if (value == "Violett")
            {
                nome = "Queen " + value;
            }
            else
            {
                nome = value;
            }
        }
    }

    public Chef(int idade, string nome) {
        this.Idade = idade;
        this.Nome = nome;
    }

    public virtual void MakeChicken() => Console.WriteLine("The Chef makes chicken");

    public void MakeSalad() => Console.WriteLine("The Chef makes salad");

    public virtual void MakeSpecialDish() => Console.WriteLine("The Chef makes bbq ribs");
}
