using System;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] info = Console.ReadLine().Split();
            string name = $"{info[0]} {info[1]}";
            CustomTuple<string, string> nameCity 
                = new CustomTuple<string, string>(name,info[2]);

            var info2 = Console.ReadLine().Split();

            CustomTuple<string, int> beerInfo
                = new CustomTuple<string, int>(info2[0],int.Parse(info2[1]));
            
            var info3 = Console.ReadLine().Split();
            CustomTuple<int, double> intDouble
                = new CustomTuple<int, double>(int.Parse(info3[0]),double.Parse(info3[1]));


            Console.WriteLine(nameCity);
            Console.WriteLine(beerInfo);
            Console.WriteLine(intDouble);
        }
    }
}
