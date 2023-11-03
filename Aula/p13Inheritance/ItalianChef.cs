using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;
class ItalianChef : Chef {
    public ItalianChef(int idade, string nome) : base(idade, nome) {}

    public override void MakeSpecialDish() => Console.WriteLine("The Chef makes spaghetti");

    // I can't override this method, because is not marked as virtual on the superclass
    // public override void MakeSalad() {
    //     Console.WriteLine("The Chef makes salad");
    // }

    public void MakePasta() => Console.WriteLine("The Chef makes pasta");
}
