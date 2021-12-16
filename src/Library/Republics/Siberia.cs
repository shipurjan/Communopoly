using Library.Spaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * W tej republice:
 * Gdy gracz stoi na polu tej republiki, rzuty jego kostki mają słabszy efekt.
 * Zamiast poruszać się o wyrzuconą liczbę oczek, będzie się on poruszać o
 * floor(wyrzucona liczba oczek/2)
 * 1 -> 0
 * 2 -> 1
 * 3 -> 1
 * 4 -> 2
 * 5 -> 2
 * 6 -> 3
 */

namespace Library.Republics
{
    class Siberia : Republic
    {
        private string color = "#1b395d";
        public string Color { get { return color; } }
    }
}
