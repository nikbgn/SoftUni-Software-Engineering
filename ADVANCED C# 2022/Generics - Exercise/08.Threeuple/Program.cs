using System;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string name = $"{arr[0]} {arr[1]}";
            CustomThreeuple<string, string, string> t1
                = new
                CustomThreeuple
                <string, string, string>
                (name, arr[2], arr[3]);

            arr = Console.ReadLine().Split();
            bool drunk = arr[2] == "drunk" ? true:false ;
            CustomThreeuple<string, int, bool> t2
                = new
                CustomThreeuple
                <string, int, bool>
                (arr[0], int.Parse(arr[1]), drunk);

            arr = Console.ReadLine().Split();

            CustomThreeuple<string, double, string> t3
                = new
                CustomThreeuple
                <string, double, string>
                (arr[0], double.Parse(arr[1]), arr[2]);



            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
}
