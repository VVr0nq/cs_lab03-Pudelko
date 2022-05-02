using PudelkoLibrary;
using System;


namespace ConsoleApp {
    public static class InnePudelko {
        public static Pudelko Kompresuj(this Pudelko pudelko) {
            double size = Math.Cbrt(pudelko.Objetosc);
            return new Pudelko(size, size, size);
        }
    }
}
