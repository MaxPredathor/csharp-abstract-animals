using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale , IVolante
    {
        public Aquila(string nome) : base(nome)
        {
        }
        public override void Verso()
        {
            Console.WriteLine($"{Nome}: Hawwwwk");
        }

        public override void Mangia()
        {
            Console.WriteLine($"{Nome} si nutre di Carne");
        }
        public void FaiVolare()
        {
            Console.WriteLine($"{Nome} sta Volando!");
        }
    }
}
