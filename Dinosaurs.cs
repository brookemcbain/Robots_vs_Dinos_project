using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Dinosaurs
    {
        public string name { get; set; }
        public int health { get; set; }
        public int energy { get; set; }
        public int attackPower { get; set; }

        public Dinosaurs(string name, int health, int energy, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower; 
        }
    }
}
