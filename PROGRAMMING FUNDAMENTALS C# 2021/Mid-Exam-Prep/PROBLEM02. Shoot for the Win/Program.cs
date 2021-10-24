using System;
using System.Linq;

namespace PROBLEM02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int indexToShoot = 0;
            int shotIndex = 0;
            int shotsCount = 0;
            while (command != "End")
            {
                indexToShoot = int.Parse(command);
                //If index is not invalid.
                if (indexToShoot >= 0 && indexToShoot < targets.Length) 
                {
                    //Save value of the target we shoot
                    shotsCount++; //Increase shots count
                    shotIndex = targets[indexToShoot]; //Save the value of the shot index.
                    targets[indexToShoot] = -1;//Set the target to -1

                    //Go through the array and every value that is higher ..., every value that is smaller ...
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > shotIndex) { targets[i] -= shotIndex; }
                        else if(targets[i] <= shotIndex && targets[i] != -1) { targets[i] += shotIndex; }
                    }
 
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shotsCount} -> {string.Join(" ",targets)}");
        }
    }
}
