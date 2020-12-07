using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public List<Dinosaurs> dinosaurs; 
        public Herd()
        {
            dinosaurs = new List<Dinosaurs>();
            Dinosaurs dinoOne = new Dinosaurs("T-Rex", 10, 10, 5);
            Dinosaurs dinoTwo = new Dinosaurs("Velociraptor", 10, 10, 3);
            Dinosaurs dinoThree = new Dinosaurs("Stegosaurus", 10, 10, 4);

            dinosaurs.Add(dinoOne); 
            dinosaurs.Add(dinoTwo); 
            dinosaurs.Add(dinoThree); 


        }
    }
}
