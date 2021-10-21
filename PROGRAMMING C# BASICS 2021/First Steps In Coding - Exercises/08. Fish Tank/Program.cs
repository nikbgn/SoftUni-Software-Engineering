using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:
            //1. len - int
            int lenght = int.Parse(Console.ReadLine());
            //2. width - int
            int width = int.Parse(Console.ReadLine());
            //3. height - int
            int height = int.Parse(Console.ReadLine());
            //4. % na zaetoto prostransvto - double
            double percentTaken = double.Parse(Console.ReadLine());


            int volumeCM = lenght * width * height;
            double volumeL = volumeCM * 0.001;
            double waterNeeded = volumeL * (1 - percentTaken * 0.01);
            Console.WriteLine(waterNeeded);
            //obem v sm3 = l*w*h
            //obem v litri = obem v sm3 / 1000
            //nujna voda = obem v litri * (1-% na zaetoto prostranstvo)

        }
    }
}
