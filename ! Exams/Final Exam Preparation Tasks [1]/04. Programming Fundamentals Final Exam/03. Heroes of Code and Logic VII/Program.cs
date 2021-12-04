using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    public class Hero
    {
        private string name;
        private int hp;
        private int mp;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int HP
        {
            get { return this.hp; }
            set { this.hp = value; }
        }
        public int MP
        {
            get { return this.mp; }
            set { this.mp = value; }
        }

        public Hero() { } // Class Instance Object (So we can access our methods and stuff)

        public Hero(string name, int hp, int mp)
        {
            this.Name = name;
            this.HP = hp;
            this.MP = mp;
        }

        public Hero CastSpell(Hero hero, string name, int mp, string spell)
        {
            if (hero.MP >= mp)
            {
                hero.MP -= mp;
                Console.WriteLine($"{hero.Name} has successfully cast {spell} and now has {hero.MP} MP!");
            }
            else
            {
                Console.WriteLine($"{hero.Name} does not have enough MP to cast {spell}!");
            }

            return hero;
        }

        public Hero TakeDamage(Hero hero, List<Hero> heroList, string name, int damage, string attacker)
        {
            hero.HP -= damage;
            if (hero.HP > 0)
            {
                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
            }
            else if (hero.HP <= 0)
            {
                Console.WriteLine($"{name} has been killed by {attacker}!");
                heroList.Remove(hero);
            }

            return hero;
        }

        public Hero Recharge(Hero hero, string name, int amount)
        {
            if (hero.MP + amount > 200)
            {
                int buffer = hero.MP;
                hero.MP = 200;
                amount = 200 - buffer;
            }
            else
            {
                hero.MP += amount;
            }
            Console.WriteLine($"{name} recharged for {amount} MP!");

            return hero;
        }

        public Hero Heal(Hero hero, string name, int amount)
        {
            if (hero.HP + amount > 100)
            {
                int buffer = hero.HP;
                hero.HP = 100;
                amount = 100 - buffer;
            }
            else
            {
                hero.HP += amount;
            }
            Console.WriteLine($"{name} healed for {amount} HP!");

            return hero;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hero classInstance = new Hero();
            List<Hero> heroCollection = new List<Hero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] newHero = Console.ReadLine().Split().ToArray();
                string name = newHero[0];
                int hp = int.Parse(newHero[1]);
                int mp = int.Parse(newHero[2]);

                heroCollection.Add(new Hero(name, hp, mp));
            }

            string[] command = Console.ReadLine().Split(" - ").ToArray();
            while (command[0] != "End")
            {
                if (command[0] == "CastSpell")
                {
                    string name = command[1];
                    int mpNeeded = int.Parse(command[2]);
                    string spell = command[3];

                    Hero hero = heroCollection.FirstOrDefault(x => x.Name == name);
                    hero = classInstance.CastSpell(hero, name, mpNeeded, spell);
                }

                if (command[0] == "TakeDamage")
                {
                    string name = command[1];
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    Hero hero = heroCollection.FirstOrDefault(x => x.Name == name);
                    hero = classInstance.TakeDamage(hero, heroCollection, name, damage, attacker);
                }

                if (command[0] == "Recharge")
                {
                    string name = command[1];
                    int amount = int.Parse(command[2]);

                    Hero hero = heroCollection.FirstOrDefault(x => x.Name == name);
                    hero = classInstance.Recharge(hero, name, amount);
                }

                if (command[0] == "Heal")
                {
                    string name = command[1];
                    int amount = int.Parse(command[2]);

                    Hero hero = heroCollection.FirstOrDefault(x => x.Name == name);
                    hero = classInstance.Heal(hero, name, amount);
                }

                command = Console.ReadLine().Split(" - ").ToArray();
            }

            foreach (Hero hero in heroCollection.OrderByDescending(x => x.HP).ThenBy(x => x.Name))
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"  MP: {hero.MP}");
            }
        }
    }
}
