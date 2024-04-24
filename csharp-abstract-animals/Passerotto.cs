using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale , IVolante
    {
        public Passerotto(string nome) : base(nome)
        {
        }
        public override void Verso()
        {
            Console.WriteLine($"{Nome}: Cip cip");
        }

        public override void Mangia()
        {
            Console.WriteLine($"{Nome} si nutre di Semi, bacche, insetti");
        }

        public void FaiVolare() 
        {
            Console.WriteLine($"{Nome} sta Volando!");
        }
    }
}
