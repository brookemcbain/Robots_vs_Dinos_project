using System;
using System.Linq;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Main(); 

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
                    Console.WriteLine("Which Dinosaur would you like to play first?");
                    Console.WriteLine("1) T-Rex");
                    Console.WriteLine("2) Velociraptor");
                    Console.WriteLine("3) Stegasaurus");
                    Battlefield battlefield = new Battlefield();
                    
                    while (battlefield.dinosaurs.Count > 0 || battlefield.robots.Count > 0)
                    {
                        string chosenDinosaur = Console.ReadLine(); 

                        if (chosenDinosaur == "T-Rex")
                        {
                            battlefield.AttackDinoOne();
                            Console.WriteLine("Which dinosaur would you like to play next?"); 

                        }
                        else if (chosenDinosaur == "Velociraptor")
                        {
                            battlefield.AttackDinoTwo();
                            Console.WriteLine("WWhich dinosaur would you like to play next?"); 
                        }
                        else if (chosenDinosaur == "Stegasaurus")
                        {
                            battlefield.AttackDinoThree();
                            Console.WriteLine("WWhich dinosaur would you like to play next?");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid response");
                            Main();
                        }

                    }

                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("Type 1 for YES, Type 2 for NO");
                    string answerTwo = Console.ReadLine();
                    if (answer == "1")
                    {
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!"); 
                    }
                }
                else
                {
                    Console.WriteLine("You chose Robots");
                    Battlefield battlefield = new Battlefield();
                    

                }

            }


        }
    }
}
