using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale , INuotante
    {
        public Delfino(string nome) : base(nome)
        {
        }
        public override void Verso()
        {
            Console.WriteLine($"{Nome}: Eee eee eee click click");// Questa e' la mia miglior interpretazione di quello che dice wikipedia :D
            // Wikipedia: I delfini sono in grado di emettere una vasta gamma di suoni usando sacchi aeriferi nasali situati appena sotto lo sfiatatoio. Si possono identificare tre categorie di suoni: fischi modulati in frequenza, suoni e clic a impulsi a raffica.
            // Infatti, comunicano con suoni simili a quelli dei fischietti, che vengono prodotti dal tessuto connettivo vibrante, simile al modo in cui funzionano le corde vocali umane e attraverso suoni pulsati di scoppio.
        }

        public override void Mangia()
        {
            Console.WriteLine($"{Nome} si nutre di Pesci, molluschi");
        }
        public void FaiNuotare()
        {
            Console.WriteLine($"{Nome} sta Nuotando!");
        }
    }
}
