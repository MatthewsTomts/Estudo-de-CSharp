using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    class Chef {
        public virtual void MakeChicken() {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad() {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish() {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}