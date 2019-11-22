using System;

namespace diceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to the Dice program!");
            Console.WriteLine("Press any key to roll the dice");
            Console.ReadKey();

            int gate = 0;

            while (gate == 0)
            {
                Random num1 = new Random();

                int dice1 = num1.Next(1, 6);
                int dice2 = num1.Next(1, 6);

                Console.WriteLine("You rolled a... " + dice1 + " & " + dice2 );
                Console.WriteLine("\n Roll again? y/n");
                string again = Console.ReadLine(); 

                if (again == "n")
                {
                    gate = 1;
                    Console.WriteLine("Thank you!, GoodBye!");
                }
            }
            Console.WriteLine("Press anything to exit");
            Console.ReadKey();
        }
    }
}
