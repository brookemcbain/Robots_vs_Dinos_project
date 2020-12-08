using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public List<Dinosaurs> dinosaurs = new List<Dinosaurs>();
        public List<Robots> robots = new List<Robots>();

        Dinosaurs dinoOne = new Dinosaurs("T-Rex", 10, 10, 5);
        Dinosaurs dinoTwo = new Dinosaurs("Velociraptor", 10, 10, 3);
        Dinosaurs dinoThree = new Dinosaurs("Stegosaurus", 10, 10, 4);

        Robots robotOne = new Robots("Robot One", 10, 6);
        Robots robotTwo = new Robots("Robot Two", 10, 3);
        Robots robotThree = new Robots("Robot Three", 10, 2);

        public Battlefield()
        {
        
        }
        public void Attack() 
        {
            if (dinosaurs.Equals("T-Rex") && robots.Equals("Robot One"))
            {
                dinoOne.energy -= 1;
                dinoOne.health -= 6;
                robotOne.powerLevel -= 1;
                robotOne.health -= 5; 

                if(dinoOne.energy == 0 || dinoOne.health == 0 || robotOne.powerLevel == 0 || robotOne.health == 0)
                {
                    if(dinoOne.health > robotOne.health)
                    {
                        Console.WriteLine( dinoOne.name + "is the winner!"); 
                        
                    }
                    else
                    {
                        Console.WriteLine(robotOne.name + "is the winner!");
                    }
                }

            }
            else if (dinosaurs.Equals("T-Rex") && robots.Equals("Robot Two"))
            {

            }
            else if (dinosaurs.Equals("T-Rex") && robots.Equals("Robot Three"))
            {

            }
            else if (dinosaurs.Equals("Velociraptor") && robots.Equals("Robot One"))
            {

            }
            else if (dinosaurs.Equals("Velociraptor") && robots.Equals("Robot Two"))
            {

            }
            else if (dinosaurs.Equals("Velociraptor") && robots.Equals("Robot Three"))
            {

            }
            else if (dinosaurs.Equals("Stegasaurus") && robots.Equals("Robot Three"))
            {

            }
            else if (dinosaurs.Equals("Stegasaurus") && robots.Equals("Robot Three"))
            {

            }
            else if (dinosaurs.Equals("Stegasaurus") && robots.Equals("Robot Three"))
            {

            }
            
        }

    }
}
