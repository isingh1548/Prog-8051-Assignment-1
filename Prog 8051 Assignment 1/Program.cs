using System;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            string name;
            int petCareAction;
            int health = 7;
            int hunger = 6;
            int happiness = 6;


            Console.WriteLine("Please choose a type of pet");
            Console.WriteLine("1.Cat");
            Console.WriteLine("2.Dog");
            Console.WriteLine("3.Rabbit");

            Console.Write("User Input: ");
            type = Console.ReadLine();


            Console.WriteLine($"\nYou've chosen a {type}. What would you like to name your pet?");

            Console.Write("\nUser input: ");
            name = Console.ReadLine();

            Console.WriteLine($"\nWelcome, {name}! Let's take good care of him. \n");


            do
            {

                Console.WriteLine("\nMain Menu:");
                Console.WriteLine($"1. Feed {name}");
                Console.WriteLine($"2. Play with {name}");
                Console.WriteLine($"3. Let {name} Rest");
                Console.WriteLine($"4. Check {name}'s Status");
                Console.WriteLine($"5. Exit");

                Console.Write("\nUser Input: ");
                petCareAction = Convert.ToInt32(Console.ReadLine());

                switch (petCareAction)
                {
                    case 1:
                        hunger = hunger - 2;
                        if (hunger < 0)
                        {
                            hunger = 0;
                        }

                        health = health + 1;
                        if (health > 10)
                        {
                            health = 10;
                        }
                        
                        Console.WriteLine($"\nYou feed {name}. His hunger decreases, and health improves slightly.");
                        break;

                    case 2:
                        happiness = happiness + 2;
                        hunger = hunger + 1;

                        if (happiness > 10)
                        {
                            happiness = 10;
                        }

                        if (hunger > 10)
                        {
                            hunger = 10;
                        }

                        Console.WriteLine($"\nYou played with {name}. His happiness increases, and hunger increases slightly.");
                        break;

                    case 3:
                        health = health + 2;
                        happiness = happiness - 1;

                        if (health > 10)
                        {
                            health = 10;
                        }

                        if (happiness < 0)
                        {
                            happiness = 0;
                        }
                        Console.WriteLine($"\n{name} is resting. His health improves, and happiness decreases slightly.");
                        break;

                    case 4:
                        Console.WriteLine($"\n{name}'s Status: ");
                        Console.WriteLine($"- Hunger: " + Convert.ToString(hunger));
                        Console.WriteLine($"- Health: " + Convert.ToString(health));
                        Console.WriteLine($"- Happiness: " + Convert.ToString(happiness));

                        if (hunger >= 8)
                        {
                            Console.WriteLine($"\n{name} will refusing to play if too hungry.");
                        }

                        if (happiness <= 2)
                        {
                            Console.WriteLine($"\n{name}! is unhappy.");
                        }

                        if (health <= 2)
                        {
                            Console.WriteLine($"\n{name}! is unhealthy.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nBye..");
                        break;

                    default:
                        Console.WriteLine("\nInvalid options! Please select option from 1-5.");
                        break;
                }

                if (hunger >= 8)
                {
                    Console.WriteLine($"\n{name} will refusing to play if too hungry.");
                }

                if (happiness <= 2)
                {
                    Console.WriteLine($"\n{name}! is unhappy.");
                }

                if (health <= 2)
                {
                    Console.WriteLine($"\n{name}! is unhealthy.");
                }


                

                hunger = hunger + 1;
                if (hunger > 10) {
                    hunger = 10;
                }

                if (happiness < 0) {
                    happiness = 0;
                }
                happiness = happiness - 1;



            } while (petCareAction != 5);

        }
    }
}