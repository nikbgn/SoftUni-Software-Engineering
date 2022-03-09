using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T04
{
    public class Engine
    {
        private List<IIdentifiable> society;

        public Engine()
        {
            this.society = new List<IIdentifiable>();
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
            string fakeIdPattern = Console.ReadLine();

            //Detect fake ID's in society
            string[] fakes = 
                this.society.Where(x => x.Id.EndsWith(fakeIdPattern)).Select(i=>i.Id).ToArray();

            foreach (var detained in fakes)
            {
                Console.WriteLine(detained);
            }

        }

        private void CreateSocietyMember(string[] inputTokens)
        {
            //If token length is 3 -> Citizen
            if (inputTokens.Length == 3)
            {
                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);
                string id = inputTokens[2];
                IIdentifiable member = new Citizen(id,name,age);
                this.society.Add(member);
            }
            else
            {
                string model = inputTokens[0];
                string id = inputTokens[1];
                IIdentifiable robot = new Robot(id,model);
                this.society.Add(robot);
            }
        }
    }
}
