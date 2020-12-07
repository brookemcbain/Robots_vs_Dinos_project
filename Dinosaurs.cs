using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Dinosaurs
    {
        public string type;
        public int health;
        public int energy;
        public int attackPower; 

        public Dinosaurs(string type, int health, int energy, int attackPower )
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower; 
        }
    }
}
