using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());
            float biggestKeg = 0;
            string biggestKegModel = string.Empty;
            while (numOfKegs > 0)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float currentVolume = (float)(Math.PI * (radius * radius) * height);
                if (currentVolume > biggestKeg) { biggestKeg = currentVolume; biggestKegModel = model; }
                numOfKegs -= 1;
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
