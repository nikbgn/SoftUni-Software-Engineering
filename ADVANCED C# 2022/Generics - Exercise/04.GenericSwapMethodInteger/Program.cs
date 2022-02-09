using System;

namespace _04.GenericSwapMethodInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfBoxes = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < numOfBoxes; i++)
            {
                box.Items.Add(int.Parse(Console.ReadLine()));
            }

            var indexes = Console.ReadLine().Split();
            int idx1 = int.Parse(indexes[0]);
            int idx2 = int.Parse(indexes[1]);
            box.Swap(idx1, idx2);
            box.Items.ForEach(x => Console.WriteLine($"{x.GetType()}: {x}"));
        }
    }
}
