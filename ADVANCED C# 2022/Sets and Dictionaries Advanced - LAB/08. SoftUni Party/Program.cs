using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> numbers = new HashSet<string>();
            HashSet<string> VIPnumbers = new HashSet<string>();
            while (true)
            {
                string currentCMD = Console.ReadLine();
                switch (currentCMD)
                {
                    case "PARTY":
                        while (true)
                        {
                            currentCMD = Console.ReadLine();
                            if(currentCMD == "END")
                            {
                                Console.WriteLine(VIPnumbers.Count + numbers.Count);
                                if (VIPnumbers.Count > 0)
                                {
                                    foreach (var vip in VIPnumbers)
                                    {
                                        Console.WriteLine(vip);
                                    }
                                }
                                if (numbers.Count > 0)
                                {
                                    foreach (var person in numbers)
                                    {
                                        Console.WriteLine(person);
                                    }
                                }
                                return;

                            }
                            if (numbers.Contains(currentCMD))
                            {
                                numbers.Remove(currentCMD);
                            }
                            else if (VIPnumbers.Contains(currentCMD))
                            {
                                VIPnumbers.Remove(currentCMD);
                            }
                            
                        }

                        break;

                    default:
                        if (Char.IsDigit(currentCMD[0])) VIPnumbers.Add(currentCMD);
                        else numbers.Add(currentCMD);
                        break;
                }

            }

        }
    }
}
