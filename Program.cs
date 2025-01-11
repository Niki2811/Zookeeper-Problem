using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Животни
{
    internal class Program
    {


        class Fish
        {
            string[] fishFood = new string[] { "pellets", "chopsticks", "flakes", "tablets" };
            public void fishEat(string food)
            {
                if (fishFood.Contains(food))
                {
                    Console.WriteLine("Delicious!");
                }
                else
                {
                    Console.WriteLine("The fish has died...");
                    Environment.Exit(0);
                }
            }
        }


        class Lamb
        {
            string[] lambFood = new string[] { "wheat bran", "hay", "oats", "beetroot" };
            public void lambEat(string food)
            {

                if (lambFood.Contains(food))
                {
                    Console.WriteLine("Delicious!");
                }
                else
                {
                    Console.WriteLine("The lamb has died...");
                    Environment.Exit(0);
                }
            }
        }

        class Wolf
        {
            string[] wolfFood = new string[] { "hind", "rat", "goat", "rabbit" };

            public void wolfEat(string food)
            {


                if (wolfFood.Contains(food))
                {
                    Console.WriteLine("Delicious!");
                }
                else
                {
                    Console.WriteLine("The wolf has died...");
                    Environment.Exit(0);
                }

            }
        }


        class Fowl
        {
            string[] fowlFood = new string[] { "barley", "corn", "wheat", "whititng" };

            public void fowlEat(string food)
            {

                if (fowlFood.Contains(food))
                {
                    Console.WriteLine("Delicious!");
                }
                else
                {
                    Console.WriteLine("The fowl has died...");
                    Environment.Exit(0);
                }
            }
        }

        class Zookeeper
        {
            public void Feed(Fowl animal)
            {
                Console.WriteLine($"What do you want to feed the fowl with?");
                string food = Console.ReadLine();
                Console.WriteLine($"You fed the fowl with {food}.");
                animal.fowlEat(food);
            }


            public void Feed(Wolf animal)
            {
                Console.WriteLine($"What do you want to feed the wolf with?");
                string food = Console.ReadLine();
                Console.WriteLine($"You fed the wolf with {food}.");
                animal.wolfEat(food);
            }


            public void Feed(Lamb animal)
            {
                Console.WriteLine($"What do you want to feed the lamb with?");
                string food = Console.ReadLine();
                Console.WriteLine($"You fed the lamb with {food}.");
                animal.lambEat(food);

            }


            public void Feed(Fish animal)
            {
                Console.WriteLine($"What do you want to feed the fish with?");
                string food = Console.ReadLine();
                Console.WriteLine($"You fed the fish with {food}.");
                animal.fishEat(food);
            }

        }

        static void Main(string[] args)
        {
            Zookeeper zookeeper = new Zookeeper();

            for (int i = 1; i <= 12; i++)
            {
                switch (i % 4)
                {
                    case 0:
                        zookeeper.Feed(new Fowl());
                        break;
                    case 1:
                        zookeeper.Feed(new Wolf());
                        break;
                    case 2:
                        zookeeper.Feed(new Lamb());
                        break;
                    case 3:
                        zookeeper.Feed(new Fish());
                        break;
                }
            }
        }
    }
}
