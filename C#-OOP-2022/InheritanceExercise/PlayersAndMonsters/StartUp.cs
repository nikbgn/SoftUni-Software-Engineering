using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Hero t = new Hero("niki", 10);
            Elf z = new Elf("niki", 10);
            MuseElf m = new MuseElf("niki", 10);
            Console.WriteLine(t);
            Console.WriteLine(z);
            Console.WriteLine(m);
        }
    }
}