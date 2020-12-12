using System;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to ROBOTS VS. DINOSAURS!");
            Console.WriteLine("Would you like to be Robots or Dinosaurs?");
            Console.WriteLine("Type 1 for Dinosaurs");
            Console.WriteLine("Type 2 for Robots");
            string answer = Console.ReadLine();   
            if(answer == "1")
            {
                Console.WriteLine("You chose Dinosaurs"); 
                Battlefield battlefield1 = new Battlefield();
                battlefield1.Attack(); 
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
