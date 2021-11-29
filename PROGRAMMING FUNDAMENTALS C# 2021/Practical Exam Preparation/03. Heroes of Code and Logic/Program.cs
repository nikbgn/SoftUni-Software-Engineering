using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic
{
    class Hero
    {
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public string HeroName { get; set; }

        public void SpellCast(string spellName, int mpNeeded)
        {
            string successMSG = $"{this.HeroName} has successfully cast {spellName} and now has {this.ManaPoints-mpNeeded} MP!";
            string failMSG = $"{this.HeroName} does not have enough MP to cast {spellName}!";

            if (this.ManaPoints >= mpNeeded)
            {
                this.ManaPoints -= mpNeeded;
                Console.WriteLine(successMSG);
            }
            else
            {
                Console.WriteLine(failMSG);
            }
        }

        public void TakeDamage(int dmgTaken,string enemyName)
        {
            string aliveMSG = $"{this.HeroName} was hit for {dmgTaken} HP by {enemyName} and now has {this.HealthPoints-dmgTaken} HP left!";
            string deadMSG = $"{this.HeroName} has been killed by {enemyName}!";

            this.HealthPoints -= dmgTaken;
            if (this.HealthPoints > 0) Console.WriteLine(aliveMSG);
            else Console.WriteLine(deadMSG);
        }

        public void Recharge(int rechargeAmount)
        {
            int maxMP = 200;
            if (this.ManaPoints + rechargeAmount > maxMP)
            {
                int rechargedForCalculation = Math.Abs(maxMP - this.ManaPoints);
                Console.WriteLine($"{this.HeroName} recharged for {rechargedForCalculation} MP!");
                this.ManaPoints = maxMP;
            }
            else
            {
                Console.WriteLine($"{this.HeroName} recharged for {rechargeAmount} MP!");
                this.ManaPoints += rechargeAmount;
            }
        }

        public void Heal(int healAmount)
        {
            int maxHP = 100;
            if (this.HealthPoints + healAmount > maxHP)
            {
                int rechargedForCalculation = Math.Abs(maxHP - this.HealthPoints);
                Console.WriteLine($"{this.HeroName} healed for {rechargedForCalculation} HP!");
                this.HealthPoints = maxHP;
            }
            else
            {
                Console.WriteLine($"{this.HeroName} healed for {healAmount} HP!");
                this.HealthPoints += healAmount;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroDict = new Dictionary<string, Hero>();
            //Fill the heroes
            for (int i = 0; i < numOfHeroes; i++)
            {
                string[] currentHeroInfo = Console.ReadLine().Split();
                string heroName = currentHeroInfo[0];
                int heroHP = int.Parse(currentHeroInfo[1]);
                int heroMP = int.Parse(currentHeroInfo[2]);
                //Input will always be valid, so we can just fill in the hero without doing checks.
                heroDict.Add(heroName, new Hero() { HealthPoints = heroHP, ManaPoints = heroMP, HeroName = heroName });
            }

            string[] command = Console.ReadLine().Split(" - ");
            while(command[0] != "End")
            {
                string currCMD = command[0];
                string currHeroName = command[1];
                switch (currCMD)
                {
                    //"CastSpell – {hero name} – {MP needed} – {spell name}"
                    case "CastSpell":
                        int mpNeeded = int.Parse(command[2]);
                        string spellName = command[3];
                        heroDict[currHeroName].SpellCast(spellName, mpNeeded);
                        break;
                    //"TakeDamage – {hero name} – {damage} – {attacker}"
                    case "TakeDamage":
                        int takeDamage = int.Parse(command[2]);
                        string attackerName = command[3];
                        heroDict[currHeroName].TakeDamage(takeDamage, attackerName);
                        break;
                    //"Recharge – {hero name} – {amount}"
                    case "Recharge":
                        int rechargeAmount = int.Parse(command[2]);
                        heroDict[currHeroName].Recharge(rechargeAmount);
                        break;
                    //"Heal – {hero name} – {amount}"
                    case "Heal":
                        int healAmount = int.Parse(command[2]);
                        heroDict[currHeroName].Heal(healAmount);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(" - ");
            }


            foreach (var hero in heroDict.Where(hero => hero.Value.HealthPoints > 0).OrderByDescending(hero => hero.Value.HealthPoints).ThenBy(hero => hero.Value.HeroName))
            {
                Console.WriteLine($"{hero.Value.HeroName}");
                Console.WriteLine($"  HP: {hero.Value.HealthPoints}");
                Console.WriteLine($"  MP: {hero.Value.ManaPoints}");
            }


            

        }
    }
}
