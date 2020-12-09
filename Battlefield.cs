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
            
            Attack(); 
        }
        public void Attack() 
        {
            if (dinoOne.name.Equals("T-Rex") && robotOne.name.Equals("Robot One"))
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
            else if (dinoOne.name.Equals("T-Rex") && robotOne.name.Equals("Robot Two"))
            {
                dinoOne.energy -= 1;
                dinoOne.health -= 6;
                robotTwo.powerLevel -= 1;
                robotTwo.health -= 5;

                if (dinoOne.energy == 0 || dinoOne.health == 0 || robotTwo.powerLevel == 0 || robotTwo.health == 0)
                {
                    if (dinoOne.health > robotOne.health)
                    {
                        Console.WriteLine(dinoOne.name + "is the winner!");

                    }
                    else
                    {
                        Console.WriteLine(robotTwo.name + "is the winner!");
                    }
                }

            }
            else if (dinoOne.name.Equals("T-Rex") && robotOne.name.Equals("Robot Three"))
            {
                dinoOne.energy -= 1;
                dinoOne.health -= 6;
                robotThree.powerLevel -= 1;
                robotThree.health -= 5;

                if (dinoOne.energy == 0 || dinoOne.health == 0 || robotThree.powerLevel == 0 || robotThree.health == 0)
                {
                    if (dinoOne.health > robotThree.health)
                    {
                        Console.WriteLine(dinoOne.name + "is the winner!");

                    }
                    else
                    {
                        Console.WriteLine(robotThree.name + "is the winner!");
                    }
                }

            }
            else if (dinoTwo.name.Equals("Velociraptor") && robotTwo.name.Equals("Robot One"))
            {
                dinoTwo.energy -= 1;
                dinoTwo.health -= 6;
                robotOne.powerLevel -= 1;
                robotOne.health -= 5;

                if (dinoTwo.energy == 0 || dinoTwo.health == 0 || robotOne.powerLevel == 0 || robotOne.health == 0)
                {
                    if (dinoTwo.health > robotOne.health)
                    {
                        Console.WriteLine(dinoTwo.name + "is the winner!");

                    }
                    else
                    {
                        Console.WriteLine(robotOne.name + "is the winner!");
                    }
                }

            }
            else if (dinoTwo.name.Equals("Velociraptor") && robotTwo.name.Equals("Robot Two"))
            {
                dinoTwo.energy -= 1;
                dinoTwo.health -= 6;
                robotTwo.powerLevel -= 1;
                robotTwo.health -= 5;

                if (dinoTwo.energy == 0 || dinoTwo.health == 0 || robotTwo.powerLevel == 0 || robotTwo.health == 0)
                {
                    if (dinoTwo.health > robotTwo.health)
                    {
                        Console.WriteLine(dinoTwo.name + "is the winner!");

                    }
                    else
                    {
                        Console.WriteLine(robotTwo.name + "is the winner!");
                    }
                }

            }
            else if (dinoTwo.name.Equals("Velociraptor") && robotThree.name.Equals("Robot Three"))
            {
                dinoTwo.energy -= 1;
                dinoTwo.health -= 6;
                robotThree.powerLevel -= 1;
                robotThree.health -= 5;

                if (dinoTwo.energy == 0 || dinoTwo.health == 0 || robotThree.powerLevel == 0 || robotThree.health == 0)
                {
                    if (dinoTwo.health > robotThree.health)
                    {
                        Console.WriteLine(dinoTwo.name + "is the winner!");

                    }
                    else
                    {
                        Console.WriteLine(robotThree.name + "is the winner!");
                    }
                }

            }
            else if (dinoThree.name.Equals("Stegasaurus") && robotOne.name.Equals("Robot One"))
            {
                dinoThree.energy -= 1;
                dinoThree.health -= 6;
                robotOne.powerLevel -= 1;
                robotOne.health -= 5;

                if (dinoThree.energy == 0 || dinoThree.health == 0 || robotOne.powerLevel == 0 || robotOne.health == 0)
                {
                    if (dinoThree.health > robotOne.health)
                    {
                        Console.WriteLine(dinoThree.name + "is the winner!");

                    }
                    else
                    {
                        Console.WriteLine(robotOne.name + "is the winner!");
                    }
                }

            }
            else if (dinoThree.name.Equals("Stegasaurus") && robotTwo.name.Equals("Robot Two"))
            {
                dinoThree.energy -= 1;
                dinoThree.health -= 6;
                robotTwo.powerLevel -= 1;
                robotTwo.health -= 5;

                if (dinoThree.energy == 0 || dinoThree.health == 0 || robotTwo.powerLevel == 0 || robotTwo.health == 0)
                {
                    if (dinoThree.health > robotTwo.health)
                    {
                        Console.WriteLine(dinoThree.name + "is the winner!");

                    }
                    else
                    {
                        Console.WriteLine(robotTwo.name + "is the winner!");
                    }
                }

            }
            else if (dinoThree.name.Equals("Stegasaurus") && robotThree.name.Equals("Robot Three"))
            {
                dinoThree.energy -= 1;
                dinoThree.health -= 6;
                robotThree.powerLevel -= 1;
                robotThree.health -= 5;

                if (dinoThree.energy == 0 || dinoThree.health == 0 || robotThree.powerLevel == 0 || robotThree.health == 0)
                {
                    if (dinoThree.health > robotThree.health)
                    {
                        Console.WriteLine(dinoThree.name + "is the winner!");

                    }
                    else
                    {
                        Console.WriteLine(robotThree.name + "is the winner!");
                    }
                }

            }


        }

    }
}
