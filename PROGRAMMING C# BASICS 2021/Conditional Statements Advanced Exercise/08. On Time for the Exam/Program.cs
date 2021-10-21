using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int comingHour = int.Parse(Console.ReadLine());
            int comingMinute = int.Parse(Console.ReadLine());

            //On time => comingHour == Exam Hour
            //Early => More than 30 min before examHour
            //Late => comingHour,Min > examhour,examMin

            int examTime = examHour * 60 + examMinute;
            int comeTime = comingHour * 60 + comingMinute;
            int minutesDifference = comeTime - examTime;
            int studentHour = Math.Abs(minutesDifference / 60);
            int studentMinutes = Math.Abs(minutesDifference % 60);

            if (minutesDifference == 0) { Console.WriteLine("On time"); }
            else if (minutesDifference < -30) { Console.WriteLine("Early"); }
            else if (minutesDifference < 0) { Console.WriteLine("On time"); }
            
            else { Console.WriteLine("Late"); }

            if (studentHour > 0)
            {
                if (studentMinutes < 10)
                {
                    Console.WriteLine($"{studentHour}:0{studentMinutes} hours");
                }
                else
                {
                    Console.WriteLine($"{studentHour}:{studentMinutes} hours");
                }
            }
            else
            {
                Console.WriteLine($"{studentMinutes} minutes");
            }


            Console.WriteLine(minutesDifference < 0 ? "before the start":"after the start");


        }
    }
}
