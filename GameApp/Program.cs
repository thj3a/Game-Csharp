
using System;
using static System.Console;

namespace GameApp
{
    class Program {
        static void Main(string[] args) {
            var Arthur = new HeroiGuerreiro("Arthur");
            var Jéssica = new HeroiMago("Jéssica");
            var Kowalski = new HeroiArqueiro("Kowalski");

            WriteLine(Arthur.TentaDarDano(Jéssica));
            WriteLine(Jéssica.TentaDarDano(Arthur));
            WriteLine(Arthur.TentaDarDano(Kowalski));
            WriteLine(Kowalski.TentaDarDano(Arthur));
            WriteLine(Kowalski.TentaDarDano(Arthur, 5));
        }

    }
}
