using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            string temp = "";


            for (int k = 0; k < rotations; k++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    temp = numbers[i + 1];
                    numbers[i + 1] = numbers[i];
                    numbers[i] = temp;
                }

            }


            Console.WriteLine(String.Join(' ',numbers));
        }
    }
}
