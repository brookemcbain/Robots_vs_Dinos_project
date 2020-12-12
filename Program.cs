using System;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Console.WriteLine("Welcome to ROBOTS VS. DINOSAURS!");
                Console.WriteLine("Would you like to be Robots or Dinosaurs?");
                Console.WriteLine("Type 1 for Dinosaurs");
                Console.WriteLine("Type 2 for Robots");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("You chose Dinosaurs!");
                    Console.WriteLine("Which Dinosaur would you like to be?"); 
                    Console.WriteLine()
                    Battlefield battlefield1 = new Battlefield();
                    battlefield1.Attack();
                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("Type 1 for YES, Type 2 for NO");
                    string answerTwo = Console.ReadLine();
                    if (answer == "1")
                    {
                        Main();
                    }
                }
                else
                {
                    Console.WriteLine("You chose Robots");
                    Battlefield battlefield = new Battlefield();
                    battlefield.Attack();

                }

            }


        }
    }
}
