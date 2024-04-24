using System.Linq.Expressions;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esercizio 1
            Delfino Ulisse = new("Ulisse");
            Passerotto Twitter = new("Twitter");
            Cane Cheems = new("Cheems");
            Aquila Valor = new("Valor");

            Ulisse.Dormi();
            Ulisse.Mangia();
            Ulisse.Verso();
            Twitter.Dormi();
            Twitter.Mangia();
            Twitter.Verso();
            Cheems.Dormi();
            Cheems.Mangia();
            Cheems.Verso();
            Valor.Dormi();
            Valor.Mangia();
            Valor.Verso();

            //Esercizio 2
            Ulisse.FaiNuotare();
            Twitter.FaiVolare();
            Valor.FaiVolare();
        }
    }
}
