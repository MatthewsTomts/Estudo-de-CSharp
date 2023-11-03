using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Chef violett = new(20, "Violett");
violett.MakeSalad();
violett.MakeChicken();
violett.MakeSpecialDish();
Console.WriteLine(violett.Nome);
Console.WriteLine(violett.Idade);

Console.WriteLine();

ItalianChef harvey = new(21, "Harvey");
harvey.MakeSalad();
harvey.MakeChicken();
harvey.MakeSpecialDish();
harvey.MakePasta();
