using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Robots
    {
        public string name; 
        public int health;
        public int powerLevel;
    

        public Robots(string name, int health, int powerLevel)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            
        }
    }
}
