using System;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder initialTourPlan = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split(":");
            while (command[0] != "Travel")
            {
                string currentCommand = command[0];

                switch (currentCommand)
                {
                    case "Add Stop":
                        int insertAtIndex = int.Parse(command[1]);
                        string stringToInsert = command[2];
                        if (insertAtIndex >= 0 && insertAtIndex < initialTourPlan.Length)
                        {
                            initialTourPlan.Insert(insertAtIndex, stringToInsert);
                        }
                        Console.WriteLine(initialTourPlan);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if ((startIndex >= 0 && startIndex < initialTourPlan.Length) && (endIndex >= 0 && endIndex < initialTourPlan.Length))
                        {
                            int removeN = 0;
                            if (endIndex > startIndex)
                            {
                                removeN = endIndex - startIndex;
                            }
                            else
                            {
                                removeN = startIndex - endIndex;
                            }


                            initialTourPlan.Remove(startIndex, removeN + 1);
                        }
                        Console.WriteLine(initialTourPlan);
                        break;
                    case "Switch":
                        string toSwitch = command[1];
                        string toSwitchWith = command[2];
                        initialTourPlan.Replace(toSwitch, toSwitchWith);
                        Console.WriteLine(initialTourPlan);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split(":");
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {initialTourPlan}");
        }
    }
}
