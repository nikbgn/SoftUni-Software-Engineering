using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class User
    {
        public User(string userName, int recievedPoints, string recievedContest)
        {
            this.UserName = userName;
            this.RecievedPoints = recievedPoints;
            this.RecievedContest = recievedContest;
            this.UserContentsAndPoints = new Dictionary<string, int>();
            this.UpdateContests(recievedPoints, recievedContest);
            
            
        }

        public string UserName { get; set; }
        public Dictionary<string, int> UserContentsAndPoints { get; set; } 

        public int RecievedPoints { get; set; }

        public string RecievedContest { get; set; }


        public int GetTotalPoints()
        {
            int totalPoints = 0;
            foreach (var contest in this.UserContentsAndPoints)
            {
                totalPoints += contest.Value;
            }
            return totalPoints;
        }

        public void UpdateContests(int recievedPoitns, string recievedContest)
        {
            if (!UserContentsAndPoints.ContainsKey(recievedContest))
            {
                UserContentsAndPoints.Add(recievedContest, recievedPoitns);
            }

            else if(UserContentsAndPoints[recievedContest] < recievedPoitns)
            {
                UserContentsAndPoints[recievedContest] = recievedPoitns;
            }
            else
            {

            }
        }

        public int GetMaxPoints()
        {
            int maxPts = 0;
            foreach (var item in UserContentsAndPoints)
            {
                maxPts += item.Value;
            }

            return maxPts;
        }

        public void PrintUserContests()
        {
            Console.WriteLine(UserName);
            foreach (var contest in UserContentsAndPoints.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsInfo = new Dictionary<string, string>(); //This dictionary will hold contest names & passwords
            List<User> users = new List<User>(); //This list will hold all users

            //{contest}:{password for contest} until "end of contests"
            List<string> input = Console.ReadLine().Split(':').ToList();
            while (input[0] != "end of contests")
            {
                string contestName = input[0];
                string contestPassword = input[1];
                updateContestsInfo(contestName, contestPassword, contestsInfo);
                input = Console.ReadLine().Split(':').ToList();
            }

            //{contest}=>{password}=>{username}=>{points} until end of submissions
            input = Console.ReadLine().Split("=>").ToList();
            while (input[0] != "end of submissions")
            {
                string currentContest = input[0];
                string currentContestPassword = input[1];
                string currentUserName = input[2];
                int currentUserPointsInContest = int.Parse(input[3]);
                bool toAddUser = true;
                if (validateContestInfo(currentContest, currentContestPassword, contestsInfo))
                {
                    foreach (var individual in users)
                    {
                        if (individual.UserName == currentUserName)
                        {
                            individual.UpdateContests(currentUserPointsInContest,currentContest);
                            toAddUser = false;
                        }
                    }
                    if (toAddUser)
                    {
                        User newUser = new User(currentUserName, currentUserPointsInContest, currentContest);
                        users.Add(newUser);
                    }

                }
                input = Console.ReadLine().Split("=>").ToList();
            }

            users = users.OrderByDescending(x => x.GetMaxPoints()).ToList();


            Console.WriteLine($"Best candidate is {users[0].UserName} with total {users[0].GetTotalPoints()} points.");
            Console.WriteLine("Ranking:");
            
            foreach (var person in users.OrderBy(p => p.UserName))
            {
                person.PrintUserContests();
            }

        }

        private static bool validateContestInfo(string currentContest, string currentContestPassword, Dictionary<string, string> contestsInfo)
        {
            if (contestsInfo.ContainsKey(currentContest))
            {
                if (contestsInfo[currentContest] == currentContestPassword)
                {
                    return true;
                }
            }
            return false;
        }

        private static void updateContestsInfo(string contestName, string contestPassword, Dictionary<string, string> contestsInfo)
        {
            //There will be no case in which two contests hold the same Key, so we can fill the Dictionary without checking.
            contestsInfo.Add(contestName, contestPassword);
        }
    }
}
