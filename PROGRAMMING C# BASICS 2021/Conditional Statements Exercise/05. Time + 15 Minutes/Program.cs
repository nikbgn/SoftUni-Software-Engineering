using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме час и минути
            //2. Преобразуваме текущото време в минути
            //3. Добавяме 15 мин към текущото време
            //4. Преобразуваме крайното време в часове и минути
            // часове = крайно време в мин / 60
            // минути = крано време % 60

            int currentHour = int.Parse(Console.ReadLine());
            int currentMinutes = int.Parse(Console.ReadLine());

            int currentTimeInMinutes = currentHour * 60 + currentMinutes;

            int finalTime = currentTimeInMinutes + 15;

            int finalHours = finalTime / 60;
            int finalMinutes = finalTime % 60;

            if (finalHours == 24)
            {
                finalHours = 0;
                
            }

            Console.WriteLine($"{finalHours}:{finalMinutes:D2}");

        }
    }
}
