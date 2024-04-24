using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale
    {
        public Cane(string nome) : base(nome)
        {
        }
        public override void Verso()
        {
            Console.WriteLine($"{Nome}: Woof woof");
        }

        public override void Mangia()
        {
            Console.WriteLine($"{Nome} si nutre di Carne");
        }
    }
}
