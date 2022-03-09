using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T05
{
    public class Engine
    {
        private List<IIdentifiable> society;
        private List<IBirthdayable> membersWithBirthdays;
        public Engine()
        {
            this.society = new List<IIdentifiable>();
            this.membersWithBirthdays = new List<IBirthdayable>();
        }


        public void Run()
        {

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputTokens = input.Split().ToArray();
                CreateSocietyMember(inputTokens);
                input = Console.ReadLine();
            }

            /*

            After the "End" command on the next line, you will receive a single number representing a specific year, your task is to print all birthdates (of both Citizen and Pet)
            in that year in the format day/month/year in the order of input.

             */

            string yearOutput = Console.ReadLine();
            membersWithBirthdays.ForEach(x =>
            {
                if (x.BirthDay.EndsWith(yearOutput))
                {
                    Console.WriteLine($"{x.BirthDay}");
                }
            });


        }

        private void CreateSocietyMember(string[] inputTokens)
        {
            //If token length is 3 -> Citizen
            IIdentifiable societyMember;
            string typeOfMember = inputTokens[0];



            switch (typeOfMember)
            {
                case "Citizen":
                    string name = inputTokens[1];
                    int age = int.Parse(inputTokens[2]);
                    string id = inputTokens[3];
                    string birthDate = inputTokens[4];
                    societyMember = new Citizen(id, name, age, birthDate);
                    this.society.Add(societyMember);
                    this.membersWithBirthdays.Add((IBirthdayable)societyMember);
                    break;

                case "Robot":
                    string model = inputTokens[1];
                    string robotID = inputTokens[2];
                    societyMember = new Robot(robotID, model);
                    break;

                case "Pet":
                    string petName = inputTokens[1];
                    string petBirth = inputTokens[2];
                    societyMember = new Pet(petName, petBirth);
                    this.membersWithBirthdays.Add((IBirthdayable)societyMember);
                    break;

                default:
                    break;
            }

        }
    }
}
