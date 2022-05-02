using PudelkoLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            List<Pudelko> pudelka = new List<Pudelko>();
            pudelka.Add(new Pudelko(3, 5, 2, UnitOfMeasure.meter));
            pudelka.Add(new Pudelko(22.11, 31.111, 322.10, UnitOfMeasure.centimeter));
            pudelka.Add(new Pudelko(1022, 7215, 9241, UnitOfMeasure.milimeter));
            pudelka.Add(new Pudelko(5, 9, 5, UnitOfMeasure.meter));
            pudelka.Add(new Pudelko(5.551, 2.940));
            pudelka.Add(new Pudelko(2.852, null, 9.10));
            pudelka.Add(new Pudelko(null, 2.00, null));
            pudelka.Add(new Pudelko(5.50));
            pudelka.Add(new Pudelko());
            pudelka.Add(
                new Pudelko(444, 123, 215, UnitOfMeasure.centimeter).Kompresuj()
            );

            pudelka.Sort();

            pudelka.ForEach(
                (pudelko) => {
                    Console.WriteLine(pudelko);
                }
            );
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).ToString("mm"));
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).ToString("cm"));
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).ToString("m"));
        }
    }
}
