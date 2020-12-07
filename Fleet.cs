using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robots> robots;

        public Fleet()
        {
            robots = new List<Robots>();
            Robots robotOne = new Robots("Robot One", 10, 5);
            Robots robotTwo = new Robots("Robot Two", 10, 3);
            Robots robotThree = new Robots("Robot Three", 10, 2);

        }
    }
}
