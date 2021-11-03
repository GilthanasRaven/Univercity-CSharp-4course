using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01.Bridge
{
    static class PartsDatabase
    {
        //Запчасти
        static public Engine HOLE52 = new Engine("Hole-52-C", 54.2, 25.00, 100.00);
        static public Radar MONTY43 = new Radar("Lolt-43", 23.2, 15.00, 10.00);
        static public Weapon BlueLaser = new Weapon("Blue Laser", 10.1, 15.00, 22.00);
        static public Hull MARK2 = new Hull("MARK-II", 0, 200.00);
        static public Shield PsychoShield = new Shield("Psycho Shield", 250.2, 5000.00);
    }
}
