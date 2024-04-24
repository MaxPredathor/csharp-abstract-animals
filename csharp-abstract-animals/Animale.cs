using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public string Nome { get; set; }

        public Animale(string nome)
        {
            this.Nome = nome;
        }
        public void Dormi()
        {
            Console.WriteLine($"{Nome}: ZzZ");
        }

        public abstract void Verso();
        public abstract void Mangia();
    }
}
